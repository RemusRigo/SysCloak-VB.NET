# SysCloak: User's Guide

> SysCloak is **in progress**: the options are listed, but applying them is not finished yet.



## Downloads & Runtimes

Download the latest release from the [Releases page](https://github.com/RemusRigo/SysCloak-VB.NET/releases).

|Folder|Target Framework|Architecture|Required Runtime|
|-|-|-|-|
|`net4.8 x64`|.NET Framework 4.8|64-bit|[.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48) (included in Windows 10/11)|
|`net8.0 x64`|.NET 8.0|64-bit|[.NET 8.0 Desktop Runtime (x64)](https://dotnet.microsoft.com/download/dotnet/8.0)|
|`net10.0 x64`|.NET 10.0|64-bit|[.NET 10.0 Desktop Runtime (x64)](https://dotnet.microsoft.com/download/dotnet/10.0)|

> **Which one do I need?** On Windows 10/11, the **net4.8** build runs without installing anything.
> For the .NET 8.0/10.0 builds, the plain ".NET Runtime" is not enough; install the **Desktop** Runtime.



## Install

SysCloak is portable: there is no installer.

1. Download and extract the folder that matches your system, e.g. `net4.8 x64`.
2. Copy the **whole folder** to a location where you have write access, for example `D:\My Apps\SysCloak\`.
3. Right-click `SysCloak.exe` → **Run as administrator** to see all the options (or double-click it for the current-user options only).

> If Windows blocks the file ("Windows protected your PC"), right-click `SysCloak.exe` →
> **Properties** → check **Unblock** → **OK**, then try again.



## Usage

The toolbar has 3 buttons: **Microsoft** (Windows options), **Apps** (application options) and **About**.

Each list shows the options grouped by category, with their Windows **Default** state.
Click an option's check box to change it; right-click the list to check or uncheck all.

### Microsoft

|Group|Options|Needs admin|
|-|-|-|
|**Copilot**|Disable Windows Copilot, Disable Copilot button on taskbar| |
|**Edge User Interface**|Turn Off Backstack, Disable Recent Apps, Disable tracking of most-frequently-used (MFU) apps| |
|**Location And Sensors**|Disable Location, Location Scripting, Sensors, Windows Location Provider|yes|
|**Windows AI**|Disable AI Data Analysis, Disable Click To Do| |
|**Windows AI**|Allow Recall Enablement, Turn Off Saving Snapshots|yes|

### Apps

|Group|Options|Needs admin|
|-|-|-|
|**Microsoft Edge**|Alternate error pages, Compose inline, Copilot page context, History AI search, GenAI local model, Sidebar (Hubs), Bing Chat on new tab page, Default top sites, Acrobat subscription button, Recommendations, Spotlight, Tab services, User feedback, Wallet donation|yes|

The options are Windows and Edge **policies** (registry values under `Software\Policies\Microsoft`).
After a change, sign out and in again (or restart Edge) for it to take effect.

Actions and errors are written to `Logs\<year>\<month>\<day>\SysCloak.log`.



## Uninstall

1. Set the options back to their **Default** state.
2. Delete the folder you copied in step 2 of *Install*.
