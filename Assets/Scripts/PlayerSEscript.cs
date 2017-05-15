using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSEscript : MonoBehaviour {
	public AudioSource attackSource;
	public AudioSource damageSource;

	void Start(){
	}

	public void attackSound(){
		attackSource.PlayOneShot (attackSource.clip);
	}

	public void damageSound(){
		damageSource.PlayOneShot (damageSource.clip);
	}
		
}
