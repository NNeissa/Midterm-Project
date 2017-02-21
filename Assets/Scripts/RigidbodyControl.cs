using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyControl : MonoBehaviour {

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
		//MOVEMENT
		float horizontal = Input.GetAxis ("Horizontal"); // Left/Right, A/D
		float vertical = Input.GetAxis ("Vertical"); // Up/Down, W/S
		InputVector = new Vector3 (horizontal, 0f, vertical);

		//TURNING(Mouse needs to be on game screen to work)
		transform.Rotate(0f, Input.GetAxis("Mouse X") * Time.deltaTime * 180f,0f);

		//DO GROUNDED CHECK: shoot raycast just a litle past bottom of capsule
		isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

		//JUMPING
		if (Input.GetKeyDown (KeyCode.Space) && isGrounded) {
			InputVector.y = 50f;

		}
		Debug.Log (RB.velocity.magnitude);
	}
	//this is the framerate where PHYSICS runs
	//do not do controls here
	void FixedUpdate () {
		//apply Y movement force
		RB.AddRelativeForce(Vector3.up * InputVector.y * 20f);
		InputVector.y = 0f;
		//apply X/Z movement force
		if(RB.velocity.magnitude < maxSpeed){
			RB.AddRelativeForce (InputVector * 10f); // actually move object now
		}
	} 
}
