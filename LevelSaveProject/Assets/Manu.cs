using UnityEngine;
using System.Collections;

public class Manu : MonoBehaviour {


	public int level=1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (10, 10, 100, 20), "new game")) {
			Application.LoadLevel(1);
		}
		if (GUI.Button (new Rect (10, 40, 100, 20), "continue")) {
			//Application.LoadLevel(level);	

			PlayerPrefs.SetInt("SL",1);
		}
	}
}
