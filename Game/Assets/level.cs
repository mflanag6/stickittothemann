using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class level : Multiply {


    public GameObject Tile;
    public RectTransform Multiply;

    public button buttonInstance;

	public int size;
	private int [,] ocean;
    
	public GameObject oceanTile;
	public GameObject pirateTile;

    private bool submitted = false;
    private int x, y, a;

    

	// Use this for initialization
	public void Start() {
    }

    public void createGrid() {

        showPanels.ShowHelpPanel();

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
    
    

    public void check(int xCord, int yCord, button b)
    {

        Debug.Log ("Checking " + xCord + " " + yCord);
        x = xCord;
        y = yCord;
        submitted = false;

        buttonInstance = b;

        //show multiply panel
        showPanels.ShowMultiplyPanel();
        firstNumber.text = xCord.ToString();
        secondNumber.text = yCord.ToString();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void submission()
    {
        Debug.Log ("fire pressed");
        submitted = true;

        a = Int32.Parse (answerInput.text);
        if (a == x * y)
        {
          buttonInstance.discovered = true;
          buttonInstance.checkDiscovered ();
          showPanels.HideMultiplyPanel ();
        }

        if (buttonInstance.revealSprite.name == "ship-tile")
        {
            showPanels.ShowLevelWinPanel();
        }
    }
    
    public void endLevel()
    {
        highestLevel++;
    Debug.Log ("Highest level set to " + highestLevel);
        //delete board
        foreach (Transform child in Multiply.transform)
        {
            if (child.name == "pirateTile(Clone)" || child.name == "oceanTile(Clone)")
            {
                GameObject.Destroy (child.gameObject);
            }
        }
        
        showPanels.ShowLevelPanel();
    }
   
}
