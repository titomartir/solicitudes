Public Class EditInsumos

#Region "difinition"

    Private TITLE As String = ""
    Private cu As CommonUtility = CommonUtility.GetInstance
    Dim sc As New SetCombobox

#End Region

#Region "Property"
    Private _CodigoDato As String = ""

    Public WriteOnly Property CodigoDato As String
        Set(value As String)
            _CodigoDato = value
        End Set
    End Property

    Private _Bodega As String = ""

    Public WriteOnly Property Bodega As String
        Set(value As String)
            _Bodega = value
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
            TITLE = "Modificación del insumos"
        Else
            TITLE = "Agregar de insumos"
        End If

        'Set Form Title
        MyBase.FormTitle = TITLE

        'Set ComboBox
        SetCombo()

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
    ''' Set ComboBox
    ''' </summary>
    Private Sub SetCombo()

        sc.SetUnidadComboBox(Me.cboUnidad)
        sc.SetBodegaComboBox(Me.cboBodega)

    End Sub

    ''' <summary>
    ''' Clear Data
    ''' </summary>
    Private Sub ClearData()

        If _EditMode Then
            Me.txtNumero.Text = ""
        Else
            Me.txtNumero.Text = "Sin asignar"
        End If
        Me.cboBodega.SelectedValue = _Bodega
        Me.txtNombre.Text = String.Empty
        Me.cboUnidad.SelectedIndex = -1

    End Sub

    ''' <summary>
    ''' Display Data
    ''' </summary>
    Private Sub DispData()

        Dim bc As New PedidoYRequisicionBC
        Dim dtRet As New DataTable

        'Set Condition
        Dim dtcondition As DataTable = Entity.GetTable(Entity.TableNmae.Insumos)
        Dim dr As DataRow = dtcondition.NewRow
        dr.Item(Entity.Insumos.Codigo_Dato) = _CodigoDato
        dr.Item(Entity.Insumos.Bodega) = _Bodega
        dtcondition.Rows.Add(dr)

        'Table Access
        If bc.insumos_select_key(dtRet, dtcondition) <> HospitalConst.DB_RET.NML Then
            MessageBoxManager.ShowError("Error en la base de datos")
            Exit Sub
        End If

        'Data Not Exist
        If dtRet.Rows.Count = 0 Then
            MessageBoxManager.ShowWorning("No hay datos")
            Exit Sub
        End If

        With dtRet.Rows(0)
            Me.txtNumero.Text = .Item(Entity.Insumos.Codigo_Insu).ToString
            Me.txtNombre.Text = .Item(Entity.Insumos.Nombre_Insu).ToString
            Me.cboUnidad.SelectedValue = .Item(Entity.Insumos.Unidad).ToString
        End With

    End Sub

    ''' <summary>
    ''' Imput Check
    ''' </summary>
    ''' <returns></returns>
    Private Function InputCheck() As Boolean

        If Me.cboBodega.SelectedIndex = -1 Then
            MessageBoxManager.ShowWorning("Por favor, establece un Bodega")
            Me.cboBodega.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.txtNombre.Text) Then
            MessageBoxManager.ShowWorning("Por favor, establece un nombre")
            Me.txtNombre.Focus()
            Return False
        End If

        If Me.cboUnidad.SelectedIndex = -1 Then
            MessageBoxManager.ShowWorning("Por favor, establece un unidad")
            Me.cboUnidad.Focus()
            Return False
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

        Dim dtData As DataTable = Entity.GetTable(Entity.TableNmae.Insumos)
        Dim dr As DataRow = dtData.NewRow
        dr.Item(Entity.Insumos.Codigo_Dato) = _CodigoDato
        dr.Item(Entity.Insumos.Bodega) = Me.cboBodega.SelectedValue
        dr.Item(Entity.Insumos.Codigo_Insu) = Me.txtNumero.Text
        dr.Item(Entity.Insumos.Nombre_Insu) = Me.txtNombre.Text
        dr.Item(Entity.Insumos.Unidad) = Me.cboUnidad.SelectedValue
        dtData.Rows.Add(dr)

        Dim bc As New PedidoYRequisicionBC

        If _EditMode Then
            'Mode : Edit Data
            If bc.insumos_update(dtData) <= 0 Then
                MessageBoxManager.ShowError("Error en la base de datos")
                Exit Sub
            End If

            'Disp Data
            DispData()

            MessageBoxManager.ShowNormal("Guardado")
        Else
            'Mode : Add Data
            Dim wkNumbero As String = ""

            'Add Patient Data
            If bc.insumos_insert(dtData, wkNumbero) <= 0 Then
                MessageBoxManager.ShowError("Error en la base de datos")
                Exit Sub
            End If

            MessageBoxManager.ShowNormal("Guardado")

            'Set Key
            _CodigoDato = wkNumbero

            Me.Close()

        End If

    End Sub

#End Region

End Class
