using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour {
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
	bool HitWall = false;
	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody> ();
		RestartPosition = new Vector3 (24.4f, 1.78f, -4.5f);
	}
	
	// Update is called once per frame
	void Update () {
		Timer = Timer + Time.deltaTime;
		Ray ray = new Ray(transform.position, transform.forward);
		Debug.DrawRay(ray.origin, Direction * 9f, Color.yellow);
		Debug.Log (TextTimer);
		SeePlayer = Physics.Raycast (transform.position, Direction, RayDistance, RaycastMask);
		if (SeePlayer == true && HitWall == false) {
			TextTimer += Time.deltaTime;
			Debug.Log ("Camera1 see's the player");
			PlayerText.text = "What are you doing up? BACK TO BED!";
			Player.GetComponent<CharacterController> ().enabled = false;
		}
		if(TextTimer > 5f){
			Debug.Log ("transport");
			Player.transform.position = RestartPosition;
			PlayerText.text = "";
			Player.GetComponent<CharacterController> ().enabled = true;
	}
}
}
