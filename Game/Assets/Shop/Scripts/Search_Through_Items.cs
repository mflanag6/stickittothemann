using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Search_Through_Items : MonoBehaviour {

	public Image[] items;
	public int i=0;

	public void Start(){
		items[i].enabled = true;
	}

	public void OnRightButtonClick(){
		items[i].enabled = false;
		i++;
		items [i].enabled = true;
	}

	public void OnLeftButtonClick(){
		items [i].enabled = false;
		i--;
		items [i].enabled = true;
	}
}
