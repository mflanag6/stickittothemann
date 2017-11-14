using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Multiply : MonoBehaviour {



	private int firstNum;
	private int secondNum;
	private int answer;
	public Text textinput;
	public Text textinput2;
	public Text answerInput;

	// Use this for initialization
	void Start () {

		GameObject input = this.gameObject.transform.GetChild(2).gameObject;

		//string input2 = box.text;//.GetComponent (typeof(Text));
		//input.GetComponent<inputField> ();

		//string hello = input.gameObject.transform.GetChild(1).gameObject.GetComponent<Script>();

		//var inputttt = gameObject.GetComponent<InputField>();


		Debug.Log("test");



		Debug.Log(textinput.text);
	}






	public bool checkAnswer(){


		try 
		{
			firstNum = int.Parse (textinput.text);
			secondNum = int.Parse (textinput2.text);
			answer = int.Parse (answerInput.text);
		}

		catch (Exception e)
		{

		}



		if ((firstNum * secondNum) == answer) {
			return true;
			Debug.Log ("correct");
		}

		return false;
	}



	// Update is called once per frame
	void Update () {
	

		try 
			{
		firstNum = int.Parse (textinput.text);
		secondNum = int.Parse (textinput2.text);
		answer = int.Parse (answerInput.text);
			}

		catch (Exception e)
			{

			}
	


		if ((firstNum * secondNum) == answer) {
		Debug.Log ("correct");
		}

		Debug.Log("running");






	}
}
