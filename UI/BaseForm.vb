Imports System.Security.Permissions

Public Class BaseForm

#Region "Property"

    ''' <summary>
    ''' FormTitle
    ''' </summary>
    Public WriteOnly Property FormTitle As String
        Set(value As String)
            lblFormTitle.Text = value
        End Set
    End Property

#End Region

#Region "Form Event"

    ''' <summary>
    ''' Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AcceptButton = Nothing
        Me.KeyPreview = True

        'Set Form Text
        Me.Text = HospitalConst.SYSTEM_NAME & "   -- " & HospitalConst.HOSPITAL_NAME & " --"

    End Sub

    ''' <summary>
    ''' Form Key Down
    ''' (Enter Key To Tab Key)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BaseForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Enter Key Press   (Escape Ctlr+Enter,Alt+Enter)
        If (e.KeyCode = Keys.Enter) AndAlso
        Not e.Alt AndAlso Not e.Control Then
            'Send Tab Key
            Me.ProcessTabKey(Not e.Shift)

            e.Handled = True
            e.SuppressKeyPress = True
        End If

    End Sub

#End Region

#Region "Disable Alt+F4"

    <SecurityPermission(SecurityAction.Demand,
    Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_CLOSE As Long = &HF060L

        If m.Msg = WM_SYSCOMMAND AndAlso
            (m.WParam.ToInt64() And &HFFF0L) = SC_CLOSE Then
            Return
        End If

        MyBase.WndProc(m)
    End Sub

#End Region

End Class