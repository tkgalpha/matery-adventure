using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animCon : MonoBehaviour {
	public Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
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
	

