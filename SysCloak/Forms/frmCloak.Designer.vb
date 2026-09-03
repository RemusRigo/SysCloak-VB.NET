<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCloak
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCloak))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsBtnMS = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnApps = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnSep = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnAbout = New System.Windows.Forms.ToolStripButton()
        Me.pnlPlaceholder = New System.Windows.Forms.Panel()
        Me.tsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 368)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(686, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnMS, Me.tsBtnApps, Me.tsBtnSep, Me.tsBtnAbout})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(686, 31)
        Me.tsMain.TabIndex = 1
        '
        'tsBtnMS
        '
        Me.tsBtnMS.AutoSize = False
        Me.tsBtnMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnMS.Image = Global.SysCloak.My.Resources.Resources.Windows
        Me.tsBtnMS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsBtnMS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnMS.Name = "tsBtnMS"
        Me.tsBtnMS.Size = New System.Drawing.Size(40, 40)
        Me.tsBtnMS.Text = "ToolStripButton1"
        '
        'tsBtnApps
        '
        Me.tsBtnApps.AutoSize = False
        Me.tsBtnApps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnApps.Image = Global.SysCloak.My.Resources.Resources.Apps
        Me.tsBtnApps.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnApps.Name = "tsBtnApps"
        Me.tsBtnApps.Size = New System.Drawing.Size(36, 33)
        Me.tsBtnApps.Text = "ToolStripButton2"
        '
        'tsBtnSep
        '
        Me.tsBtnSep.Name = "tsBtnSep"
        Me.tsBtnSep.Size = New System.Drawing.Size(6, 31)
        '
        'tsBtnAbout
        '
        Me.tsBtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnAbout.Image = CType(resources.GetObject("tsBtnAbout.Image"), System.Drawing.Image)
        Me.tsBtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnAbout.Name = "tsBtnAbout"
        Me.tsBtnAbout.Size = New System.Drawing.Size(36, 28)
        Me.tsBtnAbout.Text = "ToolStripButton3"
        '
        'pnlPlaceholder
        '
        Me.pnlPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPlaceholder.Location = New System.Drawing.Point(0, 31)
        Me.pnlPlaceholder.Name = "pnlPlaceholder"
        Me.pnlPlaceholder.Size = New System.Drawing.Size(686, 337)
        Me.pnlPlaceholder.TabIndex = 2
        '
        'frmCloak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.pnlPlaceholder)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCloak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cloak"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
   Friend WithEvents tsMain As ToolStrip
   Friend WithEvents tsBtnMS As ToolStripButton
   Friend WithEvents tsBtnApps As ToolStripButton
   Friend WithEvents tsBtnSep As ToolStripSeparator
   Friend WithEvents tsBtnAbout As ToolStripButton
   Friend WithEvents pnlPlaceholder As Panel
End Class
