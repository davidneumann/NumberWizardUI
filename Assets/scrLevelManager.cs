using UnityEngine;
using System.Collections;

public class scrLevelManager : MonoBehaviour {

	public void LoadLevel(string levelName)	{
		Debug.Log("LoadLevel: trying to load " + levelName);
		Application.LoadLevel(levelName);
	}
	
	public void QuitRequest(){
		Debug.Log("Quit requested");
		Application.Quit();
	}
}
