Imports System.Drawing

Public Class ReportCommon

#Region "difinition"

    Private cu As CommonUtility = CommonUtility.GetInstance

#End Region

#Region "Print Requisicion Report"

    ''' <summary>
    ''' Print Requisicion Report
    ''' </summary>
    Public Sub PrintRequisicion(ByVal Anio As String,
                                ByVal Numero As String,
                                Optional ByVal isDirectPrint As Boolean = False)

        Dim DispMax As Integer = 29
        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable
        Dim dtRetDetail As New DataTable

        'Set Condition
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Requisicion)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Requisicion.Numero_docu) = Numero
        dr.Item(Entity.Requisicion.Anio) = Anio
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.Requisicion_Report(dtRet, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRet.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        'Table Access
        If bc.RequisicionDetalles_Report(dtRetDetail, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRetDetail.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        'create report
        Dim rpt As New Requisicion
        With dtRet.Rows(0)

            cu.setReportText(rpt, "txtNumero", .Item(Entity.Requisicion.Numero_docu))
            cu.setReportText(rpt, "txtFecha", cu.SetFormatDateForReport(.Item(Entity.Requisicion.Fecha)))
            cu.setReportText(rpt, "txtServicio", .Item(Entity.Servicio.Nombre_Serv))
            cu.setReportText(rpt, "txtBodega", HospitalConst.GetNombreBodegaName(.Item(Entity.Requisicion.NombreBodega)))

            cu.setReportText(rpt, "txtJustificacion", .Item(Entity.Requisicion.Descripcion).ToString)

            cu.setReportText(rpt, "txtSolicita", .Item(Entity.Requisicion.Solicita))
            cu.setReportText(rpt, "txtRevisa", .Item(Entity.Requisicion.Revisa))
            cu.setReportText(rpt, "txtAutoriza", .Item(Entity.Requisicion.Autoriza))
            cu.setReportText(rpt, "txtDespacha", .Item(Entity.Requisicion.Despacha))
            cu.setReportText(rpt, "txtRecibe", .Item(Entity.Requisicion.Recibe))
            cu.setReportText(rpt, "txtSolicitaCargo", .Item(Entity.Requisicion.Solicita_Carg))
            cu.setReportText(rpt, "txtRevisaCargo", .Item(Entity.Requisicion.Revisa_Carg))
            cu.setReportText(rpt, "txtAutorizaCargo", .Item(Entity.Requisicion.Autoriza_Carg))
            cu.setReportText(rpt, "txtDespachaCargo", .Item(Entity.Requisicion.Despacha_Carg))
            cu.setReportText(rpt, "txtRecibeCargo", .Item(Entity.Requisicion.Recibe_Carg))


        End With

        Dim ds As New dsRep

        For Each tmpDr As DataRow In dtRetDetail.Rows
            Dim wkDr As DataRow = ds.Tables(0).NewRow
            wkDr.Item("DATA01") = tmpDr.Item(Entity.Insumos.Nombre_Insu)
            wkDr.Item("DATA02") = tmpDr.Item(Entity.Unidad.Nombre_Unid)
            wkDr.Item("INT01") = tmpDr.Item(Entity.RequisicionDetalles.Solicitada)
            ds.Tables(0).Rows.Add(wkDr)
        Next

        'Insert Brank Rows
        Dim wkRowCnt As Integer = DispMax - ds.Tables(0).Rows.Count
        For lp = 1 To wkRowCnt
            ds.Tables(0).Rows.Add(ds.Tables(0).NewRow)
            If lp = 1 Then
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item("DATA01") = "---------- ULTIMA LINEA ----------"
            End If
        Next

        'Data Copy
        For lp = 0 To DispMax - 1
            ds.Tables(0).Rows.Add(ds.Tables(0).Rows(lp).ItemArray)
        Next

        'Set Report Data
        rpt.SetDataSource(ds)

        'Direct Print
        If isDirectPrint Then
            rpt.PrintToPrinter(1, False, 0, 0)
            Exit Sub
        End If

        Using Frm As New Preview
            Frm.Report = rpt
            Frm.ShowDialog()
        End Using

    End Sub

#End Region

#Region "Print Pedido Report"

    ''' <summary>
    ''' Print Pedido Report
    ''' </summary>
    Public Sub PrintPedido(ByVal Anio As String,
                           ByVal Numero As String,
                           Optional ByVal isDirectPrint As Boolean = False)

        Dim DispMax As Integer = 10
        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable
        Dim dtRetDetail As New DataTable

        'Set Condition
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Pedido)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Pedido.Numero_docu) = Numero
        dr.Item(Entity.Pedido.Anio) = Anio
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.Pedido_Report(dtRet, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRet.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        'Table Access
        If bc.PedidoDetalles_Report(dtRetDetail, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRetDetail.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        'create report
        Dim rpt As New SolicitudDePedido
        With dtRet.Rows(0)

            cu.setReportText(rpt, "txtNumero", .Item(Entity.Pedido.Numero_docu))
            cu.setReportText(rpt, "txtFecha", cu.SetFormatDateForReport(.Item(Entity.Pedido.Fecha)))
            cu.setReportText(rpt, "txtServicio", .Item(Entity.Servicio.Nombre_Serv))
            cu.setReportText(rpt, "txtTelefono", .Item(Entity.Pedido.Telefono))

            cu.setReportText(rpt, "txtJustificacion", .Item(Entity.Pedido.Descripcion).ToString)

            cu.setReportText(rpt, "txtSolicita", .Item(Entity.Pedido.Solicita))
            cu.setReportText(rpt, "txtAutoriza", .Item(Entity.Pedido.Autoriza))
            cu.setReportText(rpt, "txtAprobacion", .Item(Entity.Pedido.Aprobacion))
            cu.setReportText(rpt, "txtSolicitaCargo", .Item(Entity.Pedido.Solicita_Carg))
            cu.setReportText(rpt, "txtAutorizaCargo", .Item(Entity.Pedido.Autoriza_Carg))
            cu.setReportText(rpt, "txtAprobacionCargo", .Item(Entity.Pedido.Aprobacion_Carg))

            Select Case .Item(Entity.Pedido.TipoCompras).ToString
                Case "1"
                    cu.setReportText(rpt, "txtCompraDirecta", "x")
                Case "2"
                    cu.setReportText(rpt, "txtContratoAbierto", "x")
                Case "3"
                    cu.setReportText(rpt, "txtCotizacion", "x")
                Case "4"
                    cu.setReportText(rpt, "txtLicitacion", "x")
                Case "5"
                    cu.setReportText(rpt, "txtBajaCuantilla", "x")
                Case "6"
                    cu.setReportText(rpt, "txtSubastaInversa", "x")
                Case Else
            End Select
            cu.setReportText(rpt, "txtOtro", .Item(Entity.Pedido.Otro))
            cu.setReportText(rpt, "txtSubProducto", .Item(Entity.Pedido.SubProducto))
            Select Case .Item(Entity.Pedido.Pago).ToString
                Case "1"
                    cu.setReportText(rpt, "txtFondoRotativo", "x")
                Case "2"
                    cu.setReportText(rpt, "txtAcreditamiento", "x")
                Case Else
            End Select
            Select Case .Item(Entity.Pedido.Disponibilidad).ToString
                Case "1"
                    cu.setReportText(rpt, "txtPresupuestoSi", "x")
                Case "2"
                    cu.setReportText(rpt, "txtPresupuestoNo", "x")
                Case Else
            End Select
            cu.setReportText(rpt, "txtPresupuesto", .Item(Entity.Pedido.Presupuesto))
            cu.setReportText(rpt, "txtCompras", .Item(Entity.Pedido.Compras))
            cu.setReportText(rpt, "txtPresupuestoFecha", cu.SetFormatDate(.Item(Entity.Pedido.Fecha)))
            cu.setReportText(rpt, "txtComprasFecha", cu.SetFormatDate(.Item(Entity.Pedido.Fecha)))

        End With

        Dim ds As New dsRep

        Dim wkDtQ As New DataTable
        wkDtQ.Columns.Add(Entity.PedidoDetalles.Estimado, GetType(System.Double))
        wkDtQ.Columns.Add(Entity.PedidoDetalles.Financiero, GetType(System.String))
        Dim wkQTotal As Double = 0

        Dim tmpCnt As Integer = 1
        For Each tmpDr As DataRow In dtRetDetail.Rows
            Dim wkDr As DataRow = ds.Tables(0).NewRow
            wkDr.Item("DATA01") = tmpDr.Item(Entity.PedidoDetalles.Codigo_Insu)
            wkDr.Item("DATA02") = tmpDr.Item(Entity.PedidoDetalles.Unidad)
            wkDr.Item("DATA03") = tmpDr.Item(Entity.PedidoDetalles.Insumos)
            wkDr.Item("INT01") = tmpCnt.ToString
            wkDr.Item("DATA07") = tmpDr.Item(Entity.PedidoDetalles.Solicitada)
            wkDr.Item("DATA08") = tmpDr.Item(Entity.PedidoDetalles.Autorizada)
            wkDr.Item("DATA09") = tmpDr.Item(Entity.PedidoDetalles.Financiero)
            wkDr.Item("DATA11") = tmpDr.Item(Entity.PedidoDetalles.Codigo_Presentacion)
            If IsNumeric(tmpDr.Item(Entity.PedidoDetalles.Estimado)) Then
                wkDr.Item("DATA10") = CDbl(tmpDr.Item(Entity.PedidoDetalles.Estimado)).ToString("#,##0.00")
                wkDr.Item("DBL01") = CDbl(tmpDr.Item(Entity.PedidoDetalles.Estimado))
                If tmpDr.Item(Entity.PedidoDetalles.Financiero).ToString <> "" Then
                    wkQTotal = wkQTotal + CDbl(tmpDr.Item(Entity.PedidoDetalles.Estimado))
                End If
            End If
            If tmpDr.Item(Entity.PedidoDetalles.Paac).ToString = "1" Then
                wkDr.Item("DATA04") = "Si"
            Else
                wkDr.Item("DATA04") = "No"
            End If
            If tmpDr.Item(Entity.PedidoDetalles.Abierto).ToString = "1" Then
                wkDr.Item("DATA05") = "Si"
            Else
                wkDr.Item("DATA05") = "No"
            End If
            wkDr.Item("DATA06") = "1"
            ds.Tables(0).Rows.Add(wkDr)

            If tmpDr.Item(Entity.PedidoDetalles.Financiero).ToString <> "" Then

                'For Financial
                If wkDtQ.Rows.Count = 0 Then
                    wkDtQ.Rows.Add(wkDtQ.NewRow)
                    If IsNumeric(tmpDr.Item(Entity.PedidoDetalles.Estimado)) Then
                        wkDtQ.Rows(0).Item(Entity.PedidoDetalles.Estimado) = CDbl(tmpDr.Item(Entity.PedidoDetalles.Estimado))
                    Else
                        wkDtQ.Rows(0).Item(Entity.PedidoDetalles.Estimado) = 0
                    End If
                    wkDtQ.Rows(0).Item(Entity.PedidoDetalles.Financiero) = tmpDr.Item(Entity.PedidoDetalles.Financiero)

                Else
                    Dim TargetFlg As Boolean = False

                    For Each wkDrQ As DataRow In wkDtQ.Rows
                        If wkDrQ.Item(Entity.PedidoDetalles.Financiero).ToString = tmpDr.Item(Entity.PedidoDetalles.Financiero).ToString Then
                            If IsNumeric(tmpDr.Item(Entity.PedidoDetalles.Estimado)) Then
                                wkDrQ.Item(Entity.PedidoDetalles.Estimado) = CDbl(tmpDr.Item(Entity.PedidoDetalles.Estimado)) + CDbl(wkDrQ.Item(Entity.PedidoDetalles.Estimado))
                            End If
                            TargetFlg = True
                            Exit For
                        End If
                    Next

                    If TargetFlg = False Then
                        wkDtQ.Rows.Add(wkDtQ.NewRow)
                        If IsNumeric(tmpDr.Item(Entity.PedidoDetalles.Estimado)) Then
                            wkDtQ.Rows(wkDtQ.Rows.Count - 1).Item(Entity.PedidoDetalles.Estimado) = CDbl(tmpDr.Item(Entity.PedidoDetalles.Estimado))
                        Else
                            wkDtQ.Rows(wkDtQ.Rows.Count - 1).Item(Entity.PedidoDetalles.Estimado) = 0
                        End If
                        wkDtQ.Rows(wkDtQ.Rows.Count - 1).Item(Entity.PedidoDetalles.Financiero) = tmpDr.Item(Entity.PedidoDetalles.Financiero)
                    End If

                End If
            End If

            tmpCnt = tmpCnt + 1
        Next

        Dim wkProg As String = ""
        Dim wkSubp As String = ""
        Dim wkProy As String = ""
        Dim wkAct As String = ""
        Dim wkObra As String = ""
        Dim wkUbGeo As String = ""
        Dim wkFteFin As String = ""
        With dtRet.Rows(0)
            wkProg = .Item(Entity.Pedido.Prog).ToString
            wkSubp = .Item(Entity.Pedido.Subp).ToString
            wkProy = .Item(Entity.Pedido.Proy).ToString
            wkAct = .Item(Entity.Pedido.Act).ToString
            wkObra = .Item(Entity.Pedido.Obra).ToString
            wkUbGeo = .Item(Entity.Pedido.Ub_Geo).ToString
            wkFteFin = .Item(Entity.Pedido.Fte_Fin).ToString
        End With

        'Set Financial
        Dim lp As Integer = 0
        For Each wkDrF As DataRow In wkDtQ.Select("", Entity.PedidoDetalles.Financiero)
            Select Case lp
                Case 0
                    cu.setReportText(rpt, "txtProg01", wkProg)
                    cu.setReportText(rpt, "txtSubp01", wkSubp)
                    cu.setReportText(rpt, "txtProy01", wkProy)
                    cu.setReportText(rpt, "txtAct01", wkAct)
                    cu.setReportText(rpt, "txtObra01", wkObra)
                    cu.setReportText(rpt, "txtRengron01", wkDrF.Item(Entity.PedidoDetalles.Financiero))
                    cu.setReportText(rpt, "txtUB01", wkUbGeo)
                    cu.setReportText(rpt, "txtFte01", wkFteFin)
                    cu.setReportTextNum(rpt, "txtMonto01", wkDrF.Item(Entity.PedidoDetalles.Estimado))
                Case 1
                    cu.setReportText(rpt, "txtProg02", wkProg)
                    cu.setReportText(rpt, "txtSubp02", wkSubp)
                    cu.setReportText(rpt, "txtProy02", wkProy)
                    cu.setReportText(rpt, "txtAct02", wkAct)
                    cu.setReportText(rpt, "txtObra02", wkObra)
                    cu.setReportText(rpt, "txtRengron02", wkDrF.Item(Entity.PedidoDetalles.Financiero))
                    cu.setReportText(rpt, "txtUB02", wkUbGeo)
                    cu.setReportText(rpt, "txtFte02", wkFteFin)
                    cu.setReportTextNum(rpt, "txtMonto02", wkDrF.Item(Entity.PedidoDetalles.Estimado))
                Case 2
                    cu.setReportText(rpt, "txtProg03", wkProg)
                    cu.setReportText(rpt, "txtSubp03", wkSubp)
                    cu.setReportText(rpt, "txtProy03", wkProy)
                    cu.setReportText(rpt, "txtAct03", wkAct)
                    cu.setReportText(rpt, "txtObra03", wkObra)
                    cu.setReportText(rpt, "txtRengron03", wkDrF.Item(Entity.PedidoDetalles.Financiero))
                    cu.setReportText(rpt, "txtUB03", wkUbGeo)
                    cu.setReportText(rpt, "txtFte03", wkFteFin)
                    cu.setReportTextNum(rpt, "txtMonto03", wkDrF.Item(Entity.PedidoDetalles.Estimado))
                Case 3
                    cu.setReportText(rpt, "txtProg04", wkProg)
                    cu.setReportText(rpt, "txtSubp04", wkSubp)
                    cu.setReportText(rpt, "txtProy04", wkProy)
                    cu.setReportText(rpt, "txtAct04", wkAct)
                    cu.setReportText(rpt, "txtObra04", wkObra)
                    cu.setReportText(rpt, "txtRengron04", wkDrF.Item(Entity.PedidoDetalles.Financiero))
                    cu.setReportText(rpt, "txtUB04", wkUbGeo)
                    cu.setReportText(rpt, "txtFte04", wkFteFin)
                    cu.setReportTextNum(rpt, "txtMonto04", wkDrF.Item(Entity.PedidoDetalles.Estimado))
                Case 4
                    cu.setReportText(rpt, "txtProg05", wkProg)
                    cu.setReportText(rpt, "txtSubp05", wkSubp)
                    cu.setReportText(rpt, "txtProy05", wkProy)
                    cu.setReportText(rpt, "txtAct05", wkAct)
                    cu.setReportText(rpt, "txtObra05", wkObra)
                    cu.setReportText(rpt, "txtRengron05", wkDrF.Item(Entity.PedidoDetalles.Financiero))
                    cu.setReportText(rpt, "txtUB05", wkUbGeo)
                    cu.setReportText(rpt, "txtFte05", wkFteFin)
                    cu.setReportTextNum(rpt, "txtMonto05", wkDrF.Item(Entity.PedidoDetalles.Estimado))
                Case Else
            End Select

            lp = lp + 1

        Next
        cu.setReportTextNum(rpt, "txtMontoTotal", wkQTotal)


        'Insert Brank Rows
        Dim wkRowCnt As Integer = DispMax - ds.Tables(0).Rows.Count
        For lp = 1 To wkRowCnt
            ds.Tables(0).Rows.Add(ds.Tables(0).NewRow)
            If lp = 1 Then
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item("DATA03") = "---------- ULTIMA LINEA ----------"
            End If
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item("INT01") = ds.Tables(0).Rows.Count.ToString
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item("DATA06") = "1"
        Next

        'Data Copy
        For lp = 0 To DispMax - 1
            ds.Tables(0).Rows.Add(ds.Tables(0).Rows(lp).ItemArray)
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item("DATA06") = "2"
        Next
        For lp = 0 To DispMax - 1
            ds.Tables(0).Rows.Add(ds.Tables(0).Rows(lp).ItemArray)
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item("DATA06") = "3"
        Next
        For lp = 0 To DispMax - 1
            ds.Tables(0).Rows.Add(ds.Tables(0).Rows(lp).ItemArray)
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item("DATA06") = "4"
        Next
        For lp = 0 To DispMax - 1
            ds.Tables(0).Rows.Add(ds.Tables(0).Rows(lp).ItemArray)
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item("DATA06") = "5"
        Next

        'Set Report Data
        rpt.SetDataSource(ds)

        'Direct Print
        If isDirectPrint Then
            rpt.PrintToPrinter(1, False, 0, 0)
            Exit Sub
        End If

        Using Frm As New Preview
            Frm.Report = rpt
            Frm.ShowDialog()
        End Using

    End Sub

#End Region

End Class
