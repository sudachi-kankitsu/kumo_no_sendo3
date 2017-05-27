using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttackScript : MonoBehaviour {

	int NextAttack = 1;

	float ShotInterval = 1;
	public GameObject shot;
	public AudioSource attack1SEsource;
	public AudioSource attack2SEsource;
	public AudioSource attack3SEsource;

	void Update(){

		if (BossFlagControllerScript.BossFlag == 1 && NextAttack == 1) {
			
			Invoke ("SE_Rush", 1.0f);
			NextAttack = 2;

		} else if (BossFlagControllerScript.BossFlag == 2) {
			ShotInterval -= Time.deltaTime;
			if (ShotInterval <= 0) {
				Shot ();
				ShotInterval = 1;
			}
			NextAttack = 3;

		} else if (BossFlagControllerScript.BossFlag == 3 && NextAttack == 3) {
			Invoke ("shot1", 1.5f);
			Invoke ("shot2", 2.5f);
			NextAttack = 1;
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

	void SE_Rush(){
		attack2SEsource.PlayOneShot (attack2SEsource.clip);
	}
}
