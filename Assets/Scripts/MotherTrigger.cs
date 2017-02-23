using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherTrigger : MonoBehaviour {
	public static bool GravOn = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GravOn) {
			GetComponentInParent<Rigidbody> ().useGravity = true;
		} else {
			GetComponentInParent<Rigidbody> ().useGravity = false;
			GravOn = false;
		}
	}
	void OnTriggerEnter(Collider other){
		GravOn = false;
	}
}
