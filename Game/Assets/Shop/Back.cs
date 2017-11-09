using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {

	public void go_back(string s){
		Application.LoadLevel (s);
	}
}
