using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {

	Rigidbody RB;
	Vector3 InputVector; // var we use to pass info from Update > FixedUpdate
	bool isGrounded; // result of the raycast below the player

	float maxSpeed = 10f;
	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody> (); // cache reference for our shortcut
	}

	// Update is called once per frame
	void Update () {
		//DO GROUNDED CHECK: shoot raycast just a litle past bottom of capsule
		isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.5f);

		//JUMPING
		if (Input.GetKeyDown (KeyCode.Space) && isGrounded) {
			InputVector.y = 50f;

		}
	}
	//this is the framerate where PHYSICS runs
	//do not do controls here
	void FixedUpdate () {
		//apply Y movement force
		RB.AddRelativeForce(Vector3.up * InputVector.y * 20f);
		InputVector.y = 0f;
	} 
}
