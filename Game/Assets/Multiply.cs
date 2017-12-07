using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Multiply : LevelSelect {

	private int firstNum;
	private int secondNum;
	private int answer;
	public Text firstNumber;
	public Text secondNumber;
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
