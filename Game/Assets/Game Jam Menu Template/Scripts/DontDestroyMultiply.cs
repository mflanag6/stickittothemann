using UnityEngine;
using System.Collections;

public class DontDestroyMultiply : MonoBehaviour {

	void Start()
	{
		if (GameObject.FindWithTag ("Multiply") == null) {
			Debug.LogWarning ("tagging M");

			this.gameObject.tag = "Multiply";
			//Causes UI object not to be destroyed when loading a new scene. If you want it to be destroyed, destroy it manually via script.
			DontDestroyOnLoad(this.gameObject);
		} 
		else {
			Debug.LogWarning ("destroying");
			Destroy (this.gameObject);
		}
	}



}