<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtOpciones = New System.Windows.Forms.TextBox()
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.btnConfirmarPedido = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.radioBtnRegular = New System.Windows.Forms.RadioButton()
        Me.radioBtnVeg = New System.Windows.Forms.RadioButton()
        Me.radioBtnOtra = New System.Windows.Forms.RadioButton()
        Me.lblDieta = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.lblTitulo)
        Me.panel1.Location = New System.Drawing.Point(12, 12)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(428, 98)
        Me.panel1.TabIndex = 2
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(303, -12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(120, 105)
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(3, 30)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(304, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Restó - Haga Su Pedido"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(18, 225)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(318, 28)
        Me.ComboBox1.TabIndex = 3
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(342, 225)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(94, 35)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtOpciones
        '
        Me.txtOpciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtOpciones.Enabled = False
        Me.txtOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpciones.Location = New System.Drawing.Point(18, 177)
        Me.txtOpciones.Name = "txtOpciones"
        Me.txtOpciones.Size = New System.Drawing.Size(418, 34)
        Me.txtOpciones.TabIndex = 5
        '
        'txtPedido
        '
        Me.txtPedido.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.Location = New System.Drawing.Point(18, 277)
        Me.txtPedido.Multiline = True
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.ReadOnly = True
        Me.txtPedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPedido.Size = New System.Drawing.Size(414, 196)
        Me.txtPedido.TabIndex = 6
        '
        'btnConfirmarPedido
        '
        Me.btnConfirmarPedido.Enabled = False
        Me.btnConfirmarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarPedido.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnConfirmarPedido.Location = New System.Drawing.Point(204, 479)
        Me.btnConfirmarPedido.Name = "btnConfirmarPedido"
        Me.btnConfirmarPedido.Size = New System.Drawing.Size(226, 38)
        Me.btnConfirmarPedido.TabIndex = 7
        Me.btnConfirmarPedido.Text = "Confirmar pedido"
        Me.btnConfirmarPedido.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Enabled = False
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAtras.Location = New System.Drawing.Point(18, 481)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(180, 38)
        Me.btnAtras.TabIndex = 8
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'radioBtnRegular
        '
        Me.radioBtnRegular.AutoSize = True
        Me.radioBtnRegular.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.radioBtnRegular.Checked = True
        Me.radioBtnRegular.Location = New System.Drawing.Point(12, 150)
        Me.radioBtnRegular.Name = "radioBtnRegular"
        Me.radioBtnRegular.Size = New System.Drawing.Size(79, 21)
        Me.radioBtnRegular.TabIndex = 9
        Me.radioBtnRegular.TabStop = True
        Me.radioBtnRegular.Text = "Regular"
        Me.radioBtnRegular.UseVisualStyleBackColor = False
        '
        'radioBtnVeg
        '
        Me.radioBtnVeg.AutoSize = True
        Me.radioBtnVeg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.radioBtnVeg.Location = New System.Drawing.Point(112, 150)
        Me.radioBtnVeg.Name = "radioBtnVeg"
        Me.radioBtnVeg.Size = New System.Drawing.Size(106, 21)
        Me.radioBtnVeg.TabIndex = 10
        Me.radioBtnVeg.Text = "Vegetariana"
        Me.radioBtnVeg.UseVisualStyleBackColor = False
        '
        'radioBtnOtra
        '
        Me.radioBtnOtra.AutoSize = True
        Me.radioBtnOtra.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.radioBtnOtra.Location = New System.Drawing.Point(254, 150)
        Me.radioBtnOtra.Name = "radioBtnOtra"
        Me.radioBtnOtra.Size = New System.Drawing.Size(57, 21)
        Me.radioBtnOtra.TabIndex = 11
        Me.radioBtnOtra.Text = "Otra"
        Me.radioBtnOtra.UseVisualStyleBackColor = False
        '
        'lblDieta
        '
        Me.lblDieta.AutoSize = True
        Me.lblDieta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblDieta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDieta.Location = New System.Drawing.Point(12, 123)
        Me.lblDieta.Name = "lblDieta"
        Me.lblDieta.Size = New System.Drawing.Size(60, 20)
        Me.lblDieta.TabIndex = 12
        Me.lblDieta.Text = "Dieta:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(447, 527)
        Me.Controls.Add(Me.lblDieta)
        Me.Controls.Add(Me.radioBtnOtra)
        Me.Controls.Add(Me.radioBtnVeg)
        Me.Controls.Add(Me.radioBtnRegular)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnConfirmarPedido)
        Me.Controls.Add(Me.txtPedido)
        Me.Controls.Add(Me.txtOpciones)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.panel1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Restaurante - Autoservicio"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents txtOpciones As System.Windows.Forms.TextBox
    Friend WithEvents txtPedido As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirmarPedido As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents radioBtnRegular As System.Windows.Forms.RadioButton
    Friend WithEvents radioBtnVeg As System.Windows.Forms.RadioButton
    Friend WithEvents radioBtnOtra As System.Windows.Forms.RadioButton
    Friend WithEvents lblDieta As System.Windows.Forms.Label

End Class
