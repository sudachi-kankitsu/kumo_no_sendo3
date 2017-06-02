using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossFlagControllerScript : MonoBehaviour {
	public static bool BossFlag = false;
	public GameObject Boss;
	public GameObject Maincamera;
	Animator animator;

	//待機アニメーションにしておく
	void Start(){
		animator = Boss.GetComponent <Animator> ();
		animator.SetBool ("BossFlag",false);
	}

	//ボス戦開始
	//アニメーションを動かす＋カメラとプレイヤーを止める
	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player" && BossFlag == false) {
			BossFlag = true;
			animator.SetBool ("BossFlag",true);
			GodTouches.PlayerMoveScript Pmove = Maincamera.GetComponent<GodTouches.PlayerMoveScript>();
			Pmove.StopPlayer();
			CameraMoveScript.CameraCanMove = 0;
		}
	}
}
