Imports MySql.Data.MySqlClient

''' <summary>
''' DataBase access Control For MySQL
''' </summary>
Public MustInherit Class MySQLDataAccess
    Implements System.IDisposable

#Region "difinition"

    Private Con As MySqlConnection
    Private Trn As MySqlTransaction
    Private Cmd As MySqlCommand

#End Region

#Region "Property"

    ''' <summary>
    ''' Connection
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Connection As MySqlConnection
        Get
            Return Con
        End Get
    End Property

#End Region

#Region "Constructor"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Friend Sub New(ByVal DBName As String)

        If String.IsNullOrEmpty(DBName) Then
            Throw New Exception("DBName is empty")
        End If

        Con = Nothing

        'DB Open
        Open(DBName)
    End Sub

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Friend Sub New(ByRef Connection As MySqlConnection)

        If Con IsNot Nothing Then
            Throw New Exception("Connection is nothing")
        End If

        Con = Connection
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose

        'DB Close
        Close()

    End Sub

#End Region

#Region "DBConnect"

    ''' <summary>
    '''  DB Open
    ''' </summary>
    Private Sub Open(ByVal DBName As String)

        If Con IsNot Nothing Then
            Throw New Exception("Database already opened")
        End If

        Dim conString As String = "host=" & HospitalConst.DB_SERVER & "; " &
            "user=" & HospitalConst.DB_USER & "; " &
            "password=" & HospitalConst.DB_PASSWORD & "; " &
            "database=" & DBName & "; " &
            "Allow Zero Datetime=true"

        Con = New MySqlConnection(conString)

        'DB Open
        Con.Open()

        Cmd = New MySqlCommand

    End Sub


    ''' <summary>
    '''  DB Close
    ''' </summary>
    Private Sub Close()

        Cmd = Nothing

        If Con Is Nothing Then
            Exit Sub
        End If

        If Trn IsNot Nothing Then
            'Rollback
            Trn.Rollback()
        End If

        'DB Close
        Con.Close()

        Con = Nothing

    End Sub

#End Region

#Region "Transaction"

    ''' <summary>
    '''  BeginTransaction
    ''' </summary>
    Public Sub BeginTransaction()

        If Trn IsNot Nothing Then
            'RollBack
            RollBack()

            Throw New Exception("Transaction already started")
        End If

        ' BeginTransaction
        Trn = Con.BeginTransaction
    End Sub

    ''' <summary>
    '''  Connit
    ''' </summary>
    Public Sub Commit()

        If Trn Is Nothing Then
            Throw New Exception("Transaction not exist")
        End If

        ' Connit
        Trn.Commit()

        Trn = Nothing

    End Sub

    ''' <summary>
    '''  RollBack
    ''' </summary>
    Public Sub RollBack()

        If Trn Is Nothing Then
            Throw New Exception("Transaction not exist")
        End If

        ' RollBack
        Trn.Rollback()

        Trn = Nothing

    End Sub

#End Region

#Region "Query"

    ''' <summary>
    '''  ExecuteQuery
    ''' </summary>
    Friend Function ExecuteQuery(ByVal SQL As String, ByRef dtRet As DataTable) As HospitalConst.DB_RET

        Try
            dtRet = New DataTable

            Cmd.Connection = Con
            Cmd.CommandText = SQL

            Dim da As New MySqlDataAdapter(Cmd)
            da.Fill(dtRet)

        Catch ex As Exception
            Return HospitalConst.DB_RET.ERR
        End Try

        Return HospitalConst.DB_RET.NML

    End Function

    ''' <summary>
    '''  ExecuteNonQuery
    ''' </summary>
    Friend Function ExecuteNonQuery(ByVal SQL As String) As HospitalConst.DB_RET

        Try
            Cmd.Connection = Con
            Cmd.CommandText = SQL
            Return DirectCast(Cmd.ExecuteNonQuery(), HospitalConst.DB_RET)

        Catch ex As Exception
            Return HospitalConst.DB_RET.ERR
        End Try

    End Function

#End Region

#Region "Data Bind"

    Friend Sub ClearParam()

        If Cmd Is Nothing Then
            Throw New Exception("Command Not Exist")
        End If

        'Clear Parameters
        Cmd.Parameters.Clear()

    End Sub

    Friend Sub SetParam(ByVal key As String, ByVal value As Object)

        If Cmd Is Nothing Then
            Throw New Exception("Command Not Exist")
        End If

        'Add Parameter
        Cmd.Parameters.AddWithValue(key, value)

    End Sub

#End Region

End Class
