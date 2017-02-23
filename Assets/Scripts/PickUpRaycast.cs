using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRaycast : MonoBehaviour {

	Collider ObjectHeld;
	public LayerMask myRaycastMask; //access in inspector
	
	// Update is called once per frame
	void Update () {
		//1. construct a ray
		Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

		//2. reserve some space in memory to remember what we hit
		RaycastHit rayHit = new RaycastHit(); // this is just a blank variable right now

		//2b. visualize ray in the debug scene
		Debug.DrawRay(ray.origin, ray.direction * 5f, Color.yellow);


		//3. shoot our raycast
		if (Physics.Raycast (ray, out rayHit, 5f, myRaycastMask)) {
			//4. did player click?
			if(Input.GetMouseButtonDown(0)){
				ObjectHeld = rayHit.collider;// remember the object the raycast hit
				ObjectHeld.transform.parent = Camera.main.transform; // parent object to camera
				//GameManager.myPoints += 1;
		}

	}
		//5. did player stop clicking
		if (Input.GetMouseButton (0) == false && ObjectHeld != null) {
			ObjectHeld.transform.parent = null;//unparent object
			ObjectHeld = null;//forget about it
		}
}
}
