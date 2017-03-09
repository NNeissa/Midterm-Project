using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FatherCamera : MonoBehaviour {
	Rigidbody RB;
	bool SeePlayer1;
	bool SeePlayer2;
	bool SeePlayer3;
	public LayerMask RaycastMask;
	public float RayDistance = 15f;
	public Vector3 Direction1 = new Vector3 (-1, 0, 0);
	public Vector3 Direction2 = new Vector3 (-1f, 0, 1f);
	public Vector3 Direction3 = new Vector3 (-1f, 0, -1f);
	public GameObject Player;
	public Text PlayerText;
	float TextTimer = 0f;
	Vector3 RestartPosition;
	float Timer = 0f;
	float TimeTurnOff = 3f;
	bool Caught = false;
	public AudioSource TeleportSound;

	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody> ();
		RestartPosition = new Vector3 (24.4f, 1.78f, -4.5f);
	}

	// Update is called once per frame
	void Update () {
		Timer = Timer + Time.deltaTime;
		Ray ray = new Ray(transform.position, transform.forward);
		Debug.DrawRay(ray.origin, Direction2 * 10f, Color.yellow);
		if (Timer > TimeTurnOff) {
			GetComponentInChildren<Light> ().intensity = 8f;
			SeePlayer1 = Physics.Raycast (transform.position, Direction1, RayDistance, RaycastMask);
		}
		if(Timer < TimeTurnOff){
			GetComponentInChildren<Light> ().intensity = 0f;
		}
		if (Timer > TimeTurnOff + 3f) {
			Timer = Timer - 6f;
		}
		if(TextTimer >= 5f){
			SeePlayer1 = false;
			TextTimer = 0f;
			Player.transform.position = RestartPosition;
			Player.GetComponent<CharacterController> ().enabled = true;
			TextScript.Caught = false;
//			PlayerText.text = "";
		} else if(SeePlayer1 == true) {
			TeleportSound.Play();
			TextTimer += Time.deltaTime;
			TextScript.Caught = true;
//			PlayerText.text = "What are you doing up? BACK TO BED!";
			Player.GetComponent<CharacterController> ().enabled = false;
		}
	}
}
