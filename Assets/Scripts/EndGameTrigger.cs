using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameTrigger : MonoBehaviour {
	public Text PlayerText;
	bool EndGame = false;
	public GameObject FinalDoor;

	void Start(){
	}
	// Use this for initialization
	void Update(){
		if (EndGame == true) {
			PlayerText.text = "Congratulations! You have snuck out of the house!";
		}
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			EndGame = true;
			FinalDoor.transform.Rotate (new Vector3 (0, 90, 0));
		}
	}
}
