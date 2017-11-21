using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsBehavior : MonoBehaviour {

	public Image[] items;
	public Image BoughtIcon;

	public int i = 0;
	public int ITEMS = 2;

	bool[] isbought = new bool[10];

	// Use this for initialization
	public void Start () {
		// Check is bought and display accordingly
		if (isbought [0] == true) {
			items [0].enabled = false;
			BoughtIcon.enabled = true;
		} else {
			items [0].enabled = true;
			BoughtIcon.enabled = false;
		}

		// Don't display any other item besides item 0
		for (int j = 1; j < ITEMS; j++) {
			items [j].enabled = false;
		}

		// If an item has not been bought, set isbought to false
		for (int k = 0; k < ITEMS; k++) {
			if (isbought [k] != true) {
				isbought [k] = false;
			}
		}
	}

	// Function: Item Bought
	public void OnBuyButtonClick(){
		// Always show Bought Icon in place of item i
		items [i].enabled = false;
		BoughtIcon.enabled = true;

		// Assure this by setting isbought to true
		isbought [i] = true;

	}

	// Function: User goes right
	public void OnRightButtonClick(){
		// Only display i+1 item if i+1 item is not the end of the list
		if (i + 1 >= ITEMS) {
			return;
		}
		// If not the end of the list, go to next item
		else {
			// if next item hasn't been bought, show the next item
			if (isbought [i+1] == false) {
				BoughtIcon.enabled = false; // don't display bought icon
				items[i+1].enabled = true; // do display next item
				items [i].enabled = false; // don't display current item
				
				// iterate item
				i++;
			// If next item has been bought, show bought icon
			} else {
				BoughtIcon.enabled = true; // do display bought icon
				items[i+1].enabled = false; // don't display next item
				items [i].enabled = false; // don't display current item

				// iterate item
				i++;
			}
		}
	}
	// Function: User goes left
	public void OnLeftButtonClick(){
		// Only display i-1 item if i-1 item is not the end of the list
		if (i -1 <= -1) {
			return;
		}
		// If not the end of the list, go to previous item
		else {
			// if previous item hasn't been bought, show the previous item
			if (isbought [i-1] == false) {
				BoughtIcon.enabled = false; // don't display bought icon
				items[i-1].enabled = true; // do display previous item
				items [i].enabled = false; // don't display current item

				// iterate item
				i--;
			// If previous item has been bought, show bought icon
			} else {
				BoughtIcon.enabled = true; // do display bought icon
				items[i-1].enabled = false; // don't display previous item
				items [i].enabled = false; // don't display current item

				// iterate item
				i--;
			}
		}
	}
}