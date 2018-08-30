using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour {
	[SerializeField]
	private GameObject shotObject;
	[SerializeField]
	private Transform muzzle;
	[SerializeField]
	private float bulletSpeed = 10f;
	public AudioSource gunSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.X)) {
				GameObject runcherBullet = GameObject.Instantiate(shotObject,muzzle.position,muzzle.rotation) as GameObject; //runcherbulletにbulletのインスタンスを格納
				runcherBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed; //アタッチしているオブジェクトの前方にbullet speedの速さで発射
				runcherBullet.transform.position = transform.position;
				gunSound.Play ();
				Destroy(runcherBullet, 5f);
			}
		}
}


