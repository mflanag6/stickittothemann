using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToShopBehavior : MonoBehaviour {

	public GameObject Game_UI;
	public GameObject shop_button;

	public bool created = false;

	public void Start(){
		// Begin with Shop button disabled 
		shop_button.SetActive(false);
	}

	public void Show_Shop_Button(){
		shop_button.SetActive(true);
	}


	public void go_to_shop(string s){
		// Load scene s
		Application.LoadLevel(s);
	}	

}
 