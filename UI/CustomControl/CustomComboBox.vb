Imports System.ComponentModel

Public Class CustomComboBox
    Inherits ComboBox

    Dim _Index As Integer = -1

#Region "DispKind"

    Public Enum DispKind
        Code = 1
        Text = 2
        CodeText = 3
    End Enum

#End Region

#Region "Enabled Property"

    Private _Enabled As Boolean = True

    Public Property SetEnabled As Boolean
        Set(value As Boolean)
            _Enabled = value

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

#Region "SetComboData"

    Public Sub SetComboData(ByVal dtData As DataTable,
                             ByVal colCode As String,
                             ByVal colText As String,
                             Optional kind As DispKind = DispKind.CodeText,
                             Optional isMakeEmpty As Boolean = False)

        Dim dt As New DataTable
        dt.Columns.Add("code", GetType(System.String))
        dt.Columns.Add("text", GetType(System.String))
        dt.Columns.Add("codetext", GetType(System.String))

        If isMakeEmpty Then
            dt.Rows.Add(String.Empty, String.Empty, String.Empty)
        End If

        For Each dr As DataRow In dtData.Rows
            dt.Rows.Add(dr.Item(colCode), dr.Item(colText), dr.Item(colCode).ToString & ":" & dr.Item(colText).ToString)
        Next

        Select Case kind
            Case DispKind.Code
                Me.DisplayMember = "code"
                Me.ValueMember = "code"
            Case DispKind.Text
                Me.DisplayMember = "text"
                Me.ValueMember = "code"
            Case Else
                Me.DisplayMember = "codetext"
                Me.ValueMember = "code"
        End Select

        Me.DataSource = dt

        Me.SelectedIndex = -1

    End Sub

#End Region

#Region "Focus Event"

    Private Sub CustomComboBox_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating

        If Me.DataSource Is Nothing Then
            Me.Text = ""
            Exit Sub
        End If

        If _Enabled = False AndAlso Me.SelectedIndex <> _Index Then
            Me.SelectedIndex = _Index
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.Text) Then
            Me.SelectedIndex = -1
            Exit Sub
        End If

        Dim wkdT As DataTable = DirectCast(Me.DataSource, DataTable)
        Dim wkIndex As Integer

        For wkIndex = 0 To wkdT.Rows.Count - 1
            If UCase(wkdT.Rows(wkIndex).Item(Me.DisplayMember).ToString) = UCase(Me.Text) Then
                Exit For
            End If
        Next

        If wkIndex = wkdT.Rows.Count Then
            For wkIndex = 0 To wkdT.Rows.Count - 1
                If InStr(UCase(wkdT.Rows(wkIndex).Item(Me.DisplayMember).ToString), UCase(Me.Text)) > 0 Then
                    Exit For
                End If
            Next
        End If

        If wkIndex = wkdT.Rows.Count Then
            wkIndex = -1
        End If

        If wkIndex = -1 Then
            MessageBoxManager.ShowWorning("Sin datos relevantes")
            Me.Focus()
        Else
            Me.SelectedIndex = wkIndex
        End If

    End Sub

    Private Sub CustomComboBox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

        _Index = Me.SelectedIndex

        Me.SelectAll()

    End Sub

#End Region

#Region "DropDown Event"

    Private Sub CustomComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles Me.DropDownClosed
        If _Enabled = False AndAlso Me.SelectedIndex <> _Index Then
            Me.SelectedIndex = _Index
            Exit Sub
        End If
    End Sub

#End Region

#Region "Key Event"

    Private Sub CustomComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If _Enabled = False Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub CustomComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If _Enabled = False Then
            If e.Control And e.KeyCode = Keys.C Then
                Clipboard.SetText(Mid(Me.Text, Me.SelectionStart + 1, Me.SelectionLength))
            End If
            e.Handled = True
        End If
    End Sub

#End Region

End Class
