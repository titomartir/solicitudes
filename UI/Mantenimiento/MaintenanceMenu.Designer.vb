<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MaintenanceMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintenanceMenu))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnServicio = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnProductList = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddServicio = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddUnidad = New System.Windows.Forms.Button()
        Me.btnUnidadList = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(543, 305)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(249, 183)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
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
        'btnServicio
        '
        Me.btnServicio.Location = New System.Drawing.Point(543, 157)
        Me.btnServicio.Name = "btnServicio"
        Me.btnServicio.Size = New System.Drawing.Size(249, 37)
        Me.btnServicio.TabIndex = 4
        Me.btnServicio.Text = "Lista de servicio"
        Me.btnServicio.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(250, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Insumos"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(176, 217)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(249, 37)
        Me.btnAddProduct.TabIndex = 1
        Me.btnAddProduct.Text = "Agregar de insumos"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnProductList
        '
        Me.btnProductList.Location = New System.Drawing.Point(176, 157)
        Me.btnProductList.Name = "btnProductList"
        Me.btnProductList.Size = New System.Drawing.Size(249, 37)
        Me.btnProductList.TabIndex = 0
        Me.btnProductList.Text = "Lista de insumos"
        Me.btnProductList.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(617, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Servicio"
        '
        'btnAddServicio
        '
        Me.btnAddServicio.Location = New System.Drawing.Point(543, 217)
        Me.btnAddServicio.Name = "btnAddServicio"
        Me.btnAddServicio.Size = New System.Drawing.Size(249, 37)
        Me.btnAddServicio.TabIndex = 5
        Me.btnAddServicio.Text = "Agregar de servicio"
        Me.btnAddServicio.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(257, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Unidad"
        '
        'btnAddUnidad
        '
        Me.btnAddUnidad.Location = New System.Drawing.Point(176, 390)
        Me.btnAddUnidad.Name = "btnAddUnidad"
        Me.btnAddUnidad.Size = New System.Drawing.Size(249, 37)
        Me.btnAddUnidad.TabIndex = 3
        Me.btnAddUnidad.Text = "Agregar de unidad"
        Me.btnAddUnidad.UseVisualStyleBackColor = True
        '
        'btnUnidadList
        '
        Me.btnUnidadList.Location = New System.Drawing.Point(176, 330)
        Me.btnUnidadList.Name = "btnUnidadList"
        Me.btnUnidadList.Size = New System.Drawing.Size(249, 37)
        Me.btnUnidadList.TabIndex = 2
        Me.btnUnidadList.Text = "Lista deunidad"
        Me.btnUnidadList.UseVisualStyleBackColor = True
        '
        'MaintenanceMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddUnidad)
        Me.Controls.Add(Me.btnUnidadList)
        Me.Controls.Add(Me.btnAddServicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.btnProductList)
        Me.Controls.Add(Me.btnServicio)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnClose)
        Me.KeyPreview = True
        Me.Name = "MaintenanceMenu"
        Me.Text = "Sistema de gestión hospitalaria   -- Hospital Regional de El Quiché --"
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBox2, 0)
        Me.Controls.SetChildIndex(Me.btnServicio, 0)
        Me.Controls.SetChildIndex(Me.btnProductList, 0)
        Me.Controls.SetChildIndex(Me.btnAddProduct, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnAddServicio, 0)
        Me.Controls.SetChildIndex(Me.btnUnidadList, 0)
        Me.Controls.SetChildIndex(Me.btnAddUnidad, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnServicio As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnProductList As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddServicio As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddUnidad As Button
    Friend WithEvents btnUnidadList As Button
End Class
