using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	Rigidbody RB;
	bool SeePlayer;
	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		SeePlayer = Physics.Raycast (transform.position, new Vector3(-1,0,0), 15f);
		if (SeePlayer == true) {
			Debug.Log ("Camera1 see's the player");
		}
	}
}
