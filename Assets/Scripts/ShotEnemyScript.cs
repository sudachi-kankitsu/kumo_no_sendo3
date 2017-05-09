using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnemyScript : MonoBehaviour {
	float interval = 2;
	public GameObject shot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		interval -= Time.deltaTime;
		if (interval <= 0) {
			Instantiate (shot, this.transform.position,Quaternion.Euler(0,0,Random.Range (90, 271)));
			interval = 2;
		}
	}
}
