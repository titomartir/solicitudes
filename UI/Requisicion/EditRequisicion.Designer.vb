<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditRequisicion
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboYear = New SolicitudDePedidoYRequisicion.CustomComboBox()
        Me.cboServicio = New SolicitudDePedidoYRequisicion.CustomComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFecha = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumero = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.btnUp = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDown = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnIns = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cboInsumo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.txtUnidad = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.txtSolicitada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvFirma = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJustificacion = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cboBodega = New SolicitudDePedidoYRequisicion.CustomComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboNombreBodega = New SolicitudDePedidoYRequisicion.CustomComboBox()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(871, 58)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 30)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cboYear
        '
        Me.cboYear.BackColor = System.Drawing.Color.LightGray
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(74, 67)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.SetEnabled = False
        Me.cboYear.SetRequerido = False
        Me.cboYear.Size = New System.Drawing.Size(86, 26)
        Me.cboYear.TabIndex = 0
        Me.cboYear.TabStop = False
        '
        'cboServicio
        '
        Me.cboServicio.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboServicio.FormattingEnabled = True
        Me.cboServicio.Location = New System.Drawing.Point(106, 161)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.SetEnabled = True
        Me.cboServicio.SetRequerido = True
        Me.cboServicio.Size = New System.Drawing.Size(375, 26)
        Me.cboServicio.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 18)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Servicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFecha.ErrorCheck = True
        Me.txtFecha.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtFecha.Location = New System.Drawing.Point(63, 99)
        Me.txtFecha.MaxLength = 10
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.SetEnabled = True
        Me.txtFecha.SetRequerido = True
        Me.txtFecha.Size = New System.Drawing.Size(97, 24)
        Me.txtFecha.TabIndex = 2
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFecha.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.DateText
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Numero"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.LightGray
        Me.txtNumero.ErrorCheck = True
        Me.txtNumero.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtNumero.Location = New System.Drawing.Point(247, 67)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.SetEnabled = False
        Me.txtNumero.SetRequerido = True
        Me.txtNumero.Size = New System.Drawing.Size(119, 24)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.TabStop = False
        Me.txtNumero.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.NumericText
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 18)
        Me.Label1.TabIndex = 82
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
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnUp, Me.btnDown, Me.btnIns, Me.btnDel, Me.cboInsumo, Me.txtUnidad, Me.txtSolicitada})
        Me.dgvList.EnableHeadersVisualStyles = False
        Me.dgvList.Location = New System.Drawing.Point(12, 248)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.RowTemplate.Height = 44
        Me.dgvList.Size = New System.Drawing.Size(959, 301)
        Me.dgvList.TabIndex = 8
        '
        'btnUp
        '
        Me.btnUp.Frozen = True
        Me.btnUp.HeaderText = ""
        Me.btnUp.MinimumWidth = 30
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnUp.Text = "Det"
        Me.btnUp.ToolTipText = "Detalles"
        Me.btnUp.Width = 30
        '
        'btnDown
        '
        Me.btnDown.Frozen = True
        Me.btnDown.HeaderText = ""
        Me.btnDown.MinimumWidth = 30
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Text = "Mod"
        Me.btnDown.ToolTipText = "Modificar"
        Me.btnDown.Width = 30
        '
        'btnIns
        '
        Me.btnIns.Frozen = True
        Me.btnIns.HeaderText = ""
        Me.btnIns.MinimumWidth = 35
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnIns.Text = "Bor"
        Me.btnIns.ToolTipText = "Borrar"
        Me.btnIns.Width = 35
        '
        'btnDel
        '
        Me.btnDel.Frozen = True
        Me.btnDel.HeaderText = ""
        Me.btnDel.MinimumWidth = 35
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnDel.Text = "Imp"
        Me.btnDel.ToolTipText = "Imprimir"
        Me.btnDel.Width = 35
        '
        'cboInsumo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboInsumo.DefaultCellStyle = DataGridViewCellStyle3
        Me.cboInsumo.HeaderText = "Insumo"
        Me.cboInsumo.Name = "cboInsumo"
        Me.cboInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboInsumo.Width = 557
        '
        'txtUnidad
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtUnidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.txtUnidad.HeaderText = "Unidad de Medida"
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.ReadOnly = True
        Me.txtUnidad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtUnidad.Width = 150
        '
        'txtSolicitada
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtSolicitada.DefaultCellStyle = DataGridViewCellStyle5
        Me.txtSolicitada.HeaderText = "Cantidad Solicitada"
        Me.txtSolicitada.MaxInputLength = 6
        Me.txtSolicitada.Name = "txtSolicitada"
        Me.txtSolicitada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnReDisplay
        '
        Me.btnReDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReDisplay.Location = New System.Drawing.Point(655, 58)
        Me.btnReDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReDisplay.Name = "btnReDisplay"
        Me.btnReDisplay.Size = New System.Drawing.Size(100, 30)
        Me.btnReDisplay.TabIndex = 11
        Me.btnReDisplay.Text = "Redisplay"
        Me.btnReDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(547, 58)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Claro"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(439, 58)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvFirma
        '
        Me.dgvFirma.AllowUserToAddRows = False
        Me.dgvFirma.AllowUserToDeleteRows = False
        Me.dgvFirma.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvFirma.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFirma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFirma.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFirma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewComboBoxColumn1, Me.DataGridViewComboBoxColumn2})
        Me.dgvFirma.EnableHeadersVisualStyles = False
        Me.dgvFirma.Location = New System.Drawing.Point(499, 106)
        Me.dgvFirma.MultiSelect = False
        Me.dgvFirma.Name = "dgvFirma"
        Me.dgvFirma.RowHeadersVisible = False
        Me.dgvFirma.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvFirma.Size = New System.Drawing.Size(473, 136)
        Me.dgvFirma.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewComboBoxColumn1
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewComboBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewComboBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewComboBoxColumn1.MaxInputLength = 50
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewComboBoxColumn1.Width = 200
        '
        'DataGridViewComboBoxColumn2
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewComboBoxColumn2.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewComboBoxColumn2.HeaderText = "Cargo"
        Me.DataGridViewComboBoxColumn2.MaxInputLength = 50
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewComboBoxColumn2.Width = 190
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-2, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Observaciones"
        '
        'txtJustificacion
        '
        Me.txtJustificacion.BackColor = System.Drawing.Color.White
        Me.txtJustificacion.ErrorCheck = True
        Me.txtJustificacion.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtJustificacion.Location = New System.Drawing.Point(106, 193)
        Me.txtJustificacion.MaxLength = 200
        Me.txtJustificacion.Multiline = True
        Me.txtJustificacion.Name = "txtJustificacion"
        Me.txtJustificacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificacion.SetEnabled = True
        Me.txtJustificacion.SetRequerido = False
        Me.txtJustificacion.Size = New System.Drawing.Size(375, 49)
        Me.txtJustificacion.TabIndex = 6
        Me.txtJustificacion.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Location = New System.Drawing.Point(763, 58)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 30)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "Imprimir"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cboBodega
        '
        Me.cboBodega.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboBodega.FormattingEnabled = True
        Me.cboBodega.Location = New System.Drawing.Point(108, 130)
        Me.cboBodega.Name = "cboBodega"
        Me.cboBodega.SetEnabled = True
        Me.cboBodega.SetRequerido = True
        Me.cboBodega.Size = New System.Drawing.Size(263, 26)
        Me.cboBodega.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Insumos de"
        '
        'cboNombreBodega
        '
        Me.cboNombreBodega.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboNombreBodega.Enabled = False
        Me.cboNombreBodega.FormattingEnabled = True
        Me.cboNombreBodega.Location = New System.Drawing.Point(307, 97)
        Me.cboNombreBodega.Name = "cboNombreBodega"
        Me.cboNombreBodega.SetEnabled = True
        Me.cboNombreBodega.SetRequerido = True
        Me.cboNombreBodega.Size = New System.Drawing.Size(186, 26)
        Me.cboNombreBodega.TabIndex = 3
        '
        'EditRequisicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.cboNombreBodega)
        Me.Controls.Add(Me.cboBodega)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJustificacion)
        Me.Controls.Add(Me.dgvFirma)
        Me.Controls.Add(Me.btnReDisplay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.cboServicio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.KeyPreview = True
        Me.Name = "EditRequisicion"
        Me.Text = "Sistema de gestión hospitalaria   -- Hospital Regional de El Quiché --"
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtNumero, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.cboServicio, 0)
        Me.Controls.SetChildIndex(Me.cboYear, 0)
        Me.Controls.SetChildIndex(Me.dgvList, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.Controls.SetChildIndex(Me.btnReDisplay, 0)
        Me.Controls.SetChildIndex(Me.dgvFirma, 0)
        Me.Controls.SetChildIndex(Me.txtJustificacion, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.btnPrint, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.cboBodega, 0)
        Me.Controls.SetChildIndex(Me.cboNombreBodega, 0)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFirma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents cboYear As CustomComboBox
    Friend WithEvents cboServicio As CustomComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFecha As CustomTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumero As CustomTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents btnReDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvFirma As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJustificacion As CustomTextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents cboBodega As CustomComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUp As DataGridViewButtonColumn
    Friend WithEvents btnDown As DataGridViewButtonColumn
    Friend WithEvents btnIns As DataGridViewButtonColumn
    Friend WithEvents btnDel As DataGridViewButtonColumn
    Friend WithEvents cboInsumo As DataGridViewComboBoxColumn
    Friend WithEvents txtUnidad As DataGridViewComboBoxColumn
    Friend WithEvents txtSolicitada As DataGridViewTextBoxColumn
    Friend WithEvents cboNombreBodega As CustomComboBox
End Class
