<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TXTUSER = New System.Windows.Forms.TextBox()
        Me.TXTPASS = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PBOFF = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PBON = New System.Windows.Forms.PictureBox()
        Me.TXTCONEXION = New System.Windows.Forms.TextBox()
        CType(Me.PBOFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBON, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(537, 341)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 1
        '
        'TXTUSER
        '
        Me.TXTUSER.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUSER.Location = New System.Drawing.Point(142, 313)
        Me.TXTUSER.Multiline = True
        Me.TXTUSER.Name = "TXTUSER"
        Me.TXTUSER.Size = New System.Drawing.Size(222, 37)
        Me.TXTUSER.TabIndex = 2
        '
        'TXTPASS
        '
        Me.TXTPASS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPASS.Location = New System.Drawing.Point(142, 397)
        Me.TXTPASS.Multiline = True
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.Size = New System.Drawing.Size(222, 37)
        Me.TXTPASS.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(184, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 60)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "ENTRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PBOFF
        '
        Me.PBOFF.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PBOFF.Image = Global.LOGINCONMYSQL.My.Resources.Resources._OF
        Me.PBOFF.Location = New System.Drawing.Point(305, 10)
        Me.PBOFF.Name = "PBOFF"
        Me.PBOFF.Size = New System.Drawing.Size(100, 50)
        Me.PBOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBOFF.TabIndex = 5
        Me.PBOFF.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LOGINCONMYSQL.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(412, 705)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PBON
        '
        Me.PBON.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PBON.Image = Global.LOGINCONMYSQL.My.Resources.Resources._ON
        Me.PBON.Location = New System.Drawing.Point(305, 10)
        Me.PBON.Name = "PBON"
        Me.PBON.Size = New System.Drawing.Size(100, 50)
        Me.PBON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBON.TabIndex = 6
        Me.PBON.TabStop = False
        Me.PBON.Visible = False
        '
        'TXTCONEXION
        '
        Me.TXTCONEXION.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TXTCONEXION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTCONEXION.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.TXTCONEXION.Location = New System.Drawing.Point(300, 66)
        Me.TXTCONEXION.Name = "TXTCONEXION"
        Me.TXTCONEXION.Size = New System.Drawing.Size(100, 15)
        Me.TXTCONEXION.TabIndex = 7
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 705)
        Me.Controls.Add(Me.TXTCONEXION)
        Me.Controls.Add(Me.PBON)
        Me.Controls.Add(Me.PBOFF)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXTPASS)
        Me.Controls.Add(Me.TXTUSER)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmlogin"
        Me.Text = "Form1"
        CType(Me.PBOFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBON, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TXTUSER As TextBox
    Friend WithEvents TXTPASS As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PBOFF As PictureBox
    Friend WithEvents PBON As PictureBox
    Friend WithEvents TXTCONEXION As TextBox
End Class
