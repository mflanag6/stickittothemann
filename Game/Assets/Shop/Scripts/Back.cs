using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : GoToShopBehavior {

	public void go_back(string s){
		Game_UI = GameObject.FindWithTag("UI");
		Game_UI.SetActive (true);
		// Load scene s
		Application.LoadLevel (s);
	}
}
