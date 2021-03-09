<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.txtced = New System.Windows.Forms.TextBox()
        Me.txtapell = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CBSEX = New System.Windows.Forms.ComboBox()
        Me.BTNMOSTRAR = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PNLDATA = New System.Windows.Forms.Panel()
        Me.DGVDATA = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.PNLDATA.SuspendLayout()
        CType(Me.DGVDATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(209, 74)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(100, 22)
        Me.txtnom.TabIndex = 0
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(527, 74)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(100, 22)
        Me.txtedad.TabIndex = 1
        '
        'txtced
        '
        Me.txtced.Location = New System.Drawing.Point(22, 156)
        Me.txtced.Name = "txtced"
        Me.txtced.Size = New System.Drawing.Size(100, 22)
        Me.txtced.TabIndex = 2
        '
        'txtapell
        '
        Me.txtapell.Location = New System.Drawing.Point(377, 74)
        Me.txtapell.Name = "txtapell"
        Me.txtapell.Size = New System.Drawing.Size(100, 22)
        Me.txtapell.TabIndex = 3
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(22, 74)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(140, 22)
        Me.txtid.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(388, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "APELLIDO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "SEXO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(524, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "EDAD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "CEDULA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(876, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 41)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "INGRESAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CBSEX
        '
        Me.CBSEX.FormattingEnabled = True
        Me.CBSEX.Items.AddRange(New Object() {"HOMBRE", "MUJER "})
        Me.CBSEX.Location = New System.Drawing.Point(209, 155)
        Me.CBSEX.Name = "CBSEX"
        Me.CBSEX.Size = New System.Drawing.Size(121, 24)
        Me.CBSEX.TabIndex = 14
        '
        'BTNMOSTRAR
        '
        Me.BTNMOSTRAR.Location = New System.Drawing.Point(876, 79)
        Me.BTNMOSTRAR.Name = "BTNMOSTRAR"
        Me.BTNMOSTRAR.Size = New System.Drawing.Size(205, 41)
        Me.BTNMOSTRAR.TabIndex = 15
        Me.BTNMOSTRAR.Text = "MOSTRAR DATOS "
        Me.BTNMOSTRAR.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(876, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 41)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "REGRESAR "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnom)
        Me.GroupBox1.Controls.Add(Me.txtedad)
        Me.GroupBox1.Controls.Add(Me.CBSEX)
        Me.GroupBox1.Controls.Add(Me.txtced)
        Me.GroupBox1.Controls.Add(Me.txtapell)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 211)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS "
        '
        'PNLDATA
        '
        Me.PNLDATA.Controls.Add(Me.DGVDATA)
        Me.PNLDATA.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNLDATA.Location = New System.Drawing.Point(0, 268)
        Me.PNLDATA.Name = "PNLDATA"
        Me.PNLDATA.Size = New System.Drawing.Size(1093, 287)
        Me.PNLDATA.TabIndex = 20
        Me.PNLDATA.Visible = False
        '
        'DGVDATA
        '
        Me.DGVDATA.AllowUserToAddRows = False
        Me.DGVDATA.AllowUserToDeleteRows = False
        Me.DGVDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDATA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVDATA.Location = New System.Drawing.Point(0, 0)
        Me.DGVDATA.Name = "DGVDATA"
        Me.DGVDATA.ReadOnly = True
        Me.DGVDATA.RowHeadersWidth = 51
        Me.DGVDATA.RowTemplate.Height = 24
        Me.DGVDATA.Size = New System.Drawing.Size(1093, 287)
        Me.DGVDATA.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 555)
        Me.Controls.Add(Me.PNLDATA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTNMOSTRAR)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PNLDATA.ResumeLayout(False)
        CType(Me.DGVDATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtnom As TextBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents txtced As TextBox
    Friend WithEvents txtapell As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CBSEX As ComboBox
    Friend WithEvents BTNMOSTRAR As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PNLDATA As Panel
    Friend WithEvents DGVDATA As DataGridView
End Class
