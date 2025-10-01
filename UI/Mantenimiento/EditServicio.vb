Public Class EditServicio

#Region "difinition"

    Private TITLE As String = ""
    Private cu As CommonUtility = CommonUtility.GetInstance

#End Region

#Region "Property"
    Private _CodigoServ As String = ""

    Public WriteOnly Property CodigoServ As String
        Set(value As String)
            _CodigoServ = value
        End Set
    End Property

    Private _EditMode As Boolean = False

    ''' <summary>
    ''' Edit Mode
    ''' 
    ''' True: Edit
    ''' False: Add
    ''' </summary>
    Public WriteOnly Property EditMode As Boolean
        Set(value As Boolean)
            _EditMode = value
        End Set
    End Property

#End Region

#Region "Form Event"

    ''' <summary>
    ''' Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _EditMode Then
            TITLE = "Modificación del servicio"
        Else
            TITLE = "Agregar de servicio"
        End If

        'Set Form Title
        MyBase.FormTitle = TITLE

        'Clear Data
        ClearData()

        If _EditMode Then

            'Display Data
            DispData()

        End If

    End Sub

#End Region

#Region "Button Event"

    ''' <summary>
    ''' Save Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Save Data
        SaveData()

    End Sub

    ''' <summary>
    ''' Clear Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear Data
        ClearData()

    End Sub

    ''' <summary>
    ''' ReDisplay Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btmReDisplay_Click(sender As Object, e As EventArgs) Handles btmReDisplay.Click

        If _EditMode Then

            'Display Data
            DispData()
        Else

            'Clear Data
            ClearData()

        End If

    End Sub

    ''' <summary>
    ''' Close Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Form Close
        Me.Close()

    End Sub

#End Region

#Region "User Method"

    ''' <summary>
    ''' Clear Data
    ''' </summary>
    Private Sub ClearData()

        If _EditMode Then
            Me.txtCodigo.Text = _CodigoServ
            Me.txtCodigo.SetEnabled = False
        Else
            Me.txtCodigo.Text = ""
            Me.txtCodigo.SetEnabled = True
        End If
        Me.txtNombre.Text = String.Empty
        Me.txtTelefono.Text = String.Empty

    End Sub

    ''' <summary>
    ''' Display Data
    ''' </summary>
    Private Sub DispData()

        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable

        'Set Condition
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Servicio)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Servicio.Codigo_Serv) = _CodigoServ
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.Servicio_select_key(dtRet, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRet.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        With dtRet.Rows(0)
            Me.txtNombre.Text = .Item(Entity.Servicio.Nombre_Serv).ToString
            Me.txtTelefono.Text = .Item(Entity.Servicio.Telefono).ToString
        End With

    End Sub

    ''' <summary>
    ''' Imput Check
    ''' </summary>
    ''' <returns></returns>
    Private Function InputCheck() As Boolean

        If String.IsNullOrEmpty(Me.txtCodigo.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un codigo")
            Me.txtCodigo.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.txtNombre.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un nombre")
            Me.txtNombre.Focus()
            Return False
        End If

        'Data Exist Check
        If _EditMode = False Then

            Dim bc As New PedidoYRequisicionBC
            Dim dtRet As New DataTable

            'Set Condition
            Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Servicio)
            Dim dr As DataRow = dtcondition.NewRow
            dr.Item(Entity.Servicio.Codigo_Serv) = Me.txtCodigo.Text
            dtcondition.Rows.Add(dr)

            'Table Access
            If bc.Servicio_select_key(dtRet, dtcondition) <> HospitalConst.DB_RET.NML Then
                MessageBoxManager.ShowError("Error en la base de datos")
                Return False
            End If

            'Data Exist
            If dtRet.Rows.Count <> 0 Then
                MessageBoxManager.ShowWorning("Ya registrado")
                Return False
            End If

        End If

        Return True

    End Function

    ''' <summary>
    ''' Save Data
    ''' </summary>
    Private Sub SaveData()

        If InputCheck() = False Then
            Exit Sub
        End If

        If MessageBoxManager.ShowQuestionOkCancel("¿Quieres guardarlo?") <> MsgBoxResult.Ok Then
            Exit Sub
        End If

        Dim dtData As DataTable = Entity.GetTable(Entity.TableNmae.Servicio)
        Dim dr As DataRow = dtData.NewRow
        dr.Item(Entity.Servicio.Codigo_Serv) = Me.txtCodigo.Text
        dr.Item(Entity.Servicio.Nombre_Serv) = Me.txtNombre.Text
        dr.Item(Entity.Servicio.Telefono) = Me.txtTelefono.Text
        dtData.Rows.Add(dr)

        Dim bc As New PedidoYRequisicionBC

        If _EditMode Then
            'Mode : Edit Data
            If bc.Servicio_update(dtData) <= 0 Then
                MessageBoxManager.ShowError("Error en la base de datos")
                Exit Sub
            End If

            'Disp Data
            DispData()

            MessageBoxManager.ShowNormal("Guardado")
        Else
            'Mode : Add Data
            If bc.Servicio_insert(dtData) <= 0 Then
                MessageBoxManager.ShowError("Error en la base de datos")
                Exit Sub
            End If

            MessageBoxManager.ShowNormal("Guardado")

            Me.Close()

        End If

    End Sub

#End Region

End Class
