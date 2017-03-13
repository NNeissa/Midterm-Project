using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour {
	Vector2 StartPosition;
	// Use this for initialization
	void Start () {
		StartPosition = new Vector2 (19.6f, 14.25f);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 3.2f) {
			transform.position += new Vector3 (-5f, 0f, 0f) * Time.deltaTime;
		}
}
}

