using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossFlagControllerScript : MonoBehaviour {
	public static int BossFlag = -1;

	public GameObject Boss;
	public GameObject Maincamera;
	public GameObject ClearImg;
	Animator animator;

	//待機アニメーションにしておく
	void Start(){
		animator = Boss.GetComponent <Animator> ();
		animator.SetBool ("BossFlag",false);
	}

	//ボス戦開始
	//アニメーションを動かす＋カメラとプレイヤーを止める
	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player" && BossFlag == -1) {
			BossFlag = 0;
			animator.SetBool ("BossFlag",true);
			GodTouches.PlayerMoveScript Pmove = Maincamera.GetComponent<GodTouches.PlayerMoveScript>();
			Pmove.StopPlayer();
		}
	}

	//ボス戦勝利
	//カメラは止めたままプレイヤーを動かす＋１秒後にクリア画面へ
	public void FlagClear() {
		BossFlag = 8;

		CameraMoveScript.CameraStopper = 0;
		GodTouches.PlayerMoveScript Pmove = Maincamera.GetComponent<GodTouches.PlayerMoveScript>();
		Pmove.StartPlayer();
		Invoke ("clear", 3.0f);
	}

	//クリア画面
	//クリア音を流す＋クリア後の処理可能にする
	void clear(){
		BossFlag = 9;
		ClearImg.gameObject.SetActive (true);
		SystemSEscript systemSE = Maincamera.GetComponent<SystemSEscript>();
		systemSE.ClearSound ();
	}
}
