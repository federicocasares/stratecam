# Stratecam
(an open-source RTS-like camera system for Unity)

## Important Information
This repository contains an example project that includes a few Unity Standard Assets. These are distributed here only as part of the example scene to demonstrate the capabilities of Stratecam. If you are not interested in that and only want the component itself to test it out in your own project, feel free to proceed to copy the two .js scripts in the Scripts directory and nothing else.

## Installation
Getting Stratecam running is pretty easy. You simply need to get a copy of the Stratecam and DoubleClickDetector js files in the Scripts directory and copy them to your project. Once there, simply add the Stratecam component to your camera, set the options and you are good to go!

## Where can I see a demo?
[You can find a demo of the latest version of Stratecam here.](http://www.windsoftrade.net/stratecam)

## What do the options mean?
Almost all of the settings are pretty much self explanatory, but here are the details:

* Terrain: If you are going to use a terrain object, set the reference here. This is required in order to make the 'adapt to terrain height' and 'allow double click movement' features work.
* Pan Speed: speed of the movement along the X and Z axis (both mouse and keyboard). Default value: 15.
* Zoom Speed: speed of the zoom-in and zoom-out movement (both mouse and keyboard). Default value: 100.
* Rotation Speed: speed of the rotation movement in the Y axis (both mouse and keyboard). Default value: 50.
* Mouse Pan Multiplier: speed of the pan movement for the mouse only in order to make it slower or faster. Default value: 0.1.
* Mouse Rotation Multiplier: speed of the rotation movement for the mouse only in order to make it slower or faster. Default value: 0.2.
* Mouse Zoom Multiplier: speed of the zoom movement for the mouse only in order to make it slower or faster. Default value: 5.0.
* Minimum Zoom Distance: the closest you can get to the camera target point, in world units. Default value: 20.
* Maximum Zoom Distance: the furthest you can get from the camera target point, in world units. Default value: 200.
* Smoothing Factor: value for the linear interpolation used to smooth out the pan movement. A value close to zero represents greater smoothing and a value of 1.0 represents no smoothing at all. Default value: 0.1.
* Go-to Speed: value for the linear interpolation used when moving the camera automatically to a target. A value of 1.0 makes the camera immediately teleport to the destination. Default value: 0.1.

* Use Keyboard Input: when enabled, the player will be able to move the camera using the WASD/QE/RF keys.
* Use Mouse Input: when enabled, the player will be able to move the camera around using the mouse (middle mouse button and scroll wheel).
* Adapt to Terrain Height: when enabled, the camera will automatically try to remain above the terrain.
* Increase Speed When Zoomed-Out: when enabled, the panning speed will increase when you are zoomed-out. It is recommended to keep this on.
* Correct Zoom-out Ratio: when enabled, the distance from the camera to the camera target point will increase faster when you are zoomed out in order to make it non-linear. It is recommended to keep this on to provide a more usable zooming experience.
* Smoothing: when enabled, smooths out panning to avoid having the camera start and stop the movement suddenly.
* Allow Double Click Movment: when enabled, double clicking on the terrain will automatically move the camera to that point.

## Public Methods

### GoTo(position : Vector3)
Moves the camera target point to the specified position.

### Follow(gameObjectToFollow : GameObject)
Makes the camera follow the movement of the specified GameObject, keeping it centered in the screen.