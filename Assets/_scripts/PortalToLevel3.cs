using UnityEngine;
using System.Collections;

public class PortalToLevel3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider otherCollider){
		if(otherCollider.CompareTag("Player")) {
			Application.LoadLevel("Level3");
		}
	}
}
