using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageScript : MonoBehaviour {
	public float EnemyHP = 1;
	int PowerUpPoint = 1;

	// Use this for initialization
	void Start () {
		EnemyHP = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Damage(){
		EnemyHP -= 1;

		if (EnemyHP <= 0) {
			Destroy (this.gameObject);
		}
	}
}
