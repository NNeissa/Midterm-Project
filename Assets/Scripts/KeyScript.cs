using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {
	public AudioSource OpenDoor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
//	void OnTriggerEnter(Collider other){
//		if (other.name == "FinalDoor") {
//			other.transform.Rotate (new Vector3 (0f, -90f, 0f));
//			OpenDoor.Play ();
//			Destroy (this.gameObject);
//		}
//	}
}
