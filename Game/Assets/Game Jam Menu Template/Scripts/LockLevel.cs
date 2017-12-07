using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    GameObject go = GameObject.Find("VisualHealth");
 
    //check if we have a match 
        if(go!= null) {
        //assign sprite reference to your variable 
        _canvas = go.GetComponent<SpriteRenderer>().sprite;
    }
}
