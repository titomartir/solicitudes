Public Class Login

#Region "difinition"

    Private TITLE As String = "Login"
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

        Me.Width = 650
        Me.Height = 400

    End Sub

#End Region

#Region "Button Event"

    ''' <summary>
    ''' Login Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim PWD As String = Me.txtPassword.Text

        'Input Check

        If String.IsNullOrEmpty(PWD) Then
            MessageBoxManager.ShowWorning("Por favor, configure la Contraseña")
            Me.txtPassword.Focus()
            Exit Sub
        End If

        'User Not Exist
        If HospitalConst.MAINTENANCE_PASSWORD <> PWD Then
            MessageBoxManager.ShowWorning("No puedo Login")

            Me.txtPassword.Clear()
            Me.txtPassword.Focus()
            Exit Sub
        End If

        'Login Success
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    ''' <summary>
    ''' Cancel Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        'Login Success
        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

#End Region

End Class