#pragma strict

function Start () {

}

function Update () {

     if (Input.GetKeyDown(KeyCode.J)) {
     // toggle visibility:
     GetComponent.<Renderer>().enabled = !GetComponent.<Renderer>().enabled;
 }
}

