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
        Me.components = New System.ComponentModel.Container()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.TmOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.TmMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnCompras = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnProducto = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btnmenu = New System.Windows.Forms.PictureBox()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PanelPrincipal.SuspendLayout()
        Me.Panelmenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btnmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelPrincipal.Controls.Add(Me.BtnRestaurar)
        Me.PanelPrincipal.Controls.Add(Me.BtnMinimizar)
        Me.PanelPrincipal.Controls.Add(Me.BtnMaximizar)
        Me.PanelPrincipal.Controls.Add(Me.BtnCerrar)
        Me.PanelPrincipal.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPrincipal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(1100, 40)
        Me.PanelPrincipal.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(125, 28)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(8, 8)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panelmenu
        '
        Me.Panelmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panelmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panelmenu.Controls.Add(Me.Panel3)
        Me.Panelmenu.Controls.Add(Me.Panel4)
        Me.Panelmenu.Controls.Add(Me.Panel2)
        Me.Panelmenu.Controls.Add(Me.BtnVentas)
        Me.Panelmenu.Controls.Add(Me.BtnCompras)
        Me.Panelmenu.Controls.Add(Me.BtnClientes)
        Me.Panelmenu.Controls.Add(Me.Panel1)
        Me.Panelmenu.Controls.Add(Me.BtnProducto)
        Me.Panelmenu.Controls.Add(Me.PictureBox1)
        Me.Panelmenu.Controls.Add(Me.Btnmenu)
        Me.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelmenu.Location = New System.Drawing.Point(0, 40)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(220, 460)
        Me.Panelmenu.TabIndex = 1
        '
        'TmOcultar
        '
        '
        'TmMostrar
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(0, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Location = New System.Drawing.Point(0, 227)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel3.Location = New System.Drawing.Point(0, 283)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel4.Location = New System.Drawing.Point(0, 171)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 3
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelContenedor.BackgroundImage = Global.Menu_desplegable.My.Resources.Resources.MegaManZeroZXZXASountrackSoundbox
        Me.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(220, 40)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(880, 460)
        Me.PanelContenedor.TabIndex = 2
        '
        'BtnVentas
        '
        Me.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVentas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnVentas.Image = Global.Menu_desplegable.My.Resources.Resources.venta
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.Location = New System.Drawing.Point(0, 171)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(220, 50)
        Me.BtnVentas.TabIndex = 5
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'BtnCompras
        '
        Me.BtnCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCompras.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCompras.FlatAppearance.BorderSize = 0
        Me.BtnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.BtnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompras.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCompras.Image = Global.Menu_desplegable.My.Resources.Resources.compras
        Me.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompras.Location = New System.Drawing.Point(3, 283)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Size = New System.Drawing.Size(220, 50)
        Me.BtnCompras.TabIndex = 4
        Me.BtnCompras.Text = "Compras"
        Me.BtnCompras.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnClientes.Image = Global.Menu_desplegable.My.Resources.Resources.clientes
        Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.Location = New System.Drawing.Point(3, 227)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(220, 50)
        Me.BtnClientes.TabIndex = 3
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnProducto
        '
        Me.BtnProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnProducto.FlatAppearance.BorderSize = 0
        Me.BtnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.BtnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProducto.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnProducto.Image = Global.Menu_desplegable.My.Resources.Resources.producto
        Me.BtnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProducto.Location = New System.Drawing.Point(3, 115)
        Me.BtnProducto.Name = "BtnProducto"
        Me.BtnProducto.Size = New System.Drawing.Size(220, 50)
        Me.BtnProducto.TabIndex = 0
        Me.BtnProducto.Text = "Producto"
        Me.BtnProducto.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Menu_desplegable.My.Resources.Resources.megaman_xz
        Me.PictureBox1.Location = New System.Drawing.Point(3, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Btnmenu
        '
        Me.Btnmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnmenu.Image = Global.Menu_desplegable.My.Resources.Resources.Mobile_Menu_Icon
        Me.Btnmenu.Location = New System.Drawing.Point(174, 3)
        Me.Btnmenu.Name = "Btnmenu"
        Me.Btnmenu.Size = New System.Drawing.Size(46, 34)
        Me.Btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btnmenu.TabIndex = 0
        Me.Btnmenu.TabStop = False
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.FlatAppearance.BorderSize = 0
        Me.BtnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurar.Image = Global.Menu_desplegable.My.Resources.Resources.Icono_Restaurar
        Me.BtnRestaurar.Location = New System.Drawing.Point(1014, 0)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.BtnRestaurar.TabIndex = 4
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        Me.BtnRestaurar.Visible = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Image = Global.Menu_desplegable.My.Resources.Resources.Icono_Minimizar
        Me.BtnMinimizar.Location = New System.Drawing.Point(968, 0)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.BtnMinimizar.TabIndex = 3
        Me.BtnMinimizar.UseVisualStyleBackColor = True
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.FlatAppearance.BorderSize = 0
        Me.BtnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizar.Image = Global.Menu_desplegable.My.Resources.Resources.Icono_Maximizar
        Me.BtnMaximizar.Location = New System.Drawing.Point(1014, 0)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.BtnMaximizar.TabIndex = 2
        Me.BtnMaximizar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = Global.Menu_desplegable.My.Resources.Resources.Icono_cerrar_FN
        Me.BtnCerrar.Location = New System.Drawing.Point(1060, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1100, 500)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.Panelmenu)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelPrincipal.ResumeLayout(False)
        Me.Panelmenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btnmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panelmenu As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents Btnmenu As PictureBox
    Friend WithEvents TmOcultar As Timer
    Friend WithEvents TmMostrar As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents BtnProducto As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnVentas As Button
    Friend WithEvents BtnCompras As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
End Class
