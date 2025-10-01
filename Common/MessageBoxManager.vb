Public Class MessageBoxManager

    ''' <summary>
    ''' Show Normal Message
    ''' </summary>
    ''' <param name="msg"></param>
    Public Shared Sub ShowNormal(ByVal msg As String)
        MsgBox(msg, DirectCast(vbOKOnly + MsgBoxStyle.Information, MsgBoxStyle), HospitalConst.HOSPITAL_NAME)
    End Sub

    ''' <summary>
    ''' Show Worning Message
    ''' </summary>
    ''' <param name="msg"></param>
    Public Shared Sub ShowWorning(ByVal msg As String)
        MsgBox(msg, DirectCast(vbOKOnly + MsgBoxStyle.Exclamation, MsgBoxStyle), HospitalConst.HOSPITAL_NAME)
    End Sub

    ''' <summary>
    ''' Show Error Message
    ''' </summary>
    ''' <param name="msg"></param>
    Public Shared Sub ShowError(ByVal msg As String)
        MsgBox(msg, DirectCast(vbOKOnly + MsgBoxStyle.Critical, MsgBoxStyle), HospitalConst.HOSPITAL_NAME)
    End Sub

    ''' <summary>
    ''' Show Question Message (OkCancel)
    ''' </summary>
    ''' <param name="msg"></param>
    Public Shared Function ShowQuestionOkCancel(ByVal msg As String) As MsgBoxResult
        Return MsgBox(msg, DirectCast(vbOKCancel + MsgBoxStyle.Question, MsgBoxStyle), HospitalConst.HOSPITAL_NAME)
    End Function

    ''' <summary>
    ''' Show Question Message (YesNo)
    ''' </summary>
    ''' <param name="msg"></param>
    Public Shared Function ShowQuestionYesNo(ByVal msg As String) As MsgBoxResult
        Return MsgBox(msg, DirectCast(vbYesNo + MsgBoxStyle.Question, MsgBoxStyle), HospitalConst.HOSPITAL_NAME)
    End Function


    ''' <summary>
    ''' Show Question Message (YesNoCancel)
    ''' </summary>
    ''' <param name="msg"></param>
    Public Shared Function ShowQuestionYesNoCancel(ByVal msg As String) As MsgBoxResult
        Return MsgBox(msg, DirectCast(vbYesNoCancel + MsgBoxStyle.Question, MsgBoxStyle), HospitalConst.HOSPITAL_NAME)
    End Function

End Class
