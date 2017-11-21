using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class level : Multiply {


    public GameObject Tile;
    public RectTransform Multiply;  

	public int size;
	private int [,] ocean;
    
	public GameObject oceanTile;
	public GameObject pirateTile;

    private bool submitted = false;

    

	// Use this for initialization
	public void Start() {
    }

    public void createGrid() {
    
		ocean = new int[10, 10];


		for (int i = 0; i < size; i++) {
			for (int j = 0; j < size; j++) {
				ocean[i,j] = 0;

			}
		}



		int x = UnityEngine.Random.Range(0,size);
		int y = UnityEngine.Random.Range(0,size);
		ocean[x,y] = 1;
            
        int offsetX = 100;
        int offsetY = 100;

		for (int i = 0; i < size; i++) {
			/// i is the x value of the thing

			for (int j = 0; j < size; j++) {
				/// j is the yvalue of the thing
       
                Vector3 pos = new Vector3(i * 100 + offsetX, j * 100 + offsetY, 0);
                Debug.Log ("new pos is " + pos);

				if (ocean [i, j] == 0) {
                    GameObject tile = Instantiate(oceanTile);
                    //tile.transform.position.Set(i*100, j*100, 0);
                    tile.transform.SetParent(Multiply);

                    tile.transform.position = pos;
					tile.GetComponent<button> ().SetParams (i, j);
				} else {
                    GameObject tile = Instantiate(pirateTile);
                    //tile.transform.position.Set(i*100, j*100, 0);
                    tile.transform.SetParent(Multiply);

                    tile.transform.position = pos;
					tile.GetComponent<button> ().SetParams (i, j);
				}

			}
		}

        Debug.Log ("done w/ board");

	}



    public bool check(int xCord, int yCord){

        submitted = false;

        //show multiply panel
        this.GetComponent<ShowPanels>().ShowMultiplyPanel();
        firstNumber.text = xCord.ToString();
        secondNumber.text = yCord.ToString();

        while (!submitted)
        {
            //wait for button press and submission of answer      
        }

        this.GetComponent<ShowPanels>().HideMultiplyPanel();
        
        int a = Int32.Parse(answerInput.text);
        if (a == xCord * yCord)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    /*
		if (ocean [xCord, yCord] == 1) {
			Debug.Log ("hit");
		} else {
			Debug.Log ("miss");
		}*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void submission()
    {
        submitted = true;
    }
}
