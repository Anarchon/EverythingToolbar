EverythingToolbar
=================

[Everything](https://www.voidtools.com/) integration for the Windows taskbar

![demo](https://user-images.githubusercontent.com/17520641/94998321-63675a00-05b1-11eb-9331-ef1fd744329e.gif)

Install
-------

- Download from [releases](https://github.com/stnkl/EverythingToolbar/releases)
- Extract it somewhere safe
- Run the `install.cmd` as admin
- Enable EverythingToolbar via the context menu of the taskbar
  - *Note: You might have to open the context menu twice as it not always shows up instantly.*

Uninstall
---------

- Run the `uninstall.cmd` as admin

Requirements
------------

- Windows 10
- .NET Framework >= 4.7
- Everything >= 1.4.1 must be running

Build
-----

- Open solution in Visual Studio 2019 with .NET Framework 4.7 support
- Install NuGet packages
- Disable signing in project properties
- Build the project (Windows Explorer will restart)
- Install the toolbar by running `EverythingToolbar/bin/Debug/install.cmd` as admin

Todo
----

- Light theme
- Search icon only

Compatibility
-------------

- Tested on Windows 10 x64.
- High DPI support requires at least Windows 10 Creators Update.
