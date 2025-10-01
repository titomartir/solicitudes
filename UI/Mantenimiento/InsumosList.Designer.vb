<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsumosList
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBNumero = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBNombre = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboUnidad = New SolicitudDePedidoYRequisicion.CustomComboBox()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboBodega = New SolicitudDePedidoYRequisicion.CustomComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDisp = New System.Windows.Forms.Button()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtBodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBodegaName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCodigoDato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(749, 121)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 30)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Número"
        '
        'txtBNumero
        '
        Me.txtBNumero.BackColor = System.Drawing.Color.White
        Me.txtBNumero.ErrorCheck = True
        Me.txtBNumero.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtBNumero.Location = New System.Drawing.Point(406, 62)
        Me.txtBNumero.MaxLength = 10
        Me.txtBNumero.Name = "txtBNumero"
        Me.txtBNumero.SetEnabled = True
        Me.txtBNumero.SetRequerido = False
        Me.txtBNumero.Size = New System.Drawing.Size(76, 24)
        Me.txtBNumero.TabIndex = 1
        Me.txtBNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBNumero.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.NumericText
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Nombre"
        '
        'txtBNombre
        '
        Me.txtBNombre.BackColor = System.Drawing.Color.White
        Me.txtBNombre.ErrorCheck = True
        Me.txtBNombre.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtBNombre.Location = New System.Drawing.Point(86, 94)
        Me.txtBNombre.MaxLength = 50
        Me.txtBNombre.Name = "txtBNombre"
        Me.txtBNombre.SetEnabled = True
        Me.txtBNombre.SetRequerido = False
        Me.txtBNombre.Size = New System.Drawing.Size(567, 24)
        Me.txtBNombre.TabIndex = 2
        Me.txtBNombre.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Unidad"
        '
        'cboUnidad
        '
        Me.cboUnidad.BackColor = System.Drawing.Color.White
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Location = New System.Drawing.Point(86, 124)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.SetEnabled = True
        Me.cboUnidad.SetRequerido = False
        Me.cboUnidad.Size = New System.Drawing.Size(154, 26)
        Me.cboUnidad.TabIndex = 3
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
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnMod, Me.btnDel, Me.txtBodega, Me.txtBodegaName, Me.txtCodigoDato, Me.txtNumero, Me.txtNombre, Me.txtUnidad})
        Me.dgvList.EnableHeadersVisualStyles = False
        Me.dgvList.Location = New System.Drawing.Point(12, 158)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.Size = New System.Drawing.Size(959, 391)
        Me.dgvList.TabIndex = 8
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(871, 58)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 30)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Bodega"
        '
        'cboBodega
        '
        Me.cboBodega.BackColor = System.Drawing.Color.White
        Me.cboBodega.FormattingEnabled = True
        Me.cboBodega.Location = New System.Drawing.Point(86, 62)
        Me.cboBodega.Name = "cboBodega"
        Me.cboBodega.SetEnabled = True
        Me.cboBodega.SetRequerido = False
        Me.cboBodega.Size = New System.Drawing.Size(233, 26)
        Me.cboBodega.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(641, 121)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Claro"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDisp
        '
        Me.btnDisp.Location = New System.Drawing.Point(533, 120)
        Me.btnDisp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDisp.Name = "btnDisp"
        Me.btnDisp.Size = New System.Drawing.Size(100, 30)
        Me.btnDisp.TabIndex = 4
        Me.btnDisp.Text = "Buscar"
        Me.btnDisp.UseVisualStyleBackColor = True
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(871, 120)
        Me.btnOrdenar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(100, 30)
        Me.btnOrdenar.TabIndex = 7
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = True
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
        'txtBodega
        '
        Me.txtBodega.DataPropertyName = "Bodega"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtBodega.DefaultCellStyle = DataGridViewCellStyle3
        Me.txtBodega.HeaderText = "Bodega CD"
        Me.txtBodega.Name = "txtBodega"
        Me.txtBodega.ReadOnly = True
        Me.txtBodega.Visible = False
        '
        'txtBodegaName
        '
        Me.txtBodegaName.DataPropertyName = "BodegaName"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtBodegaName.DefaultCellStyle = DataGridViewCellStyle4
        Me.txtBodegaName.HeaderText = "Bodega"
        Me.txtBodegaName.Name = "txtBodegaName"
        Me.txtBodegaName.ReadOnly = True
        Me.txtBodegaName.Width = 170
        '
        'txtCodigoDato
        '
        Me.txtCodigoDato.DataPropertyName = "Codigo_Dato"
        Me.txtCodigoDato.HeaderText = "Codigo_Dato"
        Me.txtCodigoDato.Name = "txtCodigoDato"
        Me.txtCodigoDato.ReadOnly = True
        Me.txtCodigoDato.Visible = False
        '
        'txtNumero
        '
        Me.txtNumero.DataPropertyName = "Codigo_Insu"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtNumero.DefaultCellStyle = DataGridViewCellStyle5
        Me.txtNumero.HeaderText = "Número"
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Width = 80
        '
        'txtNombre
        '
        Me.txtNombre.DataPropertyName = "Nombre_Insu"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtNombre.DefaultCellStyle = DataGridViewCellStyle6
        Me.txtNombre.HeaderText = "Nombre"
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Width = 420
        '
        'txtUnidad
        '
        Me.txtUnidad.DataPropertyName = "Nombre_Unid"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtUnidad.DefaultCellStyle = DataGridViewCellStyle7
        Me.txtUnidad.HeaderText = "Unidad"
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.ReadOnly = True
        Me.txtUnidad.Width = 180
        '
        'InsumosList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboBodega)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBNumero)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboUnidad)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.btnClose)
        Me.KeyPreview = True
        Me.Name = "InsumosList"
        Me.Text = "Sistema de gestión hospitalaria   -- Hospital Regional de El Quiché --"
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.dgvList, 0)
        Me.Controls.SetChildIndex(Me.cboUnidad, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtBNombre, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtBNumero, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.cboBodega, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.btnDisp, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.Controls.SetChildIndex(Me.btnOrdenar, 0)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBNumero As CustomTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBNombre As CustomTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboUnidad As CustomComboBox
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cboBodega As CustomComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDisp As Button
    Friend WithEvents btnOrdenar As Button
    Friend WithEvents btnMod As DataGridViewButtonColumn
    Friend WithEvents btnDel As DataGridViewButtonColumn
    Friend WithEvents txtBodega As DataGridViewTextBoxColumn
    Friend WithEvents txtBodegaName As DataGridViewTextBoxColumn
    Friend WithEvents txtCodigoDato As DataGridViewTextBoxColumn
    Friend WithEvents txtNumero As DataGridViewTextBoxColumn
    Friend WithEvents txtNombre As DataGridViewTextBoxColumn
    Friend WithEvents txtUnidad As DataGridViewTextBoxColumn
End Class
