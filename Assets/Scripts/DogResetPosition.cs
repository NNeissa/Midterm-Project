using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogResetPosition : MonoBehaviour {
	Vector3 Dog1;
	Vector3 Dog2;
	Vector3 Dog3;
	// Use this for initialization
	void Start () {
		Dog1 = new Vector3 (19.6f, 14.25f, -6.61f);
		Dog2 = new Vector3 (19.6f, 14.25f, 0.52f);
		Dog3 = new Vector3 (19.6f, 14.25f, 7f);
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -25.3f && this.gameObject.name == "Enemy_Catcher/Dog1"){
			transform.position = Dog1;
		}
		if(transform.position.x < -25.3f && this.gameObject.name == "Enemy_Catcher/Dog2"){
			transform.position = Dog2;
		}
		if(transform.position.x < -25.3f && this.gameObject.name == "Enemy_Catcher/Dog3"){
			transform.position = Dog3;
		}
	}
}
