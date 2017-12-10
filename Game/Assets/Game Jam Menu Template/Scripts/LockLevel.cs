using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockLevel : MonoBehaviour {
    
    public Sprite locked;
    public Sprite unlocked1;
    public Sprite unlocked2;
    public Sprite unlocked3;
    public Sprite unlocked4;
    public Sprite unlocked5;
    public Sprite unlocked6;
    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;
    public level levelInstance;
    private List<Button> buttonList = new List<Button>();
    private List<Sprite> imageList = new List<Sprite>();

    void Start()
    {
        level1 = GameObject.Find("Level1Button").GetComponent<Button>();
        level2 = GameObject.Find("Level2Button").GetComponent<Button>();
        level3 = GameObject.Find("Level3Button").GetComponent<Button>();
        level4 = GameObject.Find("Level4Button").GetComponent<Button>();
        level5 = GameObject.Find("Level5Button").GetComponent<Button>();
        level6 = GameObject.Find("Level6Button").GetComponent<Button>();

        buttonList.Add(level1);
        buttonList.Add(level2);
        buttonList.Add(level3);
        buttonList.Add(level4);
        buttonList.Add(level5);
        buttonList.Add(level6);

        imageList.Add(unlocked1);
        imageList.Add(unlocked2);
        imageList.Add(unlocked3);
        imageList.Add(unlocked4);
        imageList.Add(unlocked5);
        imageList.Add(unlocked6);

        level1.image.sprite = imageList[0];
        level2.image.sprite = locked;
        level3.image.sprite = locked;
        level4.image.sprite = locked;
        level5.image.sprite = locked;
        level6.image.sprite = locked;

        //buttonList = { level1, level2, level3, level4, level5, level6 };
        for (int i = 0; i < levelInstance.highestUnlocked; i++) {
            buttonList[i].image.sprite = imageList[i];
        }
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < levelInstance.highestUnlocked; i++)
        {
            buttonList[i].image.sprite = imageList[i];
        }
	}


}
