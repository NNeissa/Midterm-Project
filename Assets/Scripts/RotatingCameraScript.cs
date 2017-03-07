using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatingCameraScript : MonoBehaviour {
	Rigidbody RB;
	bool rayCastSaw;
	public LayerMask RaycastMask;
	public float RayDistance = 15f;
	public Vector3 Direction = new Vector3 (-1, 0, 0);
	public GameObject Player;
	public Text PlayerText;
	float TextTimer = 0f;
	Vector3 RestartPosition;
	float Timer = 0f;
	float TimeTurnOff = 3f;
	bool HitWall = false;
	bool SeePlayer = false;
	float RotateSpeed = 10f;
	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody> ();
		RestartPosition = new Vector3 (24.4f, 1.78f, -4.5f);
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 2, 0) * Time.deltaTime * RotateSpeed);
		Timer = Timer + Time.deltaTime;
		Ray ray = new Ray(transform.position, transform.forward);
		Debug.DrawRay(ray.origin, transform.forward * 9f, Color.yellow);
		RaycastHit rayHit = new RaycastHit(); // this is just a blank variable right now
		rayCastSaw = Physics.Raycast (transform.position, transform.forward, out rayHit, RayDistance, RaycastMask);

		if (rayCastSaw == true && rayHit.collider.gameObject.tag == "Player") {
			SeePlayer = true;
			MotherMovement.SeePlayer = true;
			TextTimer += Time.deltaTime;
			TextScript.Caught = true;
//			PlayerText.text = "What are you doing up? BACK TO BED!";
			Player.GetComponent<CharacterController> ().enabled = false;
		}
		if(SeePlayer){
			RotateSpeed = 0f;
			TextTimer += Time.deltaTime;
			TextScript.Caught = true;
//			PlayerText.text = "What are you doing up? BACK TO BED!";
			Player.GetComponent<CharacterController> ().enabled = false;
		}
		if(TextTimer > 5f){
			SeePlayer = false;
			RotateSpeed = 10f;
			TextTimer = 0f;
			rayCastSaw = false;
			Player.transform.position = RestartPosition;
			Player.GetComponent<CharacterController> ().enabled = true;
			TextScript.Caught = false;
//			PlayerText.text = "";
		}
	}
}

