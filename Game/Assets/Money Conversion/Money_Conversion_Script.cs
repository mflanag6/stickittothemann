using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Conversion_Script : MonoBehaviour {

	// How to play popup
	public GameObject HowToPlay_Popup;

	// Use this for initialization
	void Start () {
		// make sure how to play popup isn't showing
		HowToPlay_Popup.SetActive(false);
	}

	// How to Play button
	public void OnHowToButtonClick(){
		// Open up how to play popup
		HowToPlay_Popup.SetActive(true);
	}
}
