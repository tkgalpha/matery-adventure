using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materyScript : MonoBehaviour {
	public	float speed;
	private Vector3 Player_pos;
	private float x;
	private float z;
	private Rigidbody rigd;
	float upspeed =4.0f;

	// Use this for initialization
	void Start () {
		//Player_pos = GetComponent<Transform> ().position;
		//rigd = GetComponent<Rigidbody> ();
	}
	// Update is called once per frame
	void Update () {
		//x = Input.GetAxis ("Horizontal");
		//z = Input.GetAxis ("Vertical");
		//rigd.velocity = new Vector3(x*speed,0,z*speed);
		//Vector3 diff = transform.position - Player_pos;

	//	if (diff.magnitude > 0.1f) {
	//		transform.rotation = Quaternion.LookRotation (diff);
	//	}
	//	Player_pos = transform.position;

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += new Vector3 (0, 0, -speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += new Vector3 (0, 0, speed * Time.deltaTime);
		}

		//if (Input.GetKey (KeyCode.UpArrow)) {
		//	GetComponent<Rigidbody>().velocity = new Vector3 (0, upspeed * Time.deltaTime, 0);
		//}
	}
}
	



