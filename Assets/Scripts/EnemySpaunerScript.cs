using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaunerScript : MonoBehaviour {

	float Timer = 0;
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		Instantiate (enemy, this.transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;

		if (Timer >= 3){
			Instantiate (enemy, this.transform.position, Quaternion.identity);
			Timer = 0;
		}
	}
}
