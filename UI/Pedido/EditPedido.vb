' Note:
' Add EditPedido.Designer.vb
' dgvList.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

Public Class EditPedido

#Region "difinition"

    Private TITLE As String = ""
    Private cu As CommonUtility = CommonUtility.GetInstance
    Private sc As New SetCombobox
    Private scDGV As New SetComboBoxDGV
    Private DispMax As Integer = 10
    Private _EditFlg As Boolean = False
    Private _LoadFlg As Boolean = False

    Private Enum dgvCol
        btnUp = 0
        btnDown = 1
        btnIns = 2
        btnDel = 3
        Codigo_Insu = 4
        Codigo_Presentacion = 5
        Insumos = 6
        Unidad = 7
        Solicitada = 8
        Autorizada = 9
        Financiero = 10
        Estimado = 11
        Paac = 12
        Abierto = 13
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
            TITLE = "Modificación del pedido"
        Else
            TITLE = "Agregar de pedido"
        End If
        If _DispMode Then
            TITLE = "Referencia del pedido"
        End If

        'Set Form Title
        MyBase.FormTitle = TITLE

        'Set ComboBox
        SetCombo()

        _LoadFlg = True

        'Init List
        InitList()

        'Clear Data
        ClearData()

        If _EditMode Or _DispMode Then

            'Display Data
            DispData()

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

        'Printout Pedido Report
        Dim rc As New ReportCommon
        rc.PrintPedido(Me.cboYear.SelectedValue.ToString, Me.txtNumero.Text)

        'Update Pedido Data
        UpdatePedido(Me.cboYear.SelectedValue.ToString, Me.txtNumero.Text, HospitalConst.INVENTARIOST_CD.IMPRESO)

        Me.Cursor = Cursors.Default

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

        If e.ColumnIndex < dgvCol.Insumos Or e.ColumnIndex > dgvCol.Estimado Then
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
                    dgvList.Item(dgvCol.Autorizada, e.RowIndex).Value = wkVal
                    dgvList.Item(dgvCol.Financiero, e.RowIndex).Value = wkVal
                    dgvList.Item(dgvCol.Estimado, e.RowIndex).Value = wkVal
                    dgvList.Item(dgvCol.Paac, e.RowIndex).Value = "False"
                    dgvList.Item(dgvCol.Abierto, e.RowIndex).Value = "False"
                Else
                    'dgvList.Item(dgvCol.Unidad, e.RowIndex).Value = ""
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
                dgvList.Item(dgvCol.Autorizada, e.RowIndex).Value = wkVal

            Case dgvCol.Autorizada 'Autorizada
                If Not String.IsNullOrEmpty(wkVal) Then
                    If Not IsNumeric(wkVal) Then
                        MessageBoxManager.ShowError("Por favor ingrese un valor numérico")
                        dgvList.Item(e.ColumnIndex, e.RowIndex).Value = ""
                        dgvList.CurrentCell = dgvList.Item(e.ColumnIndex, e.RowIndex)
                        dgvList.BeginEdit(True)
                        Exit Sub
                    End If
                End If

            Case dgvCol.Financiero 'Financiero
                If Not String.IsNullOrEmpty(wkVal) Then
                    If Not IsNumeric(wkVal) Then
                        MessageBoxManager.ShowError("Por favor ingrese un valor numérico")
                        dgvList.Item(e.ColumnIndex, e.RowIndex).Value = ""
                        dgvList.CurrentCell = dgvList.Item(e.ColumnIndex, e.RowIndex)
                        dgvList.BeginEdit(True)
                        Exit Sub
                    End If
                End If

            Case dgvCol.Estimado 'Estimado
                If Not String.IsNullOrEmpty(wkVal) Then
                    If Not IsNumeric(wkVal) Then
                        MessageBoxManager.ShowError("Por favor ingrese un valor numérico")
                        dgvList.Item(e.ColumnIndex, e.RowIndex).Value = ""
                        dgvList.CurrentCell = dgvList.Item(e.ColumnIndex, e.RowIndex)
                        dgvList.BeginEdit(True)
                        Exit Sub
                    Else
                        dgvList.Item(dgvCol.Estimado, e.RowIndex).Value = CDbl(wkVal).ToString("#0.00")
                    End If
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

    End Sub

    ''' <summary>
    ''' Init List
    ''' </summary>
    Private Sub InitList()

        Me.dgvList.ColumnHeadersDefaultCellStyle.Font = New Font("", 9)
        Me.dgvFirma.ColumnHeadersDefaultCellStyle.Font = New Font("", 9)

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

            'SetComboBox
            'scDGV.SetInsumosComboBox(.Columns(dgvCol.Insumos))
            'scDGV.SetUnidadComboBox(.Columns(dgvCol.Unidad))

            .ResumeLayout()

        End With

        With dgvFirma

            .SuspendLayout()

            .AutoGenerateColumns = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .RowCount = 3

            Dim wkFont As New Font("", 9, FontStyle.Bold)
            .Columns(dgvColFirma.Title).DefaultCellStyle.Font = wkFont
            .Item(dgvColFirma.Title, 0).Value = "Solicita"
            .Item(dgvColFirma.Title, 1).Value = "Autorización"
            .Item(dgvColFirma.Title, 2).Value = "Aprobación"

            .ResumeLayout()

        End With

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
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Pedido)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Pedido.Numero_docu) = Me.txtNumero.Text
        dr.Item(Entity.Pedido.Anio) = Me.cboYear.SelectedValue
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.Pedido_select_key(dtRet, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRet.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        Me.txtFecha.Text = cu.SetFormatDate(dtRet.Rows(0).Item(Entity.Pedido.Fecha))
        Me.cboServicio.SelectedValue = dtRet.Rows(0).Item(Entity.Pedido.Codigo_Serv)
        Me.txtTelefono.Text = dtRet.Rows(0).Item(Entity.Pedido.Telefono).ToString
        Me.txtJustificacion.Text = dtRet.Rows(0).Item(Entity.Pedido.Descripcion).ToString
        With dgvFirma
            .Item(dgvColFirma.Nombre, 0).Value = dtRet.Rows(0).Item(Entity.Pedido.Solicita)
            .Item(dgvColFirma.Nombre, 1).Value = dtRet.Rows(0).Item(Entity.Pedido.Autoriza)
            .Item(dgvColFirma.Nombre, 2).Value = dtRet.Rows(0).Item(Entity.Pedido.Aprobacion)
            .Item(dgvColFirma.Cargo, 0).Value = dtRet.Rows(0).Item(Entity.Pedido.Solicita_Carg)
            .Item(dgvColFirma.Cargo, 1).Value = dtRet.Rows(0).Item(Entity.Pedido.Autoriza_Carg)
            .Item(dgvColFirma.Cargo, 2).Value = dtRet.Rows(0).Item(Entity.Pedido.Aprobacion_Carg)
        End With
        Select Case dtRet.Rows(0).Item(Entity.Pedido.TipoCompras).ToString
            Case "1"
                Me.rbtCompraDirecta.Checked = True
            Case "2"
                Me.rbtContratoAbierto.Checked = True
            Case "3"
                Me.rbtCotizacion.Checked = True
            Case "4"
                Me.rbtLicitacion.Checked = True
            Case "5"
                Me.rbtBajaCuantilla.Checked = True
            Case "6"
                Me.rbtSubastaInversa.Checked = True
            Case Else
                Me.rbtCompraDirecta.Checked = True
        End Select
        Select Case dtRet.Rows(0).Item(Entity.Pedido.Pago).ToString
            Case "1"
                Me.rbtFondoRotativo.Checked = True
            Case "2"
                Me.rbtAcreditamiento.Checked = True
            Case Else
                Me.rbtFondoRotativo.Checked = True
        End Select
        Select Case dtRet.Rows(0).Item(Entity.Pedido.Disponibilidad).ToString
            Case "1"
                Me.rbtDisponibilidadSi.Checked = True
            Case "2"
                Me.rbtDisponibilidadNo.Checked = True
            Case Else
                Me.rbtDisponibilidadSi.Checked = True
        End Select
        Me.txtPresupuesto.Text = dtRet.Rows(0).Item(Entity.Pedido.Presupuesto).ToString
        Me.txtCompras.Text = dtRet.Rows(0).Item(Entity.Pedido.Compras).ToString
        Me.txtOtro.Text = dtRet.Rows(0).Item(Entity.Pedido.Otro).ToString
        Me.txtSubProducto.Text = dtRet.Rows(0).Item(Entity.Pedido.SubProducto).ToString
        Me.txtProg.Text = dtRet.Rows(0).Item(Entity.Pedido.Prog).ToString
        Me.txtSubp.Text = dtRet.Rows(0).Item(Entity.Pedido.Subp).ToString
        Me.txtProy.Text = dtRet.Rows(0).Item(Entity.Pedido.Proy).ToString
        Me.txtAct.Text = dtRet.Rows(0).Item(Entity.Pedido.Act).ToString
        Me.txtObra.Text = dtRet.Rows(0).Item(Entity.Pedido.Obra).ToString
        Me.txtUbGeo.Text = dtRet.Rows(0).Item(Entity.Pedido.Ub_Geo).ToString
        Me.txtFteFin.Text = dtRet.Rows(0).Item(Entity.Pedido.Fte_Fin).ToString

        'Table Access
        If bc.PedidoDetalles_select_key(dtRetDetail, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRetDetail.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        For wkRow As Integer = 0 To dtRetDetail.Rows.Count - 1
            dgvList.Item(dgvCol.Codigo_Insu, wkRow).Value = dtRetDetail.Rows(wkRow).Item(Entity.PedidoDetalles.Codigo_Insu)
            dgvList.Item(dgvCol.Codigo_Presentacion, wkRow).Value = dtRetDetail.Rows(wkRow).Item(Entity.PedidoDetalles.Codigo_Presentacion)
            dgvList.Item(dgvCol.Insumos, wkRow).Value = dtRetDetail.Rows(wkRow).Item(Entity.PedidoDetalles.Insumos)
            dgvList.Item(dgvCol.Unidad, wkRow).Value = dtRetDetail.Rows(wkRow).Item(Entity.PedidoDetalles.Unidad)
            dgvList.Item(dgvCol.Solicitada, wkRow).Value = dtRetDetail.Rows(wkRow).Item(Entity.PedidoDetalles.Solicitada)
            dgvList.Item(dgvCol.Autorizada, wkRow).Value = dtRetDetail.Rows(wkRow).Item(Entity.PedidoDetalles.Autorizada)
            dgvList.Item(dgvCol.Financiero, wkRow).Value = dtRetDetail.Rows(wkRow).Item(Entity.PedidoDetalles.Financiero)
            dgvList.Item(dgvCol.Estimado, wkRow).Value = dtRetDetail.Rows(wkRow).Item(Entity.PedidoDetalles.Estimado)
            If dtRetDetail.Rows(wkRow).Item(Entity.PedidoDetalles.Paac).ToString = "1" Then
                dgvList.Item(dgvCol.Paac, wkRow).Value = "True"
            Else
                dgvList.Item(dgvCol.Paac, wkRow).Value = "False"
            End If
            If dtRetDetail.Rows(wkRow).Item(Entity.PedidoDetalles.Abierto).ToString = "1" Then
                dgvList.Item(dgvCol.Abierto, wkRow).Value = "True"
            Else
                dgvList.Item(dgvCol.Abierto, wkRow).Value = "False"
            End If
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
        Me.cboServicio.SelectedValue = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_SERVICIO)
        Me.txtTelefono.Text = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_TELEFONO)
        Me.txtJustificacion.Text = ""

        Me.txtPresupuesto.Text = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_PRESUPUESTO)
        Me.txtCompras.Text = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_COMPRAS)
        Me.txtOtro.Text = ""
        Me.txtSubProducto.Text = ""
        Me.rbtCompraDirecta.Checked = True
        Me.rbtFondoRotativo.Checked = True
        Me.rbtDisponibilidadSi.Checked = True

        Me.txtProg.Text = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_PROG)
        Me.txtSubp.Text = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_SUBP)
        Me.txtProy.Text = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_PROY)
        Me.txtAct.Text = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_ACT)
        Me.txtObra.Text = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_OBRA)
        Me.txtUbGeo.Text = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_UB_GEO)
        Me.txtFteFin.Text = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_FTE_FIN)

        _EditFlg = True

        With dgvList
            For row As Integer = 0 To dgvList.RowCount - 1
                .Item(dgvCol.Codigo_Insu, row).Value = String.Empty
                .Item(dgvCol.Codigo_Presentacion, row).Value = String.Empty
                .Item(dgvCol.Insumos, row).Value = String.Empty
                .Item(dgvCol.Unidad, row).Value = String.Empty
                .Item(dgvCol.Solicitada, row).Value = String.Empty
                .Item(dgvCol.Autorizada, row).Value = String.Empty
                .Item(dgvCol.Financiero, row).Value = String.Empty
                .Item(dgvCol.Estimado, row).Value = String.Empty
                .Item(dgvCol.Paac, row).Value = "False"
                .Item(dgvCol.Abierto, row).Value = "False"
            Next
        End With

        With dgvFirma
            .Item(dgvColFirma.Nombre, 0).Value = ""
            .Item(dgvColFirma.Nombre, 1).Value = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_AUTORIZA)
            .Item(dgvColFirma.Nombre, 2).Value = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_APROBACION)

            .Item(dgvColFirma.Cargo, 0).Value = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_SOLICITA_CARGO)
            .Item(dgvColFirma.Cargo, 1).Value = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_AUTORIZA_CARGO)
            .Item(dgvColFirma.Cargo, 2).Value = cu.GetSetting(HospitalConst.SETTINGS.PEDIDO_APROBACION_CARGO)
        End With

        If _DispMode Then
            Me.txtFecha.SetEnabled = False
            Me.cboServicio.SetEnabled = False
            Me.txtJustificacion.SetEnabled = False
            Me.dgvList.ReadOnly = True
            Me.dgvFirma.ReadOnly = True
            Me.btnSave.Enabled = False
            Me.btnClear.Enabled = False
            Me.btnReDisplay.Enabled = False
            Me.GroupBox1.Enabled = False
            Me.GroupBox2.Enabled = False
            Me.GroupBox3.Enabled = False
            Me.txtPresupuesto.SetEnabled = False
            Me.txtCompras.SetEnabled = False
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

        Dim wkData(9) As Object
        wkData(0) = dgvList.Item(dgvCol.Codigo_Insu, Row1).Value
        wkData(1) = dgvList.Item(dgvCol.Codigo_Presentacion, Row1).Value
        wkData(2) = dgvList.Item(dgvCol.Insumos, Row1).Value
        wkData(3) = dgvList.Item(dgvCol.Unidad, Row1).Value
        wkData(4) = dgvList.Item(dgvCol.Solicitada, Row1).Value
        wkData(5) = dgvList.Item(dgvCol.Autorizada, Row1).Value
        wkData(6) = dgvList.Item(dgvCol.Financiero, Row1).Value
        wkData(7) = dgvList.Item(dgvCol.Estimado, Row1).Value
        wkData(8) = dgvList.Item(dgvCol.Paac, Row1).Value
        wkData(9) = dgvList.Item(dgvCol.Abierto, Row1).Value

        dgvList.Item(dgvCol.Codigo_Insu, Row1).Value = dgvList.Item(dgvCol.Codigo_Insu, Row2).Value
        dgvList.Item(dgvCol.Codigo_Presentacion, Row1).Value = dgvList.Item(dgvCol.Codigo_Presentacion, Row2).Value
        dgvList.Item(dgvCol.Insumos, Row1).Value = dgvList.Item(dgvCol.Insumos, Row2).Value
        dgvList.Item(dgvCol.Unidad, Row1).Value = dgvList.Item(dgvCol.Unidad, Row2).Value
        dgvList.Item(dgvCol.Solicitada, Row1).Value = dgvList.Item(dgvCol.Solicitada, Row2).Value
        dgvList.Item(dgvCol.Autorizada, Row1).Value = dgvList.Item(dgvCol.Autorizada, Row2).Value
        dgvList.Item(dgvCol.Financiero, Row1).Value = dgvList.Item(dgvCol.Financiero, Row2).Value
        dgvList.Item(dgvCol.Estimado, Row1).Value = dgvList.Item(dgvCol.Estimado, Row2).Value
        dgvList.Item(dgvCol.Paac, Row1).Value = dgvList.Item(dgvCol.Paac, Row2).Value
        dgvList.Item(dgvCol.Abierto, Row1).Value = dgvList.Item(dgvCol.Abierto, Row2).Value

        dgvList.Item(dgvCol.Codigo_Insu, Row2).Value = wkData(0)
        dgvList.Item(dgvCol.Codigo_Presentacion, Row2).Value = wkData(1)
        dgvList.Item(dgvCol.Insumos, Row2).Value = wkData(2)
        dgvList.Item(dgvCol.Unidad, Row2).Value = wkData(3)
        dgvList.Item(dgvCol.Solicitada, Row2).Value = wkData(4)
        dgvList.Item(dgvCol.Autorizada, Row2).Value = wkData(5)
        dgvList.Item(dgvCol.Financiero, Row2).Value = wkData(6)
        dgvList.Item(dgvCol.Estimado, Row2).Value = wkData(7)
        dgvList.Item(dgvCol.Paac, Row2).Value = wkData(8)
        dgvList.Item(dgvCol.Abierto, Row2).Value = wkData(9)

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

            dgvList.Item(dgvCol.Codigo_Insu, Row).Value = dgvList.Item(dgvCol.Codigo_Insu, Row + 1).Value
            dgvList.Item(dgvCol.Codigo_Presentacion, Row).Value = dgvList.Item(dgvCol.Codigo_Presentacion, Row + 1).Value
            dgvList.Item(dgvCol.Insumos, Row).Value = dgvList.Item(dgvCol.Insumos, Row + 1).Value
            dgvList.Item(dgvCol.Unidad, Row).Value = dgvList.Item(dgvCol.Unidad, Row + 1).Value
            dgvList.Item(dgvCol.Solicitada, Row).Value = dgvList.Item(dgvCol.Solicitada, Row + 1).Value
            dgvList.Item(dgvCol.Autorizada, Row).Value = dgvList.Item(dgvCol.Autorizada, Row + 1).Value
            dgvList.Item(dgvCol.Financiero, Row).Value = dgvList.Item(dgvCol.Financiero, Row + 1).Value
            dgvList.Item(dgvCol.Estimado, Row).Value = dgvList.Item(dgvCol.Estimado, Row + 1).Value
            dgvList.Item(dgvCol.Paac, Row).Value = dgvList.Item(dgvCol.Paac, Row + 1).Value
            dgvList.Item(dgvCol.Abierto, Row).Value = dgvList.Item(dgvCol.Abierto, Row + 1).Value
        Next

        dgvList.Item(dgvCol.Codigo_Insu, dgvList.RowCount - 1).Value = String.Empty
        dgvList.Item(dgvCol.Codigo_Presentacion, dgvList.RowCount - 1).Value = String.Empty
        dgvList.Item(dgvCol.Insumos, dgvList.RowCount - 1).Value = String.Empty
        dgvList.Item(dgvCol.Unidad, dgvList.RowCount - 1).Value = String.Empty
        dgvList.Item(dgvCol.Solicitada, dgvList.RowCount - 1).Value = String.Empty
        dgvList.Item(dgvCol.Autorizada, dgvList.RowCount - 1).Value = String.Empty
        dgvList.Item(dgvCol.Financiero, dgvList.RowCount - 1).Value = String.Empty
        dgvList.Item(dgvCol.Estimado, dgvList.RowCount - 1).Value = String.Empty
        dgvList.Item(dgvCol.Paac, dgvList.RowCount - 1).Value = "False"
        dgvList.Item(dgvCol.Abierto, dgvList.RowCount - 1).Value = "False"

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
            dgvList.Item(dgvCol.Codigo_Insu, Row + 1).Value = dgvList.Item(dgvCol.Codigo_Insu, Row).Value
            dgvList.Item(dgvCol.Codigo_Presentacion, Row + 1).Value = dgvList.Item(dgvCol.Codigo_Presentacion, Row).Value
            dgvList.Item(dgvCol.Insumos, Row + 1).Value = dgvList.Item(dgvCol.Insumos, Row).Value
            dgvList.Item(dgvCol.Unidad, Row + 1).Value = dgvList.Item(dgvCol.Unidad, Row).Value
            dgvList.Item(dgvCol.Solicitada, Row + 1).Value = dgvList.Item(dgvCol.Solicitada, Row).Value
            dgvList.Item(dgvCol.Autorizada, Row + 1).Value = dgvList.Item(dgvCol.Autorizada, Row).Value
            dgvList.Item(dgvCol.Financiero, Row + 1).Value = dgvList.Item(dgvCol.Financiero, Row).Value
            dgvList.Item(dgvCol.Estimado, Row + 1).Value = dgvList.Item(dgvCol.Estimado, Row).Value
            dgvList.Item(dgvCol.Paac, Row + 1).Value = dgvList.Item(dgvCol.Paac, Row).Value
            dgvList.Item(dgvCol.Abierto, Row + 1).Value = dgvList.Item(dgvCol.Abierto, Row).Value
        Next

        dgvList.Item(dgvCol.Codigo_Insu, RowIndex).Value = String.Empty
        dgvList.Item(dgvCol.Codigo_Presentacion, RowIndex).Value = String.Empty
        dgvList.Item(dgvCol.Insumos, RowIndex).Value = String.Empty
        dgvList.Item(dgvCol.Unidad, RowIndex).Value = String.Empty
        dgvList.Item(dgvCol.Solicitada, RowIndex).Value = String.Empty
        dgvList.Item(dgvCol.Autorizada, RowIndex).Value = String.Empty
        dgvList.Item(dgvCol.Financiero, RowIndex).Value = String.Empty
        dgvList.Item(dgvCol.Estimado, RowIndex).Value = String.Empty
        dgvList.Item(dgvCol.Paac, RowIndex).Value = "False"
        dgvList.Item(dgvCol.Abierto, RowIndex).Value = "False"

        dgvList.ResumeLayout()

        _EditFlg = False

    End Sub


    ''' <summary>
    ''' Imput Check
    ''' </summary>
    ''' <returns></returns>
    Private Function InputCheck() As Boolean

        If String.IsNullOrEmpty(Me.txtFecha.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un fecha")
            Me.txtFecha.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.txtTelefono.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un teléfono")
            Me.txtTelefono.Focus()
            Return False
        End If

        If Me.cboServicio.SelectedIndex = -1 Then
            MessageBoxManager.ShowWorning("Por favor, establece un servicio")
            Me.cboServicio.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.txtOtro.Text) Then
            'MessageBoxManager.ShowWorning("Por favor, establece un Otro")
            'Me.txtOtro.Focus()
            'Return False
        End If

        If String.IsNullOrEmpty(Me.txtSubProducto.Text) Then
            'MessageBoxManager.ShowWorning("Por favor, establece un Sub Producto")
            'Me.txtSubProducto.Focus()
            'Return False
        End If

        If String.IsNullOrEmpty(Me.txtProg.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un PROG")
            Me.txtProg.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.txtSubp.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un SUBP")
            Me.txtSubp.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.txtProy.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un PROY.")
            Me.txtProy.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.txtAct.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un ACT.")
            Me.txtAct.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.txtObra.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un OBRA")
            Me.txtObra.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.txtUbGeo.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un UB.GEO")
            Me.txtUbGeo.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.txtFteFin.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un FTE.FIN")
            Me.txtFteFin.Focus()
            Return False
        End If

        For cnt As Integer = 0 To dgvList.RowCount - 1
            If dgvList.Item(dgvCol.Insumos, cnt).Value IsNot Nothing AndAlso
               Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Insumos, cnt).Value.ToString) Then

                'If dgvList.Item(dgvCol.Unidad, cnt).Value Is Nothing OrElse
                '   String.IsNullOrEmpty(dgvList.Item(dgvCol.Unidad, cnt).Value.ToString) OrElse
                '   dgvList.Item(dgvCol.Solicitada, cnt).Value Is Nothing OrElse
                '   String.IsNullOrEmpty(dgvList.Item(dgvCol.Solicitada, cnt).Value.ToString) OrElse
                '   dgvList.Item(dgvCol.Autorizada, cnt).Value Is Nothing OrElse
                '   String.IsNullOrEmpty(dgvList.Item(dgvCol.Autorizada, cnt).Value.ToString) OrElse
                '   dgvList.Item(dgvCol.Financiero, cnt).Value Is Nothing OrElse
                '   String.IsNullOrEmpty(dgvList.Item(dgvCol.Financiero, cnt).Value.ToString) OrElse
                '   dgvList.Item(dgvCol.Estimado, cnt).Value Is Nothing OrElse
                '   String.IsNullOrEmpty(dgvList.Item(dgvCol.Estimado, cnt).Value.ToString) Then
                '    MessageBoxManager.ShowWorning("La lista de insumos no es válida")
                '    Me.dgvList.Focus()
                '    Return False
                'End If
            Else

                If (dgvList.Item(dgvCol.Codigo_Insu, cnt).Value IsNot Nothing AndAlso
                    Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Codigo_Insu, cnt).Value.ToString)) OrElse
                   (dgvList.Item(dgvCol.Codigo_Presentacion, cnt).Value IsNot Nothing AndAlso
                    Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Codigo_Presentacion, cnt).Value.ToString)) OrElse
                   (dgvList.Item(dgvCol.Unidad, cnt).Value IsNot Nothing AndAlso
                    Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Unidad, cnt).Value.ToString)) OrElse
                   (dgvList.Item(dgvCol.Solicitada, cnt).Value IsNot Nothing AndAlso
                    Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Solicitada, cnt).Value.ToString)) OrElse
                   (dgvList.Item(dgvCol.Autorizada, cnt).Value IsNot Nothing AndAlso
                    Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Autorizada, cnt).Value.ToString)) OrElse
                   (dgvList.Item(dgvCol.Financiero, cnt).Value IsNot Nothing AndAlso
                    Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Financiero, cnt).Value.ToString)) OrElse
                   (dgvList.Item(dgvCol.Estimado, cnt).Value IsNot Nothing AndAlso
                    Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Estimado, cnt).Value.ToString)) Then
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

        Dim dtData As DataTable = Entity.GetTable(Entity.TableNmae.Pedido)
        Dim dr As DataRow = dtData.NewRow
        dr.Item(Entity.Pedido.Numero_docu) = Me.txtNumero.Text
        dr.Item(Entity.Pedido.Anio) = Me.cboYear.SelectedValue
        dr.Item(Entity.Pedido.Fecha) = cu.SetFormatDateForDB(Me.txtFecha.Text)
        dr.Item(Entity.Pedido.Codigo_Serv) = Me.cboServicio.SelectedValue
        dr.Item(Entity.Pedido.Telefono) = Me.txtTelefono.Text
        dr.Item(Entity.Pedido.Descripcion) = Me.txtJustificacion.Text
        dr.Item(Entity.Pedido.Solicita) = dgvFirma.Item(dgvColFirma.Nombre, 0).Value
        dr.Item(Entity.Pedido.Autoriza) = dgvFirma.Item(dgvColFirma.Nombre, 1).Value
        dr.Item(Entity.Pedido.Aprobacion) = dgvFirma.Item(dgvColFirma.Nombre, 2).Value
        dr.Item(Entity.Pedido.Solicita_Carg) = dgvFirma.Item(dgvColFirma.Cargo, 0).Value
        dr.Item(Entity.Pedido.Autoriza_Carg) = dgvFirma.Item(dgvColFirma.Cargo, 1).Value
        dr.Item(Entity.Pedido.Aprobacion_Carg) = dgvFirma.Item(dgvColFirma.Cargo, 2).Value

        If Me.rbtCompraDirecta.Checked Then
            dr.Item(Entity.Pedido.TipoCompras) = "1"
        End If
        If Me.rbtContratoAbierto.Checked Then
            dr.Item(Entity.Pedido.TipoCompras) = "2"
        End If
        If Me.rbtCotizacion.Checked Then
            dr.Item(Entity.Pedido.TipoCompras) = "3"
        End If
        If Me.rbtLicitacion.Checked Then
            dr.Item(Entity.Pedido.TipoCompras) = "4"
        End If
        If Me.rbtBajaCuantilla.Checked Then
            dr.Item(Entity.Pedido.TipoCompras) = "5"
        End If
        If Me.rbtSubastaInversa.Checked Then
            dr.Item(Entity.Pedido.TipoCompras) = "6"
        End If

        If Me.rbtFondoRotativo.Checked Then
            dr.Item(Entity.Pedido.Pago) = "1"
        End If
        If Me.rbtAcreditamiento.Checked Then
            dr.Item(Entity.Pedido.Pago) = "2"
        End If

        If Me.rbtDisponibilidadSi.Checked Then
            dr.Item(Entity.Pedido.Disponibilidad) = "1"
        End If
        If Me.rbtDisponibilidadNo.Checked Then
            dr.Item(Entity.Pedido.Disponibilidad) = "2"
        End If

        dr.Item(Entity.Pedido.Presupuesto) = Me.txtPresupuesto.Text
        dr.Item(Entity.Pedido.Compras) = Me.txtCompras.Text
        dr.Item(Entity.Pedido.Otro) = Me.txtOtro.Text
        dr.Item(Entity.Pedido.SubProducto) = Me.txtSubProducto.Text

        dr.Item(Entity.Pedido.Prog) = Me.txtProg.Text
        dr.Item(Entity.Pedido.Subp) = Me.txtSubp.Text
        dr.Item(Entity.Pedido.Proy) = Me.txtProy.Text
        dr.Item(Entity.Pedido.Act) = Me.txtAct.Text
        dr.Item(Entity.Pedido.Obra) = Me.txtObra.Text
        dr.Item(Entity.Pedido.Ub_Geo) = Me.txtUbGeo.Text
        dr.Item(Entity.Pedido.Fte_Fin) = Me.txtFteFin.Text

        If Not _EditMode Then
            dr.Item(Entity.Pedido.Inventario) = "0"
        End If

        dtData.Rows.Add(dr)

        Dim dtDataDetail As DataTable = Entity.GetTable(Entity.TableNmae.PedidoDetalles)
        For cnt As Integer = 0 To dgvList.RowCount - 1
            If dgvList.Item(dgvCol.Insumos, cnt).Value IsNot Nothing AndAlso
               Not String.IsNullOrEmpty(dgvList.Item(dgvCol.Insumos, cnt).Value.ToString) Then
                Dim drDetail As DataRow = dtDataDetail.NewRow
                drDetail.Item(Entity.PedidoDetalles.Numero_docu) = Me.txtNumero.Text
                drDetail.Item(Entity.PedidoDetalles.Anio) = Me.cboYear.SelectedValue
                drDetail.Item(Entity.PedidoDetalles.Numero_serie) = (cnt + 1).ToString("00")
                drDetail.Item(Entity.PedidoDetalles.Codigo_Insu) = dgvList.Item(dgvCol.Codigo_Insu, cnt).Value
                drDetail.Item(Entity.PedidoDetalles.Codigo_Presentacion) = dgvList.Item(dgvCol.Codigo_Presentacion, cnt).Value
                drDetail.Item(Entity.PedidoDetalles.Insumos) = dgvList.Item(dgvCol.Insumos, cnt).Value
                drDetail.Item(Entity.PedidoDetalles.Unidad) = dgvList.Item(dgvCol.Unidad, cnt).Value
                drDetail.Item(Entity.PedidoDetalles.Solicitada) = dgvList.Item(dgvCol.Solicitada, cnt).Value
                drDetail.Item(Entity.PedidoDetalles.Autorizada) = dgvList.Item(dgvCol.Autorizada, cnt).Value
                drDetail.Item(Entity.PedidoDetalles.Financiero) = dgvList.Item(dgvCol.Financiero, cnt).Value
                drDetail.Item(Entity.PedidoDetalles.Estimado) = dgvList.Item(dgvCol.Estimado, cnt).Value
                If dgvList.Item(dgvCol.Paac, cnt).Value.ToString = "True" Then
                    drDetail.Item(Entity.PedidoDetalles.Paac) = "1"
                Else
                    drDetail.Item(Entity.PedidoDetalles.Paac) = "2"
                End If
                If dgvList.Item(dgvCol.Abierto, cnt).Value.ToString = "True" Then
                    drDetail.Item(Entity.PedidoDetalles.Abierto) = "1"
                Else
                    drDetail.Item(Entity.PedidoDetalles.Abierto) = "2"
                End If
                dtDataDetail.Rows.Add(drDetail)
            End If
        Next

        Dim bc As New PedidoYRequisicionBC

        If _EditMode Then
            'Mode : Edit Data
            If bc.Pedido_update(dtData, dtDataDetail) <= 0 Then
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
            If bc.Pedido_insert(dtData, dtDataDetail, wkNumbero, wkAnio) <= 0 Then
                MessageBoxManager.ShowError("Error en la base de datos")
                Exit Sub
            End If

            MessageBoxManager.ShowNormal("Guardado")

            'Set Key
            _Anio = wkAnio
            _NumeroDocu = wkNumbero

            'Set Settings
            SetSettings()

            Me.Close()

        End If

    End Sub

    ''' <summary>
    ''' Set Settings
    ''' </summary>
    Private Sub SetSettings()
        cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_SERVICIO, Me.cboServicio.SelectedValue)
        cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_TELEFONO, Me.txtTelefono.Text)
        With dgvFirma
            cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_AUTORIZA, .Item(dgvColFirma.Nombre, 1).Value)
            cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_APROBACION, .Item(dgvColFirma.Nombre, 2).Value)

            cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_SOLICITA_CARGO, .Item(dgvColFirma.Cargo, 0).Value)
            cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_AUTORIZA_CARGO, .Item(dgvColFirma.Cargo, 1).Value)
            cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_APROBACION_CARGO, .Item(dgvColFirma.Cargo, 2).Value)
        End With
        cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_PRESUPUESTO, Me.txtPresupuesto.Text)
        cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_COMPRAS, Me.txtCompras.Text)

        cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_PROG, Me.txtProg.Text)
        cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_SUBP, Me.txtSubp.Text)
        cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_PROY, Me.txtProy.Text)
        cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_ACT, Me.txtAct.Text)
        cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_OBRA, Me.txtObra.Text)
        cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_UB_GEO, Me.txtUbGeo.Text)
        cu.SetSetting(HospitalConst.SETTINGS.PEDIDO_FTE_FIN, Me.txtFteFin.Text)

    End Sub

    ''' <summary>
    ''' Update Patient Data
    ''' </summary>
    Private Sub UpdatePedido(ByVal Anio As String, ByVal Numero As String, ByVal Status As String)

        Dim bc As New PedidoYRequisicionBC

        'Set Condition
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Pedido)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Pedido.Numero_docu) = Numero
        dr.Item(Entity.Pedido.Anio) = Anio
        dr.Item(Entity.Pedido.Inventario) = Status
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.Pedido_update_inventario(dtcondition) < HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

    End Sub

#End Region

End Class
