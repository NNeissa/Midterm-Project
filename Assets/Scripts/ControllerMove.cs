using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMove : MonoBehaviour {

	CharacterController charCon;

	// Use this for initialization
	void Start () {
		charCon = GetComponent<CharacterController> (); // save reference to our component
	}
	
	// Update is called once per frame
	void Update () {
		//1. grab input from input devices
		float horizontal = Input.GetAxis ("Horizontal"); //left/right movement
		float vertical = Input.GetAxis ("Vertical");// up/down movement
		//2. plug values into the character controller
		charCon.Move (transform.forward * Time.deltaTime * vertical * 10f); //move along forward facing
		transform.Rotate (0f, horizontal * Time.deltaTime * 30f, 0f);
		//3. lets add gravity
		//charCon.Move (Physics.gravity * 0.05f); // move the controller down
		//4. les press SPACE to jump
		if (Input.GetKey (KeyCode.Space)) {
			charCon.Move (new Vector3 (0f, 15f, 0f) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftControl)) {
			charCon.Move (new Vector3 (0f, -15f, 0f) * Time.deltaTime);
		}


	}
}
