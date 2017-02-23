using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 2f) {
			transform.position += new Vector3 (0f, 0f, -5f) * Time.deltaTime;
		}
	}
}
