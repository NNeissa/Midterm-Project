using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextProximityInitiation : MonoBehaviour {
	public GameObject player;
	Vector3 Distance;
	public Text PlayerText;
	bool WonGame = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 20f && this.gameObject.name == "FirstLandmark") {
			PlayerText.text = "Travel to the green plains and find the star crater.";
		}
		if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 20f && this.gameObject.name == "SecondLandmark") {
			PlayerText.text = "Fly STRAIGHT UP...unto the great watcher of the land...and find his eye.";
		}
		if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 20f && this.gameObject.name == "ThirdLandmark") {
			PlayerText.text = "Speak with the Red Archon of the west.";
		}
		if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 15f && this.gameObject.name == "FourthLandmark") {
			PlayerText.text = "Speak with the Blue Arhcon of the east.";
		}
		if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 15f && this.gameObject.name == "FifthLandmark") {
			PlayerText.text = "Go to the peak of this world...there you will find your treasure.";
		}
		if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 20f && this.gameObject.name == "Treasure" && WonGame == false) {
			PlayerText.text = "Press SPACE to collect the treasure.";
			if (Input.GetKeyDown (KeyCode.Space)) {
				WonGame = true;
			}
		}
		if (WonGame) {
			PlayerText.text = "You Win!";
		}
}
}
