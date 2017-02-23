using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameTrigger : MonoBehaviour {
	public Text PlayerText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		PlayerText.text = "Congratulations! You have snuck out of the house!";
	}
}
