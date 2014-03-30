# CncControl plugin to Repetier-host

## Abstract
This is a Repetier Host plugin focused on CNC machines. 
When working with CNC machines there are slightly different demands on user interface for frequent tasks such as jogging and height probing as the machined objects can be clamped at different positions on the bed. 

##Screenshot
<img src="/CncPlugin/Screenshots/screenshot-2014-03-30.png">

## Install (Windows only so far)
Create the directory C:\Program Files\Repetier-Host\plugins\CncPlugin and drop the two files from "Binaries" directory (cncplugin.dll and cncplugin.pdb from https://github.com/ahd71/repetier-cncplugin/tree/master/CncPlugin/Binaries). Restart Repetier Host. Done :-)

## Feature list
* Jog with keyboard (instead of mouse + click) - enabled only when the plugin panel is opened. Right now, arrow keys moves X and Y axis and numerical keyboard keys /*- keys sets step interval.
* Easy access to Z-Probe (G30, G31) and one-click-action to set height (G92 Zn.nn) based on the probing.

## Planned features
* Spindle on/off and PWM (configurable for different configurations, such as via the FAN_PORT etc)

## To-do
* disable all elements unless the device is connected
* show current XYZ position in the panel
* update 3d view after each jog if possible (seems to update but "one step behind")
* implement G1 assist mode
* implement G92 assist mode
* Change and add key codes for a custom made keyboard to have "all relevant commands as hardware buttons"

## Contact information
Ideas? Please contact me here at github! (I got this idea today when I discovered the plugin architecture so it's kind of new...)

(c) Hellstrand 2014
