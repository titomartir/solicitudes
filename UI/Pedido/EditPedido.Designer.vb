<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditPedido
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJustificacion = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.btnReDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboYear = New SolicitudDePedidoYRequisicion.CustomComboBox()
        Me.cboServicio = New SolicitudDePedidoYRequisicion.CustomComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFecha = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumero = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.btnUp = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDown = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnIns = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtCodigo_Insu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCodigo_Presentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtInsumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSolicitada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAutorizada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFinanciero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtEstimado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkPaac = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chkAbierto = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvFirma = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtSubastaInversa = New System.Windows.Forms.RadioButton()
        Me.rbtBajaCuantilla = New System.Windows.Forms.RadioButton()
        Me.rbtLicitacion = New System.Windows.Forms.RadioButton()
        Me.rbtCotizacion = New System.Windows.Forms.RadioButton()
        Me.rbtContratoAbierto = New System.Windows.Forms.RadioButton()
        Me.rbtCompraDirecta = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtAcreditamiento = New System.Windows.Forms.RadioButton()
        Me.rbtFondoRotativo = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbtDisponibilidadNo = New System.Windows.Forms.RadioButton()
        Me.rbtDisponibilidadSi = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPresupuesto = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.txtCompras = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.txtProg = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSubp = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProy = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAct = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFteFin = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtUbGeo = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtObra = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtOtro = New SolicitudDePedidoYRequisicion.CustomTextBox()
        Me.txtSubProducto = New SolicitudDePedidoYRequisicion.CustomTextBox()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Location = New System.Drawing.Point(762, 58)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 30)
        Me.btnPrint.TabIndex = 25
        Me.btnPrint.Text = "Imprimir"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Justificación"
        '
        'txtJustificacion
        '
        Me.txtJustificacion.BackColor = System.Drawing.Color.White
        Me.txtJustificacion.ErrorCheck = True
        Me.txtJustificacion.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtJustificacion.Location = New System.Drawing.Point(105, 156)
        Me.txtJustificacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtJustificacion.MaxLength = 300
        Me.txtJustificacion.Multiline = True
        Me.txtJustificacion.Name = "txtJustificacion"
        Me.txtJustificacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificacion.SetEnabled = True
        Me.txtJustificacion.SetRequerido = False
        Me.txtJustificacion.Size = New System.Drawing.Size(409, 71)
        Me.txtJustificacion.TabIndex = 5
        Me.txtJustificacion.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'btnReDisplay
        '
        Me.btnReDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReDisplay.Location = New System.Drawing.Point(654, 58)
        Me.btnReDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReDisplay.Name = "btnReDisplay"
        Me.btnReDisplay.Size = New System.Drawing.Size(100, 30)
        Me.btnReDisplay.TabIndex = 24
        Me.btnReDisplay.Text = "Redisplay"
        Me.btnReDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(546, 58)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Claro"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(438, 58)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboYear
        '
        Me.cboYear.BackColor = System.Drawing.Color.LightGray
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(77, 67)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.cboServicio.Location = New System.Drawing.Point(105, 126)
        Me.cboServicio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.SetEnabled = True
        Me.cboServicio.SetRequerido = True
        Me.cboServicio.Size = New System.Drawing.Size(409, 26)
        Me.cboServicio.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 18)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Servicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFecha.ErrorCheck = True
        Me.txtFecha.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtFecha.Location = New System.Drawing.Point(105, 98)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFecha.MaxLength = 10
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.SetEnabled = True
        Me.txtFecha.SetRequerido = True
        Me.txtFecha.Size = New System.Drawing.Size(118, 24)
        Me.txtFecha.TabIndex = 2
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFecha.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Numero"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.LightGray
        Me.txtNumero.ErrorCheck = True
        Me.txtNumero.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtNumero.Location = New System.Drawing.Point(249, 67)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.SetEnabled = False
        Me.txtNumero.SetRequerido = True
        Me.txtNumero.Size = New System.Drawing.Size(118, 24)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.TabStop = False
        Me.txtNumero.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 18)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Año"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(870, 58)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 30)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTelefono.ErrorCheck = True
        Me.txtTelefono.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtTelefono.Location = New System.Drawing.Point(327, 98)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefono.MaxLength = 15
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.SetEnabled = True
        Me.txtTelefono.SetRequerido = True
        Me.txtTelefono.Size = New System.Drawing.Size(187, 24)
        Me.txtTelefono.TabIndex = 3
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTelefono.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
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
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnUp, Me.btnDown, Me.btnIns, Me.btnDel, Me.txtCodigo_Insu, Me.txtCodigo_Presentacion, Me.txtInsumo, Me.txtUnidad, Me.txtSolicitada, Me.txtAutorizada, Me.txtFinanciero, Me.txtEstimado, Me.chkPaac, Me.chkAbierto})
        Me.dgvList.EnableHeadersVisualStyles = False
        Me.dgvList.Location = New System.Drawing.Point(12, 354)
        Me.dgvList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.RowTemplate.Height = 66
        Me.dgvList.Size = New System.Drawing.Size(959, 195)
        Me.dgvList.TabIndex = 21
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
        Me.btnUp.Width = 60
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
        'txtCodigo_Insu
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo_Insu.DefaultCellStyle = DataGridViewCellStyle3
        Me.txtCodigo_Insu.Frozen = True
        Me.txtCodigo_Insu.HeaderText = "Código de Insumo"
        Me.txtCodigo_Insu.MaxInputLength = 7
        Me.txtCodigo_Insu.Name = "txtCodigo_Insu"
        Me.txtCodigo_Insu.Width = 60
        '
        'txtCodigo_Presentacion
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo_Presentacion.DefaultCellStyle = DataGridViewCellStyle4
        Me.txtCodigo_Presentacion.Frozen = True
        Me.txtCodigo_Presentacion.HeaderText = "Código de Presentasión"
        Me.txtCodigo_Presentacion.MaxInputLength = 10
        Me.txtCodigo_Presentacion.Name = "txtCodigo_Presentacion"
        Me.txtCodigo_Presentacion.Width = 95
        '
        'txtInsumo
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtInsumo.DefaultCellStyle = DataGridViewCellStyle5
        Me.txtInsumo.Frozen = True
        Me.txtInsumo.HeaderText = "Insumo"
        Me.txtInsumo.MaxInputLength = 400
        Me.txtInsumo.Name = "txtInsumo"
        Me.txtInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtInsumo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.txtInsumo.Width = 295
        '
        'txtUnidad
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtUnidad.DefaultCellStyle = DataGridViewCellStyle6
        Me.txtUnidad.HeaderText = "Unidad de Medida"
        Me.txtUnidad.MaxInputLength = 30
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtUnidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.txtUnidad.Width = 75
        '
        'txtSolicitada
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtSolicitada.DefaultCellStyle = DataGridViewCellStyle7
        Me.txtSolicitada.HeaderText = "Cantidad Solicitada"
        Me.txtSolicitada.MaxInputLength = 9
        Me.txtSolicitada.MinimumWidth = 10
        Me.txtSolicitada.Name = "txtSolicitada"
        Me.txtSolicitada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.txtSolicitada.Width = 75
        '
        'txtAutorizada
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtAutorizada.DefaultCellStyle = DataGridViewCellStyle8
        Me.txtAutorizada.HeaderText = "Cantidad Autorizada"
        Me.txtAutorizada.MaxInputLength = 9
        Me.txtAutorizada.Name = "txtAutorizada"
        Me.txtAutorizada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.txtAutorizada.Width = 75
        '
        'txtFinanciero
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtFinanciero.DefaultCellStyle = DataGridViewCellStyle9
        Me.txtFinanciero.HeaderText = "Rengión afectado"
        Me.txtFinanciero.MaxInputLength = 7
        Me.txtFinanciero.Name = "txtFinanciero"
        Me.txtFinanciero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.txtFinanciero.Width = 65
        '
        'txtEstimado
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.txtEstimado.DefaultCellStyle = DataGridViewCellStyle10
        Me.txtEstimado.HeaderText = "Valor estimado (Quetzales)"
        Me.txtEstimado.MaxInputLength = 12
        Me.txtEstimado.Name = "txtEstimado"
        Me.txtEstimado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.txtEstimado.Width = 70
        '
        'chkPaac
        '
        Me.chkPaac.HeaderText = "Incluido en Paac"
        Me.chkPaac.Name = "chkPaac"
        Me.chkPaac.Width = 55
        '
        'chkAbierto
        '
        Me.chkAbierto.HeaderText = "Esta en contrato abierto"
        Me.chkAbierto.Name = "chkAbierto"
        Me.chkAbierto.Width = 55
        '
        'dgvFirma
        '
        Me.dgvFirma.AllowUserToAddRows = False
        Me.dgvFirma.AllowUserToDeleteRows = False
        Me.dgvFirma.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvFirma.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFirma.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFirma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewComboBoxColumn1, Me.DataGridViewComboBoxColumn2})
        Me.dgvFirma.EnableHeadersVisualStyles = False
        Me.dgvFirma.Location = New System.Drawing.Point(13, 232)
        Me.dgvFirma.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvFirma.MultiSelect = False
        Me.dgvFirma.Name = "dgvFirma"
        Me.dgvFirma.RowHeadersVisible = False
        Me.dgvFirma.RowTemplate.Height = 19
        Me.dgvFirma.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvFirma.Size = New System.Drawing.Size(503, 80)
        Me.dgvFirma.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewComboBoxColumn1
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewComboBoxColumn1.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewComboBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewComboBoxColumn1.MaxInputLength = 50
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewComboBoxColumn1.Width = 200
        '
        'DataGridViewComboBoxColumn2
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewComboBoxColumn2.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewComboBoxColumn2.HeaderText = "Cargo"
        Me.DataGridViewComboBoxColumn2.MaxInputLength = 50
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewComboBoxColumn2.Width = 210
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtSubastaInversa)
        Me.GroupBox1.Controls.Add(Me.rbtBajaCuantilla)
        Me.GroupBox1.Controls.Add(Me.rbtLicitacion)
        Me.GroupBox1.Controls.Add(Me.rbtCotizacion)
        Me.GroupBox1.Controls.Add(Me.rbtContratoAbierto)
        Me.GroupBox1.Controls.Add(Me.rbtCompraDirecta)
        Me.GroupBox1.Location = New System.Drawing.Point(539, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 60)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'rbtSubastaInversa
        '
        Me.rbtSubastaInversa.AutoSize = True
        Me.rbtSubastaInversa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSubastaInversa.Location = New System.Drawing.Point(292, 36)
        Me.rbtSubastaInversa.Name = "rbtSubastaInversa"
        Me.rbtSubastaInversa.Size = New System.Drawing.Size(112, 19)
        Me.rbtSubastaInversa.TabIndex = 5
        Me.rbtSubastaInversa.Text = "Subasta Inversa"
        Me.rbtSubastaInversa.UseVisualStyleBackColor = True
        '
        'rbtBajaCuantilla
        '
        Me.rbtBajaCuantilla.AutoSize = True
        Me.rbtBajaCuantilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBajaCuantilla.Location = New System.Drawing.Point(292, 16)
        Me.rbtBajaCuantilla.Name = "rbtBajaCuantilla"
        Me.rbtBajaCuantilla.Size = New System.Drawing.Size(95, 19)
        Me.rbtBajaCuantilla.TabIndex = 4
        Me.rbtBajaCuantilla.Text = "Baja Cuantia"
        Me.rbtBajaCuantilla.UseVisualStyleBackColor = True
        '
        'rbtLicitacion
        '
        Me.rbtLicitacion.AutoSize = True
        Me.rbtLicitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtLicitacion.Location = New System.Drawing.Point(172, 36)
        Me.rbtLicitacion.Name = "rbtLicitacion"
        Me.rbtLicitacion.Size = New System.Drawing.Size(89, 19)
        Me.rbtLicitacion.TabIndex = 3
        Me.rbtLicitacion.Text = "LICITACIÓN"
        Me.rbtLicitacion.UseVisualStyleBackColor = True
        '
        'rbtCotizacion
        '
        Me.rbtCotizacion.AutoSize = True
        Me.rbtCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCotizacion.Location = New System.Drawing.Point(172, 16)
        Me.rbtCotizacion.Name = "rbtCotizacion"
        Me.rbtCotizacion.Size = New System.Drawing.Size(95, 19)
        Me.rbtCotizacion.TabIndex = 2
        Me.rbtCotizacion.Text = "COTIZACIÓN"
        Me.rbtCotizacion.UseVisualStyleBackColor = True
        '
        'rbtContratoAbierto
        '
        Me.rbtContratoAbierto.AutoSize = True
        Me.rbtContratoAbierto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtContratoAbierto.Location = New System.Drawing.Point(11, 36)
        Me.rbtContratoAbierto.Name = "rbtContratoAbierto"
        Me.rbtContratoAbierto.Size = New System.Drawing.Size(144, 19)
        Me.rbtContratoAbierto.TabIndex = 1
        Me.rbtContratoAbierto.Text = "CONTRATO ABIERTO"
        Me.rbtContratoAbierto.UseVisualStyleBackColor = True
        '
        'rbtCompraDirecta
        '
        Me.rbtCompraDirecta.AutoSize = True
        Me.rbtCompraDirecta.Checked = True
        Me.rbtCompraDirecta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCompraDirecta.Location = New System.Drawing.Point(11, 16)
        Me.rbtCompraDirecta.Name = "rbtCompraDirecta"
        Me.rbtCompraDirecta.Size = New System.Drawing.Size(131, 19)
        Me.rbtCompraDirecta.TabIndex = 0
        Me.rbtCompraDirecta.TabStop = True
        Me.rbtCompraDirecta.Text = "COMPRA DIRECTA"
        Me.rbtCompraDirecta.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtAcreditamiento)
        Me.GroupBox2.Controls.Add(Me.rbtFondoRotativo)
        Me.GroupBox2.Location = New System.Drawing.Point(682, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 39)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'rbtAcreditamiento
        '
        Me.rbtAcreditamiento.AutoSize = True
        Me.rbtAcreditamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAcreditamiento.Location = New System.Drawing.Point(149, 14)
        Me.rbtAcreditamiento.Name = "rbtAcreditamiento"
        Me.rbtAcreditamiento.Size = New System.Drawing.Size(130, 19)
        Me.rbtAcreditamiento.TabIndex = 1
        Me.rbtAcreditamiento.Text = "ACREDITAMIENTO"
        Me.rbtAcreditamiento.UseVisualStyleBackColor = True
        '
        'rbtFondoRotativo
        '
        Me.rbtFondoRotativo.AutoSize = True
        Me.rbtFondoRotativo.Checked = True
        Me.rbtFondoRotativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFondoRotativo.Location = New System.Drawing.Point(14, 14)
        Me.rbtFondoRotativo.Name = "rbtFondoRotativo"
        Me.rbtFondoRotativo.Size = New System.Drawing.Size(129, 19)
        Me.rbtFondoRotativo.TabIndex = 0
        Me.rbtFondoRotativo.TabStop = True
        Me.rbtFondoRotativo.Text = "FONDO ROTATIVO"
        Me.rbtFondoRotativo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbtDisponibilidadNo)
        Me.GroupBox3.Controls.Add(Me.rbtDisponibilidadSi)
        Me.GroupBox3.Location = New System.Drawing.Point(752, 188)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(143, 39)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'rbtDisponibilidadNo
        '
        Me.rbtDisponibilidadNo.AutoSize = True
        Me.rbtDisponibilidadNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDisponibilidadNo.Location = New System.Drawing.Point(79, 14)
        Me.rbtDisponibilidadNo.Name = "rbtDisponibilidadNo"
        Me.rbtDisponibilidadNo.Size = New System.Drawing.Size(41, 19)
        Me.rbtDisponibilidadNo.TabIndex = 1
        Me.rbtDisponibilidadNo.Text = "No"
        Me.rbtDisponibilidadNo.UseVisualStyleBackColor = True
        '
        'rbtDisponibilidadSi
        '
        Me.rbtDisponibilidadSi.AutoSize = True
        Me.rbtDisponibilidadSi.Checked = True
        Me.rbtDisponibilidadSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDisponibilidadSi.Location = New System.Drawing.Point(15, 14)
        Me.rbtDisponibilidadSi.Name = "rbtDisponibilidadSi"
        Me.rbtDisponibilidadSi.Size = New System.Drawing.Size(36, 19)
        Me.rbtDisponibilidadSi.TabIndex = 0
        Me.rbtDisponibilidadSi.TabStop = True
        Me.rbtDisponibilidadSi.Text = "Si"
        Me.rbtDisponibilidadSi.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(540, 231)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 18)
        Me.Label18.TabIndex = 112
        Me.Label18.Text = "Presupuesto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(540, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Compras"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(539, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 18)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Disponibilidad de presupuest"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(539, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 18)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Modalida de pago"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(540, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(424, 13)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "PARA USO EXCLUSIVO SECCIÓN FINANCIERA/SECCIÓN DE COMPRAS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPresupuesto.ErrorCheck = True
        Me.txtPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresupuesto.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtPresupuesto.Location = New System.Drawing.Point(638, 230)
        Me.txtPresupuesto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPresupuesto.MaxLength = 50
        Me.txtPresupuesto.Name = "txtPresupuesto"
        Me.txtPresupuesto.SetEnabled = True
        Me.txtPresupuesto.SetRequerido = True
        Me.txtPresupuesto.Size = New System.Drawing.Size(331, 21)
        Me.txtPresupuesto.TabIndex = 10
        Me.txtPresupuesto.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'txtCompras
        '
        Me.txtCompras.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCompras.ErrorCheck = True
        Me.txtCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompras.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtCompras.Location = New System.Drawing.Point(638, 254)
        Me.txtCompras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCompras.MaxLength = 50
        Me.txtCompras.Name = "txtCompras"
        Me.txtCompras.SetEnabled = True
        Me.txtCompras.SetRequerido = True
        Me.txtCompras.Size = New System.Drawing.Size(331, 21)
        Me.txtCompras.TabIndex = 11
        Me.txtCompras.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'txtProg
        '
        Me.txtProg.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtProg.ErrorCheck = True
        Me.txtProg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProg.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtProg.Location = New System.Drawing.Point(139, 329)
        Me.txtProg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProg.MaxLength = 5
        Me.txtProg.Name = "txtProg"
        Me.txtProg.SetEnabled = True
        Me.txtProg.SetRequerido = True
        Me.txtProg.Size = New System.Drawing.Size(62, 21)
        Me.txtProg.TabIndex = 14
        Me.txtProg.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(86, 330)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 16)
        Me.Label11.TabIndex = 119
        Me.Label11.Text = "PROG"
        '
        'txtSubp
        '
        Me.txtSubp.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSubp.ErrorCheck = True
        Me.txtSubp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubp.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtSubp.Location = New System.Drawing.Point(262, 329)
        Me.txtSubp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSubp.MaxLength = 5
        Me.txtSubp.Name = "txtSubp"
        Me.txtSubp.SetEnabled = True
        Me.txtSubp.SetRequerido = True
        Me.txtSubp.Size = New System.Drawing.Size(62, 21)
        Me.txtSubp.TabIndex = 15
        Me.txtSubp.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(211, 330)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 16)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "SUBP"
        '
        'txtProy
        '
        Me.txtProy.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtProy.ErrorCheck = True
        Me.txtProy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProy.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtProy.Location = New System.Drawing.Point(390, 329)
        Me.txtProy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProy.MaxLength = 5
        Me.txtProy.Name = "txtProy"
        Me.txtProy.SetEnabled = True
        Me.txtProy.SetRequerido = True
        Me.txtProy.Size = New System.Drawing.Size(62, 21)
        Me.txtProy.TabIndex = 16
        Me.txtProy.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(335, 332)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 16)
        Me.Label13.TabIndex = 123
        Me.Label13.Text = "PROY."
        '
        'txtAct
        '
        Me.txtAct.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtAct.ErrorCheck = True
        Me.txtAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAct.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtAct.Location = New System.Drawing.Point(505, 329)
        Me.txtAct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAct.MaxLength = 5
        Me.txtAct.Name = "txtAct"
        Me.txtAct.SetEnabled = True
        Me.txtAct.SetRequerido = True
        Me.txtAct.Size = New System.Drawing.Size(62, 21)
        Me.txtAct.TabIndex = 17
        Me.txtAct.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(461, 332)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 16)
        Me.Label14.TabIndex = 125
        Me.Label14.Text = "ACT."
        '
        'txtFteFin
        '
        Me.txtFteFin.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFteFin.ErrorCheck = True
        Me.txtFteFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFteFin.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtFteFin.Location = New System.Drawing.Point(907, 329)
        Me.txtFteFin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFteFin.MaxLength = 5
        Me.txtFteFin.Name = "txtFteFin"
        Me.txtFteFin.SetEnabled = True
        Me.txtFteFin.SetRequerido = True
        Me.txtFteFin.Size = New System.Drawing.Size(62, 21)
        Me.txtFteFin.TabIndex = 20
        Me.txtFteFin.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(843, 332)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 16)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "FTE.FIN"
        '
        'txtUbGeo
        '
        Me.txtUbGeo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtUbGeo.ErrorCheck = True
        Me.txtUbGeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbGeo.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtUbGeo.Location = New System.Drawing.Point(770, 329)
        Me.txtUbGeo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUbGeo.MaxLength = 5
        Me.txtUbGeo.Name = "txtUbGeo"
        Me.txtUbGeo.SetEnabled = True
        Me.txtUbGeo.SetRequerido = True
        Me.txtUbGeo.Size = New System.Drawing.Size(62, 21)
        Me.txtUbGeo.TabIndex = 19
        Me.txtUbGeo.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(705, 332)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 16)
        Me.Label16.TabIndex = 129
        Me.Label16.Text = "UB.GEO"
        '
        'txtObra
        '
        Me.txtObra.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtObra.ErrorCheck = True
        Me.txtObra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObra.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtObra.Location = New System.Drawing.Point(629, 329)
        Me.txtObra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtObra.MaxLength = 5
        Me.txtObra.Name = "txtObra"
        Me.txtObra.SetEnabled = True
        Me.txtObra.SetRequerido = True
        Me.txtObra.Size = New System.Drawing.Size(62, 21)
        Me.txtObra.TabIndex = 18
        Me.txtObra.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(577, 332)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 16)
        Me.Label17.TabIndex = 127
        Me.Label17.Text = "OBRA"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(539, 279)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 18)
        Me.Label19.TabIndex = 132
        Me.Label19.Text = "Otro"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(539, 303)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 18)
        Me.Label20.TabIndex = 133
        Me.Label20.Text = "Sub Producto"
        '
        'txtOtro
        '
        Me.txtOtro.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtOtro.ErrorCheck = True
        Me.txtOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtro.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtOtro.Location = New System.Drawing.Point(638, 278)
        Me.txtOtro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOtro.MaxLength = 25
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.SetEnabled = True
        Me.txtOtro.SetRequerido = True
        Me.txtOtro.Size = New System.Drawing.Size(331, 21)
        Me.txtOtro.TabIndex = 12
        Me.txtOtro.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'txtSubProducto
        '
        Me.txtSubProducto.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSubProducto.Enabled = False
        Me.txtSubProducto.ErrorCheck = True
        Me.txtSubProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubProducto.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtSubProducto.Location = New System.Drawing.Point(638, 302)
        Me.txtSubProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSubProducto.MaxLength = 25
        Me.txtSubProducto.Name = "txtSubProducto"
        Me.txtSubProducto.SetEnabled = True
        Me.txtSubProducto.SetRequerido = True
        Me.txtSubProducto.Size = New System.Drawing.Size(331, 21)
        Me.txtSubProducto.TabIndex = 13
        Me.txtSubProducto.Type = SolicitudDePedidoYRequisicion.CustomTextBox.TextType.Text
        '
        'EditPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(984, 560)
        Me.Controls.Add(Me.txtSubProducto)
        Me.Controls.Add(Me.txtOtro)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtFteFin)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtUbGeo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtObra)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtAct)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtProy)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSubp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtProg)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCompras)
        Me.Controls.Add(Me.txtPresupuesto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.dgvFirma)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJustificacion)
        Me.Controls.Add(Me.btnReDisplay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.cboServicio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.KeyPreview = True
        Me.Name = "EditPedido"
        Me.Text = "Sistema de gestión hospitalaria   -- Hospital Regional de El Quiché --"
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtNumero, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.cboServicio, 0)
        Me.Controls.SetChildIndex(Me.cboYear, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.Controls.SetChildIndex(Me.btnReDisplay, 0)
        Me.Controls.SetChildIndex(Me.txtJustificacion, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.btnPrint, 0)
        Me.Controls.SetChildIndex(Me.txtTelefono, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.dgvFirma, 0)
        Me.Controls.SetChildIndex(Me.dgvList, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtPresupuesto, 0)
        Me.Controls.SetChildIndex(Me.txtCompras, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txtProg, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.txtSubp, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txtProy, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.txtAct, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.txtObra, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.txtUbGeo, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.txtFteFin, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.Label20, 0)
        Me.Controls.SetChildIndex(Me.txtOtro, 0)
        Me.Controls.SetChildIndex(Me.txtSubProducto, 0)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFirma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrint As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJustificacion As CustomTextBox
    Friend WithEvents btnReDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cboYear As CustomComboBox
    Friend WithEvents cboServicio As CustomComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFecha As CustomTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumero As CustomTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefono As CustomTextBox
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents dgvFirma As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbtLicitacion As RadioButton
    Friend WithEvents rbtCotizacion As RadioButton
    Friend WithEvents rbtContratoAbierto As RadioButton
    Friend WithEvents rbtCompraDirecta As RadioButton
    Friend WithEvents rbtAcreditamiento As RadioButton
    Friend WithEvents rbtFondoRotativo As RadioButton
    Friend WithEvents rbtDisponibilidadNo As RadioButton
    Friend WithEvents rbtDisponibilidadSi As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPresupuesto As CustomTextBox
    Friend WithEvents txtCompras As CustomTextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents txtProg As CustomTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSubp As CustomTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtProy As CustomTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAct As CustomTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtFteFin As CustomTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtUbGeo As CustomTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtObra As CustomTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents rbtSubastaInversa As RadioButton
    Friend WithEvents rbtBajaCuantilla As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtOtro As CustomTextBox
    Friend WithEvents txtSubProducto As CustomTextBox
    Friend WithEvents btnUp As DataGridViewButtonColumn
    Friend WithEvents btnDown As DataGridViewButtonColumn
    Friend WithEvents btnIns As DataGridViewButtonColumn
    Friend WithEvents btnDel As DataGridViewButtonColumn
    Friend WithEvents txtCodigo_Insu As DataGridViewTextBoxColumn
    Friend WithEvents txtCodigo_Presentacion As DataGridViewTextBoxColumn
    Friend WithEvents txtInsumo As DataGridViewTextBoxColumn
    Friend WithEvents txtUnidad As DataGridViewTextBoxColumn
    Friend WithEvents txtSolicitada As DataGridViewTextBoxColumn
    Friend WithEvents txtAutorizada As DataGridViewTextBoxColumn
    Friend WithEvents txtFinanciero As DataGridViewTextBoxColumn
    Friend WithEvents txtEstimado As DataGridViewTextBoxColumn
    Friend WithEvents chkPaac As DataGridViewCheckBoxColumn
    Friend WithEvents chkAbierto As DataGridViewCheckBoxColumn
End Class
