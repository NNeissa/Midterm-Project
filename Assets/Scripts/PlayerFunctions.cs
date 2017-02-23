using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFunctions : MonoBehaviour {

	CharacterController charCon;
	Vector3 JumpStrength;
	// Use this for initialization
	void Start () {
		charCon = GetComponent<CharacterController> (); // save reference to our component
		JumpStrength = new Vector3(0,100,0);
	}

	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal"); //left/right movement
		float vertical = Input.GetAxis ("Vertical");// up/down movement
		charCon.Move (transform.forward * Time.deltaTime * vertical * 10f); //move along forward facing
		charCon.Move(transform.right * Time.deltaTime * horizontal * 10f);
		charCon.Move (Physics.gravity * 0.05f); // move the controller down
	}
}
