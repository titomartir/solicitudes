Public Class Entity

#Region "TableName"

    ''' <summary>
    ''' TableNmae
    ''' </summary>
    Public Class TableNmae

        'SolicitudDePedidoYRequisicion
        Public Const Pedido As String = "Pedido"
        Public Const PedidoDetalles As String = "PedidoDetalles"
        Public Const Requisicion As String = "Requisicion"
        Public Const RequisicionDetalles As String = "RequisicionDetalles"
        Public Const Insumos As String = "Insumos"
        Public Const Servicio As String = "Servicio"
        Public Const Unidad As String = "Unidad"

        'Condition
        Public Const Condition As String = "Condition"
    End Class

#End Region

#Region "GetTable"

    ''' <summary>
    ''' GetTable
    ''' </summary>
    ''' <param name="Name"></param>
    ''' <returns></returns>
    Public Shared Function GetTable(ByVal Name As String) As DataTable
        Select Case Name
            Case TableNmae.Pedido
                Return GetPedido()
            Case TableNmae.PedidoDetalles
                Return GetPedidoDetalles()
            Case TableNmae.Requisicion
                Return GetRequisicion()
            Case TableNmae.RequisicionDetalles
                Return GetRequisicionDetalles()
            Case TableNmae.Insumos
                Return GetInsumos()
            Case TableNmae.Servicio
                Return GetServicio()
            Case TableNmae.Unidad
                Return GetUnidad()

            Case TableNmae.Condition
                Return GetCondition()

            Case Else
                Return New DataTable
        End Select
    End Function

#End Region

#Region "Struct difinition"

#Region "Pedido"

    Public Class Pedido
        Public Const Numero_docu As String = "Numero_docu"
        Public Const Anio As String = "Anio"
        Public Const Fecha As String = "Fecha"
        Public Const Codigo_Serv As String = "Codigo_Serv"
        Public Const Telefono As String = "Telefono"
        Public Const Descripcion As String = "Descripcion"
        Public Const Solicita As String = "Solicita"
        Public Const Autoriza As String = "Autoriza"
        Public Const Aprobacion As String = "Aprobacion"
        Public Const Solicita_Carg As String = "Solicita_Carg"
        Public Const Autoriza_Carg As String = "Autoriza_Carg"
        Public Const Aprobacion_Carg As String = "Aprobacion_Carg"
        Public Const TipoCompras As String = "TipoCompras"
        Public Const Pago As String = "Pago"
        Public Const Disponibilidad As String = "Disponibilidad"
        Public Const Presupuesto As String = "Presupuesto"
        Public Const Compras As String = "Compras"
        Public Const Otro As String = "Otro"
        Public Const SubProducto As String = "SubProducto"
        Public Const Prog As String = "Prog"
        Public Const Subp As String = "Subp"
        Public Const Proy As String = "Proy"
        Public Const Act As String = "Act"
        Public Const Obra As String = "Obra"
        Public Const Ub_Geo As String = "Ub_Geo"
        Public Const Fte_Fin As String = "Fte_Fin"
        Public Const Inventario As String = "Inventario"
        Public Const Actualizador As String = "Actualizador"
        Public Const Fecha_Actu As String = "Fecha_Actu"
        Public Const Clasi_Actu As String = "Clasi_Actu"
    End Class

    Private Shared Function GetPedido() As DataTable

        Dim dt As New DataTable
        With dt.Columns
            .Add(Pedido.Numero_docu, GetType(System.String))
            .Add(Pedido.Anio, GetType(System.String))
            .Add(Pedido.Fecha, GetType(System.String))
            .Add(Pedido.Codigo_Serv, GetType(System.String))
            .Add(Pedido.Telefono, GetType(System.String))
            .Add(Pedido.Descripcion, GetType(System.String))
            .Add(Pedido.Solicita, GetType(System.String))
            .Add(Pedido.Autoriza, GetType(System.String))
            .Add(Pedido.Aprobacion, GetType(System.String))
            .Add(Pedido.Solicita_Carg, GetType(System.String))
            .Add(Pedido.Autoriza_Carg, GetType(System.String))
            .Add(Pedido.Aprobacion_Carg, GetType(System.String))
            .Add(Pedido.TipoCompras, GetType(System.String))
            .Add(Pedido.Pago, GetType(System.String))
            .Add(Pedido.Disponibilidad, GetType(System.String))
            .Add(Pedido.Presupuesto, GetType(System.String))
            .Add(Pedido.Compras, GetType(System.String))
            .Add(Pedido.Otro, GetType(System.String))
            .Add(Pedido.SubProducto, GetType(System.String))
            .Add(Pedido.Prog, GetType(System.String))
            .Add(Pedido.Subp, GetType(System.String))
            .Add(Pedido.Proy, GetType(System.String))
            .Add(Pedido.Act, GetType(System.String))
            .Add(Pedido.Obra, GetType(System.String))
            .Add(Pedido.Ub_Geo, GetType(System.String))
            .Add(Pedido.Fte_Fin, GetType(System.String))
            .Add(Pedido.Inventario, GetType(System.String))
            .Add(Pedido.Actualizador, GetType(System.String))
            .Add(Pedido.Fecha_Actu, GetType(System.DateTime))
            .Add(Pedido.Clasi_Actu, GetType(System.String))
        End With

        dt.TableName = TableNmae.Pedido

        Return dt

    End Function

#End Region

#Region "PedidoDetalles"

    Public Class PedidoDetalles
        Public Const Numero_docu As String = "Numero_docu"
        Public Const Anio As String = "Anio"
        Public Const Numero_serie As String = "Numero_serie"
        Public Const Codigo_Insu As String = "Codigo_Insu"
        Public Const Codigo_Presentacion As String = "Codigo_Presentacion"
        Public Const Insumos As String = "Insumos"
        Public Const Descripcion As String = "Descripcion"
        Public Const Unidad As String = "Unidad"
        Public Const Solicitada As String = "Solicitada"
        Public Const Autorizada As String = "Autorizada"
        Public Const Estimado As String = "Estimado"
        Public Const Financiero As String = "Financiero"
        Public Const Paac As String = "Paac"
        Public Const Abierto As String = "Abierto"
        Public Const Actualizador As String = "Actualizador"
        Public Const Fecha_Actu As String = "Fecha_Actu"
        Public Const Clasi_Actu As String = "Clasi_Actu"
    End Class

    Private Shared Function GetPedidoDetalles() As DataTable

        Dim dt As New DataTable
        With dt.Columns
            .Add(PedidoDetalles.Numero_docu, GetType(System.String))
            .Add(PedidoDetalles.Anio, GetType(System.String))
            .Add(PedidoDetalles.Numero_serie, GetType(System.String))
            .Add(PedidoDetalles.Codigo_Insu, GetType(System.String))
            .Add(PedidoDetalles.Codigo_Presentacion, GetType(System.String))
            .Add(PedidoDetalles.Insumos, GetType(System.String))
            .Add(PedidoDetalles.Descripcion, GetType(System.String))
            .Add(PedidoDetalles.Unidad, GetType(System.String))
            .Add(PedidoDetalles.Solicitada, GetType(System.String))
            .Add(PedidoDetalles.Autorizada, GetType(System.String))
            .Add(PedidoDetalles.Estimado, GetType(System.String))
            .Add(PedidoDetalles.Financiero, GetType(System.String))
            .Add(PedidoDetalles.Paac, GetType(System.String))
            .Add(PedidoDetalles.Abierto, GetType(System.String))
            .Add(PedidoDetalles.Actualizador, GetType(System.String))
            .Add(PedidoDetalles.Fecha_Actu, GetType(System.DateTime))
            .Add(PedidoDetalles.Clasi_Actu, GetType(System.String))
        End With

        dt.TableName = TableNmae.PedidoDetalles

        Return dt

    End Function

#End Region

#Region "Requisicion"

    Public Class Requisicion
        Public Const Numero_docu As String = "Numero_docu"
        Public Const Anio As String = "Anio"
        Public Const Fecha As String = "Fecha"
        Public Const NombreBodega As String = "NombreBodega"
        Public Const Bodega As String = "Bodega"
        Public Const Codigo_Serv As String = "Codigo_Serv"
        Public Const Descripcion As String = "Descripcion"
        Public Const Solicita As String = "Solicita"
        Public Const Revisa As String = "Revisa"
        Public Const Autoriza As String = "Autoriza"
        Public Const Despacha As String = "Despacha"
        Public Const Recibe As String = "Recibe"
        Public Const Solicita_Carg As String = "Solicita_Carg"
        Public Const Revisa_Carg As String = "Revisa_Carg"
        Public Const Autoriza_Carg As String = "Autoriza_Carg"
        Public Const Despacha_Carg As String = "Despacha_Carg"
        Public Const Recibe_Carg As String = "Recibe_Carg"
        Public Const Inventario As String = "Inventario"
        Public Const Actualizador As String = "Actualizador"
        Public Const Fecha_Actu As String = "Fecha_Actu"
        Public Const Clasi_Actu As String = "Clasi_Actu"
    End Class

    Private Shared Function GetRequisicion() As DataTable

        Dim dt As New DataTable
        With dt.Columns
            .Add(Requisicion.Numero_docu, GetType(System.String))
            .Add(Requisicion.Anio, GetType(System.String))
            .Add(Requisicion.Fecha, GetType(System.String))
            .Add(Requisicion.NombreBodega, GetType(System.String))
            .Add(Requisicion.Bodega, GetType(System.String))
            .Add(Requisicion.Codigo_Serv, GetType(System.String))
            .Add(Requisicion.Descripcion, GetType(System.String))
            .Add(Requisicion.Solicita, GetType(System.String))
            .Add(Requisicion.Revisa, GetType(System.String))
            .Add(Requisicion.Autoriza, GetType(System.String))
            .Add(Requisicion.Despacha, GetType(System.String))
            .Add(Requisicion.Recibe, GetType(System.String))
            .Add(Requisicion.Solicita_Carg, GetType(System.String))
            .Add(Requisicion.Revisa_Carg, GetType(System.String))
            .Add(Requisicion.Autoriza_Carg, GetType(System.String))
            .Add(Requisicion.Despacha_Carg, GetType(System.String))
            .Add(Requisicion.Recibe_Carg, GetType(System.String))
            .Add(Requisicion.Inventario, GetType(System.String))
            .Add(Requisicion.Actualizador, GetType(System.String))
            .Add(Requisicion.Fecha_Actu, GetType(System.DateTime))
            .Add(Requisicion.Clasi_Actu, GetType(System.String))
        End With

        dt.TableName = TableNmae.Requisicion

        Return dt

    End Function

#End Region

#Region "RequisicionDetalles"

    Public Class RequisicionDetalles
        Public Const Numero_docu As String = "Numero_docu"
        Public Const Anio As String = "Anio"
        Public Const Numero_serie As String = "Numero_serie"
        Public Const Codigo_Dato As String = "Codigo_Dato"
        Public Const Bodega As String = "Bodega"
        Public Const Codigo_Insu As String = "Codigo_Insu"
        Public Const Descripcion As String = "Descripcion"
        Public Const Solicitada As String = "Solicitada"
        Public Const Actualizador As String = "Actualizador"
        Public Const Fecha_Actu As String = "Fecha_Actu"
        Public Const Clasi_Actu As String = "Clasi_Actu"
    End Class

    Private Shared Function GetRequisicionDetalles() As DataTable

        Dim dt As New DataTable
        With dt.Columns
            .Add(RequisicionDetalles.Numero_docu, GetType(System.String))
            .Add(RequisicionDetalles.Anio, GetType(System.String))
            .Add(RequisicionDetalles.Numero_serie, GetType(System.String))
            .Add(RequisicionDetalles.Codigo_Dato, GetType(System.String))
            .Add(RequisicionDetalles.Bodega, GetType(System.String))
            .Add(RequisicionDetalles.Codigo_Insu, GetType(System.String))
            .Add(RequisicionDetalles.Descripcion, GetType(System.String))
            .Add(RequisicionDetalles.Solicitada, GetType(System.String))
            .Add(RequisicionDetalles.Actualizador, GetType(System.String))
            .Add(RequisicionDetalles.Fecha_Actu, GetType(System.DateTime))
            .Add(RequisicionDetalles.Clasi_Actu, GetType(System.String))
        End With

        dt.TableName = TableNmae.RequisicionDetalles

        Return dt

    End Function

#End Region

#Region "Insumos"

    Public Class Insumos
        Public Const Codigo_Dato As String = "Codigo_Dato"
        Public Const Bodega As String = "Bodega"
        Public Const Codigo_Insu As String = "Codigo_Insu"
        Public Const Nombre_Insu As String = "Nombre_Insu"
        Public Const Unidad As String = "Unidad"
        Public Const Actualizador As String = "Actualizador"
        Public Const Fecha_Actu As String = "Fecha_Actu"
        Public Const Clasi_Actu As String = "Clasi_Actu"
    End Class

    Private Shared Function GetInsumos() As DataTable

        Dim dt As New DataTable
        With dt.Columns
            .Add(Insumos.Codigo_Dato, GetType(System.String))
            .Add(Insumos.Bodega, GetType(System.String))
            .Add(Insumos.Codigo_Insu, GetType(System.String))
            .Add(Insumos.Nombre_Insu, GetType(System.String))
            .Add(Insumos.Unidad, GetType(System.String))
            .Add(Insumos.Actualizador, GetType(System.String))
            .Add(Insumos.Fecha_Actu, GetType(System.DateTime))
            .Add(Insumos.Clasi_Actu, GetType(System.String))
        End With

        dt.TableName = TableNmae.Insumos

        Return dt

    End Function

#End Region

#Region "Servicio"

    Public Class Servicio
        Public Const Codigo_Serv As String = "Codigo_Serv"
        Public Const Nombre_Serv As String = "Nombre_Serv"
        Public Const Telefono As String = "Telefono"
        Public Const Actualizador As String = "Actualizador"
        Public Const Fecha_Actu As String = "Fecha_Actu"
        Public Const Clasi_Actu As String = "Clasi_Actu"
    End Class

    Private Shared Function GetServicio() As DataTable

        Dim dt As New DataTable
        With dt.Columns
            .Add(Servicio.Codigo_Serv, GetType(System.String))
            .Add(Servicio.Nombre_Serv, GetType(System.String))
            .Add(Servicio.Telefono, GetType(System.String))
            .Add(Servicio.Actualizador, GetType(System.String))
            .Add(Servicio.Fecha_Actu, GetType(System.DateTime))
            .Add(Servicio.Clasi_Actu, GetType(System.String))
        End With

        dt.TableName = TableNmae.Servicio

        Return dt

    End Function

#End Region

#Region "Unidad"

    Public Class Unidad
        Public Const Codigo_Unid As String = "Codigo_Unid"
        Public Const Nombre_Unid As String = "Nombre_Unid"
        Public Const Actualizador As String = "Actualizador"
        Public Const Fecha_Actu As String = "Fecha_Actu"
        Public Const Clasi_Actu As String = "Clasi_Actu"
    End Class

    Private Shared Function GetUnidad() As DataTable

        Dim dt As New DataTable
        With dt.Columns
            .Add(Unidad.Codigo_Unid, GetType(System.String))
            .Add(Unidad.Nombre_Unid, GetType(System.String))
            .Add(Unidad.Actualizador, GetType(System.String))
            .Add(Unidad.Fecha_Actu, GetType(System.DateTime))
            .Add(Unidad.Clasi_Actu, GetType(System.String))
        End With

        dt.TableName = TableNmae.Unidad

        Return dt

    End Function

#End Region

#Region "Condition"

    Public Class Condition
        Public Const Data01 As String = "Data01"
        Public Const Data02 As String = "Data02"
        Public Const Data03 As String = "Data03"
        Public Const Data04 As String = "Data04"
        Public Const Data05 As String = "Data05"
        Public Const Data06 As String = "Data06"
    End Class

    Private Shared Function GetCondition() As DataTable

        Dim dt As New DataTable
        With dt.Columns
            .Add(Condition.Data01, GetType(System.String))
            .Add(Condition.Data02, GetType(System.String))
            .Add(Condition.Data03, GetType(System.String))
            .Add(Condition.Data04, GetType(System.String))
            .Add(Condition.Data05, GetType(System.String))
            .Add(Condition.Data06, GetType(System.String))
        End With

        dt.TableName = TableNmae.Condition

        Return dt

    End Function

#End Region

#End Region

End Class
