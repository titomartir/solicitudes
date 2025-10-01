Public Class Preview

#Region "Property"

    Private Rpt As Object

    Public WriteOnly Property Report As Object
        Set(value As Object)
            Rpt = value
        End Set
    End Property

    Private _TreeView As Boolean = False

    Public WriteOnly Property ShowTreeView As Boolean
        Set(value As Boolean)
            _TreeView = value
        End Set
    End Property

#End Region

#Region "Form Event"

    Private Sub Preview_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Rpt

        If _TreeView Then
            Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.GroupTree
        Else
            Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        End If

        CrystalReportViewer1.Zoom(2)
    End Sub

#End Region

End Class