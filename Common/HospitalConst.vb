Public Class HospitalConst

    Public Const SYSTEM_NAME As String = "Departamento de Productos Afines"
    Public Const HOSPITAL_NAME As String = "Hospital Regional de El Quiché"


    Public Const DB_SERVER_DEBUG As String = "192.168.10.171" 'For Debug
    Public Const DB_SERVER_RELEASE As String = "192.168.10.11" 'For Real
    Public Shared DB_SERVER As String = DB_SERVER_RELEASE
    Public Const DB_USER As String = "hospital"
    Public Const DB_PASSWORD As String = "hospital"

    Public Const MAINTENANCE_PASSWORD As String = "hospital2018"

    Public Class DB_NAME
        Public Const PEDIDOYREQUISICION As String = "afines"
    End Class

    Public Enum DB_RET As Integer
        NML = 0
        ERR = -1
        EXCRUSIVE = -9
    End Enum

    Public Class SETTINGS
        Public Const REQUISICION_SERVICIO As String = "REQUISICION_SERVICIO"
        Public Const REQUISICION_JUSTIFICACION As String = "REQUISICION_JUSTIFICACION"
        Public Const REQUISICION_SOLICITA As String = "REQUISICION_SOLICITA"
        Public Const REQUISICION_REVISA As String = "REQUISICION_REVISA"
        Public Const REQUISICION_AUTORIZA As String = "REQUISICION_AUTORIZA"
        Public Const REQUISICION_DESPACHA As String = "REQUISICION_DESPACHA"
        Public Const REQUISICION_RECIBE As String = "REQUISICION_RECIBE"
        Public Const REQUISICION_SOLICITA_CARGO As String = "REQUISICION_SOLICITA_CARGO"
        Public Const REQUISICION_REVISA_CARGO As String = "REQUISICION_REVISA_CARGO"
        Public Const REQUISICION_AUTORIZA_CARGO As String = "REQUISICION_AUTORIZA_CARGO"
        Public Const REQUISICION_DESPACHA_CARGO As String = "REQUISICION_DESPACHA_CARGO"
        Public Const REQUISICION_RECIBE_CARGO As String = "REQUISICION_RECIBE_CARGO"

        Public Const PEDIDO_SERVICIO As String = "PEDIDO_SERVICIO"
        Public Const PEDIDO_JUSTIFICACION As String = "PEDIDO_JUSTIFICACION"
        Public Const PEDIDO_SOLICITA As String = "PEDIDO_SOLICITA"
        Public Const PEDIDO_AUTORIZA As String = "PEDIDO_AUTORIZA"
        Public Const PEDIDO_APROBACION As String = "PEDIDO_APROBACION"
        Public Const PEDIDO_SOLICITA_CARGO As String = "PEDIDO_SOLICITA_CARGO"
        Public Const PEDIDO_AUTORIZA_CARGO As String = "PEDIDO_AUTORIZA_CARGO"
        Public Const PEDIDO_APROBACION_CARGO As String = "PEDIDO_APROBACION_CARGO"
        Public Const PEDIDO_PRESUPUESTO As String = "PEDIDO_PRESUPUESTO"
        Public Const PEDIDO_COMPRAS As String = "PEDIDO_COMPRAS"
        Public Const PEDIDO_PROG As String = "PEDIDO_PROG"
        Public Const PEDIDO_SUBP As String = "PEDIDO_SUBP"
        Public Const PEDIDO_PROY As String = "PEDIDO_PROY"
        Public Const PEDIDO_ACT As String = "PEDIDO_ACT"
        Public Const PEDIDO_OBRA As String = "PEDIDO_OBRA"
        Public Const PEDIDO_UB_GEO As String = "PEDIDO_UB_GEO"
        Public Const PEDIDO_FTE_FIN As String = "PEDIDO_FTE_FIN"
        Public Const PEDIDO_TELEFONO As String = "PEDIDO_TELEFONO"

    End Class

#Region "Bodega"

    Public Class BODEGA_CD
        Public Const FARMACIA As String = "01"
        Public Const LABORATORIO As String = "02"
        Public Const QUIRURGIA_DONACION As String = "03"
        Public Const QUIRURGIA_AGREGADO As String = "04"
        Public Const QUIRURGIA_GENERAL As String = "05"
        Public Const QUIRURGIA_ADICIONAL As String = "11"
        Public Const LIMPIEZA As String = "06"
        Public Const PAPELERIA As String = "07"
        Public Const MANTENIMIENTO As String = "08"
        Public Const ALIMENTOS As String = "09"
        Public Const LIBRERIA As String = "10"
    End Class

    Public Class BODEGA_NAME
        Public Const FARMACIA As String = "Farmacia"
        Public Const LABORATORIO As String = "Laboratorio"
        Public Const QUIRURGIA_DONACION As String = "Medico Quirurgico Donacion"
        Public Const QUIRURGIA_AGREGADO As String = "Medico Quirurgico Agregado"
        Public Const QUIRURGIA_GENERAL As String = "Medico Quirurgico General"
        Public Const QUIRURGIA_ADICIONAL As String = "Medico Quirurgico Adicional"
        Public Const LIMPIEZA As String = "Limpieza"
        Public Const PAPELERIA As String = "Papeleria"
        Public Const MANTENIMIENTO As String = "Mantenimiento"
        Public Const ALIMENTOS As String = "Alimentos"
        Public Const LIBRERIA As String = "Libreria"
    End Class

    Public Shared Function GetBodegaName(ByVal Bodega As Object) As String

        Dim ret As String = ""

        If Not IsNumeric(Bodega) Then
            Return ret
        End If

        Select Case Bodega.ToString
            Case BODEGA_CD.FARMACIA
                ret = BODEGA_NAME.FARMACIA
            Case BODEGA_CD.LABORATORIO
                ret = BODEGA_NAME.LABORATORIO
            Case BODEGA_CD.QUIRURGIA_DONACION
                ret = BODEGA_NAME.QUIRURGIA_DONACION
            Case BODEGA_CD.QUIRURGIA_AGREGADO
                ret = BODEGA_NAME.QUIRURGIA_AGREGADO
            Case BODEGA_CD.QUIRURGIA_GENERAL
                ret = BODEGA_NAME.QUIRURGIA_GENERAL
            Case BODEGA_CD.QUIRURGIA_ADICIONAL
                ret = BODEGA_NAME.QUIRURGIA_ADICIONAL
            Case BODEGA_CD.LIMPIEZA
                ret = BODEGA_NAME.LIMPIEZA
            Case BODEGA_CD.PAPELERIA
                ret = BODEGA_NAME.PAPELERIA
            Case BODEGA_CD.MANTENIMIENTO
                ret = BODEGA_NAME.MANTENIMIENTO
            Case BODEGA_CD.ALIMENTOS
                ret = BODEGA_NAME.ALIMENTOS
            Case BODEGA_CD.LIBRERIA
                ret = BODEGA_NAME.LIBRERIA
            Case Else
        End Select

        Return ret

    End Function

#End Region

#Region "NombreBodega"

    Public Class NOMBREBODEGA_CD
        Public Const GENERAL As String = "1"
        Public Const FARMACIA As String = "2"
        Public Const LABORATORIO As String = "3"
        Public Const ALIMENTOS As String = "4"
    End Class

    Public Class NOMBREBODEGA_NAME
        Public Const GENERAL As String = "Bodega General"
        Public Const FARMACIA As String = "Bodega de Farmacia"
        Public Const LABORATORIO As String = "Bodega de Laboratorio"
        Public Const ALIMENTOS As String = "Bodega de Alimentos"
    End Class

    Public Shared Function GetNombreBodegaName(ByVal Bodega As Object) As String

        Dim ret As String = ""

        If Not IsNumeric(Bodega) Then
            Return ret
        End If

        Select Case Bodega.ToString
            Case NOMBREBODEGA_CD.GENERAL
                ret = NOMBREBODEGA_NAME.GENERAL
            Case NOMBREBODEGA_CD.FARMACIA
                ret = NOMBREBODEGA_NAME.FARMACIA
            Case NOMBREBODEGA_CD.LABORATORIO
                ret = NOMBREBODEGA_NAME.LABORATORIO
            Case NOMBREBODEGA_CD.ALIMENTOS
                ret = NOMBREBODEGA_NAME.ALIMENTOS
            Case Else
        End Select

        Return ret

    End Function

#End Region

#Region "InventarioStatus"

    Public Class INVENTARIOST_CD
        Public Const NOIMPRESO As String = "0"
        Public Const IMPRESO As String = "1"
        Public Const PROCESADO As String = "2"
        Public Const DESHABILITADO As String = "9"
    End Class

    Public Class INVENTARIOST_NAME
        Public Const NOIMPRESO As String = "No impreso"
        Public Const IMPRESO As String = "Impreso"
        Public Const PROCESADO As String = "Procesado"
        Public Const DESHABILITADO As String = "Deshabilitado"
    End Class

    Public Shared Function GetInventarioStatus(ByVal InventarioStatus As Object) As String

        Dim ret As String = ""

        Select Case InventarioStatus.ToString
            Case INVENTARIOST_CD.NOIMPRESO
                ret = INVENTARIOST_NAME.NOIMPRESO
            Case INVENTARIOST_CD.IMPRESO
                ret = INVENTARIOST_NAME.IMPRESO
            Case INVENTARIOST_CD.PROCESADO
                ret = INVENTARIOST_NAME.PROCESADO
            Case INVENTARIOST_CD.DESHABILITADO
                ret = INVENTARIOST_NAME.DESHABILITADO
            Case Else
        End Select

        Return ret

    End Function

    Public Shared Function GetInventarioStatusCd(ByVal InventarioStatus As Object) As String

        Dim ret As String = ""

        Select Case InventarioStatus.ToString
            Case INVENTARIOST_NAME.NOIMPRESO
                ret = INVENTARIOST_CD.NOIMPRESO
            Case INVENTARIOST_NAME.IMPRESO
                ret = INVENTARIOST_CD.IMPRESO
            Case INVENTARIOST_NAME.PROCESADO
                ret = INVENTARIOST_CD.PROCESADO
            Case INVENTARIOST_NAME.DESHABILITADO
                ret = INVENTARIOST_CD.DESHABILITADO
            Case Else
        End Select

        Return ret

    End Function

#End Region

End Class
