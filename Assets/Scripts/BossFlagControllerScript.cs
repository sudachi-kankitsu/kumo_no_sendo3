using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFlagControllerScript : MonoBehaviour {
	public GameObject Boss;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player" && BossBehaviorScript.BossFlag == 0) {
			BossBehaviorScript.BossFlag = 1;
			GodTouches.PlayerMoveScript.playerYspeed = 0;
		}
	}
}
