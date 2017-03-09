using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameTrigger : MonoBehaviour {
	public Text PlayerText;
	public static bool EndGame = false;
	public GameObject FinalDoor;
	public GameObject Player;

	void Start(){
	}
	// Use this for initialization
	void Update(){

	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			EndGame = true;
			FinalDoor.transform.Rotate (new Vector3 (0, 90, 0));
			Player.GetComponent<CharacterController> ().enabled = false;
			GetComponent<BoxCollider> ().enabled = false;
		}
	}
}
