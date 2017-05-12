using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossFlagControllerScript : MonoBehaviour {
	public static int BossFlag = 0;
	public GameObject Boss;
	public GameObject Maincamera;
	float beforeClearInterval = 3;
	public Text ClearText;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player" && BossFlag == 0) {
			BossFlag = 1;
			GodTouches.PlayerMoveScript Pmove = Maincamera.GetComponent<GodTouches.PlayerMoveScript>();
			Pmove.StopPlayer();
		}
	}

	public void FlagChange() {
		BossFlag = Random.Range (1, 4);
	}

	public void FlagClear() {
		BossFlag = 4;

		CameraMoveScript.CameraStopper = 0;
		GodTouches.PlayerMoveScript Pmove = Maincamera.GetComponent<GodTouches.PlayerMoveScript>();
		Pmove.StartPlayer();
	}

	void Update(){
		if (BossFlag == 4){
			beforeClearInterval -= Time.deltaTime;
			if (beforeClearInterval <= 0){
				ClearText.text = "Clear!";
				BossFlag = 5;
			}
		}
	}
}
