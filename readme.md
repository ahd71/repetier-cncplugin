# CncControl plugin to Repetier-host

## Abstract
A Repetier Host plugin focused on CNC machine operationss.
Working with CNC machines require slightly different user interface for frequent tasks such as jogging and height probing as the machined objects can be clamped at different positions on the bed. This plugin combines thoose into one panel in an intuitive way.

##Screenshot
### Main tab
<img src="/CncPlugin/Screenshots/screenshot-2014-04-06.png">
### Preference settings
<img src="/CncPlugin/Screenshots/preferences-2014-04-06.PNG">


## Install
(Only windows tested so far but plugins are supposed to work in linux too)
* Create the directory C:\Program Files\Repetier-Host\plugins\CncPlugin
* Change privileges to write access for the folder if required.
* Download plugin dll (https://github.com/ahd71/repetier-cncplugin/raw/master/CncPlugin/Binaries/CncPlugin.dll)
* Copy dll file (CncPlugin.dll) into the new directory (note that Repetier host is case sensitive)
* Unblock windows security for the file if required (right click on file and click UNBLOCK https://github.com/ahd71/repetier-cncplugin/blob/master/CncPlugin/Screenshots/security_unblock.PNG)
* Restart Repetier Host.
* Done :-)

## Features
* Jog with keyboard (instead of mouse + click) - enabled only when the plugin panel is focused.
* Easy access to Z-Probe (G30, G31) and one-click-action to set height (G92 Zn.nn) based on the probing.
* Spindle on/off and PWM 
* G1 assist mode (just three textboxes for coordinates to move to, leave empty to not move one or several axis)
* G92 assist mode  (just three textboxes for redefining coordinates, leave empty to not redefine one or several axis)

## Keyboard short cuts
* Default configured for jog via arrow keys and PgUp/PgDn. Fully configurable via key codes defined in http://msdn.microsoft.com/library/windows/apps/windows.system.virtualkey

## Planned features / To-do
See the [issue tracker](https://github.com/ahd71/repetier-cncplugin/issues).

## Releases
* 0.15 / 2014-11-01 - Fixed two compatibility issue introduced with Repetier 1.03 and 1.06 due to changes in the plugin interfaces
* 0.14 / 2014-04-09 - Global hotkeys in Windows (makes them work outside the CNC tab), see issue #7 for more details
* 0.13 / 2014-04-06 - Presentation of current position from the analyzer object
* 0.12 / 2014-04-06 - User preferences for short cut keys and step size
* 0.11 / 2014-03-31 - Bug fix: 0.1mm jog fixed (invalid decimal point), Added Connect/Disconnect short cut and graphics
* 0.10 / 2014-03-31 - Added spindle control and gcode sender for move/setref/manual. Controls properly disabled when machine is disconnected. Gcode info next to buttons.
* 0.01 / 2014-03-30 - Prototype with working keyboard jog + height probe aid

(c) Hellstrand 2014
