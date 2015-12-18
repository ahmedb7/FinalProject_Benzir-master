using UnityEngine;
using System.Collections;

public class InsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnInsStartButtonClick(){
		Application.LoadLevel ("Level1");
	}
	public void OnInsMenuButtonClick(){
		Application.LoadLevel ("Menu");
	}
}
