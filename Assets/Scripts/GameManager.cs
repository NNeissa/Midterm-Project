using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
	// "public static" = it lives in your code, not on a gameobject in the scene
	//your computer science professor will be upset
	//but in game development, WE DON'T CARE

	public static GameManager instance;

	// Update is called once per frame

	void Start(){
		instance = this;
	}
	void Update () {
		//if we got 11+ points, or player pressed R(debug), then restart the level
		if (Input.GetKeyDown (KeyCode.R)) {
			//to restart a level, just reload a current scene
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
