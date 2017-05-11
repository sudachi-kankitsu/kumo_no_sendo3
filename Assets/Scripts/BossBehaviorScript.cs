using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviorScript : MonoBehaviour {
	public static int BossFlag = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (BossFlag == 1) {
			this.transform.position -= transform.up * 2 * Time.deltaTime;
		}
	}
}
