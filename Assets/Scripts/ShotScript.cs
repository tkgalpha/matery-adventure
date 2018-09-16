using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {
	public GameObject ExploadObj;
	public GameObject ExploadPos;
	public float RockHP = 3.0f;

	void Start () {
		//particle = this.GetComponent<ParticleSystem> ();
		//particle.Stop ();

	}
	
	// Update is called once per frame
	void Update () {
		

	}



	
		void OnTriggerEnter(Collider col){
		if (col.tag == "Enemy") {
			Instantiate (ExploadObj, ExploadPos.transform.position, Quaternion.identity);

			col.gameObject.SetActive (false);
			Destroy (gameObject);
		//Destroy (ExploadObj);

		}
	
		if (col.tag == "block") {
			
			Instantiate (ExploadObj, ExploadPos.transform.position, Quaternion.identity);
			
			Destroy (gameObject);
		//	Destroy (ExploadObj);
		}
		if (col.tag == "Rock") {
			RockHP -= 1.0f;
			//Debug.Log ("kusa");

			Instantiate (ExploadObj, ExploadPos.transform.position, Quaternion.identity);
			if (RockHP == 0.0f) {
				col.gameObject.SetActive (false);				Debug.Log ("kusa");
			}
	

			}

	}
}



