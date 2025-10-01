Imports System.Drawing

Public Class CommonUtility

    Private _Settings As Settings = Settings.GetInstance

#Region "Singleton"

    'Instance
    Private Shared _Instance As CommonUtility = New CommonUtility()

    'GetInstance
    Public Shared ReadOnly Property GetInstance() As CommonUtility

        Get
            'Create Instance
            If IsDBNull(_Instance) Then

                _Instance = New CommonUtility()

            End If

            Return _Instance

        End Get

    End Property

    'constructor
    Private Sub New()

    End Sub

#End Region

#Region "Date"

    ''' <summary>
    ''' Format for Date to DD/MM/YYYY
    ''' 
    ''' Target Format
    ''' D/M/YYYY
    ''' D/M/YYYY HH:MI:SS
    ''' D/MM/YYYY
    ''' D/MM/YYYY HH:MI:SS
    ''' DD/MM/YYYY HH:MI:SS
    ''' DMYYYY
    ''' DMYYYY HHMISS
    ''' DMMYYYY
    ''' DMMYYYY HHMISS
    ''' DDMMYYYY HHMISS
    ''' 
    ''' Not Target
    ''' DDMYYYY HHMISS
    ''' DD/M/YYYY HH:MI:SS
    ''' etc..
    ''' </summary>
    ''' <param name="inDate"></param>
    ''' <returns>Error:Empty</returns>
    Public Function SetFormatDate(ByVal inDate As Object) As String

        Dim wkDate As String = inDate.ToString.Split(CChar(" "))(0).Replace("/", "")
        Dim retDate As String = ""

        If String.IsNullOrEmpty(wkDate) Then
            Return retDate
        End If

        If Not IsNumeric(wkDate) Then
            Return retDate
        End If

        Select Case wkDate.Length
            Case 6
                retDate = "0" & Mid(wkDate, 1, 1) & "/0" & Mid(wkDate, 2, 1) & "/" & Mid(wkDate, 3, 4)
            Case 7
                If InStr(inDate.ToString, "/") = 2 Then
                    retDate = "0" & Mid(wkDate, 1, 1) & "/" & Mid(wkDate, 2, 2) & "/" & Mid(wkDate, 4, 4)
                ElseIf InStr(inDate.ToString, "/") = 3 Then
                    retDate = Mid(wkDate, 1, 2) & "/0" & Mid(wkDate, 3, 1) & "/" & Mid(wkDate, 4, 4)
                Else
                End If
            Case 8
                retDate = Mid(wkDate, 1, 2) & "/" & Mid(wkDate, 3, 2) & "/" & Mid(wkDate, 5, 4)
            Case Else
        End Select

        Return retDate

    End Function

    ''' <summary>
    ''' Format for Date (For DataBase) to YYYY/MM/DD
    ''' 
    ''' Target Format
    ''' D/M/YYYY
    ''' D/M/YYYY HH:MI:SS
    ''' D/MM/YYYY
    ''' D/MM/YYYY HH:MI:SS
    ''' DD/MM/YYYY HH:MI:SS
    ''' DMYYYY
    ''' DMYYYY HHMISS
    ''' DMMYYYY
    ''' DMMYYYY HHMISS
    ''' DDMMYYYY HHMISS
    ''' 
    ''' Not Target
    ''' DDMYYYY HHMISS
    ''' DD/M/YYYY HH:MI:SS
    ''' etc..
    ''' </summary>
    ''' <param name="inDate"></param>
    ''' <returns>Error:Empty</returns>
    Public Function SetFormatDateForDB(ByVal inDate As Object) As String

        Dim wkDate As String = inDate.ToString.Split(CChar(" "))(0).Replace("/", "")
        Dim retDate As String = ""

        If String.IsNullOrEmpty(wkDate) Then
            Return retDate
        End If

        If Not IsNumeric(wkDate) Then
            Return retDate
        End If

        Select Case wkDate.Length
            Case 6
                retDate = Mid(wkDate, 3, 4) & "/0" & Mid(wkDate, 2, 1) & "/" & "0" & Mid(wkDate, 1, 1)
            Case 7
                If InStr(inDate.ToString, "/") = 2 Then
                    retDate = Mid(wkDate, 4, 4) & "/" & Mid(wkDate, 2, 2) & "/" & "0" & Mid(wkDate, 1, 1)
                ElseIf InStr(inDate.ToString, "/") = 3 Then
                    retDate = Mid(wkDate, 4, 4) & "/0" & Mid(wkDate, 3, 1) & "/" & Mid(wkDate, 1, 2)
                Else
                End If
            Case 8
                retDate = Mid(wkDate, 5, 4) & "/" & Mid(wkDate, 3, 2) & "/" & Mid(wkDate, 1, 2)
            Case Else
        End Select

        Return retDate

    End Function

    ''' <summary>
    ''' Format for Date (For Report) to Regional(jueves, 30 de noviembre de 2017)
    ''' 
    ''' Target Format
    ''' D/M/YYYY
    ''' D/M/YYYY HH:MI:SS
    ''' D/MM/YYYY
    ''' D/MM/YYYY HH:MI:SS
    ''' DD/MM/YYYY HH:MI:SS
    ''' DMYYYY
    ''' DMYYYY HHMISS
    ''' DMMYYYY
    ''' DMMYYYY HHMISS
    ''' DDMMYYYY HHMISS
    ''' 
    ''' Not Target
    ''' DDMYYYY HHMISS
    ''' DD/M/YYYY HH:MI:SS
    ''' etc..
    ''' </summary>
    ''' <param name="inDate"></param>
    ''' <returns>Error:Empty</returns>
    Public Function SetFormatDateForReport(ByVal inDate As Object) As String

        Dim ci As New System.Globalization.CultureInfo("es-ES")

        Return CDate(Me.SetFormatDateForDB(inDate)).ToString("D", ci)

    End Function

    ''' <summary>
    ''' Get Years Old for Years
    ''' 
    ''' Target Format
    ''' D/M/YYYY
    ''' D/M/YYYY HH:MI:SS
    ''' D/MM/YYYY
    ''' D/MM/YYYY HH:MI:SS
    ''' DD/MM/YYYY
    ''' DD/MM/YYYY HH:MI:SS
    ''' DMYYYY
    ''' DMYYYY HH:MI:SS
    ''' DMMYYYY
    ''' DMMYYYY HH:MI:SS
    ''' DDMMYYYY
    ''' DDMMYYYY HHMISS
    ''' </summary>
    ''' <param name="birthday"></param>
    ''' <returns>Error:-1</returns>
    Public Function GetYearsOldForYears(ByVal birthday As Object) As Integer

        Dim wkYears As Integer = 0
        Dim wkMonths As Integer = 0
        Dim wkDays As Integer = 0

        If GetYearsOld(birthday, wkYears, wkMonths, wkDays) <> HospitalConst.DB_RET.NML Then
            Return -1
        End If

        Return wkYears

    End Function

    ''' <summary>
    ''' Get Years Old for Months
    ''' 
    ''' Target Format
    ''' D/M/YYYY
    ''' D/M/YYYY HH:MI:SS
    ''' D/MM/YYYY
    ''' D/MM/YYYY HH:MI:SS
    ''' DD/MM/YYYY
    ''' DD/MM/YYYY HH:MI:SS
    ''' DMYYYY
    ''' DMYYYY HH:MI:SS
    ''' DMMYYYY
    ''' DMMYYYY HH:MI:SS
    ''' DDMMYYYY
    ''' DDMMYYYY HHMISS
    ''' </summary>
    ''' <param name="birthday"></param>
    ''' <returns>Error:-1</returns>
    Public Function GetYearsOldForMonths(ByVal birthday As Object) As Integer

        Dim wkYears As Integer = 0
        Dim wkMonths As Integer = 0
        Dim wkDays As Integer = 0

        If GetYearsOld(birthday, wkYears, wkMonths, wkDays) <> HospitalConst.DB_RET.NML Then
            Return -1
        End If

        Return wkMonths

    End Function

    ''' <summary>
    ''' Get Years Old for Days
    ''' 
    ''' Target Format
    ''' D/M/YYYY
    ''' D/M/YYYY HH:MI:SS
    ''' D/MM/YYYY
    ''' D/MM/YYYY HH:MI:SS
    ''' DD/MM/YYYY
    ''' DD/MM/YYYY HH:MI:SS
    ''' DMYYYY
    ''' DMYYYY HH:MI:SS
    ''' DMMYYYY
    ''' DMMYYYY HH:MI:SS
    ''' DDMMYYYY
    ''' DDMMYYYY HHMISS
    ''' </summary>
    ''' <param name="birthday"></param>
    ''' <returns>Error:-1</returns>
    Public Function GetYearsOldForDays(ByVal birthday As Object) As Integer

        Dim wkYears As Integer = 0
        Dim wkMonths As Integer = 0
        Dim wkDays As Integer = 0

        If GetYearsOld(birthday, wkYears, wkMonths, wkDays) <> HospitalConst.DB_RET.NML Then
            Return -1
        End If

        Return wkDays

    End Function

    ''' <summary>
    ''' Get Years Old
    ''' 
    ''' Target Format
    ''' D/M/YYYY
    ''' D/M/YYYY HH:MI:SS
    ''' D/MM/YYYY
    ''' D/MM/YYYY HH:MI:SS
    ''' DD/MM/YYYY
    ''' DD/MM/YYYY HH:MI:SS
    ''' DMYYYY
    ''' DMYYYY HH:MI:SS
    ''' DMMYYYY
    ''' DMMYYYY HH:MI:SS
    ''' DDMMYYYY
    ''' DDMMYYYY HHMISS
    ''' </summary>
    ''' <param name="birthday"></param>
    ''' <returns>Error:-1(DB_RET.ERR)</returns>
    Public Function GetYearsOld(ByVal birthday As Object,
                                ByRef years As Integer,
                                ByRef months As Integer,
                                ByRef days As Integer) As HospitalConst.DB_RET

        Dim wkDate As String = Me.SetFormatDate(birthday)

        If wkDate.Length <> 10 Then
            Return HospitalConst.DB_RET.ERR
        End If

        Dim wkBirthYears As Integer = CInt(wkDate.Split(CChar("/"))(2))
        Dim wkBirthMonths As Integer = CInt(wkDate.Split(CChar("/"))(1))
        Dim wkBirthDays As Integer = CInt(wkDate.Split(CChar("/"))(0))

        Dim wkYears As Integer = Date.Today.Year - wkBirthYears
        Dim wkMonths As Integer = Date.Today.Month - wkBirthMonths
        Dim wkDays As Integer = Date.Today.Day - wkBirthDays

        If wkDays < 0 Then
            Select Case Date.Today.Month
                Case 2
                    wkDays = wkDays + 28
                Case 4, 6, 9, 11
                    wkDays = wkDays + 30
                Case Else
                    wkDays = wkDays + 31
            End Select
            If wkDays < 0 Then
                wkDays = 0
            End If
            wkMonths = wkMonths - 1
        End If

        If wkMonths < 0 Then
            wkMonths = wkMonths + 12
            wkYears = wkYears - 1
        End If

        years = wkYears
        months = wkMonths
        days = wkDays

        Return HospitalConst.DB_RET.NML

    End Function


    ''' <summary>
    ''' Get Years Old for Years
    ''' 
    ''' Target Format
    ''' D/M/YYYY
    ''' D/M/YYYY HH:MI:SS
    ''' D/MM/YYYY
    ''' D/MM/YYYY HH:MI:SS
    ''' DD/MM/YYYY
    ''' DD/MM/YYYY HH:MI:SS
    ''' DMYYYY
    ''' DMYYYY HH:MI:SS
    ''' DMMYYYY
    ''' DMMYYYY HH:MI:SS
    ''' DDMMYYYY
    ''' DDMMYYYY HHMISS
    ''' </summary>
    ''' <param name="birthday"></param>
    ''' <returns>Error:-1</returns>
    Public Function GetYearsOldForYears(ByVal birthday As Object,
                                        ByVal targetDay As Object) As Integer

        Dim wkYears As Integer = 0
        Dim wkMonths As Integer = 0
        Dim wkDays As Integer = 0

        If GetYearsOld(birthday, targetDay, wkYears, wkMonths, wkDays) <> HospitalConst.DB_RET.NML Then
            Return -1
        End If

        Return wkYears

    End Function

    ''' <summary>
    ''' Get Years Old for Months
    ''' 
    ''' Target Format
    ''' D/M/YYYY
    ''' D/M/YYYY HH:MI:SS
    ''' D/MM/YYYY
    ''' D/MM/YYYY HH:MI:SS
    ''' DD/MM/YYYY
    ''' DD/MM/YYYY HH:MI:SS
    ''' DMYYYY
    ''' DMYYYY HH:MI:SS
    ''' DMMYYYY
    ''' DMMYYYY HH:MI:SS
    ''' DDMMYYYY
    ''' DDMMYYYY HHMISS
    ''' </summary>
    ''' <param name="birthday"></param>
    ''' <returns>Error:-1</returns>
    Public Function GetYearsOldForMonths(ByVal birthday As Object,
                                         ByVal targetDay As Object) As Integer

        Dim wkYears As Integer = 0
        Dim wkMonths As Integer = 0
        Dim wkDays As Integer = 0

        If GetYearsOld(birthday, targetDay, wkYears, wkMonths, wkDays) <> HospitalConst.DB_RET.NML Then
            Return -1
        End If

        Return wkMonths

    End Function

    ''' <summary>
    ''' Get Years Old for Days
    ''' 
    ''' Target Format
    ''' D/M/YYYY
    ''' D/M/YYYY HH:MI:SS
    ''' D/MM/YYYY
    ''' D/MM/YYYY HH:MI:SS
    ''' DD/MM/YYYY
    ''' DD/MM/YYYY HH:MI:SS
    ''' DMYYYY
    ''' DMYYYY HH:MI:SS
    ''' DMMYYYY
    ''' DMMYYYY HH:MI:SS
    ''' DDMMYYYY
    ''' DDMMYYYY HHMISS
    ''' </summary>
    ''' <param name="birthday"></param>
    ''' <returns>Error:-1</returns>
    Public Function GetYearsOldForDays(ByVal birthday As Object,
                                       ByVal targetDay As Object) As Integer

        Dim wkYears As Integer = 0
        Dim wkMonths As Integer = 0
        Dim wkDays As Integer = 0

        If GetYearsOld(birthday, targetDay, wkYears, wkMonths, wkDays) <> HospitalConst.DB_RET.NML Then
            Return -1
        End If

        Return wkDays

    End Function

    ''' <summary>
    ''' Get Years Old
    ''' 
    ''' Target Format
    ''' D/M/YYYY
    ''' D/M/YYYY HH:MI:SS
    ''' D/MM/YYYY
    ''' D/MM/YYYY HH:MI:SS
    ''' DD/MM/YYYY
    ''' DD/MM/YYYY HH:MI:SS
    ''' DMYYYY
    ''' DMYYYY HH:MI:SS
    ''' DMMYYYY
    ''' DMMYYYY HH:MI:SS
    ''' DDMMYYYY
    ''' DDMMYYYY HHMISS
    ''' </summary>
    ''' <param name="birthday"></param>
    ''' <returns>Error:-1(DB_RET.ERR)</returns>
    Public Function GetYearsOld(ByVal birthday As Object,
                                ByVal targetDay As Object,
                                ByRef years As Integer,
                                ByRef months As Integer,
                                ByRef days As Integer) As HospitalConst.DB_RET

        Dim wkDate As String = Me.SetFormatDate(birthday)
        If wkDate.Length <> 10 Then
            Return HospitalConst.DB_RET.ERR
        End If

        Dim wkTargetDate As String = Me.SetFormatDate(targetDay)
        If wkTargetDate.Length <> 10 Then
            Return HospitalConst.DB_RET.ERR
        End If

        Dim wkBirthYears As Integer = CInt(wkDate.Split(CChar("/"))(2))
        Dim wkBirthMonths As Integer = CInt(wkDate.Split(CChar("/"))(1))
        Dim wkBirthDays As Integer = CInt(wkDate.Split(CChar("/"))(0))
        Dim wkTargetYears As Integer = CInt(wkTargetDate.Split(CChar("/"))(2))
        Dim wkTargetMonths As Integer = CInt(wkTargetDate.Split(CChar("/"))(1))
        Dim wkTargetDays As Integer = CInt(wkTargetDate.Split(CChar("/"))(0))

        Dim wkYears As Integer = wkTargetYears - wkBirthYears
        Dim wkMonths As Integer = wkTargetMonths - wkBirthMonths
        Dim wkDays As Integer = wkTargetDays - wkBirthDays

        If wkDays < 0 Then
            Select Case wkTargetMonths
                Case 2
                    wkDays = wkDays + 28
                Case 4, 6, 9, 11
                    wkDays = wkDays + 30
                Case Else
                    wkDays = wkDays + 31
            End Select
            If wkDays < 0 Then
                wkDays = 0
            End If
            wkMonths = wkMonths - 1
        End If

        If wkMonths < 0 Then
            wkMonths = wkMonths + 12
            wkYears = wkYears - 1
        End If

        years = wkYears
        months = wkMonths
        days = wkDays

        Return HospitalConst.DB_RET.NML

    End Function

#End Region

#Region "Image"

    ''' <summary>
    ''' Convert Binary To Image
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <returns></returns>
    Public Function ConvertBinToImage(ByVal Value As Object) As Image

        Try
            If Value Is Nothing OrElse Value Is DBNull.Value Then
                Return Nothing
            End If

            Dim imgConv As New ImageConverter

            Return DirectCast(imgConv.ConvertFrom(Value), Image)

        Catch ex As Exception
            MessageBoxManager.ShowError("Se produjo un error")
            Return Nothing
        End Try

    End Function

    ''' <summary>
    ''' Convert Image To Binary
    ''' </summary>
    ''' <param name="img"></param>
    ''' <returns></returns>
    Public Function ConvertImageToBin(ByVal img As Image) As Object

        Try
            If img Is Nothing Then
                Return Nothing
            End If

            Dim imgConv As New ImageConverter

            Return imgConv.ConvertTo(img, GetType(System.Byte()))

        Catch ex As Exception
            MessageBoxManager.ShowError("Se produjo un error")
            Return Nothing
        End Try

    End Function

#End Region

#Region "Report"

    ''' <summary>
    ''' Set CrystalReport Text
    ''' </summary>
    ''' <param name="Rpt"></param>
    ''' <param name="txt"></param>
    Public Sub setReportText(ByVal Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument,
                             ByVal id As String,
                             ByVal txt As Object)
        Rpt.DataDefinition.FormulaFields(id).Text = "'" & txt.ToString.Replace("'", "''") & "'"
    End Sub

    ''' <summary>
    ''' Set CrystalReport Text
    ''' </summary>
    ''' <param name="Rpt"></param>
    ''' <param name="txt"></param>
    Public Sub setReportTextNum(ByVal Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument,
                             ByVal id As String,
                             ByVal txt As Object)
        Rpt.DataDefinition.FormulaFields(id).Text = txt.ToString
    End Sub

#End Region

#Region "Settings"

    ''' <summary>
    ''' Set Setting Data for Common Project
    ''' </summary>
    Public Sub SetSetting(ByVal Name As String, ByVal value As Object)
        _Settings.SetSetting(Name, value)
    End Sub

    ''' <summary>
    ''' Save Setting File
    ''' </summary>
    Public Sub SaveSetting()
        _Settings.SaveSetting()
    End Sub

    ''' <summary>
    ''' Get Setting Data from Common Project
    ''' </summary>
    Public Function GetSetting(ByVal Name As String) As String
        Return _Settings.GetSetting(Name)
    End Function

    ''' <summary>
    ''' Reset Setting Data for Common Project
    ''' </summary>
    Public Sub ResetSetting()
        _Settings.ResetSetting()
    End Sub

    ''' <summary>
    ''' Reload Setting Data for Common Project
    ''' </summary>
    Public Sub ReloadSetting()
        _Settings.ReloadSetting()
    End Sub

    ''' <summary>
    ''' Upgrade Setting Data for Common Project
    ''' </summary>
    Public Sub UpgradeSetting()
        _Settings.UpgradeSetting()
    End Sub

#End Region

End Class
