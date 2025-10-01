<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PedidoList
    Inherits BaseForm

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboYear = New CustomComboBox()
        Me.cboServicio = New CustomComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBFecha = New CustomTextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBNumero = New CustomTextBox()
        Me.btnDisp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.btnDetail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnMod = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnPrint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtAnio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboEstado = New CustomComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboYear
        '
        Me.cboYear.BackColor = System.Drawing.Color.White
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(81, 62)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.SetEnabled = True
        Me.cboYear.SetRequerido = False
        Me.cboYear.Size = New System.Drawing.Size(86, 26)
        Me.cboYear.TabIndex = 0
        '
        'cboServicio
        '
        Me.cboServicio.BackColor = System.Drawing.Color.White
        Me.cboServicio.FormattingEnabled = True
        Me.cboServicio.Location = New System.Drawing.Point(81, 94)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.SetEnabled = True
        Me.cboServicio.SetRequerido = False
        Me.cboServicio.Size = New System.Drawing.Size(469, 26)
        Me.cboServicio.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 18)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Servicio"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(799, 117)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 30)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(395, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Fecha"
        '
        'txtBFecha
        '
        Me.txtBFecha.BackColor = System.Drawing.Color.White
        Me.txtBFecha.ErrorCheck = False
        Me.txtBFecha.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtBFecha.Location = New System.Drawing.Point(450, 61)
        Me.txtBFecha.MaxLength = 10
        Me.txtBFecha.Name = "txtBFecha"
        Me.txtBFecha.SetEnabled = True
        Me.txtBFecha.SetRequerido = False
        Me.txtBFecha.Size = New System.Drawing.Size(119, 24)
        Me.txtBFecha.TabIndex = 2
        Me.txtBFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBFecha.Type = CustomTextBox.TextType.DateText
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(678, 117)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Claro"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Numero"
        '
        'txtBNumero
        '
        Me.txtBNumero.BackColor = System.Drawing.Color.White
        Me.txtBNumero.ErrorCheck = True
        Me.txtBNumero.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtBNumero.Location = New System.Drawing.Point(255, 61)
        Me.txtBNumero.MaxLength = 10
        Me.txtBNumero.Name = "txtBNumero"
        Me.txtBNumero.SetEnabled = True
        Me.txtBNumero.SetRequerido = False
        Me.txtBNumero.Size = New System.Drawing.Size(119, 24)
        Me.txtBNumero.TabIndex = 1
        Me.txtBNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBNumero.Type = CustomTextBox.TextType.NumericText
        '
        'btnDisp
        '
        Me.btnDisp.Location = New System.Drawing.Point(678, 79)
        Me.btnDisp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDisp.Name = "btnDisp"
        Me.btnDisp.Size = New System.Drawing.Size(100, 30)
        Me.btnDisp.TabIndex = 5
        Me.btnDisp.Text = "Buscar"
        Me.btnDisp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 18)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Año"
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeRows = False
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
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnDetail, Me.btnMod, Me.btnDel, Me.btnPrint, Me.txtAnio, Me.txtNo, Me.txtFecha, Me.txtNombre, Me.Inventario})
        Me.dgvList.EnableHeadersVisualStyles = False
        Me.dgvList.Location = New System.Drawing.Point(12, 157)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.Size = New System.Drawing.Size(959, 392)
        Me.dgvList.TabIndex = 8
        '
        'btnDetail
        '
        Me.btnDetail.DataPropertyName = "Detalles"
        Me.btnDetail.Frozen = True
        Me.btnDetail.HeaderText = ""
        Me.btnDetail.MinimumWidth = 40
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.ReadOnly = True
        Me.btnDetail.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnDetail.Text = "Det"
        Me.btnDetail.ToolTipText = "Detalles"
        Me.btnDetail.Width = 40
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
        'btnPrint
        '
        Me.btnPrint.DataPropertyName = "Imprimir"
        Me.btnPrint.Frozen = True
        Me.btnPrint.HeaderText = ""
        Me.btnPrint.MinimumWidth = 40
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ReadOnly = True
        Me.btnPrint.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnPrint.Text = "Imp"
        Me.btnPrint.ToolTipText = "Imprimir"
        Me.btnPrint.Width = 40
        '
        'txtAnio
        '
        Me.txtAnio.DataPropertyName = "Anio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtAnio.DefaultCellStyle = DataGridViewCellStyle3
        Me.txtAnio.HeaderText = "Año"
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.ReadOnly = True
        Me.txtAnio.Width = 60
        '
        'txtNo
        '
        Me.txtNo.DataPropertyName = "Numero_docu"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtNo.DefaultCellStyle = DataGridViewCellStyle4
        Me.txtNo.HeaderText = "Numero"
        Me.txtNo.Name = "txtNo"
        Me.txtNo.ReadOnly = True
        '
        'txtFecha
        '
        Me.txtFecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtFecha.DefaultCellStyle = DataGridViewCellStyle5
        Me.txtFecha.HeaderText = "Fecha"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Width = 105
        '
        'txtNombre
        '
        Me.txtNombre.DataPropertyName = "Nombre_Serv"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.txtNombre.DefaultCellStyle = DataGridViewCellStyle6
        Me.txtNombre.HeaderText = "Servicio"
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Width = 400
        '
        'Inventario
        '
        Me.Inventario.DataPropertyName = "inventario"
        Me.Inventario.HeaderText = "Estado"
        Me.Inventario.Name = "Inventario"
        Me.Inventario.ReadOnly = True
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
        'cboEstado
        '
        Me.cboEstado.BackColor = System.Drawing.Color.White
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(81, 126)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.SetEnabled = True
        Me.cboEstado.SetRequerido = False
        Me.cboEstado.Size = New System.Drawing.Size(168, 26)
        Me.cboEstado.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Estado"
        '
        'PedidoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.cboServicio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBFecha)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBNumero)
        Me.Controls.Add(Me.btnDisp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.btnClose)
        Me.KeyPreview = True
        Me.Name = "PedidoList"
        Me.Text = "Sistema de gestión hospitalaria   -- Hospital Regional de El Quiché --"
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.dgvList, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnDisp, 0)
        Me.Controls.SetChildIndex(Me.txtBNumero, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.Controls.SetChildIndex(Me.txtBFecha, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.cboServicio, 0)
        Me.Controls.SetChildIndex(Me.cboYear, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.cboEstado, 0)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboYear As CustomComboBox
    Friend WithEvents cboServicio As CustomComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBFecha As CustomTextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBNumero As CustomTextBox
    Friend WithEvents btnDisp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDetail As DataGridViewButtonColumn
    Friend WithEvents btnMod As DataGridViewButtonColumn
    Friend WithEvents btnDel As DataGridViewButtonColumn
    Friend WithEvents btnPrint As DataGridViewButtonColumn
    Friend WithEvents txtAnio As DataGridViewTextBoxColumn
    Friend WithEvents txtNo As DataGridViewTextBoxColumn
    Friend WithEvents txtFecha As DataGridViewTextBoxColumn
    Friend WithEvents txtNombre As DataGridViewTextBoxColumn
    Friend WithEvents Inventario As DataGridViewTextBoxColumn
    Friend WithEvents cboEstado As CustomComboBox
    Friend WithEvents Label3 As Label
End Class
