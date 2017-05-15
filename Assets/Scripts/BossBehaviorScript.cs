using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviorScript : MonoBehaviour {

	public GameObject shot;
	float interval = 1;
	int attackFlag = 2;

	public AudioSource attack1SEsource;
	public AudioSource attack2SEsource;
	public AudioSource attack3SEsource;

	void Start(){
		interval = 1;
		attackFlag = 2;
	}

	void Update(){
		if (BossFlagControllerScript.BossFlag == 1) {
			interval -= Time.deltaTime;
			if (interval <= 0) {
				Shot ();
				interval = 1;
			}
			attackFlag = 3;
		} else if (BossFlagControllerScript.BossFlag == 3 && attackFlag == 3) {
			Invoke ("shot1", 1.5f);
			Invoke ("shot2", 2.5f);
			attackFlag = 2;
		}else if (BossFlagControllerScript.BossFlag == 6 && attackFlag == 2) {
			Invoke ("se2", 1.0f);
			attackFlag = 1;
		}
	}

	void Shot(){
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,180));
		attack1SEsource.PlayOneShot (attack1SEsource.clip);
	}

	void shot1(){
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,0));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,90));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,180));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,270));
		attack3SEsource.PlayOneShot (attack3SEsource.clip);
	}
	void shot2(){
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,45));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,135));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,225));
		Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,315));
		attack3SEsource.PlayOneShot (attack3SEsource.clip);
	}

	void se2(){
		attack2SEsource.PlayOneShot (attack2SEsource.clip);
	}
}
