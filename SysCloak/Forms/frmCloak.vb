Public Class frmCloak

   Private Sub ShowForm(frm As Form)
      frm.TopLevel = False
      frm.FormBorderStyle = FormBorderStyle.None
      frm.Dock = DockStyle.Fill
      pnlPlaceholder.Controls.Clear()
      pnlPlaceholder.Controls.Add(frm)
      frm.Show()
   End Sub

   Private Sub tsBtnMS_Click(sender As Object, e As EventArgs) Handles tsBtnMS.Click
      ShowForm(frmMS)
   End Sub

   Private Sub tsBtnApps_Click(sender As Object, e As EventArgs) Handles tsBtnApps.Click
      ShowForm(frmApps)
   End Sub

End Class