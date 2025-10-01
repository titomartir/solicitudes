Public Class Settings

#Region "Singleton"

    'Instance
    Private Shared _Instance As Settings = New Settings()

    'GetInstance
    Public Shared ReadOnly Property GetInstance() As Settings

        Get
            'Create Instance
            If IsDBNull(_Instance) Then

                _Instance = New Settings()

            End If

            Return _Instance

        End Get

    End Property

    'constructor
    Private Sub New()

        SettingFile = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\" & FileName

        SettingData = New DataTable
        SettingData.Columns.Add("Key", GetType(System.String))
        SettingData.Columns.Add("Data", GetType(System.String))

    End Sub

#End Region

#Region "Difinition"

    Const FileName As String = "Settings.ini"
    Private SettingFile As String = ""
    Private SettingData As DataTable = Nothing

#End Region

#Region "Settings"

    ''' <summary>
    ''' Set Setting Data for Common Project
    ''' </summary>
    Public Sub SetSetting(ByVal Name As String, ByVal value As Object)
        'My.Settings(Name) = value
        'My.Settings.Save()

        Dim HitFlg As Boolean = False

        For Each dr As DataRow In SettingData.Rows
            If Name = dr.Item("Key").ToString Then
                dr.Item("Data") = value
                HitFlg = True
                Exit For
            End If
        Next

        If HitFlg = False Then
            Dim dr As DataRow = SettingData.NewRow
            dr.Item("Key") = Name
            dr.Item("Data") = value
            SettingData.Rows.Add(dr)
        End If

        'WriteSettingFile
        Me.WriteSettingFile()

    End Sub

    ''' <summary>
    ''' Save Setting
    ''' </summary>
    Public Sub SaveSetting()

        'WriteSettingFile
        Me.WriteSettingFile()

    End Sub

    ''' <summary>
    ''' Get Setting Data from Common Project O Setting File
    ''' </summary>
    Public Function GetSetting(ByVal Name As String) As String
        'Return My.Settings(Name).ToString

        Dim HitFlg As Boolean = False
        Dim wkData As String = ""

        'ReadSettingFile
        If SettingData.Rows.Count = 0 Then
            Me.ReadSettingFile()
        End If

        'Get From Srtting File
        For Each dr As DataRow In SettingData.Rows
            If Name = dr.Item("Key").ToString Then
                wkData = dr.Item("Data").ToString
                HitFlg = True
                Exit For
            End If
        Next

        'Get From App Data
        If HitFlg = False Then
            wkData = My.Settings(Name).ToString()
        End If

        Return wkData

    End Function

    ''' <summary>
    ''' Reset Setting Data for Common Project
    ''' </summary>
    Public Sub ResetSetting()
        'My.Settings.Reset()

        'File Delete
        If IO.File.Exists(SettingFile) Then
            IO.File.Delete(SettingFile)
        End If

        'Delete Setting Data
        SettingData.Clear()

        'ReadSettingFile
        Me.ReadSettingFile()

    End Sub

    ''' <summary>
    ''' Reload Setting Data for Common Project
    ''' </summary>
    Public Sub ReloadSetting()
        'My.Settings.Reload()

        'ReadSettingFile
        Me.ReadSettingFile()
    End Sub

    ''' <summary>
    ''' Upgrade Setting Data for Common Project
    ''' </summary>
    Public Sub UpgradeSetting()
        'My.Settings.Upgrade()
    End Sub

#End Region

#Region "File I/O"

    ''' <summary>
    ''' ReadSettingFile
    ''' </summary>
    Private Sub ReadSettingFile()

        'File Exist Check
        If Not IO.File.Exists(SettingFile) Then
            Exit Sub
        End If

        Try
            'Create StreamReader
            Using sr As New IO.StreamReader(SettingFile)

                Dim wkData As String = ""
                While Not sr.EndOfStream
                    'File Read
                    wkData = sr.ReadLine

                    If InStr(wkData, ",") > 0 Then
                        Dim dr As DataRow = SettingData.NewRow
                        dr.Item("Key") = wkData.Split(CChar(","))(0)
                        dr.Item("Data") = wkData.Split(CChar(","))(1)
                        SettingData.Rows.Add(dr)
                    End If

                End While

                'File Close
                sr.Close()
                sr.Dispose()

            End Using

        Catch ex As Exception
            MessageBoxManager.ShowError(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' WriteSettingFile
    ''' </summary>
    Private Sub WriteSettingFile()

        Try
            'Create StreamWriter (Create Mode)
            Using sw As New IO.StreamWriter(SettingFile, False)

                Dim wkData As String = ""
                For Each dr As DataRow In SettingData.Rows
                    wkData = dr.Item("Key").ToString & "," & dr.Item("Data").ToString

                    'File Write
                    sw.WriteLine(wkData)
                Next

                'File Close
                sw.Close()
                sw.Dispose()

            End Using
        Catch ex As Exception
            MessageBoxManager.ShowError(ex.Message)
        End Try

    End Sub

#End Region

End Class
