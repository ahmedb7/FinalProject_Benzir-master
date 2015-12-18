using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
	
	}
	//Start Button event handeler 
	public void OnStartButtonClick(){
		Application.LoadLevel ("Level1");
	}
	public void OnInsButtonClick(){
		Application.LoadLevel ("Ins");
	}
}
