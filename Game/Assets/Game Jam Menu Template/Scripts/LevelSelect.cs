﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour {

	public InputField passwordInputField;				// Reference to Password Input Field PasswordPanel, to read user's password
	public ShowPanels showPanels;						// Reference to ShowPanels script on UI GameObject, to show and hide panels
	public Text titleText;								// Instructional text to unlock password
	public string theInput;								// Password text the user enters
	public int highestLevel = 1;						// Maximum level reached by the user
	private int selectedLevel;
	private string passwordLevel2 = "password2";		// Password to unlock Level 2
	private string passwordLevel3 = "password3";		// Password to unlock Level 3
	private string passwordLevel4 = "password4";		// Password to unlock Level 4
	private string passwordLevel5 = "password5";		// Password to unlock Level 5
	private string passwordLevel6 = "password6";		// Password to unlock Level 6

	void Start () {
		titleText.text = "This level is locked. Enter the password to unlock it.";
		showPanels.HidePasswordPanel();
	}

	public void checkLocked(int level) {
		selectedLevel = level;
		if (selectedLevel > highestLevel) {						// Level is locked
			showPanels.ShowPasswordPanel();
			titleText.text = "This level " + selectedLevel.ToString() + " is locked. Enter the password to unlock it.";
		} else {										// Level is already unlocked
			showPanels.HideLevelPanel();
		}
	}

	public void checkInput() {
		bool correct = false;
		theInput = passwordInputField.text;
		switch (selectedLevel) {
			case 2:
				if (theInput == passwordLevel2) {
					correct = true;
				} else {
					correct = false;
				}
				break;
			case 3:
				if (theInput == passwordLevel3) {
					correct = true;
				} else {
					correct = false;
				}
				break;
			case 4:
				if (theInput == passwordLevel4) {
					correct = true;
				} else {
					correct = false;
				}
				break;
			case 5:
				if (theInput == passwordLevel5) {
					correct = true;
				} else {
					correct = false;
				}
				break;
			case 6:
				if (theInput == passwordLevel6) {
					correct = true;
				} else {
					correct = false;
				}
				break;
		}

		if (correct) {
			if (showPanels != null) {
				showPanels.HidePasswordPanel();
				showPanels.HideLevelPanel();

				// Proceed to the proper level

			} else {
				Debug.Log(showPanels);
			}
		} else {
			titleText.text = "The password you entered is incorrect. Please try again.";
		}		


	}
}