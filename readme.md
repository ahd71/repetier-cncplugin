# CncControl plugin to Repetier-host

## Abstract
This is a plugin for Repetier Host focused on CNC machines which is requires slightly different tratment than 3d printers.

## Feature list
* Jog with keyboard (instead of mouse + click) - enabled only when the plugin panel is opened. Right now, arrow keys moves XY and /*- keys sets step interval.
* Easy access to Z-Probe (G30, G31) and one-click-action to set height (G92 Zn.nn) based on the probing.

## Planned features
* Spindle on/off and PWM (configurable for different configurations, such as via the FAN_PORT etc)

## To-do
* show current XYZ position in the panel
* update 3d view after each jog if possible (seems to update but "one step behind")
* implement G1 assist mode
* implement G92 assist mode
* Change and add key codes for a custom made keyboard to have "all relevant commands as hardware buttons"

Ideas? Please contact me! i got this idea today when I discovered the plugin architecture so it's kind of new...

(c) Hellstrand 2014
