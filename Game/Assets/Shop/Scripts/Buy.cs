using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour {

	public Image myItem;
	public Image Bought_Icon;

	public void Start(){
		// Start out with item displayed and bought icon not displayed
		Bought_Icon.enabled = false;
		myItem.enabled = true;
	}

	public void OnButtonClick(){
		// If item is bought, change icons
		myItem.enabled = false;
		Bought_Icon.enabled = true;
	}
}
