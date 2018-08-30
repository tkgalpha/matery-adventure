using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {
	[SerializeField]private Vector3 velocity;
	[SerializeField]private float moveSpeed = 5.0f;
	[SerializeField]private float applySpeed = 0.1f;
	private CharacterController controller;
	private Vector3 moveDirection;
	public Animator animator;


	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		velocity = Vector3.zero;

		if (Input.GetKey (KeyCode.UpArrow)) {
			velocity.x += 1;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			velocity.x -= 1;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			velocity.z -= 1;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			velocity.z += 1;
		}
		velocity = velocity.normalized * moveSpeed * Time.deltaTime;
		if (velocity.magnitude > 0) {
			transform.position += velocity;
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (velocity), applySpeed);
		
		}
		if (controller.isGrounded) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				moveDirection.y = 26;
			}
		}

		moveDirection.y -= 120 * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);
		if (Input.GetKey(KeyCode.UpArrow)) {
			animator.SetBool("Walk", true);
		}else if (Input.GetKey(KeyCode.DownArrow)) {
			animator.SetBool("Walk", true);
		}else if (Input.GetKey(KeyCode.RightArrow)) {
			animator.SetBool("Walk", true);
		}else if (Input.GetKey(KeyCode.LeftArrow)) {
			animator.SetBool("Walk", true);
		}else if (Input.GetKey(KeyCode.Space)) {
			animator.SetBool("Walk", true);
		} else {
			animator.SetBool("Walk", false);
		}
	
}

}

