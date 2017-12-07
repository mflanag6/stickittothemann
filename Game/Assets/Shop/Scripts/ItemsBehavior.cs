using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsBehavior : MonoBehaviour {

	public Image[] items;
	public Image BoughtIcon;

	public Text[] titles;
	public Text[] descriptions;

	public int i = 0;
	public int ITEMS = 2;


	bool[] isbought = new bool[10];
	public Text isbought_description;

	// GameObject to display when an item is bought
	public GameObject IsBought_PopUp;

	// Use this for initialization
	public void Start () {
		// Check is bought and display accordingly
		if (isbought [0] == true) {
			items [0].enabled = false;
			descriptions[0].enabled = false;

			// Still enable title if item has been bought
			titles [0].enabled = true;

			BoughtIcon.enabled = true;
			isbought_description.enabled = true;
		} else {
			items [0].enabled = true;
			descriptions[0].enabled = true;
			titles [0].enabled = true;

			BoughtIcon.enabled = false;
			isbought_description.enabled = false;

		}

		// Don't display any other item besides item 0
		for (int j = 1; j < ITEMS; j++) {
			items [j].enabled = false;
			descriptions[j].enabled = false;
			titles [j].enabled = false;
		}

		// If an item has not been bought, set isbought to false
		for (int k = 0; k < ITEMS; k++) {
			if (isbought [k] != true) {
				isbought [k] = false;
			}
		}

		// Assume no item is actively being bought before Buy Button clicked 
		IsBought_PopUp.SetActive (false);
	}

	// Function: Item Bought
	public void OnBuyButtonClick(){
		// Check whether item is already bought
		if (isbought [i] == false) {
			// Always show Bought Icon in place of item i
			items [i].enabled = false;
			descriptions[i].enabled = false;
			titles [i].enabled = false;

			// Don't display bought icon until after OK press
			BoughtIcon.enabled = false;

			// Assure this by setting isbought to true
			isbought [i] = true;

				
			// Display Is Bought Pop Up
			IsBought_PopUp.SetActive (true);
		}
		// If item has already been bought, do nothing

	}

	// Function: Get out of Item Bought Pop Up
	public void OnOKButtonClick(){
		// get out of Item is bought pop up
		IsBought_PopUp.SetActive(false);
		// Afterwards, display that the item has been bought
		isbought_description.enabled = true;
		// Also, display title of item
		titles[i].enabled = true;
		// Also, display bought icon
		BoughtIcon.enabled = true;
	}

	// Function: User goes right
	public void OnRightButtonClick(){
		// Make sure IsBought Pop Up is not on display
		IsBought_PopUp.SetActive(false);

		// Only display i+1 item if i+1 item is not the end of the list
		if (i + 1 >= ITEMS) {
			return;
		}
		// If not the end of the list, go to next item
		else {
			// if next item hasn't been bought, show the next item
			if (isbought [i+1] == false) {
				BoughtIcon.enabled = false; // don't display bought icon
				isbought_description.enabled = false;

				items[i+1].enabled = true; // do display next item
				descriptions[i+1].enabled = true;
				titles [i+1].enabled = true;

				items [i].enabled = false; // don't display current item
				descriptions[i].enabled = false;
				titles [i].enabled = false;
				// iterate item
				i++;
			// If next item has been bought, show bought icon
			} else {
				BoughtIcon.enabled = true; // do display bought icon
				isbought_description.enabled = true;

				items[i+1].enabled = false; // don't display next item
				descriptions[i+1].enabled = false;
				titles [i+1].enabled = true; // Only show title of next item

				items [i].enabled = false; // don't display current item
				descriptions[i].enabled = false;
				titles [i].enabled = false;
				// iterate item
				i++;
			}
		}
	}
	// Function: User goes left
	public void OnLeftButtonClick(){
		// Make sure IsBought Pop Up is not on display
		IsBought_PopUp.SetActive(false);

		// Only display i-1 item if i-1 item is not the end of the list
		if (i -1 <= -1) {
			return;
		}
		// If not the end of the list, go to previous item
		else {
			// if previous item hasn't been bought, show the previous item
			if (isbought [i-1] == false) {
				BoughtIcon.enabled = false; // don't display bought icon
				isbought_description.enabled = false;

				items[i-1].enabled = true; // do display previous item
				descriptions[i-1].enabled = true;
				titles [i-1].enabled = true;

				items [i].enabled = false; // don't display current item
				descriptions[i].enabled = false;
				titles [i].enabled = false;
				// iterate item
				i--;
			// If previous item has been bought, show bought icon
			} else {
				BoughtIcon.enabled = true; // do display bought icon
				isbought_description.enabled = true;

				items[i-1].enabled = false; // don't display previous item
				descriptions[i-1].enabled = false;
				titles [i-1].enabled = true; // only show title of next item

				items [i].enabled = false; // don't display current item
				descriptions[i].enabled = false;
				titles [i].enabled = false;
				// iterate item
				i--;
			}
		}
	}
}