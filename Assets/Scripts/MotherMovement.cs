using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherMovement : MonoBehaviour {
	public Vector3 Move = new Vector3(0,0,-5f);
	public static bool SeePlayer = false;
	Vector3 StartPosition;
	float Timer = 0f;
	// Use this for initialization
	void Start () {
		StartPosition = new Vector3 (8.2f, 14.6f, 87.2f);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 2f && SeePlayer == false) {
			transform.position += Move * Time.deltaTime;
		} else {
			transform.position += new Vector3 (0, 0, 0);
			Timer = Timer + Time.deltaTime;
		}
		if (Timer > 5.2f) {
			MotherTrigger.GravOn = false;
			transform.position = StartPosition;
			Timer = 0f;
		}


	}
}
