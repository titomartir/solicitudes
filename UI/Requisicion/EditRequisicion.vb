Public Class EditRequisicion

#Region "difinition"

    Private TITLE As String = ""
    Private cu As CommonUtility = CommonUtility.GetInstance
    Private sc As New SetCombobox
    Private scDGV As New SetComboBoxDGV
    Private DispMax As Integer = 29
    Private _EditFlg As Boolean = False
    Private _LoadFlg As Boolean = False
    Private dtInsumos As New DataTable

    Private Enum dgvCol
        btnUp = 0
        btnDown = 1
        btnIns = 2
        btnDel = 3
        Insumos = 4
        Unidad = 5
        Solicitada = 6
    End Enum

    Private Enum dgvColFirma
        Title = 0
        Nombre = 1
        Cargo = 2
    End Enum

#End Region

#Region "Property"

    Private _Anio As String = ""

    Public WriteOnly Property Anio As String
        Set(value As String)
            _Anio = value
        End Set
    End Property

    Private _NumeroDocu As String = ""

    Public WriteOnly Property NumeroDocu As String
        Set(value As String)
            _NumeroDocu = value
        End Set
    End Property

    Private _EditMode As Boolean = False

    ''' <summary>
    ''' Edit Mode
    ''' 
    ''' True: Edit
    ''' False: Add
    ''' </summary>
    Public WriteOnly Property EditMode As Boolean
        Set(value As Boolean)
            _EditMode = value
        End Set
    End Property

    Private _DispMode As Boolean = False

    ''' <summary>
    ''' Display Mode
    ''' 
    ''' True: Read Only
    ''' False: New or Edit
    ''' </summary>
    Public WriteOnly Property DispMode As Boolean
        Set(value As Boolean)
            _DispMode = value
        End Set
    End Property

    Private _InventarioStatus As String = HospitalConst.INVENTARIOST_CD.NOIMPRESO

    ''' <summary>
    ''' Inventario Status
    ''' </summary>
    Public WriteOnly Property InventarioStatus As String
        Set(value As String)
            _InventarioStatus = value
        End Set
    End Property

#End Region

#Region "Form Event"

    ''' <summary>
    ''' Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _EditMode Then
            TITLE = "Modificación del requisicion"
        Else
            TITLE = "Agregar de requisicion"
        End If
        If _DispMode Then
            TITLE = "Referencia del requisicion"
        End If

        'Set Form Title
        MyBase.FormTitle = TITLE

        'Set ComboBox
        SetCombo()

        'Init List
        InitList()

        'Clear Data
        ClearData()

        _LoadFlg = True

        If _EditMode Or _DispMode Then

            'Display Data
            DispData()
        Else
            'SetDGVCombo
            SetDGVCombo()

        End If

    End Sub

#End Region

#Region "Button Event"

    ''' <summary>
    ''' Save Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Save Data
        SaveData()

    End Sub

    ''' <summary>
    ''' Clear Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear Data
        ClearData()

    End Sub

    ''' <summary>
    ''' ReDisplay Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btmReDisplay_Click(sender As Object, e As EventArgs) Handles btnReDisplay.Click

        If _EditMode Then

            'Display Data
            DispData()
        Else

            'Clear Data
            ClearData()

        End If

    End Sub

    ''' <summary>
    ''' Close Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Form Close
        Me.Close()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Me.Cursor = Cursors.WaitCursor

        'Printout Requisicion Report
        Dim rc As New ReportCommon
        rc.PrintRequisicion(Me.cboYear.SelectedValue.ToString, Me.txtNumero.Text)

        'Update Requisicion Data
        UpdateRequisicion(Me.cboYear.SelectedValue.ToString, Me.txtNumero.Text, HospitalConst.INVENTARIOST_CD.IMPRESO)

        Me.Cursor = Cursors.Default

    End Sub

#End Region

#Region "ComboBox Event"

    ''' <summary>
    ''' cboBodega SelectedIndexChanged
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBodega.SelectedIndexChanged

        If _LoadFlg = False Then
            Exit Sub
        End If

        'SetDGVCombo
        SetDGVCombo()

    End Sub

#End Region

#Region "DataGridView Event"

    ''' <summary>
    ''' DataGridView Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellContentClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If e.ColumnIndex < dgvCol.btnUp Or e.ColumnIndex > dgvCol.btnDel Then
            Exit Sub
        End If

        Select Case e.ColumnIndex
            Case dgvCol.btnUp '↑
                If e.RowIndex = 0 Then
                    Exit Sub
                End If

                'Swap Row
                SwapRow(e.RowIndex, e.RowIndex - 1)

            Case dgvCol.btnDown '↓
                If e.RowIndex = dgvList.RowCount - 1 Then
                    Exit Sub
                End If

                'Swap Row
                SwapRow(e.RowIndex, e.RowIndex + 1)

            Case dgvCol.btnIns 'Ins↑
                'Insert Row
                InsertRow(e.RowIndex)

            Case dgvCol.btnDel 'Del
                'Delete Row
                DeleteRow(e.RowIndex)

            Case Else
        End Select

    End Sub

    Private Sub dgvList_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellValueChanged

        If _EditFlg Then
            Exit Sub
        End If

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If e.ColumnIndex < dgvCol.Insumos Or e.ColumnIndex > dgvCol.Solicitada Then
            Exit Sub
        End If

        Dim wkVal As String = ""
        If Not dgvList.Item(e.ColumnIndex, e.RowIndex).Value Is Nothing Then
            wkVal = dgvList.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
        End If

        Select Case e.ColumnIndex
            Case dgvCol.Insumos 'Insumo
                If String.IsNullOrEmpty(wkVal) Then
                    dgvList.Item(dgvCol.Unidad, e.RowIndex).Value = wkVal
                    dgvList.Item(dgvCol.Solicitada, e.RowIndex).Value = wkVal
                Else
                    dgvList.Item(dgvCol.Unidad, e.RowIndex).Value = GetUnidad(wkVal)
                End If

            Case dgvCol.Unidad 'Unidad

            Case dgvCol.Solicitada 'Solicitada
                If Not String.IsNullOrEmpty(wkVal) Then
                    If Not IsNumeric(wkVal) Then
                        MessageBoxManager.ShowError("Por favor ingrese un valor numérico")
                        dgvList.Item(e.ColumnIndex, e.RowIndex).Value = ""
                        dgvList.CurrentCell = dgvList.Item(e.ColumnIndex, e.RowIndex)
                        dgvList.BeginEdit(True)
                        Exit Sub
                    End If
                End If

            Case Else
        End Select

    End Sub

    Private Sub dgvFirma_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFirma.CellValueChanged

        If _EditFlg Then
            Exit Sub
        End If

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If e.ColumnIndex <> dgvColFirma.Nombre Then
            Exit Sub
        End If

        Dim wkVal As String = ""
        If Not dgvFirma.Item(e.ColumnIndex, e.RowIndex).Value Is Nothing Then
            wkVal = dgvFirma.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
        End If

        Select Case e.ColumnIndex
            Case dgvColFirma.Nombre 'Nombre

                Select Case e.RowIndex
                    Case 0
                        If Not String.IsNullOrEmpty(wkVal) Then
                            dgvFirma.Item(dgvColFirma.Nombre, 4).Value = wkVal
                        End If
                    Case 1
                        If Not String.IsNullOrEmpty(wkVal) Then
                            dgvFirma.Item(dgvColFirma.Nombre, 3).Value = wkVal
                        End If
                    Case Else
                End Select
            Case Else
        End Select

    End Sub

    Private Sub dgvList_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvList.EditingControlShowing

        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then

            Select Case CType(sender, DataGridView).CurrentCell.OwningColumn.CellType
                Case GetType(DataGridViewComboBoxCell)
                    CType(e.Control, DataGridViewComboBoxEditingControl).DropDownStyle = ComboBoxStyle.DropDown
                Case Else
            End Select
        End If

    End Sub

    Private Sub dgvList_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvList.CellValidating

        Dim dgv As DataGridView = CType(sender, DataGridView)

        Select Case dgv.Columns(e.ColumnIndex).CellType
            Case GetType(DataGridViewComboBoxCell)

                If e.FormattedValue.ToString.Length = 0 Then
                    Exit Sub
                End If

                Dim cbc As DataGridViewComboBoxColumn = CType(dgv.Columns(e.ColumnIndex), DataGridViewComboBoxColumn)

                Dim target As String = ""
                Dim wkCd As String = ""
                Dim wkData As String = ""

                For Each item As Object In cbc.Items
                    wkCd = DirectCast(item, System.Data.DataRowView).Item(0).ToString
                    wkData = UCase(DirectCast(item, System.Data.DataRowView).Item(1).ToString)
                    If InStr(wkData, UCase(e.FormattedValue.ToString)) > 0 Then
                        target = wkCd
                        Exit For
                    End If
                Next

                If target.Length = 0 Then
                    MessageBoxManager.ShowWorning("Sin datos relevantes")
                    e.Cancel = True
                Else
                    dgv.Item(e.ColumnIndex, e.RowIndex).Value = wkCd
                End If

            Case Else
        End Select

    End Sub

#End Region

#Region "User Method"

    ''' <summary>
    ''' Set ComboBox
    ''' </summary>
    Private Sub SetCombo()

        Dim StartY As String = Date.Today.AddYears(-10).ToString("yyyy")
        Dim EndY As String = Date.Today.ToString("yyyy")

        sc.SetYearComboBox(Me.cboYear, StartY, EndY)

        Me.cboYear.SelectedIndex = 0

        sc.SetServicioComboBox(Me.cboServicio)
        sc.SetBodegaComboBox(Me.cboBodega)
        sc.SetNombreBodegaComboBox(Me.cboNombreBodega)

    End Sub

    ''' <summary>
    ''' Init List
    ''' </summary>
    Private Sub InitList()

        With dgvList

            .SuspendLayout()

            .AutoGenerateColumns = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .RowCount = DispMax

            Dim wkFont As New Font("", 7, FontStyle.Bold)
            For cnt As Integer = 0 To DispMax - 1
                .Item(dgvCol.btnUp, cnt).Value = "↑"
                .Item(dgvCol.btnUp, cnt).Style.Font = wkFont
                .Item(dgvCol.btnDown, cnt).Value = "↓"
                .Item(dgvCol.btnDown, cnt).Style.Font = wkFont
                .Item(dgvCol.btnIns, cnt).Value = "Ins"
                .Item(dgvCol.btnDel, cnt).Value = "Bor"
            Next

            .ResumeLayout()

        End With

        With dgvFirma

            .SuspendLayout()

            .AutoGenerateColumns = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .RowCount = 5

            Dim wkFont As New Font("", 9, FontStyle.Bold)
            .Columns(dgvColFirma.Title).DefaultCellStyle.Font = wkFont
            .Item(dgvColFirma.Title, 0).Value = "Solicita"
            .Item(dgvColFirma.Title, 1).Value = "Revisa"
            .Item(dgvColFirma.Title, 2).Value = "Autoriza"
            .Item(dgvColFirma.Title, 3).Value = "Despacha"
            .Item(dgvColFirma.Title, 4).Value = "Recibe"

            .ResumeLayout()

        End With

    End Sub

    ''' <summary>
    ''' SetDGVCombo
    ''' </summary>
    Private Sub SetDGVCombo()

        Dim wkBodega As String = ""
        If Me.cboBodega.SelectedIndex <> -1 Then
            wkBodega = Me.cboBodega.SelectedValue.ToString
        End If

        With dgvList

            .SuspendLayout()

            For row As Integer = 0 To dgvList.RowCount - 1
                .Item(dgvCol.Insumos, row).Value = String.Empty
                .Item(dgvCol.Unidad, row).Value = String.Empty
                .Item(dgvCol.Solicitada, row).Value = String.Empty
            Next

            'SetComboBox
            scDGV.SetInsumosComboBox(wkBodega, .Columns(dgvCol.Insumos))
            scDGV.SetUnidadComboBox(.Columns(dgvCol.Unidad))

            .ResumeLayout()

        End With

        'Get InsumosData
        GetInsumosData(wkBodega)

    End Sub

    ''' <summary>
    ''' Display List
    ''' </summary>
    Private Sub DispData()

        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable
        Dim dtRetDetail As New DataTable

        'Clear Data
        ClearData()

        'Set Condition
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Requisicion)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Requisicion.Numero_docu) = Me.txtNumero.Text
        dr.Item(Entity.Requisicion.Anio) = Me.cboYear.SelectedValue
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.Requisicion_select_key(dtRet, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRet.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        Me.txtFecha.Text = cu.SetFormatDate(dtRet.Rows(0).Item(Entity.Requisicion.Fecha))
        Me.cboNombreBodega.SelectedValue = dtRet.Rows(0).Item(Entity.Requisicion.NombreBodega)
        Me.cboBodega.SelectedValue = dtRet.Rows(0).Item(Entity.Requisicion.Bodega)
        Me.cboServicio.SelectedValue = dtRet.Rows(0).Item(Entity.Requisicion.Codigo_Serv)
        Me.txtJustificacion.Text = dtRet.Rows(0).Item(Entity.Requisicion.Descripcion).ToString
        With dgvFirma
            .Item(dgvColFirma.Nombre, 0).Value = dtRet.Rows(0).Item(Entity.Requisicion.Solicita)
            .Item(dgvColFirma.Nombre, 1).Value = dtRet.Rows(0).Item(Entity.Requisicion.Revisa)
            .Item(dgvColFirma.Nombre, 2).Value = dtRet.Rows(0).Item(Entity.Requisicion.Autoriza)
            .Item(dgvColFirma.Nombre, 3).Value = dtRet.Rows(0).Item(Entity.Requisicion.Despacha)
            .Item(dgvColFirma.Nombre, 4).Value = dtRet.Rows(0).Item(Entity.Requisicion.Recibe)
            .Item(dgvColFirma.Cargo, 0).Value = dtRet.Rows(0).Item(Entity.Requisicion.Solicita_Carg)
            .Item(dgvColFirma.Cargo, 1).Value = dtRet.Rows(0).Item(Entity.Requisicion.Revisa_Carg)
            .Item(dgvColFirma.Cargo, 2).Value = dtRet.Rows(0).Item(Entity.Requisicion.Autoriza_Carg)
            .Item(dgvColFirma.Cargo, 3).Value = dtRet.Rows(0).Item(Entity.Requisicion.Despacha_Carg)
            .Item(dgvColFirma.Cargo, 4).Value = dtRet.Rows(0).Item(Entity.Requisicion.Recibe_Carg)
        End With

        'SetDGVCombo
        SetDGVCombo()

        'Table Access
        If bc.RequisicionDetalles_select_key(dtRetDetail, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRetDetail.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        For wkRow As Integer = 0 To dtRetDetail.Rows.Count - 1
            dgvList.Item(dgvCol.Insumos, wkRow).Value = dtRetDetail.Rows(wkRow).Item(Entity.RequisicionDetalles.Codigo_Dato)
            dgvList.Item(dgvCol.Unidad, wkRow).Value = GetUnidad(dtRetDetail.Rows(wkRow).Item(Entity.RequisicionDetalles.Codigo_Dato).ToString)
            dgvList.Item(dgvCol.Solicitada, wkRow).Value = dtRetDetail.Rows(wkRow).Item(Entity.RequisicionDetalles.Solicitada)
        Next

    End Sub

    ''' <summary>
    ''' Clear Data
    ''' </summary>
    Private Sub ClearData()

        If _EditMode Or _DispMode Then
            Me.cboYear.SelectedValue = _Anio
            Me.txtNumero.Text = _NumeroDocu
            Me.txtFecha.Text = Date.Today.ToString("dd/MM/yyyy")
        Else
            Me.cboYear.SelectedIndex = 0
            Me.txtNumero.Text = "Sin asignar"
            Me.txtFecha.Text = Date.Today.ToString("dd/MM/yyyy")
        End If
        Me.cboNombreBodega.SelectedIndex = -1
        Me.cboBodega.SelectedIndex = -1
        Me.cboServicio.SelectedIndex = -1
        Me.txtJustificacion.Text = ""

        _EditFlg = True

        With dgvList
            For row As Integer = 0 To dgvList.RowCount - 1
                .Item(dgvCol.Insumos, row).Value = String.Empty
                .Item(dgvCol.Unidad, row).Value = String.Empty
                .Item(dgvCol.Solicitada, row).Value = String.Empty
            Next
        End With

        With dgvFirma
            .Item(dgvColFirma.Nombre, 0).Value = ""
            .Item(dgvColFirma.Nombre, 1).Value = cu.GetSetting(HospitalConst.SETTINGS.REQUISICION_REVISA)
            .Item(dgvColFirma.Nombre, 2).Value = cu.GetSetting(HospitalConst.SETTINGS.REQUISICION_AUTORIZA)
            .Item(dgvColFirma.Nombre, 3).Value = cu.GetSetting(HospitalConst.SETTINGS.REQUISICION_DESPACHA)
            .Item(dgvColFirma.Nombre, 4).Value = ""

            .Item(dgvColFirma.Cargo, 0).Value = cu.GetSetting(HospitalConst.SETTINGS.REQUISICION_SOLICITA_CARGO)
            .Item(dgvColFirma.Cargo, 1).Value = cu.GetSetting(HospitalConst.SETTINGS.REQUISICION_REVISA_CARGO)
            .Item(dgvColFirma.Cargo, 2).Value = cu.GetSetting(HospitalConst.SETTINGS.REQUISICION_AUTORIZA_CARGO)
            .Item(dgvColFirma.Cargo, 3).Value = cu.GetSetting(HospitalConst.SETTINGS.REQUISICION_DESPACHA_CARGO)
            .Item(dgvColFirma.Cargo, 4).Value = cu.GetSetting(HospitalConst.SETTINGS.REQUISICION_RECIBE_CARGO)
        End With

        If _DispMode Then
            Me.txtFecha.SetEnabled = False
            Me.cboNombreBodega.SetEnabled = False
            Me.cboBodega.SetEnabled = False
            Me.cboServicio.SetEnabled = False
            Me.txtJustificacion.SetEnabled = False
            Me.dgvList.ReadOnly = True
            Me.dgvFirma.ReadOnly = True
            Me.btnSave.Enabled = False
            Me.btnClear.Enabled = False
            Me.btnReDisplay.Enabled = False
            Select Case _InventarioStatus
                Case HospitalConst.INVENTARIOST_CD.NOIMPRESO, HospitalConst.INVENTARIOST_CD.IMPRESO
                Case Else
                    Me.btnPrint.Enabled = False
            End Select
        Else
            Me.btnPrint.Enabled = False
        End If

        _EditFlg = False

    End Sub

    ''' <summary>
    ''' Swap Row
    ''' </summary>
    ''' <param name="Row1"></param>
    ''' <param name="Row2"></param>
    Private Sub SwapRow(ByVal Row1 As Integer, ByVal Row2 As Integer)

        _EditFlg = True

        dgvList.SuspendLayout()

        Dim wkData(3) As Object
        wkData(0) = dgvList.Item(dgvCol.Insumos, Row1).Value
        wkData(1) = dgvList.Item(dgvCol.Unidad, Row1).Value
        wkData(2) = dgvList.Item(dgvCol.Solicitada, Row1).Value

        dgvList.Item(dgvCol.Insumos, Row1).Value = dgvList.Item(dgvCol.Insumos, Row2).Value
        dgvList.Item(dgvCol.Unidad, Row1).Value = dgvList.Item(dgvCol.Unidad, Row2).Value
        dgvList.Item(dgvCol.Solicitada, Row1).Value = dgvList.Item(dgvCol.Solicitada, Row2).Value

        dgvList.Item(dgvCol.Insumos, Row2).Value = wkData(0)
        dgvList.Item(dgvCol.Unidad, Row2).Value = wkData(1)
        dgvList.Item(dgvCol.Solicitada, Row2).Value = wkData(2)

        dgvList.ResumeLayout()

        _EditFlg = False

    End Sub

    ''' <summary>
    ''' Delete Row
    ''' </summary>
    ''' <param name="RowIndex"></param>
    Private Sub DeleteRow(ByVal RowIndex As Integer)

        _EditFlg = True

        dgvList.SuspendLayout()

        For Row As Integer = RowIndex To dgvList.RowCount - 2

            dgvList.Item(dgvCol.Insumos, Row).Value = dgvList.Item(dgvCol.Insumos, Row + 1).Value
            dgvList.Item(dgvCol.Unidad, Row).Value = dgvList.Item(dgvCol.Unidad, Row + 1).Value
            dgvList.Item(dgvCol.Solicitada, Row).Value = dgvList.Item(dgvCol.Solicitada, Row + 1).Value
        Next

        dgvList.Item(dgvCol.Insumos, dgvList.RowCount - 1).Value = String.Empty
        dgvList.Item(dgvCol.Unidad, dgvList.RowCount - 1).Value = String.Empty
        dgvList.Item(dgvCol.Solicitada, dgvList.RowCount - 1).Value = String.Empty

        dgvList.ResumeLayout()

        _EditFlg = False

    End Sub

    ''' <summary>
    ''' Insert Row
    ''' </summary>
    ''' <param name="RowIndex"></param>
    Private Sub InsertRow(ByVal RowIndex As Integer)

        If dgvList.Item(dgvCol.Insumos, dgvList.RowCount - 1).Value IsNot Nothing AndAlso
           Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Insumos, dgvList.RowCount - 1).Value.ToString) Then
            MessageBoxManager.ShowError("Los datos se establecen en la última línea")
            Exit Sub
        End If

        _EditFlg = True

        dgvList.SuspendLayout()

        For Row As Integer = dgvList.RowCount - 2 To RowIndex Step -1

            dgvList.Item(dgvCol.Insumos, Row + 1).Value = dgvList.Item(dgvCol.Insumos, Row).Value
            dgvList.Item(dgvCol.Unidad, Row + 1).Value = dgvList.Item(dgvCol.Unidad, Row).Value
            dgvList.Item(dgvCol.Solicitada, Row + 1).Value = dgvList.Item(dgvCol.Solicitada, Row).Value
        Next

        dgvList.Item(dgvCol.Insumos, RowIndex).Value = String.Empty
        dgvList.Item(dgvCol.Unidad, RowIndex).Value = String.Empty
        dgvList.Item(dgvCol.Solicitada, RowIndex).Value = String.Empty

        dgvList.ResumeLayout()

        _EditFlg = False

    End Sub


    ''' <summary>
    ''' Imput Check
    ''' </summary>
    ''' <returns></returns>
    Private Function InputCheck() As Boolean

        If String.IsNullOrEmpty(Me.txtFecha.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece una fecha")
            Me.txtFecha.Focus()
            Return False
        End If

        If Me.cboNombreBodega.SelectedIndex = -1 Then
            MessageBoxManager.ShowWorning("Por favor, establece un nombre de bodega")
            Me.cboNombreBodega.Focus()
            Return False
        End If

        If Me.cboBodega.SelectedIndex = -1 Then
            MessageBoxManager.ShowWorning("Por favor, establece una bodega")
            Me.cboBodega.Focus()
            Return False
        End If

        If Me.cboServicio.SelectedIndex = -1 Then
            MessageBoxManager.ShowWorning("Por favor, establece un servicio")
            Me.cboServicio.Focus()
            Return False
        End If

        For cnt As Integer = 0 To dgvList.RowCount - 1
            If dgvList.Item(dgvCol.Insumos, cnt).Value IsNot Nothing AndAlso
               Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Insumos, cnt).Value.ToString) Then

                If dgvList.Item(dgvCol.Unidad, cnt).Value Is Nothing OrElse
                   String.IsNullOrEmpty(dgvList.Item(dgvCol.Unidad, cnt).Value.ToString) OrElse
                   dgvList.Item(dgvCol.Solicitada, cnt).Value Is Nothing OrElse
                   String.IsNullOrEmpty(dgvList.Item(dgvCol.Solicitada, cnt).Value.ToString) Then
                    MessageBoxManager.ShowWorning("La lista de insumos no es válida")
                    Me.dgvList.Focus()
                    Return False
                End If
            Else

                If (dgvList.Item(dgvCol.Unidad, cnt).Value IsNot Nothing AndAlso
                    Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Unidad, cnt).Value.ToString)) OrElse
                   (dgvList.Item(dgvCol.Solicitada, cnt).Value IsNot Nothing AndAlso
                    Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Solicitada, cnt).Value.ToString)) Then
                    MessageBoxManager.ShowWorning("La lista de insumos no es válida")
                    Me.dgvList.Focus()
                    Return False
                End If
            End If
        Next

        Return True

    End Function

    ''' <summary>
    ''' Save Data
    ''' </summary>
    Private Sub SaveData()

        If InputCheck() = False Then
            Exit Sub
        End If

        If MessageBoxManager.ShowQuestionOkCancel("¿Quieres guardarlo?") <> MsgBoxResult.Ok Then
            Exit Sub
        End If

        Dim dtData As DataTable = Entity.GetTable(Entity.TableNmae.Requisicion)
        Dim dr As DataRow = dtData.NewRow
        dr.Item(Entity.Requisicion.Numero_docu) = Me.txtNumero.Text
        dr.Item(Entity.Requisicion.Anio) = Me.cboYear.SelectedValue
        dr.Item(Entity.Requisicion.Fecha) = cu.SetFormatDateForDB(Me.txtFecha.Text)
        dr.Item(Entity.Requisicion.NombreBodega) = Me.cboNombreBodega.SelectedValue
        dr.Item(Entity.Requisicion.Bodega) = Me.cboBodega.SelectedValue
        dr.Item(Entity.Requisicion.Codigo_Serv) = Me.cboServicio.SelectedValue
        dr.Item(Entity.Requisicion.Descripcion) = Me.txtJustificacion.Text
        dr.Item(Entity.Requisicion.Solicita) = dgvFirma.Item(dgvColFirma.Nombre, 0).Value
        dr.Item(Entity.Requisicion.Revisa) = dgvFirma.Item(dgvColFirma.Nombre, 1).Value
        dr.Item(Entity.Requisicion.Autoriza) = dgvFirma.Item(dgvColFirma.Nombre, 2).Value
        dr.Item(Entity.Requisicion.Despacha) = dgvFirma.Item(dgvColFirma.Nombre, 3).Value
        dr.Item(Entity.Requisicion.Recibe) = dgvFirma.Item(dgvColFirma.Nombre, 4).Value
        dr.Item(Entity.Requisicion.Solicita_Carg) = dgvFirma.Item(dgvColFirma.Cargo, 0).Value
        dr.Item(Entity.Requisicion.Revisa_Carg) = dgvFirma.Item(dgvColFirma.Cargo, 1).Value
        dr.Item(Entity.Requisicion.Autoriza_Carg) = dgvFirma.Item(dgvColFirma.Cargo, 2).Value
        dr.Item(Entity.Requisicion.Despacha_Carg) = dgvFirma.Item(dgvColFirma.Cargo, 3).Value
        dr.Item(Entity.Requisicion.Recibe_Carg) = dgvFirma.Item(dgvColFirma.Cargo, 4).Value

        If Not _EditMode Then
            dr.Item(Entity.Requisicion.Inventario) = "0"
        End If

        dtData.Rows.Add(dr)

        Dim dtDataDetail As DataTable = Entity.GetTable(Entity.TableNmae.RequisicionDetalles)
        For cnt As Integer = 0 To dgvList.RowCount - 1
            If dgvList.Item(dgvCol.Insumos, cnt).Value IsNot Nothing AndAlso
               Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Insumos, cnt).Value.ToString) Then
                Dim drDetail As DataRow = dtDataDetail.NewRow
                drDetail.Item(Entity.RequisicionDetalles.Numero_docu) = Me.txtNumero.Text
                drDetail.Item(Entity.RequisicionDetalles.Anio) = Me.cboYear.SelectedValue
                drDetail.Item(Entity.RequisicionDetalles.Numero_serie) = (cnt + 1).ToString("00")
                drDetail.Item(Entity.RequisicionDetalles.Codigo_Dato) = dgvList.Item(dgvCol.Insumos, cnt).Value
                drDetail.Item(Entity.RequisicionDetalles.Bodega) = Me.cboBodega.SelectedValue
                drDetail.Item(Entity.RequisicionDetalles.Codigo_Insu) = GetCodigoInsumo(dgvList.Item(dgvCol.Insumos, cnt).Value.ToString)
                drDetail.Item(Entity.RequisicionDetalles.Solicitada) = dgvList.Item(dgvCol.Solicitada, cnt).Value
                dtDataDetail.Rows.Add(drDetail)
            End If
        Next

        Dim bc As New PedidoYRequisicionBC

        If _EditMode Then
            'Mode : Edit Data
            If bc.Requisicion_update(dtData, dtDataDetail) <= 0 Then
                MessageBoxManager.ShowError("Error en la base de datos")
                Exit Sub
            End If

            'Set Settings
            SetSettings()

            'Disp Data
            DispData()

            MessageBoxManager.ShowNormal("Guardado")
        Else
            'Mode : Add Data
            Dim wkAnio As String = ""
            Dim wkNumbero As String = ""

            'Add Requisicion Data
            If bc.Requisicion_insert(dtData, dtDataDetail, wkNumbero, wkAnio) <= 0 Then
                MessageBoxManager.ShowError("Error en la base de datos")
                Exit Sub
            End If

            MessageBoxManager.ShowNormal("Guardado")

            'Set Key
            _Anio = wkAnio
            _NumeroDocu = wkNumbero

            'Set Settings
            SetSettings()

            'Me.Close()

            _LoadFlg = False

            'ClearData
            ClearData()

            'SetDGVCombo
            SetDGVCombo()

            _LoadFlg = True

            Me.txtFecha.Focus()

        End If

    End Sub

    ''' <summary>
    ''' Set Settings
    ''' </summary>
    Private Sub SetSettings()
        With dgvFirma
            cu.SetSetting(HospitalConst.SETTINGS.REQUISICION_REVISA, .Item(dgvColFirma.Nombre, 1).Value)
            cu.SetSetting(HospitalConst.SETTINGS.REQUISICION_AUTORIZA, .Item(dgvColFirma.Nombre, 2).Value)
            cu.SetSetting(HospitalConst.SETTINGS.REQUISICION_DESPACHA, .Item(dgvColFirma.Nombre, 3).Value)

            cu.SetSetting(HospitalConst.SETTINGS.REQUISICION_SOLICITA_CARGO, .Item(dgvColFirma.Cargo, 0).Value)
            cu.SetSetting(HospitalConst.SETTINGS.REQUISICION_REVISA_CARGO, .Item(dgvColFirma.Cargo, 1).Value)
            cu.SetSetting(HospitalConst.SETTINGS.REQUISICION_AUTORIZA_CARGO, .Item(dgvColFirma.Cargo, 2).Value)
            cu.SetSetting(HospitalConst.SETTINGS.REQUISICION_DESPACHA_CARGO, .Item(dgvColFirma.Cargo, 3).Value)
            cu.SetSetting(HospitalConst.SETTINGS.REQUISICION_RECIBE_CARGO, .Item(dgvColFirma.Cargo, 4).Value)
        End With
    End Sub

    ''' <summary>
    ''' Update Patient Data
    ''' </summary>
    Private Sub UpdateRequisicion(ByVal Anio As String, ByVal Numero As String, ByVal Status As String)

        Dim bc As New PedidoYRequisicionBC

        'Set Condition
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Requisicion)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Requisicion.Numero_docu) = Numero
        dr.Item(Entity.Requisicion.Anio) = Anio
        dr.Item(Entity.Requisicion.Inventario) = Status
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.Requisicion_update_inventario(dtcondition) < HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

    End Sub

    ''' <summary>
    ''' Get Insumos Data
    ''' </summary>
    Public Sub GetInsumosData(ByVal Bodega As String)

        Dim bc As New PedidoYRequisicionBC
        If bc.insumos_select(Bodega, dtInsumos) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            'Exit Sub
        End If

    End Sub

    ''' <summary>
    ''' Get Unidad
    ''' </summary>
    Public Function GetUnidad(ByVal CodigoDato As String) As String

        Dim ret As String = ""

        For Each dr As DataRow In dtInsumos.Rows
            If dr.Item(Entity.Insumos.Codigo_Dato).ToString = CodigoDato Then
                ret = dr.Item(Entity.Insumos.Unidad).ToString
                Exit For
            End If
        Next

        Return ret

    End Function

    ''' <summary>
    ''' Get Unidad
    ''' </summary>
    Public Function GetCodigoInsumo(ByVal CodigoDato As String) As String

        Dim ret As String = ""

        For Each dr As DataRow In dtInsumos.Rows
            If dr.Item(Entity.Insumos.Codigo_Dato).ToString = CodigoDato Then
                ret = dr.Item(Entity.Insumos.Codigo_Insu).ToString
                Exit For
            End If
        Next

        Return ret

    End Function

    Private Sub dgvFirma_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFirma.CellContentClick

    End Sub

#End Region

End Class
