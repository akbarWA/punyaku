<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUUTAMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTERBARANGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATABARANGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUUTAMAToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUUTAMAToolStripMenuItem
        '
        Me.MENUUTAMAToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MENUUTAMAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERBARANGToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem})
        Me.MENUUTAMAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.MENUUTAMAToolStripMenuItem.Name = "MENUUTAMAToolStripMenuItem"
        Me.MENUUTAMAToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.MENUUTAMAToolStripMenuItem.Text = "MENU UTAMA"
        '
        'MASTERBARANGToolStripMenuItem
        '
        Me.MASTERBARANGToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATABARANGToolStripMenuItem})
        Me.MASTERBARANGToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua
        Me.MASTERBARANGToolStripMenuItem.Name = "MASTERBARANGToolStripMenuItem"
        Me.MASTERBARANGToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.MASTERBARANGToolStripMenuItem.Text = "MASTER BARANG"
        '
        'DATABARANGToolStripMenuItem
        '
        Me.DATABARANGToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson
        Me.DATABARANGToolStripMenuItem.Name = "DATABARANGToolStripMenuItem"
        Me.DATABARANGToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DATABARANGToolStripMenuItem.Text = "DATA BARANG"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arno Pro Smbd Caption", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(223, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "APLIKASI PERSEDIAAN BARANG"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUUTAMAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MASTERBARANGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATABARANGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
