Public Class RequisicionList

#Region "difinition"

    Private TITLE As String = "Lista de requisicion"
    Dim sc As New SetCombobox
    Private _LoadFlg As Boolean = False

    Private Enum dgvCol
        btnDetail = 0
        btnEdit = 1
        btnDel = 2
        btnPrint = 3
        Anio = 4
        Numero = 5
        Fecha = 6
        Servicio = 7
        Estado = 8
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

        'Clear Condition
        ClearCondition()

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

        'Edit Patient
        Using Frm As New EditRequisicion
            Me.Hide()

            Frm.NumeroDocu = ""
            Frm.Anio = ""
            Frm.DispMode = False
            Frm.EditMode = False
            Frm.ShowDialog()

            Me.Show()
        End Using

        'Display List
        DispList()

    End Sub

#End Region

#Region "ComboBox Event"

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged

        If _LoadFlg = False Then
            Exit Sub
        End If

        'Clear DataGridView
        If dgvList.DataSource IsNot Nothing Then
            DirectCast(dgvList.DataSource, DataTable).Rows.Clear()
        End If

    End Sub

    Private Sub cboServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServicio.SelectedIndexChanged

        If _LoadFlg = False Then
            Exit Sub
        End If

        'Clear DataGridView
        If dgvList.DataSource IsNot Nothing Then
            DirectCast(dgvList.DataSource, DataTable).Rows.Clear()
        End If

    End Sub

    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged

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

    Private Sub txtBNumero_TextChanged(sender As Object, e As EventArgs) Handles txtBNumero.TextChanged

        If _LoadFlg = False Then
            Exit Sub
        End If

        'Clear DataGridView
        If dgvList.DataSource IsNot Nothing Then
            DirectCast(dgvList.DataSource, DataTable).Rows.Clear()
        End If

    End Sub

    Private Sub txtBFecha_TextChanged(sender As Object, e As EventArgs) Handles txtBFecha.TextChanged

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

        If e.ColumnIndex < dgvCol.btnDetail Or e.ColumnIndex > dgvCol.btnPrint Then
            Exit Sub
        End If

        'Get Key
        Dim wkAnio As String = Me.dgvList.Item(dgvCol.Anio, e.RowIndex).Value.ToString
        Dim wkNumero As String = Me.dgvList.Item(dgvCol.Numero, e.RowIndex).Value.ToString

        Select Case e.ColumnIndex
            Case dgvCol.btnDetail 'Detail

                Using Frm As New EditRequisicion
                    Frm.NumeroDocu = wkNumero
                    Frm.Anio = wkAnio
                    Frm.InventarioStatus = HospitalConst.GetInventarioStatusCd(Me.dgvList.Item(dgvCol.Estado, e.RowIndex).Value)
                    Frm.DispMode = True
                    Frm.EditMode = False
                    Frm.ShowDialog()
                End Using

                'Display List
                DispList()

            Case dgvCol.btnEdit 'Edit

                Select Case Me.dgvList.Item(dgvCol.Estado, e.RowIndex).Value.ToString
                    Case HospitalConst.INVENTARIOST_NAME.NOIMPRESO
                    Case HospitalConst.INVENTARIOST_NAME.IMPRESO
                    Case HospitalConst.INVENTARIOST_NAME.PROCESADO
                        MessageBoxManager.ShowWorning("Esta información no puede ser editada")
                        Exit Sub
                    Case HospitalConst.INVENTARIOST_NAME.DESHABILITADO
                        MessageBoxManager.ShowWorning("Esta información no puede ser editada")
                        Exit Sub
                    Case Else
                End Select

                Using Frm As New EditRequisicion
                    Frm.NumeroDocu = wkNumero
                    Frm.Anio = wkAnio
                    Frm.InventarioStatus = HospitalConst.GetInventarioStatusCd(Me.dgvList.Item(dgvCol.Estado, e.RowIndex).Value)
                    Frm.DispMode = False
                    Frm.EditMode = True
                    Frm.ShowDialog()
                End Using

                'Display List
                DispList()

            Case dgvCol.btnDel 'Del

                Select Case Me.dgvList.Item(dgvCol.Estado, e.RowIndex).Value.ToString
                    Case HospitalConst.INVENTARIOST_NAME.NOIMPRESO
                        If MessageBoxManager.ShowQuestionOkCancel("¿Desea eliminar los datos seleccionados?") = MsgBoxResult.Ok Then
                            'Delete Requisicion Data
                            DeleteRequisicion(wkAnio, wkNumero)
                        End If
                    Case HospitalConst.INVENTARIOST_NAME.IMPRESO
                        If MessageBoxManager.ShowQuestionOkCancel("¿Desea invalidar los datos?") = MsgBoxResult.Ok Then
                            'Update Requisicion Data
                            UpdateRequisicion(wkAnio, wkNumero, HospitalConst.INVENTARIOST_CD.DESHABILITADO)
                        End If
                    Case HospitalConst.INVENTARIOST_NAME.PROCESADO
                        If MessageBoxManager.ShowQuestionOkCancel("¿Desea invalidar los datos?") = MsgBoxResult.Ok Then
                            'Update Requisicion Data
                            UpdateRequisicion(wkAnio, wkNumero, HospitalConst.INVENTARIOST_CD.DESHABILITADO)
                        End If
                    Case HospitalConst.INVENTARIOST_NAME.DESHABILITADO
                        MessageBoxManager.ShowWorning("Esta información no puede ser eliminada")
                        Exit Sub
                    Case Else
                End Select

            Case dgvCol.btnPrint 'Print

                Select Case Me.dgvList.Item(dgvCol.Estado, e.RowIndex).Value.ToString
                    Case HospitalConst.INVENTARIOST_NAME.NOIMPRESO
                    Case HospitalConst.INVENTARIOST_NAME.IMPRESO
                    Case HospitalConst.INVENTARIOST_NAME.PROCESADO
                        MessageBoxManager.ShowWorning("Esta información no puede ser impresa")
                        Exit Sub
                    Case HospitalConst.INVENTARIOST_NAME.DESHABILITADO
                        MessageBoxManager.ShowWorning("Esta información no puede ser impresa")
                        Exit Sub
                    Case Else
                End Select

                Me.Cursor = Cursors.WaitCursor

                'Printout Requisicion Report
                Dim rc As New ReportCommon
                rc.PrintRequisicion(wkAnio, wkNumero)

                'Update Requisicion Data
                UpdateRequisicion(wkAnio, wkNumero, HospitalConst.INVENTARIOST_CD.IMPRESO)

                Me.Cursor = Cursors.Default

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

        sc.SetServicioComboBox(Me.cboServicio, True)
        sc.SetInventarioStatusComboBox(Me.cboEstado, True)

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
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Requisicion)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Requisicion.Numero_docu) = Me.txtBNumero.Text
        dr.Item(Entity.Requisicion.Anio) = Me.cboYear.SelectedValue
        dr.Item(Entity.Requisicion.Fecha) = Me.txtBFecha.Text
        dr.Item(Entity.Requisicion.Codigo_Serv) = Me.cboServicio.SelectedValue
        dr.Item(Entity.Requisicion.Inventario) = Me.cboEstado.SelectedValue
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.Requisicion_select_list(dtRet, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRet.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        For Each wkDr As DataRow In dtRet.Rows
            wkDr.Item(Entity.Requisicion.Inventario) = HospitalConst.GetInventarioStatus(wkDr.Item(Entity.Requisicion.Inventario))
        Next

        'Set Data For DataGridView
        Me.dgvList.DataSource = dtRet

    End Sub

    ''' <summary>
    ''' Clear Condition
    ''' </summary>
    Private Sub ClearCondition()

        Me.cboYear.SelectedIndex = 0
        Me.txtBNumero.Text = ""
        Me.txtBFecha.Text = ""
        Me.cboServicio.SelectedIndex = -1
        Me.cboEstado.SelectedIndex = -1

        'Clear DataGridView
        If dgvList.DataSource IsNot Nothing Then
            DirectCast(dgvList.DataSource, DataTable).Rows.Clear()
        End If

    End Sub

    ''' <summary>
    ''' Delete Requisicion Data
    ''' </summary>
    Private Sub DeleteRequisicion(ByVal Anio As String, ByVal Numero As String)

        Dim bc As New PedidoYRequisicionBC

        'Set Condition
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Requisicion)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Requisicion.Numero_docu) = Numero
        dr.Item(Entity.Requisicion.Anio) = Anio
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.Requisicion_delete(dtcondition) < HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Display List
        DispList()

        'Show Complete Message
        MessageBoxManager.ShowNormal("Datos eliminados")

    End Sub

    ''' <summary>
    ''' Update Requisicion Data
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

        'Display List
        DispList()

        If Status = HospitalConst.INVENTARIOST_CD.DESHABILITADO Then
            'Show Complete Message
            MessageBoxManager.ShowNormal("Datos actualizados")
        End If

    End Sub

#End Region

End Class
