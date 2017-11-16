using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Multiply : MonoBehaviour {

    public ShowPanels showPanels;
    public level level1;
	private int firstNum;
	private int secondNum;
	private int answer;
	public Text textinput;
	public Text textinput2;
	public Text answerInput;

	// Use this for initialization
	public void Start () {

    }

    public void createPanel() {
        
        showPanels.ShowMultiplyPanel();

    }

	// Update is called once per frame
    void Update () {


	}
}
