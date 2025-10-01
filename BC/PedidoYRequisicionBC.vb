Public Class PedidoYRequisicionBC

#Region "Requisicion"

    ''' <summary>
    ''' Requisicion select
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Requisicion_select(ByRef dtRet As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Requisicion_select(dtRet)
            dtRet.TableName = Entity.TableNmae.Requisicion
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Requisicion select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Requisicion_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Requisicion_select_key(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Requisicion
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Requisicion select for List
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Requisicion_select_list(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Requisicion_select_list(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Requisicion
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Requisicion insert
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function Requisicion_insert(ByVal dtData As DataTable,
                                       ByVal dtDetail As DataTable,
                                       ByRef CodigoExpe As String,
                                       ByRef AnioExpe As String) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim Num As Long = 0
        CodigoExpe = ""
        AnioExpe = ""

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            Dim dtRet As New DataTable
            'Get Max Number
            Ret = da.Requisicion_Select_MaxNumber(dtRet, dtData)
            If Ret <> HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'Set Number
            If dtRet.Rows.Count = 0 Then
                Num = 1
            Else
                If IsNumeric(dtRet.Rows(0).Item(Entity.Requisicion.Numero_docu)) Then
                    Num = CLng(dtRet.Rows(0).Item(Entity.Requisicion.Numero_docu)) + 1
                Else
                    Num = 1
                End If
            End If
            dtData.Rows(0).Item(Entity.Requisicion.Numero_docu) = Num.ToString("00000")

            CodigoExpe = dtData.Rows(0).Item(Entity.Requisicion.Numero_docu).ToString
            AnioExpe = dtData.Rows(0).Item(Entity.Requisicion.Anio).ToString

            'insert Requisicion
            Ret = da.Requisicion_insert(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            For Each dr As DataRow In dtDetail.Rows

                dr.Item(Entity.RequisicionDetalles.Numero_docu) = Num.ToString("00000")

                'insert RequisicionDetalles
                Ret = da.RequisicionDetalles_insert(dr)
                If Ret < HospitalConst.DB_RET.NML Then
                    'DB RollBack
                    da.RollBack()
                    Return Ret
                End If

            Next

            'DB Commit
            da.Commit()

        End Using

        Return Ret

    End Function

    ''' <summary>
    ''' Requisicion update
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function Requisicion_update(ByVal dtData As DataTable, ByVal dtDetail As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'update Requisicion
            Ret = da.Requisicion_update(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'Delete RequisicionDetalles
            Ret = da.RequisicionDetalles_delete(dtDetail)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            For Each dr As DataRow In dtDetail.Rows

                'insert RequisicionDetalles
                Ret = da.RequisicionDetalles_insert(dr)
                If Ret < HospitalConst.DB_RET.NML Then
                    'DB RollBack
                    da.RollBack()
                    Return Ret
                End If

            Next

            'DB Commit
            da.Commit()

        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Requisicion update
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function Requisicion_update_inventario(ByVal dtData As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'update Requisicion
            Ret = da.Requisicion_update_inventario(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Requisicion delete
    ''' </summary>
    ''' <param name="dtCondition"></param>
    ''' <returns></returns>
    Public Function Requisicion_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'Delete Requisicion
            Ret = da.Requisicion_delete(dtCondition)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'Delete RequisicionDetalles
            Ret = da.RequisicionDetalles_delete(dtCondition)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret
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

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.RequisicionDetalles_select(dtRet)
            dtRet.TableName = Entity.TableNmae.RequisicionDetalles
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' RequisicionDetalles select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function RequisicionDetalles_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.RequisicionDetalles_select_key(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.RequisicionDetalles
        End Using

        Return Ret
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

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Pedido_select(dtRet)
            dtRet.TableName = Entity.TableNmae.Pedido
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Pedido select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Pedido_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Pedido_select_key(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Pedido
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Pedido select for List
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Pedido_select_list(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Pedido_select_list(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Pedido
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Pedido insert
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function Pedido_insert(ByVal dtData As DataTable,
                                       ByVal dtDetail As DataTable,
                                       ByRef CodigoExpe As String,
                                       ByRef AnioExpe As String) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim Num As Long = 0
        CodigoExpe = ""
        AnioExpe = ""

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            Dim dtRet As New DataTable
            'Get Max Number
            Ret = da.Pedido_Select_MaxNumber(dtRet, dtData)
            If Ret <> HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'Set Number
            If dtRet.Rows.Count = 0 Then
                Num = 1
            Else
                If IsNumeric(dtRet.Rows(0).Item(Entity.Pedido.Numero_docu)) Then
                    Num = CLng(dtRet.Rows(0).Item(Entity.Pedido.Numero_docu)) + 1
                Else
                    Num = 1
                End If
            End If
            dtData.Rows(0).Item(Entity.Pedido.Numero_docu) = Num.ToString("00000")

            CodigoExpe = dtData.Rows(0).Item(Entity.Pedido.Numero_docu).ToString
            AnioExpe = dtData.Rows(0).Item(Entity.Pedido.Anio).ToString

            'insert Pedido
            Ret = da.Pedido_insert(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            For Each dr As DataRow In dtDetail.Rows

                dr.Item(Entity.Pedido.Numero_docu) = Num.ToString("00000")

                'insert PedidoDetalles
                Ret = da.PedidoDetalles_insert(dr)
                If Ret < HospitalConst.DB_RET.NML Then
                    'DB RollBack
                    da.RollBack()
                    Return Ret
                End If

            Next

            'DB Commit
            da.Commit()

        End Using

        Return Ret

    End Function

    ''' <summary>
    ''' Pedido update
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function Pedido_update(ByVal dtData As DataTable, ByVal dtDetail As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'update Pedido
            Ret = da.Pedido_update(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'Delete PedidoDetalles
            Ret = da.PedidoDetalles_delete(dtDetail)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            For Each dr As DataRow In dtDetail.Rows

                'insert PedidoDetalles
                Ret = da.PedidoDetalles_insert(dr)
                If Ret < HospitalConst.DB_RET.NML Then
                    'DB RollBack
                    da.RollBack()
                    Return Ret
                End If

            Next

            'DB Commit
            da.Commit()

        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Pedido update
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function Pedido_update_inventario(ByVal dtData As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'update Pedido
            Ret = da.Pedido_update_inventario(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Pedido delete
    ''' </summary>
    ''' <param name="dtCondition"></param>
    ''' <returns></returns>
    Public Function Pedido_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'Delete Pedido
            Ret = da.Pedido_delete(dtCondition)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'Delete PedidoDetalles
            Ret = da.PedidoDetalles_delete(dtCondition)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret
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

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.PedidoDetalles_select(dtRet)
            dtRet.TableName = Entity.TableNmae.PedidoDetalles
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' PedidoDetalles select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function PedidoDetalles_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.PedidoDetalles_select_key(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.PedidoDetalles
        End Using

        Return Ret
    End Function

#End Region

#Region "Print Requisicion Report"


    ''' <summary>
    ''' Requisicion select for Report
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Requisicion_Report(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Requisicion_Report(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Requisicion
        End Using

        Return Ret
    End Function


    ''' <summary>
    ''' RequisicionDetalles select for Report
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function RequisicionDetalles_Report(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.RequisicionDetalles_Report(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.RequisicionDetalles
        End Using

        Return Ret
    End Function

#End Region

#Region "Print Pedido Report"


    ''' <summary>
    ''' Pedido select for Report
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Pedido_Report(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Pedido_Report(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Requisicion
        End Using

        Return Ret
    End Function


    ''' <summary>
    ''' PedidoDetalles select for Report
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function PedidoDetalles_Report(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.PedidoDetalles_Report(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.RequisicionDetalles
        End Using

        Return Ret
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

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.insumos_select(Bodega, dtRet)
            dtRet.TableName = Entity.TableNmae.Insumos
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Insumos select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function insumos_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.insumos_select_key(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Insumos
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Insumos select for List
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function insumos_select_list(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.insumos_select_list(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Insumos
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Insumos insert
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function insumos_insert(ByVal dtData As DataTable,
                                   ByRef Codigo_Dato As String) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR
        Dim Num As Long = 0
        Codigo_Dato = ""

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            Dim wkBodega As String = dtData.Rows(0).Item(Entity.Insumos.Bodega).ToString

            Dim dtRet As New DataTable
            'Get Max Number
            Ret = da.Insumos_Select_MaxNumber(wkBodega, dtRet)
            If Ret <> HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'Set Number
            If dtRet.Rows.Count = 0 Then
                Num = 1
            Else
                If IsNumeric(dtRet.Rows(0).Item(Entity.Insumos.Codigo_Dato)) Then
                    Num = CLng(dtRet.Rows(0).Item(Entity.Insumos.Codigo_Dato)) + 1
                Else
                    Num = 1
                End If
            End If
            dtData.Rows(0).Item(Entity.Insumos.Codigo_Dato) = Num.ToString("00000")
            dtData.Rows(0).Item(Entity.Insumos.Codigo_Insu) = Num.ToString("00000")

            Codigo_Dato = dtData.Rows(0).Item(Entity.Insumos.Codigo_Insu).ToString

            'insert Insumos
            Ret = da.insumos_insert(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret

    End Function

    ''' <summary>
    ''' Insumos update
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function insumos_update(ByVal dtData As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'update Insumos
            Ret = da.insumos_update(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' Insumos delete
    ''' </summary>
    ''' <param name="dtCondition"></param>
    ''' <returns></returns>
    Public Function insumos_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'Delete Insumos
            Ret = da.insumos_delete(dtCondition)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret
    End Function

#End Region

#Region "Servicio"

    ''' <summary>
    ''' Servicio select
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function servicio_select(ByRef dtRet As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.servicio_select(dtRet)
            dtRet.TableName = Entity.TableNmae.Servicio
        End Using

        Return Ret
    End Function


    ''' <summary>
    ''' servicio select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Servicio_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Servicio_select_key(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Servicio
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' servicio select for List
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Servicio_select_list(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Servicio_select_list(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Servicio
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' servicio insert
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function Servicio_insert(ByVal dtData As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'insert Servicio
            Ret = da.Servicio_insert(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret

    End Function

    ''' <summary>
    ''' servicio update
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function Servicio_update(ByVal dtData As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'update Servicio
            Ret = da.Servicio_update(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' servicio delete
    ''' </summary>
    ''' <param name="dtCondition"></param>
    ''' <returns></returns>
    Public Function Servicio_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'Delete Servicio
            Ret = da.Servicio_delete(dtCondition)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret
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

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Unidad_select(dtRet)
            dtRet.TableName = Entity.TableNmae.Unidad
        End Using

        Return Ret
    End Function


    ''' <summary>
    ''' comun.Unidad select for key
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Unidad_select_key(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Unidad_select_key(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Unidad
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' comun.Unidad select for List
    ''' </summary>
    ''' <param name="dtRet"></param>
    ''' <returns></returns>
    Public Function Unidad_select_list(ByRef dtRet As DataTable, ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()
            Ret = da.Unidad_select_list(dtRet, dtCondition)
            dtRet.TableName = Entity.TableNmae.Unidad
        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' comun.Unidad insert
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function Unidad_insert(ByVal dtData As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'insert Unidad
            Ret = da.Unidad_insert(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret

    End Function

    ''' <summary>
    ''' comun.Unidad update
    ''' </summary>
    ''' <param name="dtData"></param>
    ''' <returns></returns>
    Public Function Unidad_update(ByVal dtData As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'update Unidad
            Ret = da.Unidad_update(dtData)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret
    End Function

    ''' <summary>
    ''' comun.Unidad delete
    ''' </summary>
    ''' <param name="dtCondition"></param>
    ''' <returns></returns>
    Public Function Unidad_delete(ByVal dtCondition As DataTable) As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'Delete Unidad
            Ret = da.Unidad_delete(dtCondition)
            If Ret < HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            'DB Commit
            da.Commit()

        End Using

        Return Ret
    End Function

#End Region

#Region "Orden Insumos"

    ''' <summary>
    ''' Orden Insumos
    ''' </summary>
    ''' <returns></returns>
    Public Function Orden_insumos() As HospitalConst.DB_RET
        Dim Ret As HospitalConst.DB_RET = HospitalConst.DB_RET.ERR

        'DB Access
        Using da As New PedidoYRequisicionDAC()

            'DB Begin Transaction
            da.BeginTransaction()

            'Get Insimos Data
            Dim dtInsumos As New DataTable
            Ret = da.insumos_select_ForOrden(dtInsumos)
            If Ret <> HospitalConst.DB_RET.NML Then
                'DB RollBack
                da.RollBack()
                Return Ret
            End If

            Dim wkCnt As Integer = 0
            Dim wkCodigo_Dato As String = ""
            Dim wkBodega As String = ""
            Dim wkCodigo_Insu As String = ""
            For Each drInsumo As DataRow In dtInsumos.Rows
                If wkBodega <> drInsumo.Item(Entity.Insumos.Bodega).ToString Then
                    wkCnt = 0
                End If
                wkCnt += 1
                wkCodigo_Insu = wkCnt.ToString("00000")
                wkBodega = drInsumo.Item(Entity.Insumos.Bodega).ToString
                wkCodigo_Dato = drInsumo.Item(Entity.Insumos.Codigo_Dato).ToString

                'Update Insumos
                Ret = da.insumos_update_ForOrden(wkCodigo_Dato, wkBodega, wkCodigo_Insu)
                If Ret < HospitalConst.DB_RET.NML Then
                    'DB RollBack
                    da.RollBack()
                    Return Ret
                End If

                'Update Existencia
                Ret = da.RequisicionDetalles_update_ForOrden(wkCodigo_Dato, wkBodega, wkCodigo_Insu)
                If Ret < HospitalConst.DB_RET.NML Then
                    'DB RollBack
                    da.RollBack()
                    Return Ret
                End If

            Next

            'DB Commit
            da.Commit()

        End Using

        Return Ret

    End Function

#End Region

End Class
