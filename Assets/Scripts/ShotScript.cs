using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {
	public GameObject ExploadObj;
	public GameObject ExploadPos;
	public  float RockHP = 1;
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

			Destroy (col.gameObject);
			Destroy (gameObject);
			//Destroy (ExploadObj);

		}
	
		if (col.tag == "block") {
			
			Instantiate (ExploadObj, ExploadPos.transform.position, Quaternion.identity);
			
			Destroy (gameObject);
		//	Destroy (ExploadObj);
		}
		if (col.tag == "Rock") {

			Instantiate (ExploadObj, ExploadPos.transform.position, Quaternion.identity);

			Destroy (gameObject);
		
			RockHP -= 1;

			}
		if (RockHP == 0) {
			Debug.Log (RockHP+RockHP);
			Destroy (col.gameObject);
		}
	}
}



