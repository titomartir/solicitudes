Public Class SetComboBoxDGV

#Region "DispKind"

    Public Enum DispKind
        Code = 1
        Text = 2
        CodeText = 3
    End Enum

#End Region

#Region "SetComboData"

    Public Sub SetComboData(ByRef cbo As DataGridViewComboBoxColumn,
                            ByVal dtData As DataTable,
                            ByVal colCode As String,
                            ByVal colText As String,
                            Optional kind As DispKind = DispKind.CodeText,
                            Optional isMakeEmpty As Boolean = False)

        cbo.DataSource = Nothing

        Dim dt As New DataTable
        dt.Columns.Add("code", GetType(System.String))
        dt.Columns.Add("text", GetType(System.String))
        dt.Columns.Add("codetext", GetType(System.String))

        If isMakeEmpty Then
            dt.Rows.Add(String.Empty, String.Empty, String.Empty)
        End If

        For Each dr As DataRow In dtData.Rows
            dt.Rows.Add(dr.Item(colCode), dr.Item(colText), dr.Item(colCode).ToString & ":" & dr.Item(colText).ToString)
        Next

        Select Case kind
            Case DispKind.Code
                cbo.DisplayMember = "code"
                cbo.ValueMember = "code"
            Case DispKind.Text
                cbo.DisplayMember = "text"
                cbo.ValueMember = "code"
            Case Else
                cbo.DisplayMember = "codetext"
                cbo.ValueMember = "code"
        End Select

        cbo.DataSource = dt

    End Sub

#End Region

#Region "Servicio ComboBox"

    ''' <summary>
    ''' Set Servicio ComboBox
    ''' </summary>
    ''' <param name="col"></param>
    Public Sub SetServicioComboBox(ByRef col As DataGridViewColumn)

        Dim cbo As DataGridViewComboBoxColumn = DirectCast(col, DataGridViewComboBoxColumn)
        cbo.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
        cbo.DisplayStyleForCurrentCellOnly = True

        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable
        If bc.servicio_select(dtRet) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            'Exit Sub
        End If

        'Set Data For ComboBox
        Me.SetComboData(cbo, dtRet, "Codigo_Serv", "Nombre_Serv", DispKind.Text, True)

    End Sub

#End Region

#Region "Unidad ComboBox"

    ''' <summary>
    ''' Set Unidad ComboBox
    ''' </summary>
    ''' <param name="col"></param>
    Public Sub SetUnidadComboBox(ByRef col As DataGridViewColumn)

        Dim cbo As DataGridViewComboBoxColumn = DirectCast(col, DataGridViewComboBoxColumn)
        cbo.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
        cbo.DisplayStyleForCurrentCellOnly = True

        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable
        If bc.Unidad_select(dtRet) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            'Exit Sub
        End If

        'Set Data For ComboBox
        Me.SetComboData(cbo, dtRet, "Codigo_Unid", "Nombre_Unid", DispKind.Text, True)

    End Sub

#End Region

#Region "CodigoInsumos ComboBox"

    ''' <summary>
    ''' Set CodigoInsumos ComboBox
    ''' </summary>
    ''' <param name="col"></param>
    Public Sub SetCodigoInsumosComboBox(ByVal Bodega As String, ByRef col As DataGridViewColumn)

        Dim cbo As DataGridViewComboBoxColumn = DirectCast(col, DataGridViewComboBoxColumn)
        cbo.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
        cbo.DisplayStyleForCurrentCellOnly = True

        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable
        If bc.insumos_select(Bodega, dtRet) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            'Exit Sub
        End If

        'Set Data For ComboBox
        Me.SetComboData(cbo, dtRet, "Codigo_Dato", "Codigo_Insu", DispKind.Text, True)

    End Sub

#End Region

#Region "Insumos ComboBox"

    ''' <summary>
    ''' Set Insumos ComboBox
    ''' </summary>
    ''' <param name="col"></param>
    Public Sub SetInsumosComboBox(ByVal Bodega As String, ByRef col As DataGridViewColumn)

        Dim cbo As DataGridViewComboBoxColumn = DirectCast(col, DataGridViewComboBoxColumn)
        cbo.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
        cbo.DisplayStyleForCurrentCellOnly = True

        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable
        If bc.insumos_select(Bodega, dtRet) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            'Exit Sub
        End If

        'Set Data For ComboBox
        Me.SetComboData(cbo, dtRet, "Codigo_Dato", "Nombre_Insu", DispKind.Text, True)

    End Sub

#End Region

End Class
