<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frEmpleados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.NumericUpDown()
        Me.picfoto = New System.Windows.Forms.PictureBox()
        Me.lbfoto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.openfoto = New System.Windows.Forms.OpenFileDialog()
        Me.gridDatos = New System.Windows.Forms.DataGridView()
        CType(Me.txtid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(83, 50)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 23)
        Me.txtnombre.TabIndex = 0
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(83, 88)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(100, 23)
        Me.txtapellido.TabIndex = 1
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(83, 12)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(42, 23)
        Me.txtid.TabIndex = 2
        '
        'picfoto
        '
        Me.picfoto.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.picfoto.Location = New System.Drawing.Point(83, 132)
        Me.picfoto.Name = "picfoto"
        Me.picfoto.Size = New System.Drawing.Size(141, 117)
        Me.picfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto.TabIndex = 3
        Me.picfoto.TabStop = False
        '
        'lbfoto
        '
        Me.lbfoto.AutoSize = True
        Me.lbfoto.Location = New System.Drawing.Point(87, 272)
        Me.lbfoto.Name = "lbfoto"
        Me.lbfoto.Size = New System.Drawing.Size(0, 15)
        Me.lbfoto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Foto"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 307)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_nuevo.TabIndex = 9
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(93, 307)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 10
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(182, 307)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 11
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(87, 272)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(67, 15)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Seleccionar"
        '
        'gridDatos
        '
        Me.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDatos.Location = New System.Drawing.Point(267, 20)
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RowTemplate.Height = 25
        Me.gridDatos.Size = New System.Drawing.Size(451, 176)
        Me.gridDatos.TabIndex = 13
        '
        'frEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 364)
        Me.Controls.Add(Me.gridDatos)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbfoto)
        Me.Controls.Add(Me.picfoto)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Name = "frEmpleados"
        Me.Text = "Form1"
        CType(Me.txtid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picfoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtid As NumericUpDown
    Friend WithEvents picfoto As PictureBox
    Friend WithEvents lbfoto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents openfoto As OpenFileDialog
    Friend WithEvents gridDatos As DataGridView
End Class
