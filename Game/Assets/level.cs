using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class level : MonoBehaviour {



	public int size;
	private int [,] ocean;

	public GameObject oceanTile;
	public GameObject pirateTile;
	// Use this for initialization
	void Start () {
	
		ocean = new int[10, 10];


		for (int i = 0; i < size; i++) {
			for (int j = 0; j < size; j++) {
				ocean[i,j] = 0;

			}
		}



		int x = UnityEngine.Random.Range(0,size);
		int y = UnityEngine.Random.Range(0,size);
		ocean[x,y] = 1;


		Debug.Log ("hello");

		Vector3 offsetY = new Vector3(0,100,0);
		//Vector3 value = (Vector3) this.transform;
		Vector3 offsetX = new Vector3(100,0,0);

		Debug.Log (this.transform.position);
		//Instantiate(tile, this.transform);

		//ICloneable helper;

		Vector3 newPos = (this.transform.position + offsetY);
		//Transform newTransform = this.transform;
		//newTransform.position = newPos;
		//GameObject oceanTile; 



		for (int i = 0; i < size; i++) {
			/// i is the x value of the thing

			for (int j = 0; j < size; j++) {
				/// j is the yvalue of the thing
				/// 
				if (ocean [i, j] == 0) {
					GameObject tile = Instantiate (oceanTile, new Vector3 (i * 100, j * 100, 0), Quaternion.identity, this.transform) as GameObject;
					tile.GetComponent<button> ().SetParams (i, j);
				} else {
					GameObject tile = Instantiate (pirateTile, new Vector3 (i * 100, j * 100, 0), Quaternion.identity,this.transform) as GameObject;
					tile.GetComponent<button> ().SetParams (i, j);
				}

			}
		}



		//oceanTile.transform.position = newPos;

		//newPos = (this.transform.position + offsetY);
		//newTransform = this.transform;
		//newTransform.position = newPos;

		//Instantiate(tile, newTransform);





	

	}


	public void check(int xCord, int yCord){

		if (ocean [xCord, yCord] == 1) {
			Debug.Log ("hit");
		} else {
			Debug.Log ("miss");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
