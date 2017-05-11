using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageScript : MonoBehaviour {
	public float EnemyHP = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Damage(){
		EnemyHP -= 1;
		Debug.Log (EnemyHP);
		if (EnemyHP <= 0) {
			Destroy (this.gameObject);
		}
	}

	public float HPsend (){
		return EnemyHP;
	}
}
