using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToShopBehavior : MonoBehaviour {

	public void go_to_shop(string s){
		// Load scene s
		Application.LoadLevel(s);
	}
}
