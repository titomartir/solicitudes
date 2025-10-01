Public Class CustomTextBox
    Inherits TextBox

#Region "TextType Property"

    Public Enum TextType
        Text = 0
        CodeText = 1
        DateText = 2
        TimeText = 3
        NumericText = 4
    End Enum

    Private _TextType As TextType = TextType.Text

    Public Property Type As TextType
        Set(value As TextType)
            _TextType = value

            Me.ImeMode = ImeMode.Disable

            Select Case value
                Case TextType.Text
                Case TextType.CodeText
                Case TextType.NumericText
                Case TextType.DateText
                    Me.MaxLength = 10
                Case TextType.TimeText
                    Me.MaxLength = 5
                Case Else
            End Select

        End Set
        Get
            Return _TextType
        End Get
    End Property

#End Region

#Region "Enabled Property"

    Private _Enabled As Boolean = True

    Public Property SetEnabled As Boolean
        Set(value As Boolean)
            _Enabled = value

            Me.ReadOnly = Not _Enabled
            Me.TabStop = _Enabled
            If _Enabled Then
                If _Requerido Then
                    Me.BackColor = Color.LemonChiffon
                Else
                    Me.BackColor = Color.White
                End If
            Else
                Me.BackColor = Color.LightGray
            End If

        End Set
        Get
            Return _Enabled
        End Get
    End Property

#End Region

#Region "Requerido Property"

    Private _Requerido As Boolean = False

    Public Property SetRequerido As Boolean
        Set(value As Boolean)
            _Requerido = value

            If _Enabled Then
                If _Requerido Then
                    Me.BackColor = Color.LemonChiffon
                Else
                    Me.BackColor = Color.White
                End If
            Else
                Me.BackColor = Color.LightGray
            End If

        End Set
        Get
            Return _Requerido
        End Get
    End Property

#End Region

#Region "Error Check Property"

    Private _ErrorCheck As Boolean = True

    Public Property ErrorCheck As Boolean
        Set(value As Boolean)
            _ErrorCheck = value
        End Set
        Get
            Return _ErrorCheck
        End Get
    End Property

#End Region

#Region "Focus Event"

    ''' <summary>
    ''' GotFocus
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CustomTextBox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.SelectAll()
    End Sub

    ''' <summary>
    ''' LostFocus
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CustomTextBox_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus

        If _Enabled = False Then
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.Text) Then
            Exit Sub
        End If

        Select Case _TextType
            Case TextType.Text

            Case TextType.CodeText

            Case TextType.DateText

                If Me.Text.Length = 0 Then
                    Exit Sub
                End If

                If IsDate(CommonUtility.GetInstance.SetFormatDateForDB(Me.Text)) Then
                    Me.Text = CommonUtility.GetInstance.SetFormatDate(Me.Text)
                Else
                    If _ErrorCheck Then
                        MessageBoxManager.ShowWorning("Valor inválido")
                        Me.Focus()
                        Exit Sub
                    End If
                End If

            Case TextType.TimeText

                Dim wkDate As String = Me.Text.Replace(":", "")

                If Not IsNumeric(wkDate) Then
                    If _ErrorCheck Then
                        MessageBoxManager.ShowWorning("Valor inválido (fecha)")
                        Me.Focus()
                        Exit Sub
                    End If
                End If

                Select Case InStr(Me.Text, ":")
                    Case 0, 2, 3
                    Case Else
                        If _ErrorCheck Then
                            MessageBoxManager.ShowWorning("Valor inválido (tiempo)")
                            Me.Focus()
                            Exit Sub
                        End If
                End Select

                Select Case wkDate.Length
                    Case 0
                        Me.Text = ""
                    Case 2
                        Select Case InStr(Me.Text, ":")
                            Case 2
                                Me.Text = "0" & Mid(wkDate, 1, 1) & ":0" & Mid(wkDate, 2, 1)
                            Case Else
                                If _ErrorCheck Then
                                    MessageBoxManager.ShowWorning("Valor inválido (tiempo)")
                                    Me.Focus()
                                    Exit Sub
                                End If
                        End Select
                    Case 3
                        Select Case InStr(Me.Text, ":")
                            Case 2
                                Me.Text = "0" & Mid(wkDate, 1, 1) & ":" & Mid(wkDate, 2, 2)
                            Case 3
                                Me.Text = Mid(wkDate, 1, 2) & ":0" & Mid(wkDate, 3, 1)
                            Case Else
                                If _ErrorCheck Then
                                    MessageBoxManager.ShowWorning("Valor inválido (tiempo)")
                                    Me.Focus()
                                    Exit Sub
                                End If
                        End Select
                    Case 4
                        Me.Text = Mid(wkDate, 1, 2) & ":" & Mid(wkDate, 3, 2)
                    Case Else
                        If _ErrorCheck Then
                            MessageBoxManager.ShowWorning("Valor inválido (tiempo)")
                            Me.Focus()
                            Exit Sub
                        End If
                End Select

            Case TextType.NumericText

                If Not IsNumeric(Me.Text) Then
                    If _ErrorCheck Then
                        MessageBoxManager.ShowWorning("Valor inválido (número)")
                        Me.Focus()
                        Exit Sub
                    End If
                End If

            Case Else

        End Select

    End Sub

#End Region

End Class
