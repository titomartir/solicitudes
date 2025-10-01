Public Class MainMenu

#Region "difinition"

    Private TITLE As String = "Menú"
    Private cu As CommonUtility = CommonUtility.GetInstance

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

        ' Get Precess Name
        Dim stThisProcess As String = Process.GetCurrentProcess().ProcessName

        ' Check Apprication Already Running
        If Process.GetProcessesByName(stThisProcess).Length > 1 Then

            MessageBoxManager.ShowError("Ya está comenzado")

            'End System
            End
        End If

#If DEBUG Then
        HospitalConst.DB_SERVER = HospitalConst.DB_SERVER_DEBUG
        MessageBoxManager.ShowWorning("### DEBUG MODE ###" & vbCrLf &
                                      "Si no es un administrador del sistema, " & vbCrLf &
                                      "comuníquese con el administrador del sistema.")
#End If

    End Sub

#End Region

#Region "Button Event"

    ''' <summary>
    ''' End Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click

        'Show Message
        If MessageBoxManager.ShowQuestionOkCancel("¿Quieres terminarlo?") = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        'Save Settings
        cu.SaveSetting()

        'System End
        Me.Close()

    End Sub

    ''' <summary>
    ''' Clear Settings
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClearSettings_Click(sender As Object, e As EventArgs) Handles btnClearSettings.Click

        'Show Message
        If MessageBoxManager.ShowQuestionOkCancel("¿Desea restablecer la configuración al valor inicial?") = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        cu.ResetSetting()
        MessageBoxManager.ShowNormal("Configuración cambiada al valor inicial")
    End Sub

    ''' <summary>
    ''' RequisicionList Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRequisicionList_Click(sender As Object, e As EventArgs) Handles btnRequisicionList.Click

        Using Frm As New RequisicionList
            Me.Hide()
            Frm.ShowDialog()
            Me.Show()
        End Using

    End Sub

    ''' <summary>
    ''' AddRequisicion Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddRequisicion_Click(sender As Object, e As EventArgs) Handles btnAddRequisicion.Click

        Using Frm As New EditRequisicion
            Me.Hide()
            Frm.ShowDialog()
            Frm.NumeroDocu = ""
            Frm.Anio = ""
            Frm.DispMode = False
            Frm.EditMode = False
            Me.Show()
        End Using

    End Sub

    ''' <summary>
    ''' PedidoList Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPedidoList_Click(sender As Object, e As EventArgs) 

        Using Frm As New PedidoList
            Me.Hide()
            Frm.ShowDialog()
            Me.Show()
        End Using

    End Sub

    ''' <summary>
    ''' AddPedido Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddPedido_Click(sender As Object, e As EventArgs) 

        Using Frm As New EditPedido
            Me.Hide()
            Frm.ShowDialog()
            Frm.NumeroDocu = ""
            Frm.Anio = ""
            Frm.DispMode = False
            Frm.EditMode = False
            Me.Show()
        End Using

    End Sub

    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click

        Using Frm As New Login
            Me.Hide()
            If Frm.ShowDialog() <> DialogResult.OK Then
                Me.Show()
                Exit Sub
            End If
        End Using

        Using Frm As New MaintenanceMenu
            Frm.ShowDialog()
            Me.Show()
        End Using

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

#End Region

End Class
