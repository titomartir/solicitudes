<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServicioList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDisp = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBCodigoServ = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBNombre = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtCodigoServ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(622, 96)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Claro"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDisp
        '
        Me.btnDisp.Location = New System.Drawing.Point(622, 58)
        Me.btnDisp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDisp.Name = "btnDisp"
        Me.btnDisp.Size = New System.Drawing.Size(100, 30)
        Me.btnDisp.TabIndex = 2
        Me.btnDisp.Text = "Buscar"
        Me.btnDisp.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(730, 96)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 30)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Código"
        '
        'txtBCodigoServ
        '
        Me.txtBCodigoServ.BackColor = System.Drawing.Color.White
        Me.txtBCodigoServ.ErrorCheck = True
        Me.txtBCodigoServ.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtBCodigoServ.Location = New System.Drawing.Point(81, 72)
        Me.txtBCodigoServ.MaxLength = 2
        Me.txtBCodigoServ.Name = "txtBCodigoServ"
        Me.txtBCodigoServ.SetEnabled = True
        Me.txtBCodigoServ.SetRequerido = False
        Me.txtBCodigoServ.Size = New System.Drawing.Size(40, 24)
        Me.txtBCodigoServ.TabIndex = 0
        Me.txtBCodigoServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBCodigoServ.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.NumericText
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Nombre"
        '
        'txtBNombre
        '
        Me.txtBNombre.BackColor = System.Drawing.Color.White
        Me.txtBNombre.ErrorCheck = True
        Me.txtBNombre.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtBNombre.Location = New System.Drawing.Point(81, 102)
        Me.txtBNombre.MaxLength = 50
        Me.txtBNombre.Name = "txtBNombre"
        Me.txtBNombre.SetEnabled = True
        Me.txtBNombre.SetRequerido = False
        Me.txtBNombre.Size = New System.Drawing.Size(516, 24)
        Me.txtBNombre.TabIndex = 1
        Me.txtBNombre.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnMod, Me.btnDel, Me.txtCodigoServ, Me.txtNombre, Me.txtTelefono})
        Me.dgvList.EnableHeadersVisualStyles = False
        Me.dgvList.Location = New System.Drawing.Point(12, 133)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.Size = New System.Drawing.Size(959, 416)
        Me.dgvList.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(871, 58)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 30)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.DataPropertyName = "Modificar"
        Me.btnMod.Frozen = True
        Me.btnMod.HeaderText = ""
        Me.btnMod.MinimumWidth = 40
        Me.btnMod.Name = "btnMod"
        Me.btnMod.ReadOnly = True
        Me.btnMod.Text = "Mod"
        Me.btnMod.ToolTipText = "Modificar"
        Me.btnMod.Width = 40
        '
        'btnDel
        '
        Me.btnDel.DataPropertyName = "Borrar"
        Me.btnDel.Frozen = True
        Me.btnDel.HeaderText = ""
        Me.btnDel.MinimumWidth = 40
        Me.btnDel.Name = "btnDel"
        Me.btnDel.ReadOnly = True
        Me.btnDel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnDel.Text = "Bor"
        Me.btnDel.ToolTipText = "Borrar"
        Me.btnDel.Width = 40
        '
        'txtCodigoServ
        '
        Me.txtCodigoServ.DataPropertyName = "Codigo_Serv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtCodigoServ.DefaultCellStyle = DataGridViewCellStyle3
        Me.txtCodigoServ.Frozen = True
        Me.txtCodigoServ.HeaderText = "Código"
        Me.txtCodigoServ.Name = "txtCodigoServ"
        Me.txtCodigoServ.ReadOnly = True
        Me.txtCodigoServ.Width = 75
        '
        'txtNombre
        '
        Me.txtNombre.DataPropertyName = "Nombre_Serv"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.txtNombre.DefaultCellStyle = DataGridViewCellStyle4
        Me.txtNombre.HeaderText = "Nombre"
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Width = 530
        '
        'txtTelefono
        '
        Me.txtTelefono.DataPropertyName = "Telefono"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtTelefono.DefaultCellStyle = DataGridViewCellStyle5
        Me.txtTelefono.HeaderText = "Teléfono"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Width = 150
        '
        'ServicioList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisp)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBCodigoServ)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBNombre)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.btnClose)
        Me.KeyPreview = True
        Me.Name = "ServicioList"
        Me.Text = "Sistema de gestión hospitalaria   -- Hospital Regional de El Quiché --"
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.dgvList, 0)
        Me.Controls.SetChildIndex(Me.txtBNombre, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtBCodigoServ, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.btnDisp, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnDisp As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBCodigoServ As CustomTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBNombre As CustomTextBox
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMod As DataGridViewButtonColumn
    Friend WithEvents btnDel As DataGridViewButtonColumn
    Friend WithEvents txtCodigoServ As DataGridViewTextBoxColumn
    Friend WithEvents txtNombre As DataGridViewTextBoxColumn
    Friend WithEvents txtTelefono As DataGridViewTextBoxColumn
End Class
