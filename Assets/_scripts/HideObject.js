#pragma strict

function Start () {

}

function Update () {

	if (Input.GetKeyDown(KeyCode.Z)) {
     	// toggle visibility:
     	GetComponent.<Renderer>().enabled = !GetComponent.<Renderer>().enabled;
 }

}