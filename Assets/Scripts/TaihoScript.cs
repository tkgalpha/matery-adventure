using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaihoScript : MonoBehaviour {
	[SerializeField]
	private GameObject shotObject;
	[SerializeField]
	private Transform muzzle;
	[SerializeField]
	private float bulletSpeed = 10f;
	public float timeOut;
	private float timeElapsed;
	public Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;
		if(timeElapsed >=timeOut){
			animator.SetTrigger ("Shot");
			GameObject runcherBullet = GameObject.Instantiate (shotObject, muzzle.position, muzzle.rotation) as GameObject; //runcherbulletにbulletのインスタンスを格納
			runcherBullet.GetComponent<Rigidbody> ().velocity -= transform.up * bulletSpeed; //アタッチしているオブジェクトの前方にbullet speedの速さで発射
			runcherBullet.transform.position = transform.position;
			Destroy (runcherBullet, 5f);
				timeElapsed = 0.0f;

		
		}
}
}
