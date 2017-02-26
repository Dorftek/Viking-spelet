using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void loadLevel(string name){
		Debug.Log("Loading "+name);
		Application.LoadLevel (name);

	}
	public void exitProgram(){
	
		Application.Quit ();
		Debug.Log ("shut down imminent ");

	}

}
