using UnityEngine;
using System.Collections;

public class DontDestroyManager : MonoBehaviour {

	void Start()
	{
		if (GameObject.FindWithTag ("Manager") == null) {
			Debug.LogWarning ("tagging U");
			this.gameObject.tag = "Manager";
			//Causes UI object not to be destroyed when loading a new scene. If you want it to be destroyed, destroy it manually via script.
			DontDestroyOnLoad(this.gameObject);
		} 
		else {
			Debug.LogWarning ("destroying");
			Destroy (this.gameObject);
		}
	}



}