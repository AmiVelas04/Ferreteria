<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngCliente))
        Me.PanIz = New System.Windows.Forms.Panel()
        Me.BtnLimp = New System.Windows.Forms.Button()
        Me.BtnAg = New System.Windows.Forms.Button()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNIT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanBot = New System.Windows.Forms.Panel()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNomcli = New System.Windows.Forms.TextBox()
        Me.PanCent = New System.Windows.Forms.Panel()
        Me.DgvCli = New System.Windows.Forms.DataGridView()
        Me.Lblcod = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.TxtDpi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanIz.SuspendLayout()
        Me.PanBot.SuspendLayout()
        Me.PanCent.SuspendLayout()
        CType(Me.DgvCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanIz
        '
        Me.PanIz.Controls.Add(Me.TxtDpi)
        Me.PanIz.Controls.Add(Me.Label6)
        Me.PanIz.Controls.Add(Me.Lblcod)
        Me.PanIz.Controls.Add(Me.BtnLimp)
        Me.PanIz.Controls.Add(Me.BtnAg)
        Me.PanIz.Controls.Add(Me.TxtTel)
        Me.PanIz.Controls.Add(Me.Label5)
        Me.PanIz.Controls.Add(Me.TxtDir)
        Me.PanIz.Controls.Add(Me.Label4)
        Me.PanIz.Controls.Add(Me.TxtNIT)
        Me.PanIz.Controls.Add(Me.Label3)
        Me.PanIz.Controls.Add(Me.TxtNom)
        Me.PanIz.Controls.Add(Me.Label2)
        Me.PanIz.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanIz.Location = New System.Drawing.Point(0, 0)
        Me.PanIz.Name = "PanIz"
        Me.PanIz.Size = New System.Drawing.Size(243, 498)
        Me.PanIz.TabIndex = 13
        '
        'BtnLimp
        '
        Me.BtnLimp.Image = CType(resources.GetObject("BtnLimp.Image"), System.Drawing.Image)
        Me.BtnLimp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimp.Location = New System.Drawing.Point(126, 388)
        Me.BtnLimp.Name = "BtnLimp"
        Me.BtnLimp.Size = New System.Drawing.Size(101, 40)
        Me.BtnLimp.TabIndex = 21
        Me.BtnLimp.Text = "Limpiar"
        Me.BtnLimp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimp.UseVisualStyleBackColor = True
        '
        'BtnAg
        '
        Me.BtnAg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnAg.Location = New System.Drawing.Point(0, 448)
        Me.BtnAg.Name = "BtnAg"
        Me.BtnAg.Size = New System.Drawing.Size(243, 50)
        Me.BtnAg.TabIndex = 20
        Me.BtnAg.Text = "Guardar"
        Me.BtnAg.UseVisualStyleBackColor = True
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(12, 287)
        Me.TxtTel.MaxLength = 8
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(215, 26)
        Me.TxtTel.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Telefono"
        '
        'TxtDir
        '
        Me.TxtDir.Location = New System.Drawing.Point(12, 163)
        Me.TxtDir.Name = "TxtDir"
        Me.TxtDir.Size = New System.Drawing.Size(215, 26)
        Me.TxtDir.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Direccion"
        '
        'TxtNIT
        '
        Me.TxtNIT.Location = New System.Drawing.Point(12, 100)
        Me.TxtNIT.Name = "TxtNIT"
        Me.TxtNIT.Size = New System.Drawing.Size(100, 26)
        Me.TxtNIT.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "NIT"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(12, 48)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(191, 26)
        Me.TxtNom.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre"
        '
        'PanBot
        '
        Me.PanBot.Controls.Add(Me.BtnEditar)
        Me.PanBot.Controls.Add(Me.BtnBuscar)
        Me.PanBot.Controls.Add(Me.Label1)
        Me.PanBot.Controls.Add(Me.TxtNomcli)
        Me.PanBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanBot.Location = New System.Drawing.Point(243, 428)
        Me.PanBot.Name = "PanBot"
        Me.PanBot.Size = New System.Drawing.Size(619, 70)
        Me.PanBot.TabIndex = 14
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(216, 20)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(102, 38)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre cliente"
        '
        'TxtNomcli
        '
        Me.TxtNomcli.Location = New System.Drawing.Point(6, 32)
        Me.TxtNomcli.Name = "TxtNomcli"
        Me.TxtNomcli.Size = New System.Drawing.Size(204, 26)
        Me.TxtNomcli.TabIndex = 0
        '
        'PanCent
        '
        Me.PanCent.Controls.Add(Me.DgvCli)
        Me.PanCent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCent.Location = New System.Drawing.Point(243, 0)
        Me.PanCent.Name = "PanCent"
        Me.PanCent.Size = New System.Drawing.Size(619, 428)
        Me.PanCent.TabIndex = 15
        '
        'DgvCli
        '
        Me.DgvCli.AllowUserToAddRows = False
        Me.DgvCli.AllowUserToDeleteRows = False
        Me.DgvCli.AllowUserToResizeColumns = False
        Me.DgvCli.AllowUserToResizeRows = False
        Me.DgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCli.Location = New System.Drawing.Point(0, 0)
        Me.DgvCli.Name = "DgvCli"
        Me.DgvCli.ReadOnly = True
        Me.DgvCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCli.Size = New System.Drawing.Size(619, 428)
        Me.DgvCli.TabIndex = 0
        '
        'Lblcod
        '
        Me.Lblcod.AutoSize = True
        Me.Lblcod.Location = New System.Drawing.Point(37, 331)
        Me.Lblcod.Name = "Lblcod"
        Me.Lblcod.Size = New System.Drawing.Size(19, 20)
        Me.Lblcod.TabIndex = 22
        Me.Lblcod.Text = "0"
        Me.Lblcod.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(334, 20)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 38)
        Me.BtnEditar.TabIndex = 3
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'TxtDpi
        '
        Me.TxtDpi.Location = New System.Drawing.Point(12, 225)
        Me.TxtDpi.MaxLength = 13
        Me.TxtDpi.Name = "TxtDpi"
        Me.TxtDpi.Size = New System.Drawing.Size(215, 26)
        Me.TxtDpi.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "DPI"
        '
        'IngCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(862, 498)
        Me.Controls.Add(Me.PanCent)
        Me.Controls.Add(Me.PanBot)
        Me.Controls.Add(Me.PanIz)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "IngCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Cliente"
        Me.PanIz.ResumeLayout(False)
        Me.PanIz.PerformLayout()
        Me.PanBot.ResumeLayout(False)
        Me.PanBot.PerformLayout()
        Me.PanCent.ResumeLayout(False)
        CType(Me.DgvCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanIz As Panel
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDir As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNIT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLimp As Button
    Friend WithEvents BtnAg As Button
    Friend WithEvents PanBot As Panel
    Friend WithEvents PanCent As Panel
    Friend WithEvents DgvCli As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNomcli As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Lblcod As Label
    Friend WithEvents BtnEditar As Button
    Friend WithEvents TxtDpi As TextBox
    Friend WithEvents Label6 As Label
End Class
