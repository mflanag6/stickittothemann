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
		//SceneManager.Set
		//SceneManager.LoadScene(s, LoadSceneMode.Additive);
		// Disable viewing all other things
		Game_UI.SetActive(false);	
	}	

	public void back(){
		Debug.LogWarning ("back!@!@!#");
		//Game_UI.SetActive(true);
		// Load scene s
		//Application.LoadLevel (s);
	}
}
 