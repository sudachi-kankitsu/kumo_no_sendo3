using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (BossFlagControllerScript.BossFlag == 1) {
			this.transform.position -= transform.up * 2 * Time.deltaTime;
		}
	}
}
