using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materyjumpScript : MonoBehaviour {

	private CharacterController controller;
	private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (controller.isGrounded) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				moveDirection.y = 26;
			}
		}

		moveDirection.y -= 120 * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);

	}
}
