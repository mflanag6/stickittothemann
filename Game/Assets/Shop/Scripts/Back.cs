using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {

	public GameObject Game_UI;
	public GameObject Board_UI;

	public void Awake() {
		Game_UI = GameObject.FindWithTag("UI");
		Board_UI = GameObject.FindWithTag("Multiply");
		Game_UI.SetActive(false);
		Board_UI.SetActive (false);
	}

	public void go_back(string s){
		Game_UI.SetActive(true);
		Board_UI.SetActive (true);
		// Load scene s
		Application.LoadLevel (s);
	}
}
