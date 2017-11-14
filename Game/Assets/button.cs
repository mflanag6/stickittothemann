using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class button : MonoBehaviour {



	public Sprite revealSprite;
	///public GameObject mult;
	private Image image;
	private int x;
	private int y;


	// Use this for initialization
	void Start () {
		//Button btn = yourButton.GetComponent<Button>();
		this.GetComponent<Button>().onClick.AddListener(delegate { TaskOnClick(); });
		image = this.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void TaskOnClick()
	{
		Debug.Log(x + " " + y);

		Debug.Log("instantiating");
		//GameObject multiplicationCheck = Instantiate (mult, new Vector3 (100,100, 0), Quaternion.identity, this.transform) as GameObject;
		Debug.Log("instantiated");

		this.GetComponentInParent<level> ().check (x, y);



		image.sprite = revealSprite;



	}


	public void SetParams(int xInput, int yInput){
		x = xInput;
		y = yInput;

	}
}





		
