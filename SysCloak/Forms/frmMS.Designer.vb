<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMS))
        Me.lvMS = New System.Windows.Forms.ListView()
        Me.btnMSRun = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvMS
        '
        Me.lvMS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvMS.HideSelection = False
        Me.lvMS.Location = New System.Drawing.Point(1, 1)
        Me.lvMS.Name = "lvMS"
        Me.lvMS.Size = New System.Drawing.Size(673, 289)
        Me.lvMS.TabIndex = 0
        Me.lvMS.UseCompatibleStateImageBehavior = False
        '
        'btnMSRun
        '
        Me.btnMSRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMSRun.Location = New System.Drawing.Point(627, 292)
        Me.btnMSRun.Name = "btnMSRun"
        Me.btnMSRun.Size = New System.Drawing.Size(43, 20)
        Me.btnMSRun.TabIndex = 1
        Me.btnMSRun.Text = "&Run"
        Me.btnMSRun.UseVisualStyleBackColor = True
        '
        'frmMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 313)
        Me.Controls.Add(Me.btnMSRun)
        Me.Controls.Add(Me.lvMS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMS"
        Me.Text = "Microsoft"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvMS As ListView
    Friend WithEvents btnMSRun As Button
End Class
