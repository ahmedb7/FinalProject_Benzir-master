﻿using UnityEngine;
using System.Collections;

public class GameOverScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnRestartButtonClick(){
		Application.LoadLevel("Level1");
	}
	public void OnMenuButtonClick(){
		Application.LoadLevel ("Menu");
	}
}
