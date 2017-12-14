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

    public int highestUnlocked = 1;
    public int currentLevel;

	public GameObject profile;

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

        //x = xCord;
        //y = yCord;
		x = UnityEngine.Random.Range(0, 3*currentLevel);
		y = UnityEngine.Random.Range(0, 3*currentLevel);
        submitted = false;

        buttonInstance = b;

        //show multiply panel
        showPanels.ShowMultiplyPanel();
        firstNumber.text = x.ToString();
        secondNumber.text = y.ToString();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void submission()
    {
        Debug.Log ("fire pressed");
        submitted = true;
	try{
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
    catch{
    }
    }
    
    public void endLevel()
    {
		Debug.Log (profile);
		var pro = profile.GetComponent<playerProfile>();
		pro.gold += 50;

        highestUnlocked += 1;
        //Debug.Log ("Highest level set to " + highestUnlocked);
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
