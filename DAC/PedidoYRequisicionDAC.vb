Imports MySql.Data.MySqlClient

Public Class PedidoYRequisicionDAC
    Inherits MySQLDataAccess

#Region "Constructor"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        MyBase.New(HospitalConst.DB_NAME.PEDIDOYREQUISICION)
    End Sub

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New(ByRef Connection As MySqlConnection)
        MyBase.New(Connection)
    End Sub

#End Region

#Region "Requisicion"

    ''' <summary>
    ''' Requisicion select
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Requisicion_select(ByRef dtRet As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM Requisicion" & vbCrLf)
        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Anio DESC," & vbCrLf)
        SQL.Append("    Numero_docu DESC" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Requisicion select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Requisicion_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.Requisicion.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.Requisicion.Anio).ToString
        Dim Fecha As String = dtCondition.Rows(0).Item(Entity.Requisicion.Fecha).ToString
        Dim NombreBodega As String = dtCondition.Rows(0).Item(Entity.Requisicion.NombreBodega).ToString
        Dim Bodega As String = dtCondition.Rows(0).Item(Entity.Requisicion.Bodega).ToString
        Dim Codigo_Serv As String = dtCondition.Rows(0).Item(Entity.Requisicion.Codigo_Serv).ToString
        Dim Inventario As String = dtCondition.Rows(0).Item(Entity.Requisicion.Inventario).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM Requisicion" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Numero_docu) Then
            SQL.Append("AND Numero_docu like ?Numero_docu" & vbCrLf)
            SetParam("Numero_docu", "%" & Numero_docu & "%")
        End If
        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND Anio like ?Anio" & vbCrLf)
            SetParam("Anio", "%" & Anio & "%")
        End If
        If Not String.IsNullOrEmpty(Fecha) Then
            SQL.Append("AND DATE_FORMAT(Fecha, '%d/%m/%Y') like ?Fecha" & vbCrLf)
            SetParam("Fecha", "%" & Fecha & "%")
        End If
        If Not String.IsNullOrEmpty(NombreBodega) Then
            SQL.Append("AND NombreBodega = ?NombreBodega" & vbCrLf)
            SetParam("NombreBodega", NombreBodega)
        End If
        If Not String.IsNullOrEmpty(Bodega) Then
            SQL.Append("AND Bodega = ?Bodega" & vbCrLf)
            SetParam("Bodega", Bodega)
        End If
        If Not String.IsNullOrEmpty(Codigo_Serv) Then
            SQL.Append("AND Codigo_Serv = ?Codigo_Serv" & vbCrLf)
            SetParam("Codigo_Serv", Codigo_Serv)
        End If
        If Not String.IsNullOrEmpty(Inventario) Then
            SQL.Append("AND Inventario = ?Inventario" & vbCrLf)
            SetParam("Inventario", Inventario)
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Anio DESC," & vbCrLf)
        SQL.Append("    Numero_docu DESC" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Requisicion select for List
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Requisicion_select_list(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.Requisicion.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.Requisicion.Anio).ToString
        Dim Fecha As String = dtCondition.Rows(0).Item(Entity.Requisicion.Fecha).ToString
        Dim NombreBodega As String = dtCondition.Rows(0).Item(Entity.Requisicion.NombreBodega).ToString
        Dim Bodega As String = dtCondition.Rows(0).Item(Entity.Requisicion.Bodega).ToString
        Dim Codigo_Serv As String = dtCondition.Rows(0).Item(Entity.Requisicion.Codigo_Serv).ToString
        Dim Inventario As String = dtCondition.Rows(0).Item(Entity.Requisicion.Inventario).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT" & vbCrLf)
        SQL.Append("    'Det' AS Detalles," & vbCrLf)
        SQL.Append("    'Mod' AS Modificar," & vbCrLf)
        SQL.Append("    'Bor' AS Borrar," & vbCrLf)
        SQL.Append("    'Imp' AS Imprimir," & vbCrLf)
        SQL.Append("    A.Numero_docu," & vbCrLf)
        SQL.Append("    A.Anio," & vbCrLf)
        SQL.Append("    DATE_FORMAT(A.Fecha, '%d/%m/%Y') AS Fecha," & vbCrLf)
        SQL.Append("    A.NombreBodega," & vbCrLf)
        SQL.Append("    B.Nombre_Serv," & vbCrLf)
        SQL.Append("    A.Inventario" & vbCrLf)
        SQL.Append("FROM Requisicion AS A" & vbCrLf)
        SQL.Append("    LEFT JOIN servicio AS B" & vbCrLf)
        SQL.Append("       ON A.Codigo_Serv = B.Codigo_Serv" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Numero_docu) Then
            SQL.Append("AND A.Numero_docu like ?Numero_docu" & vbCrLf)
            SetParam("Numero_docu", "%" & Numero_docu & "%")
        End If
        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND A.Anio like ?Anio" & vbCrLf)
            SetParam("Anio", "%" & Anio & "%")
        End If
        If Not String.IsNullOrEmpty(Fecha) Then
            SQL.Append("AND DATE_FORMAT(A.Fecha, '%d/%m/%Y') like ?Fecha" & vbCrLf)
            SetParam("Fecha", "%" & Fecha & "%")
        End If
        If Not String.IsNullOrEmpty(NombreBodega) Then
            SQL.Append("AND A.NombreBodega = ?NombreBodega" & vbCrLf)
            SetParam("NombreBodega", NombreBodega)
        End If
        If Not String.IsNullOrEmpty(Bodega) Then
            SQL.Append("AND A.Bodega = ?Bodega" & vbCrLf)
            SetParam("Bodega", Bodega)
        End If
        If Not String.IsNullOrEmpty(Codigo_Serv) Then
            SQL.Append("AND A.Codigo_Serv = ?Codigo_Serv" & vbCrLf)
            SetParam("Codigo_Serv", Codigo_Serv)
        End If
        If Not String.IsNullOrEmpty(Inventario) Then
            SQL.Append("AND A.Inventario = ?Inventario" & vbCrLf)
            SetParam("Inventario", Inventario)
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    A.Anio DESC," & vbCrLf)
        SQL.Append("    A.Numero_docu DESC" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Requisicion Select_MaxNumber
    ''' </summary>
    ''' <returns></returns>
    Public Function Requisicion_Select_MaxNumber(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Anio As String = dtCondition.Rows(0).Item(Entity.Requisicion.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT" & vbCrLf)
        SQL.Append("    MAX(Numero_docu) AS Numero_docu" & vbCrLf)
        SQL.Append("FROM Requisicion" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND Anio like ?Anio" & vbCrLf)
            SetParam("Anio", "%" & Anio & "%")
        End If

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Requisicion Insert
    ''' </summary>
    ''' <returns></returns>
    Public Function Requisicion_insert(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("INSERT INTO Requisicion" & vbCrLf)
        SQL.Append("VALUES" & vbCrLf)
        SQL.Append("(" & vbCrLf)
        SQL.Append("    ?Numero_docu," & vbCrLf)
        SQL.Append("    ?Anio," & vbCrLf)
        SQL.Append("    ?Fecha," & vbCrLf)
        SQL.Append("    ?NombreBodega," & vbCrLf)
        SQL.Append("    ?Bodega," & vbCrLf)
        SQL.Append("    ?Codigo_Serv," & vbCrLf)
        SQL.Append("    ?Descripcion," & vbCrLf)
        SQL.Append("    ?Solicita," & vbCrLf)
        SQL.Append("    ?Revisa," & vbCrLf)
        SQL.Append("    ?Autoriza," & vbCrLf)
        SQL.Append("    ?Despacha," & vbCrLf)
        SQL.Append("    ?Recibe," & vbCrLf)
        SQL.Append("    ?Solicita_Carg," & vbCrLf)
        SQL.Append("    ?Revisa_Carg," & vbCrLf)
        SQL.Append("    ?Autoriza_Carg," & vbCrLf)
        SQL.Append("    ?Despacha_Carg," & vbCrLf)
        SQL.Append("    ?Recibe_Carg," & vbCrLf)
        SQL.Append("    ?Inventario," & vbCrLf)
        SQL.Append("    ?Actualizador," & vbCrLf)
        SQL.Append("    NOW()," & vbCrLf)
        SQL.Append("    ?Clasi_Actu" & vbCrLf)
        SQL.Append(")" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Numero_docu", .Item(Entity.Requisicion.Numero_docu))
            SetParam("Anio", .Item(Entity.Requisicion.Anio))
            SetParam("Fecha", .Item(Entity.Requisicion.Fecha))
            SetParam("NombreBodega", .Item(Entity.Requisicion.NombreBodega))
            SetParam("Bodega", .Item(Entity.Requisicion.Bodega))
            SetParam("Codigo_Serv", .Item(Entity.Requisicion.Codigo_Serv))
            SetParam("Descripcion", .Item(Entity.Requisicion.Descripcion))
            SetParam("Solicita", .Item(Entity.Requisicion.Solicita))
            SetParam("Revisa", .Item(Entity.Requisicion.Revisa))
            SetParam("Autoriza", .Item(Entity.Requisicion.Autoriza))
            SetParam("Despacha", .Item(Entity.Requisicion.Despacha))
            SetParam("Recibe", .Item(Entity.Requisicion.Recibe))
            SetParam("Solicita_Carg", .Item(Entity.Requisicion.Solicita_Carg))
            SetParam("Revisa_Carg", .Item(Entity.Requisicion.Revisa_Carg))
            SetParam("Autoriza_Carg", .Item(Entity.Requisicion.Autoriza_Carg))
            SetParam("Despacha_Carg", .Item(Entity.Requisicion.Despacha_Carg))
            SetParam("Recibe_Carg", .Item(Entity.Requisicion.Recibe_Carg))
            SetParam("Inventario", "0")
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "A")
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' Requisicion update for key
    ''' </summary>
    ''' <returns></returns>
    Public Function Requisicion_update(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("UPDATE Requisicion" & vbCrLf)
        SQL.Append("SET" & vbCrLf)
        SQL.Append("    Fecha = ?Fecha," & vbCrLf)
        SQL.Append("    NombreBodega = ?NombreBodega," & vbCrLf)
        SQL.Append("    Bodega = ?Bodega," & vbCrLf)
        SQL.Append("    Codigo_Serv = ?Codigo_Serv," & vbCrLf)
        SQL.Append("    Descripcion = ?Descripcion," & vbCrLf)
        SQL.Append("    Solicita = ?Solicita," & vbCrLf)
        SQL.Append("    Revisa = ?Revisa," & vbCrLf)
        SQL.Append("    Autoriza = ?Autoriza," & vbCrLf)
        SQL.Append("    Despacha = ?Despacha," & vbCrLf)
        SQL.Append("    Recibe = ?Recibe," & vbCrLf)
        SQL.Append("    Solicita_Carg = ?Solicita_Carg," & vbCrLf)
        SQL.Append("    Revisa_Carg = ?Revisa_Carg," & vbCrLf)
        SQL.Append("    Autoriza_Carg = ?Autoriza_Carg," & vbCrLf)
        SQL.Append("    Despacha_Carg = ?Despacha_Carg," & vbCrLf)
        SQL.Append("    Recibe_Carg = ?Recibe_Carg," & vbCrLf)
        SQL.Append("    Inventario = ?Inventario," & vbCrLf)
        SQL.Append("    Actualizador = ?Actualizador," & vbCrLf)
        SQL.Append("    Fecha_Actu  = NOW()," & vbCrLf)
        SQL.Append("    Clasi_Actu = ?Clasi_Actu" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Numero_docu = ?Numero_docu" & vbCrLf)
        SQL.Append("AND Anio = ?Anio" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Fecha", .Item(Entity.Requisicion.Fecha))
            SetParam("NombreBodega", .Item(Entity.Requisicion.NombreBodega))
            SetParam("Bodega", .Item(Entity.Requisicion.Bodega))
            SetParam("Codigo_Serv", .Item(Entity.Requisicion.Codigo_Serv))
            SetParam("Descripcion", .Item(Entity.Requisicion.Descripcion))
            SetParam("Solicita", .Item(Entity.Requisicion.Solicita))
            SetParam("Revisa", .Item(Entity.Requisicion.Revisa))
            SetParam("Autoriza", .Item(Entity.Requisicion.Autoriza))
            SetParam("Despacha", .Item(Entity.Requisicion.Despacha))
            SetParam("Recibe", .Item(Entity.Requisicion.Recibe))
            SetParam("Solicita_Carg", .Item(Entity.Requisicion.Solicita_Carg))
            SetParam("Revisa_Carg", .Item(Entity.Requisicion.Revisa_Carg))
            SetParam("Autoriza_Carg", .Item(Entity.Requisicion.Autoriza_Carg))
            SetParam("Despacha_Carg", .Item(Entity.Requisicion.Despacha_Carg))
            SetParam("Recibe_Carg", .Item(Entity.Requisicion.Recibe_Carg))
            SetParam("Inventario", "0")
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "U")
            SetParam("Numero_docu", .Item(Entity.Requisicion.Numero_docu))
            SetParam("Anio", .Item(Entity.Requisicion.Anio))
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' Requisicion update for key
    ''' </summary>
    ''' <returns></returns>
    Public Function Requisicion_update_inventario(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("UPDATE Requisicion" & vbCrLf)
        SQL.Append("SET" & vbCrLf)
        SQL.Append("    Inventario = ?Inventario," & vbCrLf)
        SQL.Append("    Actualizador = ?Actualizador," & vbCrLf)
        SQL.Append("    Fecha_Actu  = NOW()," & vbCrLf)
        SQL.Append("    Clasi_Actu = ?Clasi_Actu" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Numero_docu = ?Numero_docu" & vbCrLf)
        SQL.Append("AND Anio = ?Anio" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Inventario", .Item(Entity.Requisicion.Inventario))
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "U")
            SetParam("Numero_docu", .Item(Entity.Requisicion.Numero_docu))
            SetParam("Anio", .Item(Entity.Requisicion.Anio))
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' Requisicion delete for key
    ''' </summary>
    ''' <returns></returns>
    Public Function Requisicion_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.Requisicion.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.Requisicion.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("DELETE FROM Requisicion" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Numero_docu = ?Numero_docu" & vbCrLf)
        SQL.Append("AND Anio = ?Anio" & vbCrLf)

        'Set Condition and Parameters
        SetParam("Numero_docu", Numero_docu)
        SetParam("Anio", Anio)

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

#End Region

#Region "RequisicionDetalles"

    ''' <summary>
    ''' RequisicionDetalles select
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function RequisicionDetalles_select(ByRef dtRet As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM RequisicionDetalles" & vbCrLf)
        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Anio DESC," & vbCrLf)
        SQL.Append("    Numero_docu DESC," & vbCrLf)
        SQL.Append("    Numero_serie" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' RequisicionDetalles select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function RequisicionDetalles_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.RequisicionDetalles.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.RequisicionDetalles.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM RequisicionDetalles" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Numero_docu) Then
            SQL.Append("AND Numero_docu = ?Numero_docu" & vbCrLf)
            SetParam("Numero_docu", Numero_docu)
        End If
        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND Anio = ?Anio" & vbCrLf)
            SetParam("Anio", Anio)
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Anio DESC," & vbCrLf)
        SQL.Append("    Numero_docu DESC," & vbCrLf)
        SQL.Append("    Numero_serie" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' RequisicionDetalles Insert
    ''' </summary>
    ''' <returns></returns>
    Public Function RequisicionDetalles_insert(ByVal drData As DataRow) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("INSERT INTO RequisicionDetalles" & vbCrLf)
        SQL.Append("VALUES" & vbCrLf)
        SQL.Append("(" & vbCrLf)
        SQL.Append("    ?Numero_docu," & vbCrLf)
        SQL.Append("    ?Anio," & vbCrLf)
        SQL.Append("    ?Numero_serie," & vbCrLf)
        SQL.Append("    ?Codigo_Dato," & vbCrLf)
        SQL.Append("    ?Bodega," & vbCrLf)
        SQL.Append("    ?Codigo_Insu," & vbCrLf)
        SQL.Append("    ?Descripcion," & vbCrLf)
        SQL.Append("    ?Solicitada," & vbCrLf)
        SQL.Append("    ?Actualizador," & vbCrLf)
        SQL.Append("    NOW()," & vbCrLf)
        SQL.Append("    ?Clasi_Actu" & vbCrLf)
        SQL.Append(")" & vbCrLf)

        'Set Condition and Parameters
        With drData
            SetParam("Numero_docu", .Item(Entity.RequisicionDetalles.Numero_docu))
            SetParam("Anio", .Item(Entity.RequisicionDetalles.Anio))
            SetParam("Numero_serie", .Item(Entity.RequisicionDetalles.Numero_serie))
            SetParam("Codigo_Dato", .Item(Entity.RequisicionDetalles.Codigo_Dato))
            SetParam("Bodega", .Item(Entity.RequisicionDetalles.Bodega))
            SetParam("Codigo_Insu", .Item(Entity.RequisicionDetalles.Codigo_Insu))
            SetParam("Descripcion", .Item(Entity.RequisicionDetalles.Descripcion))
            SetParam("Solicitada", .Item(Entity.RequisicionDetalles.Solicitada))
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "A")
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' RequisicionDetalles delete for key
    ''' </summary>
    ''' <returns></returns>
    Public Function RequisicionDetalles_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.RequisicionDetalles.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.RequisicionDetalles.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("DELETE FROM RequisicionDetalles" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Numero_docu = ?Numero_docu" & vbCrLf)
        SQL.Append("AND Anio = ?Anio" & vbCrLf)

        'Set Condition and Parameters
        SetParam("Numero_docu", Numero_docu)
        SetParam("Anio", Anio)

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

#End Region

#Region "Pedido"

    ''' <summary>
    ''' Pedido select
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Pedido_select(ByRef dtRet As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM Pedido" & vbCrLf)
        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Anio DESC," & vbCrLf)
        SQL.Append("    Numero_docu DESC" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Pedido select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Pedido_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.Pedido.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.Pedido.Anio).ToString
        Dim Fecha As String = dtCondition.Rows(0).Item(Entity.Pedido.Fecha).ToString
        Dim Codigo_Serv As String = dtCondition.Rows(0).Item(Entity.Pedido.Codigo_Serv).ToString
        Dim Inventario As String = dtCondition.Rows(0).Item(Entity.Pedido.Inventario).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM Pedido" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Numero_docu) Then
            SQL.Append("AND Numero_docu like ?Numero_docu" & vbCrLf)
            SetParam("Numero_docu", "%" & Numero_docu & "%")
        End If
        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND Anio like ?Anio" & vbCrLf)
            SetParam("Anio", "%" & Anio & "%")
        End If
        If Not String.IsNullOrEmpty(Fecha) Then
            SQL.Append("AND DATE_FORMAT(Fecha, '%d/%m/%Y') like ?Fecha" & vbCrLf)
            SetParam("Fecha", "%" & Fecha & "%")
        End If
        If Not String.IsNullOrEmpty(Codigo_Serv) Then
            SQL.Append("AND Codigo_Serv like ?Codigo_Serv" & vbCrLf)
            SetParam("Codigo_Serv", "%" & Codigo_Serv & "%")
        End If
        If Not String.IsNullOrEmpty(Inventario) Then
            SQL.Append("AND Inventario = ?Inventario" & vbCrLf)
            SetParam("Inventario", Inventario)
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Anio DESC," & vbCrLf)
        SQL.Append("    Numero_docu DESC" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Pedido select for List
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Pedido_select_list(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.Pedido.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.Pedido.Anio).ToString
        Dim Fecha As String = dtCondition.Rows(0).Item(Entity.Pedido.Fecha).ToString
        Dim Codigo_Serv As String = dtCondition.Rows(0).Item(Entity.Pedido.Codigo_Serv).ToString
        Dim Inventario As String = dtCondition.Rows(0).Item(Entity.Pedido.Inventario).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT" & vbCrLf)
        SQL.Append("    'Det' AS Detalles," & vbCrLf)
        SQL.Append("    'Mod' AS Modificar," & vbCrLf)
        SQL.Append("    'Bor' AS Borrar," & vbCrLf)
        SQL.Append("    'Imp' AS Imprimir," & vbCrLf)
        SQL.Append("    A.Numero_docu," & vbCrLf)
        SQL.Append("    A.Anio," & vbCrLf)
        SQL.Append("    DATE_FORMAT(A.Fecha, '%d/%m/%Y') AS Fecha," & vbCrLf)
        SQL.Append("    B.Nombre_Serv," & vbCrLf)
        SQL.Append("    A.Inventario" & vbCrLf)
        SQL.Append("FROM Pedido AS A" & vbCrLf)
        SQL.Append("    LEFT JOIN servicio AS B" & vbCrLf)
        SQL.Append("       ON A.Codigo_Serv = B.Codigo_Serv" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Numero_docu) Then
            SQL.Append("AND A.Numero_docu like ?Numero_docu" & vbCrLf)
            SetParam("Numero_docu", "%" & Numero_docu & "%")
        End If
        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND A.Anio like ?Anio" & vbCrLf)
            SetParam("Anio", "%" & Anio & "%")
        End If
        If Not String.IsNullOrEmpty(Fecha) Then
            SQL.Append("AND DATE_FORMAT(A.Fecha, '%d/%m/%Y') like ?Fecha" & vbCrLf)
            SetParam("Fecha", "%" & Fecha & "%")
        End If
        If Not String.IsNullOrEmpty(Codigo_Serv) Then
            SQL.Append("AND A.Codigo_Serv like ?Codigo_Serv" & vbCrLf)
            SetParam("Codigo_Serv", "%" & Codigo_Serv & "%")
        End If
        If Not String.IsNullOrEmpty(Inventario) Then
            SQL.Append("AND A.Inventario = ?Inventario" & vbCrLf)
            SetParam("Inventario", Inventario)
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    A.Anio DESC," & vbCrLf)
        SQL.Append("    A.Numero_docu DESC" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Pedido Select_MaxNumber
    ''' </summary>
    ''' <returns></returns>
    Public Function Pedido_Select_MaxNumber(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Anio As String = dtCondition.Rows(0).Item(Entity.Pedido.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT" & vbCrLf)
        SQL.Append("    MAX(Numero_docu) AS Numero_docu" & vbCrLf)
        SQL.Append("FROM Pedido" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND Anio like ?Anio" & vbCrLf)
            SetParam("Anio", "%" & Anio & "%")
        End If

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Pedido Insert
    ''' </summary>
    ''' <returns></returns>
    Public Function Pedido_insert(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("INSERT INTO Pedido" & vbCrLf)
        SQL.Append("VALUES" & vbCrLf)
        SQL.Append("(" & vbCrLf)
        SQL.Append("    ?Numero_docu," & vbCrLf)
        SQL.Append("    ?Anio," & vbCrLf)
        SQL.Append("    ?Fecha," & vbCrLf)
        SQL.Append("    ?Codigo_Serv," & vbCrLf)
        SQL.Append("    ?Telefono," & vbCrLf)
        SQL.Append("    ?Descripcion," & vbCrLf)
        SQL.Append("    ?Solicita," & vbCrLf)
        SQL.Append("    ?Autoriza," & vbCrLf)
        SQL.Append("    ?Aprobacion," & vbCrLf)
        SQL.Append("    ?Solicita_Carg," & vbCrLf)
        SQL.Append("    ?Autoriza_Carg," & vbCrLf)
        SQL.Append("    ?Aprobacion_Carg," & vbCrLf)
        SQL.Append("    ?TipoCompras," & vbCrLf)
        SQL.Append("    ?Pago," & vbCrLf)
        SQL.Append("    ?Disponibilidad," & vbCrLf)
        SQL.Append("    ?Presupuesto," & vbCrLf)
        SQL.Append("    ?Compras," & vbCrLf)
        SQL.Append("    ?Otro," & vbCrLf)
        SQL.Append("    ?SubProducto," & vbCrLf)
        SQL.Append("    ?Prog, " & vbCrLf)
        SQL.Append("    ?Subp," & vbCrLf)
        SQL.Append("    ?Proy, " & vbCrLf)
        SQL.Append("    ?Act," & vbCrLf)
        SQL.Append("    ?Obra, " & vbCrLf)
        SQL.Append("    ?Ub_Geo," & vbCrLf)
        SQL.Append("    ?Fte_Fin, " & vbCrLf)
        SQL.Append("    ?Inventario, " & vbCrLf)
        SQL.Append("    ?Actualizador, " & vbCrLf)
        SQL.Append("    NOW()," & vbCrLf)
        SQL.Append("    ?Clasi_Actu" & vbCrLf)
        SQL.Append(")" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Numero_docu", .Item(Entity.Pedido.Numero_docu))
            SetParam("Anio", .Item(Entity.Pedido.Anio))
            SetParam("Fecha", .Item(Entity.Pedido.Fecha))
            SetParam("Codigo_Serv", .Item(Entity.Pedido.Codigo_Serv))
            SetParam("Telefono", .Item(Entity.Pedido.Telefono))
            SetParam("Descripcion", .Item(Entity.Pedido.Descripcion))
            SetParam("Solicita", .Item(Entity.Pedido.Solicita))
            SetParam("Autoriza", .Item(Entity.Pedido.Autoriza))
            SetParam("Aprobacion", .Item(Entity.Pedido.Aprobacion))
            SetParam("Solicita_Carg", .Item(Entity.Pedido.Solicita_Carg))
            SetParam("Autoriza_Carg", .Item(Entity.Pedido.Autoriza_Carg))
            SetParam("Aprobacion_Carg", .Item(Entity.Pedido.Aprobacion_Carg))
            SetParam("TipoCompras", .Item(Entity.Pedido.TipoCompras))
            SetParam("Pago", .Item(Entity.Pedido.Pago))
            SetParam("Disponibilidad", .Item(Entity.Pedido.Disponibilidad))
            SetParam("Presupuesto", .Item(Entity.Pedido.Presupuesto))
            SetParam("Compras", .Item(Entity.Pedido.Compras))
            SetParam("Otro", .Item(Entity.Pedido.Otro))
            SetParam("SubProducto", .Item(Entity.Pedido.SubProducto))
            SetParam("Prog", .Item(Entity.Pedido.Prog))
            SetParam("Subp", .Item(Entity.Pedido.Subp))
            SetParam("Proy", .Item(Entity.Pedido.Proy))
            SetParam("Act", .Item(Entity.Pedido.Act))
            SetParam("Obra", .Item(Entity.Pedido.Obra))
            SetParam("Ub_Geo", .Item(Entity.Pedido.Ub_Geo))
            SetParam("Fte_Fin", .Item(Entity.Pedido.Fte_Fin))
            SetParam("Inventario", "0")
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "A")
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' Pedido update for key
    ''' </summary>
    ''' <returns></returns>
    Public Function Pedido_update(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("UPDATE Pedido" & vbCrLf)
        SQL.Append("Set" & vbCrLf)
        SQL.Append("    Fecha = ?Fecha, " & vbCrLf)
        SQL.Append("    Codigo_Serv = ?Codigo_Serv, " & vbCrLf)
        SQL.Append("    Telefono = ?Telefono, " & vbCrLf)
        SQL.Append("    Descripcion = ?Descripcion, " & vbCrLf)
        SQL.Append("    Solicita = ?Solicita, " & vbCrLf)
        SQL.Append("    Autoriza = ?Autoriza, " & vbCrLf)
        SQL.Append("    Aprobacion = ?Aprobacion, " & vbCrLf)
        SQL.Append("    Solicita_Carg = ?Solicita_Carg, " & vbCrLf)
        SQL.Append("    Autoriza_Carg = ?Autoriza_Carg, " & vbCrLf)
        SQL.Append("    Aprobacion_Carg = ?Aprobacion_Carg, " & vbCrLf)
        SQL.Append("    TipoCompras = ?TipoCompras, " & vbCrLf)
        SQL.Append("    Pago = ?Pago, " & vbCrLf)
        SQL.Append("    Disponibilidad = ?Disponibilidad, " & vbCrLf)
        SQL.Append("    Presupuesto = ?Presupuesto, " & vbCrLf)
        SQL.Append("    Compras = ?Compras, " & vbCrLf)
        SQL.Append("    Otro = ?Otro, " & vbCrLf)
        SQL.Append("    SubProducto = ?SubProducto, " & vbCrLf)
        SQL.Append("    Prog = ?Prog, " & vbCrLf)
        SQL.Append("    Subp = ?Subp, " & vbCrLf)
        SQL.Append("    Proy = ?Proy, " & vbCrLf)
        SQL.Append("    Act = ?Act, " & vbCrLf)
        SQL.Append("    Obra = ?Obra, " & vbCrLf)
        SQL.Append("    Ub_Geo = ?Ub_Geo, " & vbCrLf)
        SQL.Append("    Fte_Fin = ?Fte_Fin, " & vbCrLf)
        SQL.Append("    Inventario = ?Inventario, " & vbCrLf)
        SQL.Append("    Actualizador = ?Actualizador, " & vbCrLf)
        SQL.Append("    Fecha_Actu  = NOW()," & vbCrLf)
        SQL.Append("    Clasi_Actu = ?Clasi_Actu" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Numero_docu = ?Numero_docu" & vbCrLf)
        SQL.Append("AND Anio = ?Anio" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Fecha", .Item(Entity.Pedido.Fecha))
            SetParam("Codigo_Serv", .Item(Entity.Pedido.Codigo_Serv))
            SetParam("Telefono", .Item(Entity.Pedido.Telefono))
            SetParam("Descripcion", .Item(Entity.Pedido.Descripcion))
            SetParam("Solicita", .Item(Entity.Pedido.Solicita))
            SetParam("Autoriza", .Item(Entity.Pedido.Autoriza))
            SetParam("Aprobacion", .Item(Entity.Pedido.Aprobacion))
            SetParam("Solicita_Carg", .Item(Entity.Pedido.Solicita_Carg))
            SetParam("Autoriza_Carg", .Item(Entity.Pedido.Autoriza_Carg))
            SetParam("Aprobacion_Carg", .Item(Entity.Pedido.Aprobacion_Carg))
            SetParam("TipoCompras", .Item(Entity.Pedido.TipoCompras))
            SetParam("Pago", .Item(Entity.Pedido.Pago))
            SetParam("Disponibilidad", .Item(Entity.Pedido.Disponibilidad))
            SetParam("Presupuesto", .Item(Entity.Pedido.Presupuesto))
            SetParam("Compras", .Item(Entity.Pedido.Compras))
            SetParam("Otro", .Item(Entity.Pedido.Otro))
            SetParam("SubProducto", .Item(Entity.Pedido.SubProducto))
            SetParam("Prog", .Item(Entity.Pedido.Prog))
            SetParam("Subp", .Item(Entity.Pedido.Subp))
            SetParam("Proy", .Item(Entity.Pedido.Proy))
            SetParam("Act", .Item(Entity.Pedido.Act))
            SetParam("Obra", .Item(Entity.Pedido.Obra))
            SetParam("Ub_Geo", .Item(Entity.Pedido.Ub_Geo))
            SetParam("Fte_Fin", .Item(Entity.Pedido.Fte_Fin))
            SetParam("Inventario", "0")
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "U")
            SetParam("Numero_docu", .Item(Entity.Pedido.Numero_docu))
            SetParam("Anio", .Item(Entity.Pedido.Anio))
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' Pedido update for key
    ''' </summary>
    ''' <returns></returns>
    Public Function Pedido_update_inventario(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("UPDATE Pedido" & vbCrLf)
        SQL.Append("SET" & vbCrLf)
        SQL.Append("    Inventario = ?Inventario," & vbCrLf)
        SQL.Append("    Actualizador = ?Actualizador," & vbCrLf)
        SQL.Append("    Fecha_Actu  = NOW()," & vbCrLf)
        SQL.Append("    Clasi_Actu = ?Clasi_Actu" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Numero_docu = ?Numero_docu" & vbCrLf)
        SQL.Append("AND Anio = ?Anio" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Inventario", .Item(Entity.Pedido.Inventario))
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "U")
            SetParam("Numero_docu", .Item(Entity.Pedido.Numero_docu))
            SetParam("Anio", .Item(Entity.Pedido.Anio))
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' Pedido delete for key
    ''' </summary>
    ''' <returns></returns>
    Public Function Pedido_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.Pedido.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.Pedido.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("DELETE FROM Pedido" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Numero_docu = ?Numero_docu" & vbCrLf)
        SQL.Append("AND Anio = ?Anio" & vbCrLf)

        'Set Condition and Parameters
        SetParam("Numero_docu", Numero_docu)
        SetParam("Anio", Anio)

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

#End Region

#Region "PedidoDetalles"

    ''' <summary>
    ''' PedidoDetalles select
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function PedidoDetalles_select(ByRef dtRet As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM PedidoDetalles" & vbCrLf)
        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Anio DESC," & vbCrLf)
        SQL.Append("    Numero_docu DESC," & vbCrLf)
        SQL.Append("    Numero_serie" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' PedidoDetalles select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function PedidoDetalles_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.PedidoDetalles.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.PedidoDetalles.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM PedidoDetalles" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Numero_docu) Then
            SQL.Append("AND Numero_docu = ?Numero_docu" & vbCrLf)
            SetParam("Numero_docu", Numero_docu)
        End If
        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND Anio = ?Anio" & vbCrLf)
            SetParam("Anio", Anio)
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Anio DESC," & vbCrLf)
        SQL.Append("    Numero_docu DESC," & vbCrLf)
        SQL.Append("    Numero_serie" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' PedidoDetalles Insert
    ''' </summary>
    ''' <returns></returns>
    Public Function PedidoDetalles_insert(ByVal drData As DataRow) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("INSERT INTO PedidoDetalles" & vbCrLf)
        SQL.Append("VALUES" & vbCrLf)
        SQL.Append("(" & vbCrLf)
        SQL.Append("    ?Numero_docu," & vbCrLf)
        SQL.Append("    ?Anio," & vbCrLf)
        SQL.Append("    ?Numero_serie," & vbCrLf)
        SQL.Append("    ?Codigo_Insu," & vbCrLf)
        SQL.Append("    ?Codigo_Presentacion," & vbCrLf)
        SQL.Append("    ?Insumos," & vbCrLf)
        SQL.Append("    ?Descripcion," & vbCrLf)
        SQL.Append("    ?Unidad," & vbCrLf)
        SQL.Append("    ?Solicitada," & vbCrLf)
        SQL.Append("    ?Autorizada," & vbCrLf)
        SQL.Append("    ?Estimado," & vbCrLf)
        SQL.Append("    ?Financiero," & vbCrLf)
        SQL.Append("    ?Paac," & vbCrLf)
        SQL.Append("    ?Abierto," & vbCrLf)
        SQL.Append("    ?Actualizador," & vbCrLf)
        SQL.Append("    NOW()," & vbCrLf)
        SQL.Append("    ?Clasi_Actu" & vbCrLf)
        SQL.Append(")" & vbCrLf)

        'Set Condition and Parameters
        With drData
            SetParam("Numero_docu", .Item(Entity.PedidoDetalles.Numero_docu))
            SetParam("Anio", .Item(Entity.PedidoDetalles.Anio))
            SetParam("Numero_serie", .Item(Entity.PedidoDetalles.Numero_serie))
            SetParam("Codigo_Insu", .Item(Entity.PedidoDetalles.Codigo_Insu))
            SetParam("Codigo_Presentacion", .Item(Entity.PedidoDetalles.Codigo_Presentacion))
            SetParam("Insumos", .Item(Entity.PedidoDetalles.Insumos))
            SetParam("Descripcion", .Item(Entity.PedidoDetalles.Descripcion))
            SetParam("Unidad", .Item(Entity.PedidoDetalles.Unidad))
            SetParam("Solicitada", .Item(Entity.PedidoDetalles.Solicitada))
            SetParam("Autorizada", .Item(Entity.PedidoDetalles.Autorizada))
            SetParam("Estimado", .Item(Entity.PedidoDetalles.Estimado))
            SetParam("Financiero", .Item(Entity.PedidoDetalles.Financiero))
            SetParam("Paac", .Item(Entity.PedidoDetalles.Paac))
            SetParam("Abierto", .Item(Entity.PedidoDetalles.Abierto))
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "A")
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' PedidoDetalles delete for key
    ''' </summary>
    ''' <returns></returns>
    Public Function PedidoDetalles_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.PedidoDetalles.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.PedidoDetalles.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("DELETE FROM PedidoDetalles" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Numero_docu = ?Numero_docu" & vbCrLf)
        SQL.Append("AND Anio = ?Anio" & vbCrLf)

        'Set Condition and Parameters
        SetParam("Numero_docu", Numero_docu)
        SetParam("Anio", Anio)

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

#End Region

#Region "RequisicionReport"

    ''' <summary>
    ''' Requisicion select for Report
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Requisicion_Report(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.Requisicion.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.Requisicion.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT" & vbCrLf)
        SQL.Append("    A.*," & vbCrLf)
        SQL.Append("    B.Nombre_Serv" & vbCrLf)
        SQL.Append("FROM Requisicion AS A" & vbCrLf)
        SQL.Append("    LEFT JOIN servicio AS B" & vbCrLf)
        SQL.Append("       ON A.Codigo_Serv = B.Codigo_Serv" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Numero_docu) Then
            SQL.Append("AND A.Numero_docu like ?Numero_docu" & vbCrLf)
            SetParam("Numero_docu", "%" & Numero_docu & "%")
        End If
        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND A.Anio like ?Anio" & vbCrLf)
            SetParam("Anio", "%" & Anio & "%")
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    A.Anio DESC," & vbCrLf)
        SQL.Append("    A.Numero_docu DESC" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function


    ''' <summary>
    ''' RequisicionDetalles select for Report
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function RequisicionDetalles_Report(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.RequisicionDetalles.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.RequisicionDetalles.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT " & vbCrLf)
        SQL.Append("    A.*," & vbCrLf)
        SQL.Append("    B.Nombre_Insu," & vbCrLf)
        SQL.Append("    C.Nombre_Unid" & vbCrLf)
        SQL.Append("FROM RequisicionDetalles AS A" & vbCrLf)
        SQL.Append("LEFT JOIN Insumos AS B" & vbCrLf)
        SQL.Append("  ON  A.Bodega = B.Bodega" & vbCrLf)
        SQL.Append("  AND A.Codigo_Dato = B.Codigo_Dato" & vbCrLf)
        SQL.Append("LEFT JOIN Unidad AS C" & vbCrLf)
        SQL.Append("  ON  B.Unidad = C.Codigo_Unid" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Numero_docu) Then
            SQL.Append("AND A.Numero_docu = ?Numero_docu" & vbCrLf)
            SetParam("Numero_docu", Numero_docu)
        End If
        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND A.Anio = ?Anio" & vbCrLf)
            SetParam("Anio", Anio)
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    A.Anio DESC," & vbCrLf)
        SQL.Append("    A.Numero_docu DESC," & vbCrLf)
        SQL.Append("    A.Numero_serie" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

#End Region

#Region "PedidoReport"

    ''' <summary>
    ''' Pedido select for Report
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Pedido_Report(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.Pedido.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.Pedido.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT" & vbCrLf)
        SQL.Append("    A.*," & vbCrLf)
        SQL.Append("    B.Nombre_Serv" & vbCrLf)
        SQL.Append("FROM Pedido AS A" & vbCrLf)
        SQL.Append("    LEFT JOIN servicio AS B" & vbCrLf)
        SQL.Append("       ON A.Codigo_Serv = B.Codigo_Serv" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Numero_docu) Then
            SQL.Append("AND A.Numero_docu like ?Numero_docu" & vbCrLf)
            SetParam("Numero_docu", "%" & Numero_docu & "%")
        End If
        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND A.Anio like ?Anio" & vbCrLf)
            SetParam("Anio", "%" & Anio & "%")
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    A.Anio DESC," & vbCrLf)
        SQL.Append("    A.Numero_docu DESC" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function


    ''' <summary>
    ''' PedidoDetalles select for Report
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function PedidoDetalles_Report(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Numero_docu As String = dtCondition.Rows(0).Item(Entity.PedidoDetalles.Numero_docu).ToString
        Dim Anio As String = dtCondition.Rows(0).Item(Entity.PedidoDetalles.Anio).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM PedidoDetalles" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Numero_docu) Then
            SQL.Append("AND Numero_docu = ?Numero_docu" & vbCrLf)
            SetParam("Numero_docu", Numero_docu)
        End If
        If Not String.IsNullOrEmpty(Anio) Then
            SQL.Append("AND Anio = ?Anio" & vbCrLf)
            SetParam("Anio", Anio)
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Anio DESC," & vbCrLf)
        SQL.Append("    Numero_docu DESC," & vbCrLf)
        SQL.Append("    Numero_serie" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

#End Region

#Region "Insumos"

    ''' <summary>
    ''' Insumos select
    ''' </summary>
    ''' <param name="Bodega"></param>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function insumos_select(ByVal Bodega As String, ByRef dtRet As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM Insumos" & vbCrLf)
        SQL.Append("WHERE Bodega = ?Bodega" & vbCrLf)
        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Codigo_Insu" & vbCrLf)

        SetParam("Bodega", Bodega)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Insumos select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function insumos_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Codigo_Dato As String = dtCondition.Rows(0).Item(Entity.Insumos.Codigo_Dato).ToString
        Dim Bodega As String = dtCondition.Rows(0).Item(Entity.Insumos.Bodega).ToString
        Dim Codigo_Insu As String = dtCondition.Rows(0).Item(Entity.Insumos.Codigo_Insu).ToString
        Dim Nombre_Insu As String = dtCondition.Rows(0).Item(Entity.Insumos.Nombre_Insu).ToString
        Dim Unidad As String = dtCondition.Rows(0).Item(Entity.Insumos.Unidad).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM Insumos" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Codigo_Dato) Then
            SQL.Append("AND Codigo_Dato like ?Codigo_Dato" & vbCrLf)
            SetParam("Codigo_Dato", "%" & Codigo_Dato & "%")
        End If
        If Not String.IsNullOrEmpty(Bodega) Then
            SQL.Append("AND Bodega = ?Bodega" & vbCrLf)
            SetParam("Bodega", Bodega)
        End If
        If Not String.IsNullOrEmpty(Codigo_Insu) Then
            SQL.Append("AND Codigo_Insu like ?Codigo_Insu" & vbCrLf)
            SetParam("Codigo_Insu", "%" & Codigo_Insu & "%")
        End If
        If Not String.IsNullOrEmpty(Nombre_Insu) Then
            SQL.Append("AND Nombre_Insu like ?Nombre_Insu" & vbCrLf)
            SetParam("Nombre_Insu", "%" & Nombre_Insu & "%")
        End If
        If Not String.IsNullOrEmpty(Unidad) Then
            SQL.Append("AND Unidad = ?Unidad" & vbCrLf)
            SetParam("Unidad", Unidad)
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Codigo_Insu" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Insumos select for List
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function insumos_select_list(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Codigo_Dato As String = dtCondition.Rows(0).Item(Entity.Insumos.Codigo_Dato).ToString
        Dim Bodega As String = dtCondition.Rows(0).Item(Entity.Insumos.Bodega).ToString
        Dim Codigo_Insu As String = dtCondition.Rows(0).Item(Entity.Insumos.Codigo_Insu).ToString
        Dim Nombre_Insu As String = dtCondition.Rows(0).Item(Entity.Insumos.Nombre_Insu).ToString
        Dim Unidad As String = dtCondition.Rows(0).Item(Entity.Insumos.Unidad).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT" & vbCrLf)
        SQL.Append("    'Mod' AS Modificar," & vbCrLf)
        SQL.Append("    'Bor' AS Borrar," & vbCrLf)
        SQL.Append("    A.Codigo_Dato," & vbCrLf)
        SQL.Append("    A.Bodega," & vbCrLf)
        SQL.Append("    A.Codigo_Insu," & vbCrLf)
        SQL.Append("    A.Nombre_Insu," & vbCrLf)
        SQL.Append("    A.Unidad," & vbCrLf)
        SQL.Append("    B.Nombre_Unid" & vbCrLf)
        SQL.Append("FROM Insumos AS A" & vbCrLf)
        SQL.Append("LEFT JOIN Unidad AS B" & vbCrLf)
        SQL.Append("  ON A.Unidad = B.Codigo_Unid" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Codigo_Dato) Then
            SQL.Append("AND A.Codigo_Dato like ?Codigo_Dato" & vbCrLf)
            SetParam("Codigo_Dato", "%" & Codigo_Dato & "%")
        End If
        If Not String.IsNullOrEmpty(Bodega) Then
            SQL.Append("AND A.Bodega = ?Bodega" & vbCrLf)
            SetParam("Bodega", Bodega)
        End If
        If Not String.IsNullOrEmpty(Codigo_Insu) Then
            SQL.Append("AND A.Codigo_Insu like ?Codigo_Insu" & vbCrLf)
            SetParam("Codigo_Insu", "%" & Codigo_Insu & "%")
        End If
        If Not String.IsNullOrEmpty(Nombre_Insu) Then
            SQL.Append("AND A.Nombre_Insu like ?Nombre_Insu" & vbCrLf)
            SetParam("Nombre_Insu", "%" & Nombre_Insu & "%")
        End If
        If Not String.IsNullOrEmpty(Unidad) Then
            SQL.Append("AND A.Unidad = ?Unidad" & vbCrLf)
            SetParam("Unidad", Unidad)
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    A.Codigo_Insu" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Insumos Select_MaxNumber
    ''' </summary>
    ''' <returns></returns>
    Public Function Insumos_Select_MaxNumber(ByVal Bodega As String, ByRef dtRet As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT" & vbCrLf)
        SQL.Append("    MAX(Codigo_Dato) AS Codigo_Dato" & vbCrLf)
        SQL.Append("FROM Insumos" & vbCrLf)
        SQL.Append("WHERE Bodega = ?Bodega" & vbCrLf)

        SetParam("Bodega", Bodega)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Insumos Insert
    ''' </summary>
    ''' <returns></returns>
    Public Function insumos_insert(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("INSERT INTO Insumos" & vbCrLf)
        SQL.Append("VALUES" & vbCrLf)
        SQL.Append("(" & vbCrLf)
        SQL.Append("    ?Codigo_Dato," & vbCrLf)
        SQL.Append("    ?Bodega," & vbCrLf)
        SQL.Append("    ?Codigo_Insu," & vbCrLf)
        SQL.Append("    ?Nombre_Insu," & vbCrLf)
        SQL.Append("    ?Unidad," & vbCrLf)
        SQL.Append("    ?Actualizador," & vbCrLf)
        SQL.Append("    NOW()," & vbCrLf)
        SQL.Append("    ?Clasi_Actu" & vbCrLf)
        SQL.Append(")" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Codigo_Dato", .Item(Entity.Insumos.Codigo_Dato))
            SetParam("Bodega", .Item(Entity.Insumos.Bodega))
            SetParam("Codigo_Insu", .Item(Entity.Insumos.Codigo_Insu))
            SetParam("Nombre_Insu", .Item(Entity.Insumos.Nombre_Insu))
            SetParam("Unidad", .Item(Entity.Insumos.Unidad))
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "A")
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' Insumos update for key
    ''' </summary>
    ''' <returns></returns>
    Public Function insumos_update(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("UPDATE Insumos" & vbCrLf)
        SQL.Append("SET" & vbCrLf)
        SQL.Append("    Codigo_Insu = ?Codigo_Insu," & vbCrLf)
        SQL.Append("    Nombre_Insu = ?Nombre_Insu," & vbCrLf)
        SQL.Append("    Unidad = ?Unidad," & vbCrLf)
        SQL.Append("    Actualizador = ?Actualizador," & vbCrLf)
        SQL.Append("    Fecha_Actu  = NOW()," & vbCrLf)
        SQL.Append("    Clasi_Actu = ?Clasi_Actu" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Codigo_Dato = ?Codigo_Dato" & vbCrLf)
        SQL.Append("AND Bodega = ?Bodega" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Codigo_Insu", .Item(Entity.Insumos.Codigo_Insu))
            SetParam("Nombre_Insu", .Item(Entity.Insumos.Nombre_Insu))
            SetParam("Unidad", .Item(Entity.Insumos.Unidad))
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "U")
            SetParam("Codigo_Dato", .Item(Entity.Insumos.Codigo_Dato))
            SetParam("Bodega", .Item(Entity.Insumos.Bodega))
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' Insumos delete for key
    ''' </summary>
    ''' <returns></returns>
    Public Function insumos_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Codigo_Dato As String = dtCondition.Rows(0).Item(Entity.Insumos.Codigo_Dato).ToString
        Dim Bodega As String = dtCondition.Rows(0).Item(Entity.Insumos.Bodega).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("DELETE FROM Insumos" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Codigo_Dato = ?Codigo_Dato" & vbCrLf)
        SQL.Append("AND Bodega = ?Bodega" & vbCrLf)

        'Set Condition and Parameters
        SetParam("Codigo_Dato", Codigo_Dato)
        SetParam("Bodega", Bodega)

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

#End Region

#Region "servicio"

    ''' <summary>
    ''' servicio select
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function servicio_select(ByRef dtRet As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM servicio" & vbCrLf)
        SQL.Append("WHERE Codigo_Serv < '90'" & vbCrLf) 'Except 98,99
        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Codigo_Serv" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' servicio select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Servicio_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Codigo_Serv As String = dtCondition.Rows(0).Item(Entity.Servicio.Codigo_Serv).ToString
        Dim Nombre_Serv As String = dtCondition.Rows(0).Item(Entity.Servicio.Nombre_Serv).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM Servicio" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Codigo_Serv) Then
            SQL.Append("AND Codigo_Serv like ?Codigo_Serv" & vbCrLf)
            SetParam("Codigo_Serv", "%" & Codigo_Serv & "%")
        End If
        If Not String.IsNullOrEmpty(Nombre_Serv) Then
            SQL.Append("AND Nombre_Serv like ?Nombre_Serv" & vbCrLf)
            SetParam("Nombre_Serv", "%" & Nombre_Serv & "%")
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Codigo_Serv" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' servicio select for List
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Servicio_select_list(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Codigo_Serv As String = dtCondition.Rows(0).Item(Entity.Servicio.Codigo_Serv).ToString
        Dim Nombre_Serv As String = dtCondition.Rows(0).Item(Entity.Servicio.Nombre_Serv).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT" & vbCrLf)
        SQL.Append("    'Mod' AS Modificar," & vbCrLf)
        SQL.Append("    'Bor' AS Borrar," & vbCrLf)
        SQL.Append("    Codigo_Serv," & vbCrLf)
        SQL.Append("    Nombre_Serv," & vbCrLf)
        SQL.Append("    Telefono" & vbCrLf)
        SQL.Append("FROM Servicio" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Codigo_Serv) Then
            SQL.Append("AND Codigo_Serv like ?Codigo_Serv" & vbCrLf)
            SetParam("Codigo_Serv", "%" & Codigo_Serv & "%")
        End If
        If Not String.IsNullOrEmpty(Nombre_Serv) Then
            SQL.Append("AND Nombre_Serv like ?Nombre_Serv" & vbCrLf)
            SetParam("Nombre_Serv", "%" & Nombre_Serv & "%")
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Codigo_Serv" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' servicio Insert
    ''' </summary>
    ''' <returns></returns>
    Public Function Servicio_insert(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("INSERT INTO Servicio" & vbCrLf)
        SQL.Append("VALUES" & vbCrLf)
        SQL.Append("(" & vbCrLf)
        SQL.Append("    ?Codigo_Serv," & vbCrLf)
        SQL.Append("    ?Nombre_Serv," & vbCrLf)
        SQL.Append("    ?Telefono," & vbCrLf)
        SQL.Append("    ?Actualizador," & vbCrLf)
        SQL.Append("    NOW()," & vbCrLf)
        SQL.Append("    ?Clasi_Actu" & vbCrLf)
        SQL.Append(")" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Codigo_Serv", .Item(Entity.Servicio.Codigo_Serv))
            SetParam("Nombre_Serv", .Item(Entity.Servicio.Nombre_Serv))
            SetParam("Telefono", .Item(Entity.Servicio.Telefono))
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "A")
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' servicio update for key
    ''' </summary>
    ''' <returns></returns>
    Public Function Servicio_update(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("UPDATE Servicio" & vbCrLf)
        SQL.Append("SET" & vbCrLf)
        SQL.Append("    Nombre_Serv = ?Nombre_Serv," & vbCrLf)
        SQL.Append("    Telefono = ?Telefono," & vbCrLf)
        SQL.Append("    Actualizador = ?Actualizador," & vbCrLf)
        SQL.Append("    Fecha_Actu  = NOW()," & vbCrLf)
        SQL.Append("    Clasi_Actu = ?Clasi_Actu" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Codigo_Serv = ?Codigo_Serv" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Nombre_Serv", .Item(Entity.Servicio.Nombre_Serv))
            SetParam("Telefono", .Item(Entity.Servicio.Telefono))
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "U")
            SetParam("Codigo_Serv", .Item(Entity.Servicio.Codigo_Serv))
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' servicio delete for key
    ''' </summary>
    ''' <returns></returns>
    Public Function Servicio_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Codigo_Serv As String = dtCondition.Rows(0).Item(Entity.Servicio.Codigo_Serv).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("DELETE FROM Servicio" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Codigo_Serv = ?Codigo_Serv" & vbCrLf)

        'Set Condition and Parameters
        SetParam("Codigo_Serv", Codigo_Serv)

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

#End Region

#Region "Unidad"

    ''' <summary>
    ''' Unidad select
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Unidad_select(ByRef dtRet As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM Unidad" & vbCrLf)
        SQL.Append("WHERE Codigo_Unid < '90'" & vbCrLf) 'Except 98,99
        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Codigo_Unid" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' comun.Unidad select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Unidad_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Codigo_Unid As String = dtCondition.Rows(0).Item(Entity.Unidad.Codigo_Unid).ToString
        Dim Nombre_Unid As String = dtCondition.Rows(0).Item(Entity.Unidad.Nombre_Unid).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM Unidad" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Codigo_Unid) Then
            SQL.Append("AND Codigo_Unid like ?Codigo_Unid" & vbCrLf)
            SetParam("Codigo_Unid", "%" & Codigo_Unid & "%")
        End If
        If Not String.IsNullOrEmpty(Nombre_Unid) Then
            SQL.Append("AND Nombre_Unid like ?Nombre_Unid" & vbCrLf)
            SetParam("Nombre_Unid", "%" & Nombre_Unid & "%")
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Codigo_Unid" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' comun.Unidad select for List
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Unidad_select_list(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Codigo_Unid As String = dtCondition.Rows(0).Item(Entity.Unidad.Codigo_Unid).ToString
        Dim Nombre_Unid As String = dtCondition.Rows(0).Item(Entity.Unidad.Nombre_Unid).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT" & vbCrLf)
        SQL.Append("    'Mod' AS Modificar," & vbCrLf)
        SQL.Append("    'Bor' AS Borrar," & vbCrLf)
        SQL.Append("    Codigo_Unid," & vbCrLf)
        SQL.Append("    Nombre_Unid" & vbCrLf)
        SQL.Append("FROM Unidad" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)

        'Set Condition and Parameters
        If Not String.IsNullOrEmpty(Codigo_Unid) Then
            SQL.Append("AND Codigo_Unid like ?Codigo_Unid" & vbCrLf)
            SetParam("Codigo_Unid", "%" & Codigo_Unid & "%")
        End If
        If Not String.IsNullOrEmpty(Nombre_Unid) Then
            SQL.Append("AND Nombre_Unid like ?Nombre_Unid" & vbCrLf)
            SetParam("Nombre_Unid", "%" & Nombre_Unid & "%")
        End If

        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Codigo_Unid" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' comun.Unidad Insert
    ''' </summary>
    ''' <returns></returns>
    Public Function Unidad_insert(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("INSERT INTO Unidad" & vbCrLf)
        SQL.Append("VALUES" & vbCrLf)
        SQL.Append("(" & vbCrLf)
        SQL.Append("    ?Codigo_Unid," & vbCrLf)
        SQL.Append("    ?Nombre_Unid," & vbCrLf)
        SQL.Append("    ?Actualizador," & vbCrLf)
        SQL.Append("    NOW()," & vbCrLf)
        SQL.Append("    ?Clasi_Actu" & vbCrLf)
        SQL.Append(")" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Codigo_Unid", .Item(Entity.Unidad.Codigo_Unid))
            SetParam("Nombre_Unid", .Item(Entity.Unidad.Nombre_Unid))
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "A")
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' comun.Unidad update for key
    ''' </summary>
    ''' <returns></returns>
    Public Function Unidad_update(ByVal dtData As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("UPDATE Unidad" & vbCrLf)
        SQL.Append("SET" & vbCrLf)
        SQL.Append("    Nombre_Unid = ?Nombre_Unid," & vbCrLf)
        SQL.Append("    Actualizador = ?Actualizador," & vbCrLf)
        SQL.Append("    Fecha_Actu  = NOW()," & vbCrLf)
        SQL.Append("    Clasi_Actu = ?Clasi_Actu" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Codigo_Unid = ?Codigo_Unid" & vbCrLf)

        'Set Condition and Parameters
        With dtData.Rows(0)
            SetParam("Nombre_Unid", .Item(Entity.Unidad.Nombre_Unid))
            SetParam("Actualizador", "admin")
            SetParam("Clasi_Actu", "U")
            SetParam("Codigo_Unid", .Item(Entity.Unidad.Codigo_Unid))
        End With

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' comun.Unidad delete for key
    ''' </summary>
    ''' <returns></returns>
    Public Function Unidad_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        Dim Codigo_Unid As String = dtCondition.Rows(0).Item(Entity.Unidad.Codigo_Unid).ToString

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("DELETE FROM Unidad" & vbCrLf)
        SQL.Append("WHERE 1 = 1" & vbCrLf)
        SQL.Append("AND Codigo_Unid = ?Codigo_Unid" & vbCrLf)

        'Set Condition and Parameters
        SetParam("Codigo_Unid", Codigo_Unid)

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

#End Region

#Region "Orden Insumos"

    ''' <summary>
    ''' Insumos select For Orden
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function insumos_select_ForOrden(ByRef dtRet As DataTable) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("SELECT *" & vbCrLf)
        SQL.Append("FROM Insumos" & vbCrLf)
        SQL.Append("ORDER BY" & vbCrLf)
        SQL.Append("    Bodega," & vbCrLf)
        SQL.Append("    Nombre_Insu" & vbCrLf)

        'Execute
        Return ExecuteQuery(SQL.ToString, dtRet)

    End Function

    ''' <summary>
    ''' Insumos update for Orden
    ''' </summary>
    ''' <returns></returns>
    Public Function insumos_update_ForOrden(ByVal wkCodigo_Dato As String,
                                            ByVal wkBodega As String,
                                            ByVal wkCodigo_Insu As String) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("UPDATE Insumos" & vbCrLf)
        SQL.Append("SET" & vbCrLf)
        SQL.Append("    Codigo_Insu = ?Codigo_Insu," & vbCrLf)
        SQL.Append("    Actualizador = ?Actualizador," & vbCrLf)
        SQL.Append("    Fecha_Actu  = NOW()," & vbCrLf)
        SQL.Append("    Clasi_Actu = ?Clasi_Actu" & vbCrLf)
        SQL.Append("WHERE Codigo_Dato = ?Codigo_Dato" & vbCrLf)
        SQL.Append("AND   Bodega = ?Bodega" & vbCrLf)

        'Set Condition and Parameters
        SetParam("Codigo_Insu", wkCodigo_Insu)
        SetParam("Actualizador", "admin")
        SetParam("Clasi_Actu", "U")
        SetParam("Codigo_Dato", wkCodigo_Dato)
        SetParam("Bodega", wkBodega)

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

    ''' <summary>
    ''' RequisicionDetalles update for Orden
    ''' </summary>
    ''' <returns></returns>
    Public Function RequisicionDetalles_update_ForOrden(ByVal wkCodigo_Dato As String,
                                                        ByVal wkBodega As String,
                                                        ByVal wkCodigo_Insu As String) As HospitalConst.DB_RET

        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim SQL As New StringBuilder

        'Clear Parameters
        ClearParam()

        'Set SQL
        SQL.Append("UPDATE RequisicionDetalles" & vbCrLf)
        SQL.Append("SET" & vbCrLf)
        SQL.Append("    Codigo_Insu = ?Codigo_Insu," & vbCrLf)
        SQL.Append("    Actualizador = ?Actualizador," & vbCrLf)
        SQL.Append("    Fecha_Actu  = NOW()," & vbCrLf)
        SQL.Append("    Clasi_Actu = ?Clasi_Actu" & vbCrLf)
        SQL.Append("WHERE Codigo_Dato = ?Codigo_Dato" & vbCrLf)
        SQL.Append("AND   Bodega = ?Bodega" & vbCrLf)

        'Set Condition and Parameters
        SetParam("Codigo_Insu", wkCodigo_Insu)
        SetParam("Actualizador", "admin")
        SetParam("Clasi_Actu", "U")
        SetParam("Codigo_Dato", wkCodigo_Dato)
        SetParam("Bodega", wkBodega)

        'Execute
        Return ExecuteNonQuery(SQL.ToString)

    End Function

#End Region

End Class
