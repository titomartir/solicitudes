Public Class InsumosList

#Region "difinition"

    Private TITLE As String = "Lista de insumos"
    Private cu As CommonUtility = CommonUtility.GetInstance
    Dim sc As New SetCombobox
    Private _LoadFlg As Boolean = False

    Private Enum dgvCol
        btnEdit = 0
        btnDel = 1
        Bodega = 2
        BodegaName = 3
        CodigoDato = 4
        Numero = 5
        Nombre = 6
        Unidad = 7
    End Enum

#End Region

#Region "Form Event"

    ''' <summary>
    ''' Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Form Title
        MyBase.FormTitle = TITLE

        'Set ComboBox
        SetCombo()

        'Init List
        InitList()

        _LoadFlg = True

        'Display List
        DispList()

    End Sub

#End Region

#Region "Button Event"

    ''' <summary>
    ''' Close Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Form Close
        Me.Close()

    End Sub

    ''' <summary>
    ''' Disp Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDisp_Click(sender As Object, e As EventArgs) Handles btnDisp.Click

        'Display List
        DispList()

    End Sub

    ''' <summary>
    ''' Clear Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear Condition
        ClearCondition()

    End Sub

    ''' <summary>
    ''' Add Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Using Frm As New EditInsumos
            Frm.CodigoDato = ""
            Frm.Bodega = ""
            Frm.EditMode = False
            Frm.ShowDialog()
        End Using

        'Ordenar
        Ordenar(False)

    End Sub

    ''' <summary>
    ''' Ordenar Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click

        If MessageBoxManager.ShowQuestionOkCancel("¿Te gustaría ordenarlo?") <> MsgBoxResult.Ok Then
            Exit Sub
        End If

        'Ordenar
        Ordenar()

    End Sub

#End Region

#Region "ComboBox Event"

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidad.SelectedIndexChanged,
                                                                                        cboBodega.SelectedIndexChanged

        If _LoadFlg = False Then
            Exit Sub
        End If

        'Clear DataGridView
        If dgvList.DataSource IsNot Nothing Then
            DirectCast(dgvList.DataSource, DataTable).Rows.Clear()
        End If

    End Sub

#End Region

#Region "Text Event"

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtBNumero.TextChanged,
                                                                              txtBNombre.TextChanged

        If _LoadFlg = False Then
            Exit Sub
        End If

        'Clear DataGridView
        If dgvList.DataSource IsNot Nothing Then
            DirectCast(dgvList.DataSource, DataTable).Rows.Clear()
        End If

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

        If e.ColumnIndex < dgvCol.btnEdit Or e.ColumnIndex > dgvCol.btnDel Then
            Exit Sub
        End If

        'Get Key
        Dim wkCodigoDato As String = Me.dgvList.Item(dgvCol.CodigoDato, e.RowIndex).Value.ToString
        Dim wkBodega As String = Me.dgvList.Item(dgvCol.Bodega, e.RowIndex).Value.ToString

        Select Case e.ColumnIndex
            Case dgvCol.btnEdit 'Edit

                Using Frm As New EditInsumos
                    Frm.CodigoDato = wkCodigoDato
                    Frm.Bodega = wkBodega
                    Frm.EditMode = True
                    Frm.ShowDialog()
                End Using

                'Display List
                DispList()

            Case dgvCol.btnDel 'Del

                If MessageBoxManager.ShowQuestionOkCancel("¿Desea eliminar los datos seleccionados?") = MsgBoxResult.Ok Then
                    'Delete Patient Data
                    DeleteInsumos(wkCodigoDato, wkBodega)
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

        sc.SetBodegaComboBox(Me.cboBodega, True)
        sc.SetUnidadComboBox(Me.cboUnidad, True)

    End Sub

    ''' <summary>
    ''' Init List
    ''' </summary>
    Private Sub InitList()
        With dgvList
            .AutoGenerateColumns = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    ''' <summary>
    ''' Display List
    ''' </summary>
    Private Sub DispList()

        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable

        'Clear DataGridView
        If dgvList.DataSource IsNot Nothing Then
            DirectCast(dgvList.DataSource, DataTable).Rows.Clear()
        End If

        'Set Condition
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Insumos)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Insumos.Bodega) = Me.cboBodega.SelectedValue
        dr.Item(Entity.Insumos.Codigo_Insu) = Me.txtBNumero.Text
        dr.Item(Entity.Insumos.Nombre_Insu) = Me.txtBNombre.Text
        dr.Item(Entity.Insumos.Unidad) = Me.cboUnidad.SelectedValue
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.insumos_select_list(dtRet, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRet.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        dtRet.Columns.Add("BodegaName", GetType(System.String))

        For Each wkDr As DataRow In dtRet.Rows
            wkDr.Item("BodegaName") = HospitalConst.GetBodegaName(wkDr.Item(Entity.Insumos.Bodega))
        Next

        Me.dgvList.SuspendLayout()

        'Set Data For DataGridView
        Me.dgvList.DataSource = dtRet

        'Set Width for DataGridView Rows
        Me.dgvList.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)

        ''Set Width for DataGridView Columns
        'Me.dgvList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        Me.dgvList.ResumeLayout()

    End Sub

    ''' <summary>
    ''' Clear Condition
    ''' </summary>
    Private Sub ClearCondition()

        Me.cboBodega.SelectedIndex = -1
        Me.txtBNumero.Text = ""
        Me.txtBNombre.Text = ""
        Me.cboUnidad.SelectedIndex = -1

        'Clear DataGridView
        If dgvList.DataSource IsNot Nothing Then
            DirectCast(dgvList.DataSource, DataTable).Rows.Clear()
        End If

    End Sub

    ''' <summary>
    ''' Delete Insumos Data
    ''' </summary>
    Private Sub DeleteInsumos(ByVal wkCodigoDato As String, ByVal wkBodega As String)

        Dim bc As New PedidoYRequisicionBC

        'Set Condition
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Insumos)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Insumos.Codigo_Dato) = wkCodigoDato
        dr.Item(Entity.Insumos.Bodega) = wkBodega
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.insumos_delete(dtcondition) < HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Ordenar
        Ordenar(False)

        'Show Complete Message
        MessageBoxManager.ShowNormal("Datos eliminados")

    End Sub

    ''' <summary>
    ''' Ordenar
    ''' </summary>
    Private Sub Ordenar(Optional IsShowMsg As Boolean = True)

        Dim bc As New PedidoYRequisicionBC

        'Table Access
        If bc.Orden_insumos() < HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Display List
        DispList()

        If IsShowMsg Then
            'Show Complete Message
            MessageBoxManager.ShowNormal("Completado")
        End If

    End Sub

#End Region

End Class
