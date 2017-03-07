using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	bool DoorOpened = false;
	public AudioSource OpenDoor;
	float Timer = 0f;
	bool StartTimer = false;

	void Update(){
		if (StartTimer) {
			Timer = Timer + Time.deltaTime;
		}
		if (Timer > 3.0f) {
			if (DoorOpened == true) {
				transform.Rotate (new Vector3 (0, 90, 0));
				OpenDoor.Play ();
				DoorOpened = false;
				StartTimer = false;
				Timer = 0f;
			}
		}
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Key") {
			transform.Rotate (new Vector3 (0f, -90f, 0f));
			Destroy (other.gameObject);
			OpenDoor.Play ();
			DoorOpened = true;
		}
	}

	void OnTriggerStay(Collider other){
		if (Input.GetKeyDown (KeyCode.E)  && this.name != "FinalDoor") {
			if (DoorOpened == true) {
				transform.Rotate (new Vector3 (0, 90, 0));
				OpenDoor.Play ();
				DoorOpened = false;
				StartTimer = false;
			} else {
				transform.Rotate (new Vector3 (0, -90, 0));
				OpenDoor.Play ();
				DoorOpened = true;
				StartTimer = true;
				if (this.name == "FirstDoor") {
					TextScript.FirstDoorOpened = true;
				}
			}
		}

	}
}
