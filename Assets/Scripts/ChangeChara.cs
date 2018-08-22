using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeChara : MonoBehaviour {
	private int nowChara;
	[SerializeField]
	private List<GameObject> charaLists;

	// Use this for initialization
	void Start () {
		nowChara = charaLists.Count;
		ChangeCharacter (nowChara);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("z")){
			ChangeCharacter(nowChara);
		}
	}
	void ChangeCharacter(int tempNowChara){
		bool flag;
		int nextChara = tempNowChara + 1;
		if (nextChara >= charaLists.Count) {
			nextChara = 0;
		}
		for (var i = 0; i < charaLists.Count; i++) {
			if (i == nextChara) {
				flag = true;
			} else {
				flag = false;
			}
			charaLists [i].GetComponent<RotationScript> ().enabled = flag;
			//charaLists [i].GetComponent<Animator> ().SetFloat ("Walk", 0);
		}
		nowChara = nextChara;
				
	}
}
