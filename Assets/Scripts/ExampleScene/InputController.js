#pragma strict

public var stratecam : Stratecam;
public var objectToGoTo : GameObject;
public var objectToFollow : GameObject;

function Update () {
	if (Input.GetKey(KeyCode.T)) {
		stratecam.Follow(objectToFollow);
	}
	if (Input.GetKey(KeyCode.G)) {
		stratecam.GoTo(objectToGoTo.transform.position);
	}
}

function SetSmoothingFactor(x : float) {
	stratecam.smoothingFactor = x;
}

function SetPanSpeed(x : float) {
	stratecam.panSpeed = x;
}

function SetRotationSpeed(x : float) {
	stratecam.rotationSpeed = x;
}

function SetZoomSpeed(x : float) {
	stratecam.zoomSpeed = x;
}

function SetGoToSpeed(x : float) {
	stratecam.goToSpeed = x;
}

function SetDoubleClickMovement(x : boolean) {
	stratecam.allowDoubleClickMovement = x;
}