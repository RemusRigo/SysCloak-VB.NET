'--------------------------------------------------------------------------------------------------
' SysOptimizer: frmRegistry.vb: Registry optimization
'    © 2026 Remus Rigo
'       v1.1.20260825
'--------------------------------------------------------------------------------------------------

Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32
Imports SysCloak.UIControls

Public Class frmMS

   Private lvcbCloak As clsListViewCheckBox
   Private pbActions As ctrlProgressBarPercentage
   Private log As New Logger(appName)

   Private grp As ListViewGroup = Nothing

   '-----------------------------------------------------------------------------------------------
   ' Build Options
   Public Sub BuildOptions()
      lvMS.BeginUpdate()
      lvMS.Items.Clear()
      lvMS.Groups.Clear()

      LV_AddGroup(lvMS, grp, "Copilot")
      LVCB_AddItem(lvMS, grp, "Disable Windows Copilot", True, True)
      LVCB_AddItem(lvMS, grp, "Disable Copilot button on taskbar", True, True)

      LV_AddGroup(lvMS, grp, "Edge User Interface")
      LVCB_AddItem(lvMS, grp, "Turn Off Backstack", True, True)
      LVCB_AddItem(lvMS, grp, "Disable Recent Apps", True, True)
      LVCB_AddItem(lvMS, grp, "Disable Tracking of most-frequently-used (MFU) apps in the Start menu and File Explorer", True, True)

      LV_AddGroup(lvMS, grp, "Start Menu")
      LVCB_AddItem(lvMS, grp, "Allow Search To Use Location", True, True)

      LV_AddGroup(lvMS, grp, "Windows AI")
      LVCB_AddItem(lvMS, grp, "Disable AI Data Analysis", True, True)
      If IsAppElevated() Then LVCB_AddItem(lvMS, grp, "Allow Recall Enablement", True, True)
      If IsAppElevated() Then LVCB_AddItem(lvMS, grp, "Turn Off Saving Snapshots", True, True)

      lvMS.Columns(0).Width = -1
      lvMS.Columns(0).Width = lvMS.Columns(0).Width + 30
      lvMS.EndUpdate()
   End Sub

   '-----------------------------------------------------------------------------------------------
   ' Process Actions
   Private Sub ProcessActions(itemsToProcess As List(Of ListViewItem))
      For Each item As ListViewItem In itemsToProcess
         Dim grp = item.Group
         If grp Is Nothing Then Continue For

         Select Case grp.Header
            Case "Copilot"
               Select Case item.Text

                  '--------------------------------------------------------------------------------
                  Case "Disable Windows Copilot"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\WindowsCopilot", "TurnOffWindowsCopilot", 0)
                        If IsAppElevated() Then
                           RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsCopilot", "TurnOffWindowsCopilot", 0)
                        End If
                     Else ' Cloack
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\WindowsCopilot", "TurnOffWindowsCopilot", 1)
                        If IsAppElevated() Then
                           RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsCopilot", "TurnOffWindowsCopilot", 1)
                        End If
                     End If
                     pbActions.Value += 1

                  Case "Disable Copilot button on taskbar"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowCopilotButton", 1)
                     Else ' Cloack
                        RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowCopilotButton", 0)
                     End If
                     pbActions.Value += 1

               End Select

            Case "Edge User Interface"
               Select Case item.Text

                  '--------------------------------------------------------------------------------
                  Case "Turn Off Backstack"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\EdgeUI", "TurnOffBackstack", 0)
                     Else ' Cloack
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\EdgeUI", "TurnOffBackstack", 1)
                     End If
                     pbActions.Value += 1

                  Case "Disable Recent Apps"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\EdgeUI", "DisableRecentApps", 0)
                     Else ' Cloack
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\EdgeUI", "DisableRecentApps", 1)
                     End If
                     pbActions.Value += 1

                  Case "Disable tracking of most-frequently-used (MFU) apps in the Start menu and File Explorer"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\EdgeUI", "DisableMFUTracking", 0)
                     Else ' Cloack
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\EdgeUI", "DisableMFUTracking", 1)
                     End If
                     pbActions.Value += 1

               End Select

            Case "Start Menu" '--------------------------------------------------------------------
               Select Case item.Text

                  Case "Allow Search To Use Location"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "AllowSearchToUseLocation", 1)
                     Else ' Cloak
                        RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "AllowSearchToUseLocation", 0)
                     End If
                     pbActions.Value += 1

               End Select

            Case "Windows AI" '--------------------------------------------------------------------
               Select Case item.Text

                  Case "Disable AI Data Analysis"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\WindowsAI", "DisableAIDataAnalysis", 0)
                        If IsAppElevated() Then
                           RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsAI", "DisableAIDataAnalysis", 0)
                        End If
                     Else ' Cloak
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\WindowsAI", "DisableAIDataAnalysis", 1)
                        If IsAppElevated() Then
                           RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsAI", "DisableAIDataAnalysis", 1)
                        End If
                     End If
                     pbActions.Value += 1

                  Case "Allow Recall Enablement"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\WindowsAI", "AllowRecallEnablement", 1)
                     Else ' Cloak
                        RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\WindowsAI", "AllowRecallEnablement", 0)
                     End If
                     pbActions.Value += 1

                  Case "Turn Off Saving Snapshots"
                     If DirectCast(item.Tag, LV_CheckBoxData).CheckState Then ' Restore default                    
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsAI", "TurnOffSavingSnapshots", 0)
                     Else ' Cloak
                        RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsAI", "TurnOffSavingSnapshots", 1)
                     End If
                     pbActions.Value += 1

               End Select

         End Select
      Next
   End Sub

   Private Sub frmCloak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      lvMS.Columns.Add("Option", 350, HorizontalAlignment.Left)
      lvMS.Columns.Add("Default", 75, HorizontalAlignment.Left)
      lvMS.HeaderStyle = ColumnHeaderStyle.None
      lvcbCloak = New clsListViewCheckBox(lvMS)
      lvcbCloak.AttachContextMenu()

      pbActions = New ctrlProgressBarPercentage()
      pbActions.Dock = DockStyle.None
      pbActions.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
      pbActions.Location = New Point(3, 338)
      pbActions.Size = New Size((Me.Width - btnMSRun.Width - 6), 20)
      Me.Controls.Add(pbActions)

      BuildOptions()
   End Sub

End Class
