Public Class MaintenanceMenu

#Region "difinition"

    Private TITLE As String = "Mantenimiento"

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

    End Sub

#End Region

#Region "Button Event"

    ''' <summary>
    ''' Close Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Form Close
        Me.Close()

    End Sub

    ''' <summary>
    ''' Product List Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnProductList_Click(sender As Object, e As EventArgs) Handles btnProductList.Click

        Using Frm As New InsumosList
            Me.Hide()
            Frm.ShowDialog()
            Me.Show()
        End Using

    End Sub

    ''' <summary>
    ''' Add Product Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click

        Using Frm As New EditInsumos
            Me.Hide()
            Frm.ShowDialog()
            Frm.CodigoDato = ""
            Frm.Bodega = ""
            Frm.EditMode = False
            Me.Show()
        End Using

    End Sub

    ''' <summary>
    ''' Add Unidad List Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUnidadList_Click(sender As Object, e As EventArgs) Handles btnUnidadList.Click

        Using Frm As New UnidadList
            Me.Hide()
            Frm.ShowDialog()
            Me.Show()
        End Using

    End Sub

    ''' <summary>
    ''' Add Unidad Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddUnidad_Click(sender As Object, e As EventArgs) Handles btnAddUnidad.Click

        Using Frm As New EditUnidad
            Me.Hide()
            Frm.ShowDialog()
            Frm.CodigoUnid = ""
            Me.Show()
        End Using

    End Sub

    ''' <summary>
    ''' Servicio List Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnServicio_Click(sender As Object, e As EventArgs) Handles btnServicio.Click

        Using Frm As New ServicioList
            Me.Hide()
            Frm.ShowDialog()
            Me.Show()
        End Using

    End Sub

    ''' <summary>
    ''' Add Servicio Button Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddServicio_Click(sender As Object, e As EventArgs) Handles btnAddServicio.Click

        Using Frm As New EditServicio
            Me.Hide()
            Frm.ShowDialog()
            Frm.CodigoServ = ""
            Me.Show()
        End Using

    End Sub

#End Region

End Class
