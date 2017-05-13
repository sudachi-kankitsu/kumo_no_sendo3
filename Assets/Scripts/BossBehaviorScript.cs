using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviorScript : MonoBehaviour {

	public GameObject shot;
	float interval = 1;
	float attack3Timer = 4;
	bool attack3flag = true;

	void Update(){
		if (BossFlagControllerScript.BossFlag == 1) {
			interval -= Time.deltaTime;
			if (interval <= 0) {
				Shot ();
				interval = 1;
			}
			attack3flag = true;
		} else if (BossFlagControllerScript.BossFlag == 3 && attack3flag == true) {
			Invoke ("shot1", 1.5f);
			Invoke ("shot2", 2.5f);
			attack3flag = false;
		}
	}

	void Shot(){
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,180));
	}

	void shot1(){
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,0));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,90));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,180));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,270));
	}
	void shot2(){
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,45));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,135));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,225));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,315));
	}
}
