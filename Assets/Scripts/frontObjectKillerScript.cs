using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontObjectKillerScript : MonoBehaviour {


	void Start () {

	}

	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "frontObjectKiller") {
			Destroy (this.gameObject);
		}
	}
		
}
