using UnityEngine;
using System.Collections;

public class ShowPanels : MonoBehaviour {

	public GameObject optionsPanel;							//Store a reference to the Game Object OptionsPanel 
	public GameObject optionsTint;							//Store a reference to the Game Object OptionsTint 
	public GameObject menuPanel;							//Store a reference to the Game Object MenuPanel 
	public GameObject pausePanel;							//Store a reference to the Game Object PausePanel 
    public GameObject helpPanel;                            //Store a reference to the Game Object HelpPanel
    public GameObject tutorialPanel;                        //Store a reference to the Game Object TutorialPanel
    public GameObject levelPanel;                           //Store a reference to the Game Object LevelPanel
    public GameObject passwordPanel;                        //Store a reference to the Game Object PasswordPanel

	//Call this function to activate and display the Options panel during the main menu
	public void ShowOptionsPanel()
	{
		optionsPanel.SetActive(true);
		optionsTint.SetActive(true);
	}

	//Call this function to deactivate and hide the Options panel during the main menu
	public void HideOptionsPanel()
	{
		optionsPanel.SetActive(false);
		optionsTint.SetActive(false);
	}

    public void ShowHelpPanel()
    {
        helpPanel.SetActive(true);
        optionsTint.SetActive(true);
    }

    public void HideHelpPanel()
    {
        helpPanel.SetActive (false);
        optionsTint.SetActive (false);
    }

    public void ShowLevelPanel()
    {
        levelPanel.SetActive(true);
        optionsTint.SetActive(true);
    }

    public void HideLevelPanel()
    {
        levelPanel.SetActive (false);
        optionsTint.SetActive (false);
    }

	//Call this function to activate and display the main menu panel during the main menu
	public void ShowMenu()
	{
		menuPanel.SetActive (true);
	}

	//Call this function to deactivate and hide the main menu panel during the main menu
	public void HideMenu()
	{
		menuPanel.SetActive (false);
	}

    public void ShowTutorialPanel()
    {
        tutorialPanel.SetActive (true);
    }

    public void HideTutorialPanel()
    {
        tutorialPanel.SetActive (false);
    }
	
	//Call this function to activate and display the Pause panel during game play
	public void ShowPausePanel()
	{
		pausePanel.SetActive (true);
		optionsTint.SetActive(true);
	}

	//Call this function to deactivate and hide the Pause panel during game play
	public void HidePausePanel()
	{
		pausePanel.SetActive (false);
		optionsTint.SetActive(false);

	}
	//Call this function to activate and display the Password panel during level select
	public void ShowPasswordPanel()
	{
		passwordPanel.SetActive (true);
		optionsTint.SetActive(true);
	}

	//Call this function to deactivate and hide the Password panel during level select
	public void HidePasswordPanel()
	{
		passwordPanel.SetActive (false);
		optionsTint.SetActive(false);

	}
}
