using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSeScript : MonoBehaviour {

	public AudioSource EnemyDamageSource;
	public AudioSource BossDamageSource;

	public void EmemyDamageSound(){
		EnemyDamageSource.PlayOneShot (EnemyDamageSource.clip);
	}

	public void BossDamageSound(){
		BossDamageSource.PlayOneShot (BossDamageSource.clip);
	}
}
