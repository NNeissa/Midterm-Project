using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandFatherPatrol : MonoBehaviour {
	Vector3 Patrol;
	public static float PatrolDirection = 1f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Patrol = new Vector3 (0f, 0f, 20f) * Time.deltaTime * PatrolDirection;
		transform.position += Patrol;
		if (transform.position.z >= 92f) {
			PatrolDirection = -1f;
		}
		if (transform.position.z <= 55f) {
			PatrolDirection = 1f;
		}
	}
}
