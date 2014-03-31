# CncControl plugin to Repetier-host

## Abstract
This is a Repetier Host plugin focused on CNC machines. 
When working with CNC machines there are slightly different demands on user interface for frequent tasks such as jogging and height probing as the machined objects can be clamped at different positions on the bed. 

##Screenshot
<img src="/CncPlugin/Screenshots/screenshot-2014-03-31.png">

## Install (Windows only so far)
* Download files (https://github.com/ahd71/repetier-cncplugin/tree/master/CncPlugin/Binaries) - the raw files....
* Create the directory C:\Program Files\Repetier-Host\plugins\CncPlugin
* Drop the two files (cncplugin.dll and cncplugin.pdb) into the directory. 
* Restart Repetier Host.
* Done :-)

## Feature list
* Jog with keyboard (instead of mouse + click) - enabled only when the plugin panel is opened. Right now, arrow keys moves X and Y axis and numerical keyboard keys /*- keys sets step interval.
* Easy access to Z-Probe (G30, G31) and one-click-action to set height (G92 Zn.nn) based on the probing.
* Spindle on/off and PWM 
* G1 assist mode (just three textboxes for coordinates to move to, leave empty to not move one or several axis)
* G92 assist mode  (just three textboxes for redefining coordinates, leave empty to not redefine one or several axis)

## Planned features
* Configurable for different spindle configurations, such as via the FAN_PORT etc)

## To-do
* posibility to select/configure different keyboard layouts (or disable keyboard shortcuts)
* show current XYZ position in the panel
* update 3d view after each jog if possible (seems to update but "one step behind")
* inch support? (configurable distance and a simple label)

## Contact information
Ideas? Please contact me here via github! 

(c) Hellstrand 2014
