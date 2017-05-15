using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnemyScript : MonoBehaviour {
	float interval = 2;
	public GameObject shot;
	bool trigger = false;

	// Use this for initialization
	void Start () {
		trigger = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (trigger == true) {
			interval -= Time.deltaTime;
			if (interval <= 0) {
				Instantiate (shot, this.transform.position, Quaternion.Euler (0, 0, Random.Range (90, 271)));
				interval = 2;
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "frontObjectKiller") {
			trigger = true;
		}
	}

}

