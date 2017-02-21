using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	bool DoorOpened = false;
	Vector3 ClosedPosition;
	Vector3 OpenPosition;
	public AudioSource OpenDoor;


	void Start(){
		ClosedPosition = new Vector3 (0, 0, 0);
		OpenPosition = new Vector3 (0, -90, 0);
	}
	void Update(){
		Debug.Log (DoorOpened);
	}
//	void OnTriggerEnter(Collider other){
//		Debug.Log("Object has entered trigger");
//			if (Input.GetKeyDown (KeyCode.E)) {
//				transform.Rotate (new Vector3 (0, -90, 0));
//				DoorOpened = true;
//			}
//			if (Input.GetKeyDown (KeyCode.E)) {
//				transform.Rotate (new Vector3 (0, 0, 0));
//				DoorOpened = false;
//			}
//	}
	void OnTriggerStay(Collider other){
		Debug.Log ("Object is within trigger");
		if (DoorOpened == true) {
			if (Input.GetKeyDown (KeyCode.E)) {
				Debug.Log ("Close");
				transform.Rotate (new Vector3 (0, 90, 0));
				OpenDoor.Play ();
				DoorOpened = false;
			}
		}
		if (DoorOpened == false) {
			if (Input.GetKeyDown (KeyCode.E)) {
				Debug.Log ("Open");
				transform.Rotate (new Vector3 (0, -90, 0));
				OpenDoor.Play ();
				DoorOpened = true;
			}
		}
	}

//	void CloseDoor(){
//		transform.Rotate (new Vector3 (0f, -90f, 0f));
//	}
//	void OpenDoor(){
//		transform.Rotate (new Vector3 (0f, 90f, 0f));
//	}
}
