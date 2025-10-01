<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnClearSettings = New System.Windows.Forms.Button()
        Me.btnAddRequisicion = New System.Windows.Forms.Button()
        Me.btnRequisicionList = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnd.Location = New System.Drawing.Point(859, 58)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(112, 40)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "Fin"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(552, 307)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(249, 191)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'btnClearSettings
        '
        Me.btnClearSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearSettings.Location = New System.Drawing.Point(859, 508)
        Me.btnClearSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearSettings.Name = "btnClearSettings"
        Me.btnClearSettings.Size = New System.Drawing.Size(112, 40)
        Me.btnClearSettings.TabIndex = 6
        Me.btnClearSettings.Text = "Ajuste claro"
        Me.btnClearSettings.UseVisualStyleBackColor = True
        '
        'btnAddRequisicion
        '
        Me.btnAddRequisicion.Location = New System.Drawing.Point(172, 221)
        Me.btnAddRequisicion.Name = "btnAddRequisicion"
        Me.btnAddRequisicion.Size = New System.Drawing.Size(249, 37)
        Me.btnAddRequisicion.TabIndex = 1
        Me.btnAddRequisicion.Text = "Nueva Requisición"
        Me.btnAddRequisicion.UseVisualStyleBackColor = True
        '
        'btnRequisicionList
        '
        Me.btnRequisicionList.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRequisicionList.Location = New System.Drawing.Point(172, 161)
        Me.btnRequisicionList.Name = "btnRequisicionList"
        Me.btnRequisicionList.Size = New System.Drawing.Size(249, 37)
        Me.btnRequisicionList.TabIndex = 0
        Me.btnRequisicionList.Text = "Lista de solicitudes"
        Me.btnRequisicionList.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(170, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Solicitud de Despacho"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(590, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 25)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Mantenimiento"
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.BackColor = System.Drawing.Color.Salmon
        Me.btnMantenimiento.Location = New System.Drawing.Point(552, 161)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Size = New System.Drawing.Size(249, 37)
        Me.btnMantenimiento.TabIndex = 4
        Me.btnMantenimiento.Text = "Mantenimiento"
        Me.btnMantenimiento.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnMantenimiento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddRequisicion)
        Me.Controls.Add(Me.btnRequisicionList)
        Me.Controls.Add(Me.btnClearSettings)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnEnd)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "MainMenu"
        Me.Text = "Sistema de gestión hospitalaria   -- Hospital Regional de El Quiché --"
        Me.Controls.SetChildIndex(Me.btnEnd, 0)
        Me.Controls.SetChildIndex(Me.PictureBox2, 0)
        Me.Controls.SetChildIndex(Me.btnClearSettings, 0)
        Me.Controls.SetChildIndex(Me.btnRequisicionList, 0)
        Me.Controls.SetChildIndex(Me.btnAddRequisicion, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnMantenimiento, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnd As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnClearSettings As Button
    Friend WithEvents btnAddRequisicion As Button
    Friend WithEvents btnRequisicionList As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnMantenimiento As Button
End Class
