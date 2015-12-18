using UnityEngine;
using System.Collections;

public class WinScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnWinRestarButtonClick(){
		Application.LoadLevel("Level1");
	}
	public void OnWinMenuButtonClick(){
		Application.LoadLevel ("Menu");
	}
}
