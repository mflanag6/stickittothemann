using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToShopBehavior : MonoBehaviour {

	public GameObject Game_UI;

	public void go_to_shop(string s){
		// Load scene s
		Application.LoadLevel(s);
		// Disable viewing all other things
		Game_UI.SetActive (false); 
	}
}
