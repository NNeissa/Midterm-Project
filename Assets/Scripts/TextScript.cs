using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {
	Text PlayerText;
	float Texttimer = 0f;
	public static bool Caught = false;
	bool StartText = true;
	public static bool FirstDoorOpened = false;
	// Use this for initialization
	void Start () {
		PlayerText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		Texttimer = Time.time;
//		if (StartText) {
//			Debug.Log (PlayerText.text);
//			PlayerText.text = "Sneak out of the house...find the key to the last door...but don't get caught in the light";
//		}
//		if (FirstDoorOpened) {
//			StartText = false;
//			PlayerText.text
//		}
		if (Caught) {
			PlayerText.text = "What are you doing up? BACK TO BED!";
		}
		if (!Caught) {
			if (Texttimer < 5.0f) {
				PlayerText.text = "Sneak out of the house...find the key to the last door...but don't get caught in the light";
			} else if (EndGameTrigger.EndGame == true) {
				PlayerText.text = "Congratulations! You have snuck out of the house!";
			} else {
				PlayerText.text = "";
			}
		}
	}
}
