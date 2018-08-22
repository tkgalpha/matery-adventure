using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
	public enum Mode
	{
		Normal,
		MoveTowards,
		Lerp,
		Slerp
	};
	[SerializeField]
	private Mode mode;
	private CharacterController cCon;
	private Vector3 velocity;
	private Vector3 oldVelocity;

	[SerializeField]
	private float moveSpeed = 10f;


	// Use this for initialization
	void Start () {
		cCon = GetComponent<CharacterController> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (cCon.isGrounded) {
			velocity = Vector3.zero;
			velocity = new Vector3 (Input.GetAxis ("Horizontal"), 0f, Input.GetAxis ("Vertical"));
			if (mode == Mode.MoveTowards) {
				velocity = Vector3.MoveTowards (oldVelocity, velocity, moveSpeed * Time.deltaTime);
			} else if (mode == Mode.Lerp) {
				velocity = Vector3.Lerp (oldVelocity, velocity, moveSpeed * Time.deltaTime);
			} else if (mode == Mode.Slerp) {
				velocity = Vector3.Slerp (oldVelocity, velocity, moveSpeed * Time.deltaTime);
			}
			oldVelocity = velocity;
			if (velocity.magnitude > 0f) {
				
				transform.LookAt (transform.position + velocity);
			} 
		}
		velocity.y += Physics.gravity.y * Time.deltaTime;
		cCon.Move (velocity * Time.deltaTime);

		
	}
}
