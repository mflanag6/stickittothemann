using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoToShopBehavior : MonoBehaviour {

	public GameObject Game_UI;
	public GameObject shop_button;

	public void Start(){
		// Begin with Shop button disabled 
		//shop_button.enabled = false;
		shop_button.SetActive(false);
	}

	public void Show_Shop_Button(){
		//shop_button.enabled = true;
		shop_button.SetActive(true);
	}


	public void go_to_shop(string s){
		// Load scene s
		Application.LoadLevel(s);
		// Disable viewing all other things
		Game_UI.SetActive (false); 
	}
}
