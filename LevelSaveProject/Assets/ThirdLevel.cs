using UnityEngine;
using System.Collections;

public class ThirdLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("TL", 1);
		PlayerPrefs.Save ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnGUI(){
		GUI.Label(new Rect(Screen.width-150,30,120,100),"This is third level");
	}
}
