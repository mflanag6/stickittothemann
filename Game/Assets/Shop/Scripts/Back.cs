using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {

	public GameObject Game_UI;

	public void Awake() {
		Game_UI = GameObject.FindWithTag("UI");
		Game_UI.SetActive (false);
	}

	public void go_back(string s){
		Game_UI.SetActive(true);
		// Load scene s
		Application.LoadLevel (s);
	}
}
