Public Class ServicioList

#Region "difinition"

    Private TITLE As String = "Lista de servicio"
    Private cu As CommonUtility = CommonUtility.GetInstance
    Dim sc As New SetCombobox
    Private _LoadFlg As Boolean = False

    Private Enum dgvCol
        btnEdit = 0
        btnDel = 1
        Numero = 2
        Nombre = 3
        Telefono = 4
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

        Using Frm As New EditServicio
            Frm.CodigoServ = ""
            Frm.EditMode = False
            Frm.ShowDialog()
        End Using

        'Display List
        DispList()

    End Sub

#End Region

#Region "Text Event"

    Private Sub txtBNumero_TextChanged(sender As Object, e As EventArgs) Handles txtBCodigoServ.TextChanged

        If _LoadFlg = False Then
            Exit Sub
        End If

        'Clear DataGridView
        If dgvList.DataSource IsNot Nothing Then
            DirectCast(dgvList.DataSource, DataTable).Rows.Clear()
        End If

    End Sub

    Private Sub txtBNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBNombre.TextChanged

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
        Dim wkCodigoServ As String = Me.dgvList.Item(dgvCol.Numero, e.RowIndex).Value.ToString

        Select Case e.ColumnIndex
            Case dgvCol.btnEdit 'Edit

                Using Frm As New EditServicio
                    Frm.CodigoServ = wkCodigoServ
                    Frm.EditMode = True
                    Frm.ShowDialog()
                End Using

                'Display List
                DispList()

            Case dgvCol.btnDel 'Del

                If MessageBoxManager.ShowQuestionOkCancel("¿Desea eliminar los datos seleccionados?") = MsgBoxResult.Ok Then
                    'Delete Patient Data
                    DeleteServicio(wkCodigoServ)
                End If

            Case Else
        End Select

    End Sub

#End Region

#Region "User Method"

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
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Servicio)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Servicio.Codigo_Serv) = Me.txtBCodigoServ.Text
        dr.Item(Entity.Servicio.Nombre_Serv) = Me.txtBNombre.Text
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.Servicio_select_list(dtRet, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRet.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        Me.dgvList.SuspendLayout()

        'Set Data For DataGridView
        Me.dgvList.DataSource = dtRet

        ''Set Width for DataGridView Rows
        'Me.dgvList.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)

        ''Set Width for DataGridView Columns
        'Me.dgvList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        Me.dgvList.ResumeLayout()

    End Sub

    ''' <summary>
    ''' Clear Condition
    ''' </summary>
    Private Sub ClearCondition()

        Me.txtBCodigoServ.Text = ""
        Me.txtBNombre.Text = ""

        'Clear DataGridView
        If dgvList.DataSource IsNot Nothing Then
            DirectCast(dgvList.DataSource, DataTable).Rows.Clear()
        End If

    End Sub

    ''' <summary>
    ''' Delete Servicio Data
    ''' </summary>
    Private Sub DeleteServicio(ByVal wkCodigoServ As String)

        Dim bc As New PedidoYRequisicionBC

        'Set Condition
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Servicio)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Servicio.Codigo_Serv) = wkCodigoServ
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.Servicio_delete(dtcondition) < HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Display List
        DispList()

        'Show Complete Message
        MessageBoxManager.ShowNormal("Datos eliminados")

    End Sub

#End Region

End Class
