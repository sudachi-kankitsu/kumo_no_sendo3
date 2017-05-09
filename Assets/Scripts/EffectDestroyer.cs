using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDestroyer : MonoBehaviour {
	float Timer = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Timer -= Time.deltaTime;

		if (Timer <= 0) {
			Destroy (this.gameObject);
		}
	}
}
