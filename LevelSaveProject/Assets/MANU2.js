#pragma strict

function Start () {

}

function Update () {

}
function OnGUI(){
		if (GUI.Button (Rect (10, 10, 100, 20), "new game")) {
			PlayerPrefs.SetInt ("TL", 0);
			PlayerPrefs.Save();
			Application.LoadLevel(1);
		}
		if (GUI.Button (Rect (10, 40, 100, 20), "continue")) {
			if(PlayerPrefs.GetInt ("TL", 1)){
				Application.LoadLevel(2);
			}
			else{
				Application.LoadLevel(1);
			}
		}
	}