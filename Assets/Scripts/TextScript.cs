using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {
	public Text PlayerText;
	float Texttimer = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Texttimer = Time.time;
		PlayerText.text = "Sneak out of the house...find the key to the last door...but don't get caught in the light";
		if (Texttimer > 5f) {
			PlayerText.text = "";
		}
	}
}
