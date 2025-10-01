<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditInsumos
    Inherits BaseForm

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btmReDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboBodega = New SolicitudDePedidoYRequisicion.CustomComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumero = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboUnidad = New SolicitudDePedidoYRequisicion.CustomComboBox()
        Me.SuspendLayout()
        '
        'btmReDisplay
        '
        Me.btmReDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btmReDisplay.Location = New System.Drawing.Point(763, 58)
        Me.btmReDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.btmReDisplay.Name = "btmReDisplay"
        Me.btmReDisplay.Size = New System.Drawing.Size(100, 30)
        Me.btmReDisplay.TabIndex = 6
        Me.btmReDisplay.Text = "Redisplay"
        Me.btmReDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(655, 58)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Claro"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(547, 58)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(871, 58)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 30)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Bodega"
        '
        'cboBodega
        '
        Me.cboBodega.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboBodega.FormattingEnabled = True
        Me.cboBodega.Location = New System.Drawing.Point(153, 121)
        Me.cboBodega.Name = "cboBodega"
        Me.cboBodega.SetEnabled = True
        Me.cboBodega.SetRequerido = True
        Me.cboBodega.Size = New System.Drawing.Size(226, 26)
        Me.cboBodega.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Número"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.LightGray
        Me.txtNumero.ErrorCheck = True
        Me.txtNumero.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtNumero.Location = New System.Drawing.Point(97, 64)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.SetEnabled = False
        Me.txtNumero.SetRequerido = False
        Me.txtNumero.Size = New System.Drawing.Size(114, 24)
        Me.txtNumero.TabIndex = 0
        Me.txtNumero.TabStop = False
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumero.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.NumericText
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNombre.ErrorCheck = True
        Me.txtNombre.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtNombre.Location = New System.Drawing.Point(153, 163)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.SetEnabled = True
        Me.txtNombre.SetRequerido = True
        Me.txtNombre.Size = New System.Drawing.Size(803, 24)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Unidad"
        '
        'cboUnidad
        '
        Me.cboUnidad.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Location = New System.Drawing.Point(153, 201)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.SetEnabled = True
        Me.cboUnidad.SetRequerido = True
        Me.cboUnidad.Size = New System.Drawing.Size(226, 26)
        Me.cboUnidad.TabIndex = 3
        '
        'EditInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboBodega)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboUnidad)
        Me.Controls.Add(Me.btmReDisplay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.KeyPreview = True
        Me.Name = "EditInsumos"
        Me.Text = "Sistema de gestión hospitalaria   -- Hospital Regional de El Quiché --"
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.Controls.SetChildIndex(Me.btmReDisplay, 0)
        Me.Controls.SetChildIndex(Me.cboUnidad, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtNumero, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.cboBodega, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btmReDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cboBodega As CustomComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumero As CustomTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As CustomTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboUnidad As CustomComboBox
End Class
