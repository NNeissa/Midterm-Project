using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FatherCamera : MonoBehaviour {
	Rigidbody RB;
	bool SeePlayer;
	public LayerMask RaycastMask;
	public float RayDistance = 15f;
	public Vector3 Direction = new Vector3 (-1, 0, 0);
	public GameObject Player;
	public Text PlayerText;
	float TextTimer = 0f;
	Vector3 RestartPosition;
	float Timer = 0f;
	float TimeTurnOff = 3f;
	bool Caught = false;
	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody> ();
		RestartPosition = new Vector3 (24.4f, 1.78f, -4.5f);
	}

	// Update is called once per frame
	void Update () {
		Timer = Timer + Time.deltaTime;
		Ray ray = new Ray(transform.position, transform.forward);
		Debug.DrawRay(ray.origin, Direction * 10f, Color.yellow);
		if (Timer > TimeTurnOff) {
			GetComponentInChildren<Light> ().intensity = 8f;
			SeePlayer = Physics.Raycast (transform.position, Direction, RayDistance, RaycastMask);
		}
		if(Timer < TimeTurnOff){
			GetComponentInChildren<Light> ().intensity = 0f;
		}
		if (Timer > TimeTurnOff + 3f) {
			Timer = Timer - 6f;
		}
		if (SeePlayer == true && TextTimer < 5f) {
			Debug.Log ("Freeze");
			TextTimer += Time.deltaTime;
			PlayerText.text = "What are you doing up? BACK TO BED!";
			Player.GetComponent<CharacterController> ().enabled = false;
			Caught = true;
		}
		if(TextTimer >= 5f && Caught == true){
			Debug.Log ("Change");
			Caught = false;
			Player.transform.position = RestartPosition;
			TextTimer = 0f;
			PlayerText.text = "";
			Player.GetComponent<CharacterController> ().enabled = true;
		}
	}
}
