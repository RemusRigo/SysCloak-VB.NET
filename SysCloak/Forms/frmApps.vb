'--------------------------------------------------------------------------------------------------
' SysOptimizer: frmApps.vb: Apps privacy
'    © 2026 Remus Rigo
'       v1.1.20260904
'--------------------------------------------------------------------------------------------------

Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32
Imports SysCloak.UIControls

Public Class frmApps

   Private lvcbApps As clsListViewCheckBox
   Private pbActions As ctrlProgressBarPercentage
   Private log As New Logger(appName)

   Private grp As ListViewGroup = Nothing

   '-----------------------------------------------------------------------------------------------
   ' Build Options
   Public Sub BuildOptions()
      lvApps.BeginUpdate()
      lvApps.Items.Clear()
      lvApps.Groups.Clear()

      LV_AddGroup(lvApps, grp, "Microsoft Edge")
      If IsAppElevated() Then LVCB_AddItem(lvApps, grp, "Alternate Error Pages Enabled", True, True)
      If IsAppElevated() Then LVCB_AddItem(lvApps, grp, "New Tab Page Hide Default Top Sites", True, True)
      If IsAppElevated() Then LVCB_AddItem(lvApps, grp, "Show Acrobat Subscription Button", True, True)
      If IsAppElevated() Then LVCB_AddItem(lvApps, grp, "Show Recommendations Enabled", True, True)
      If IsAppElevated() Then LVCB_AddItem(lvApps, grp, "Spotlight Experiences And Recommendations Enabled", True, True)
      If IsAppElevated() Then LVCB_AddItem(lvApps, grp, "Tab Services Enabled", True, True)
      If IsAppElevated() Then LVCB_AddItem(lvApps, grp, "User Feedback Allowed", True, True)
      If IsAppElevated() Then LVCB_AddItem(lvApps, grp, "Wallet Donation Enabled", True, True)

      lvApps.Columns(0).Width = -1
      lvApps.Columns(0).Width = lvApps.Columns(0).Width + 30
      lvApps.EndUpdate()
   End Sub

   '-----------------------------------------------------------------------------------------------
   ' Process Actions
   Private Sub ProcessActions(itemsToProcess As List(Of ListViewItem))
      For Each item As ListViewItem In itemsToProcess
         Dim grp = item.Group
         If grp Is Nothing Then Continue For

         Select Case grp.Header

            Case "Microsoft Edge" '----------------------------------------------------------------
               Select Case item.Text

                  Case "Alternate Error Pages Enabled"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "AlternateErrorPagesEnabled", 1)
                     Else ' Cloak
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "AlternateErrorPagesEnabled", 0)
                     End If
                     pbActions.Value += 1

                  Case "New Tab Page Hide Default Top Sites"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "NewTabPageHideDefaultTopSites", 0)
                     Else ' Cloak
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "NewTabPageHideDefaultTopSites", 1)
                     End If
                     pbActions.Value += 1

                  Case "Show Acrobat Subscription Button"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "ShowAcrobatSubscriptionButton", 1)
                     Else ' Cloak
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "ShowAcrobatSubscriptionButton", 0)
                     End If
                     pbActions.Value += 1

                  Case "Show Recommendations Enabled"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "ShowRecommendationsEnabled", 1)
                     Else ' Cloak
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "ShowRecommendationsEnabled", 0)
                     End If
                     pbActions.Value += 1

                  Case "Spotlight Experiences And Recommendations Enabled"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "SpotlightExperiencesAndRecommendationsEnabled", 1)
                     Else ' Cloak
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "SpotlightExperiencesAndRecommendationsEnabled", 0)
                     End If
                     pbActions.Value += 1

                  Case "Tab Services Enabled"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "TabServicesEnabled", 1)
                     Else ' Cloak
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "TabServicesEnabled", 0)
                     End If
                     pbActions.Value += 1

                  Case "User Feedback Allowed"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "UserFeedbackAllowed", 1)
                     Else ' Cloak
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "UserFeedbackAllowed", 0)
                     End If
                     pbActions.Value += 1

                  Case "Wallet Donation Enabled"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "WalletDonationEnabled", 1)
                     Else ' Cloak
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "WalletDonationEnabled", 0)
                     End If
                     pbActions.Value += 1

               End Select
         End Select
      Next
   End Sub

   Private Sub frmApps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      lvApps.Columns.Add("Option", 350, HorizontalAlignment.Left)
      lvApps.Columns.Add("Default", 75, HorizontalAlignment.Left)
      lvApps.HeaderStyle = ColumnHeaderStyle.None
      lvcbApps = New clsListViewCheckBox(lvApps)
      lvcbApps.AttachContextMenu()

      pbActions = New ctrlProgressBarPercentage()
      pbActions.Dock = DockStyle.None
      pbActions.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
      pbActions.Location = New Point(3, 338)
      pbActions.Size = New Size((Me.Width - btnAppsRun.Width - 6), 20)
      Me.Controls.Add(pbActions)

      BuildOptions()
   End Sub

End Class
