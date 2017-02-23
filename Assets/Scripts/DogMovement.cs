using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 2.2f) {
			transform.position += new Vector3 (-5f, 0f, 0f) * Time.deltaTime;
		}
	}
}
