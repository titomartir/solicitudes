Public Class SetCombobox

#Region "Year ComboBox"

    ''' <summary>
    ''' Set Year ComboBox
    ''' </summary>
    ''' <param name="startY">"YYYY"</param>
    ''' <param name="endY">"YYYY"</param>
    ''' <param name="cbo"></param>
    Public Sub SetYearComboBox(ByRef cbo As CustomComboBox, ByVal startY As String, ByVal endY As String)

        'cbo.DropDownStyle = ComboBoxStyle.DropDownList

        If Not IsNumeric(startY) Then
            MessageBoxManager.ShowError("ERROR:SetYearComboBox")
            Exit Sub
        End If

        If Not IsNumeric(endY) Then
            MessageBoxManager.ShowError("ERROR:SetYearComboBox")
            Exit Sub
        End If

        Dim wkStart As Integer = CInt(startY)
        Dim wkEnd As Integer = CInt(endY)

        Dim dt As New DataTable
        dt.Columns.Add("code", GetType(System.String))
        dt.Columns.Add("text", GetType(System.String))

        While wkStart <= wkEnd
            dt.Rows.Add(wkEnd.ToString, "")
            wkEnd = wkEnd - 1
        End While

        'Set Data For ComboBox
        cbo.SetComboData(dt, "code", "text", CustomComboBox.DispKind.Code)

    End Sub

#End Region

#Region "InventarioStatus ComboBox"

    ''' <summary>
    ''' Set InventarioStatus ComboBox
    ''' </summary>
    ''' <param name="cbo"></param>
    Public Sub SetInventarioStatusComboBox(ByRef cbo As CustomComboBox, Optional ByVal isMakeEmpty As Boolean = False)

        'cbo.DropDownStyle = ComboBoxStyle.DropDownList

        Dim dt As New DataTable
        dt.Columns.Add("code", GetType(System.String))
        dt.Columns.Add("text", GetType(System.String))

        dt.Rows.Add(HospitalConst.INVENTARIOST_CD.NOIMPRESO, HospitalConst.INVENTARIOST_NAME.NOIMPRESO)
        dt.Rows.Add(HospitalConst.INVENTARIOST_CD.IMPRESO, HospitalConst.INVENTARIOST_NAME.IMPRESO)
        dt.Rows.Add(HospitalConst.INVENTARIOST_CD.PROCESADO, HospitalConst.INVENTARIOST_NAME.PROCESADO)
        dt.Rows.Add(HospitalConst.INVENTARIOST_CD.DESHABILITADO, HospitalConst.INVENTARIOST_NAME.DESHABILITADO)

        'Set Data For ComboBox
        cbo.SetComboData(dt, "code", "text", CustomComboBox.DispKind.Text, isMakeEmpty)

    End Sub

#End Region

#Region "Servicio ComboBox"

    ''' <summary>
    ''' Set Servicio ComboBox
    ''' </summary>
    ''' <param name="cbo"></param>
    Public Sub SetServicioComboBox(ByRef cbo As CustomComboBox, Optional ByVal isMakeEmpty As Boolean = False)

        'cbo.DropDownStyle = ComboBoxStyle.DropDownList

        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable
        If bc.servicio_select(dtRet) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            'Exit Sub
        End If

        'Set Data For ComboBox
        cbo.SetComboData(dtRet, "Codigo_Serv", "Nombre_Serv", CustomComboBox.DispKind.CodeText, isMakeEmpty)

    End Sub

#End Region

#Region "Unidad ComboBox"

    ''' <summary>
    ''' Set Unidad ComboBox
    ''' </summary>
    ''' <param name="cbo"></param>
    Public Sub SetUnidadComboBox(ByRef cbo As CustomComboBox, Optional ByVal isMakeEmpty As Boolean = False)

        'cbo.DropDownStyle = ComboBoxStyle.DropDownList

        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable
        If bc.Unidad_select(dtRet) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            'Exit Sub
        End If

        'Set Data For ComboBox
        cbo.SetComboData(dtRet, "Codigo_Unid", "Nombre_Unid", CustomComboBox.DispKind.Text, isMakeEmpty)

    End Sub

#End Region

#Region "Bodega ComboBox"

    ''' <summary>
    ''' Set Bodega ComboBox
    ''' </summary>
    ''' <param name="cbo"></param>
    Public Sub SetBodegaComboBox(ByRef cbo As CustomComboBox, Optional ByVal isMakeEmpty As Boolean = False)

        'cbo.DropDownStyle = ComboBoxStyle.DropDownList

        Dim dt As New DataTable
        dt.Columns.Add("code", GetType(System.String))
        dt.Columns.Add("text", GetType(System.String))

        dt.Rows.Add(HospitalConst.BODEGA_CD.FARMACIA, HospitalConst.BODEGA_NAME.FARMACIA)
        dt.Rows.Add(HospitalConst.BODEGA_CD.LABORATORIO, HospitalConst.BODEGA_NAME.LABORATORIO)
        dt.Rows.Add(HospitalConst.BODEGA_CD.QUIRURGIA_DONACION, HospitalConst.BODEGA_NAME.QUIRURGIA_DONACION)
        dt.Rows.Add(HospitalConst.BODEGA_CD.QUIRURGIA_AGREGADO, HospitalConst.BODEGA_NAME.QUIRURGIA_AGREGADO)
        dt.Rows.Add(HospitalConst.BODEGA_CD.QUIRURGIA_GENERAL, HospitalConst.BODEGA_NAME.QUIRURGIA_GENERAL)
        dt.Rows.Add(HospitalConst.BODEGA_CD.QUIRURGIA_ADICIONAL, HospitalConst.BODEGA_NAME.QUIRURGIA_ADICIONAL)
        dt.Rows.Add(HospitalConst.BODEGA_CD.LIMPIEZA, HospitalConst.BODEGA_NAME.LIMPIEZA)
        dt.Rows.Add(HospitalConst.BODEGA_CD.PAPELERIA, HospitalConst.BODEGA_NAME.PAPELERIA)
        dt.Rows.Add(HospitalConst.BODEGA_CD.MANTENIMIENTO, HospitalConst.BODEGA_NAME.MANTENIMIENTO)
        dt.Rows.Add(HospitalConst.BODEGA_CD.ALIMENTOS, HospitalConst.BODEGA_NAME.ALIMENTOS)
        dt.Rows.Add(HospitalConst.BODEGA_CD.LIBRERIA, HospitalConst.BODEGA_NAME.LIBRERIA)
        'Set Data For ComboBox
        cbo.SetComboData(dt, "code", "text", CustomComboBox.DispKind.Text, isMakeEmpty)

    End Sub

#End Region

#Region "Nombre de Bodega ComboBox"

    ''' <summary>
    ''' Set Nombre de Bodega ComboBox
    ''' </summary>
    ''' <param name="cbo"></param>
    Public Sub SetNombreBodegaComboBox(ByRef cbo As CustomComboBox, Optional ByVal isMakeEmpty As Boolean = False)

        'cbo.DropDownStyle = ComboBoxStyle.DropDownList

        Dim dt As New DataTable
        dt.Columns.Add("code", GetType(System.String))
        dt.Columns.Add("text", GetType(System.String))

        dt.Rows.Add(HospitalConst.NOMBREBODEGA_CD.GENERAL, HospitalConst.NOMBREBODEGA_NAME.GENERAL)
        dt.Rows.Add(HospitalConst.NOMBREBODEGA_CD.FARMACIA, HospitalConst.NOMBREBODEGA_NAME.FARMACIA)
        dt.Rows.Add(HospitalConst.NOMBREBODEGA_CD.LABORATORIO, HospitalConst.NOMBREBODEGA_NAME.LABORATORIO)
        dt.Rows.Add(HospitalConst.NOMBREBODEGA_CD.ALIMENTOS, HospitalConst.NOMBREBODEGA_NAME.ALIMENTOS)
        'Set Data For ComboBox
        cbo.SetComboData(dt, "code", "text", CustomComboBox.DispKind.Text, isMakeEmpty)

    End Sub

#End Region

#Region "Insumo ComboBox"

    ''' <summary>
    ''' Set Servicio ComboBox
    ''' </summary>
    ''' <param name="cbo"></param>
    Public Sub SetInsumoComboBox(ByRef cbo As CustomComboBox, Optional ByVal isMakeEmpty As Boolean = False)

        'cbo.DropDownStyle = ComboBoxStyle.DropDownList

        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable

        Dim dtCondition As DataTable = Entity.GetTable(Entity.TableNmae.Insumos)
        Dim drCondition As DataRow = dtCondition.NewRow
        dtCondition.Rows.Add(drCondition)

        If bc.insumos_select_key(dtRet, dtCondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            'Exit Sub
        End If

        'Set Data For ComboBox
        cbo.SetComboData(dtRet, "Codigo_Insu", "Nombre_Insu", CustomComboBox.DispKind.CodeText, isMakeEmpty)

    End Sub

#End Region

End Class
