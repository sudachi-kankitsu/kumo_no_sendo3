using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamageScript : MonoBehaviour {
	public float EnemyHP = 5;
	public GameObject BossFlagController;

	public void Damage(){
		EnemyHP -= 1;
		if (EnemyHP <= 0) {
			BossFlagControllerScript BflagCon = BossFlagController.GetComponent<BossFlagControllerScript>();
			BflagCon.FlagClear ();
			Destroy (this.gameObject);
		}
	}

	public float HPsend (){
		return EnemyHP;
	}
}
