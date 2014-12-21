using UnityEngine;
using System.Collections;

public class SecondLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.GetInt ("TL", 0);
		PlayerPrefs.Save();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (10, 30, 100, 20), "Next Level")) {
			Application.LoadLevel(2);		
		}
		GUI.Label(new Rect(Screen.width-150,30,120,100),"This is second level");
	}
}
