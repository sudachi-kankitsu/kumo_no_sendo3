using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossFlagControllerScript : MonoBehaviour {
	public static int BossFlag = 9;
	public GameObject Boss;
	public GameObject Maincamera;
	public Text ClearText;

	Animator animator;

	void Start(){
		animator = Boss.GetComponent <Animator> ();
		BossFlag = 9;
		animator.SetInteger ("BossFlag",9);
	}

	void Update(){
		if (BossFlag != 9 && BossFlag != 5 && BossFlag != 4) {
//ボスの攻撃フラグ管理
			if (animator.GetCurrentAnimatorStateInfo (0).fullPathHash == Animator.StringToHash ("Base Layer.BossAttack1")) {
				BossFlag = 1;
			} else if (animator.GetCurrentAnimatorStateInfo (0).fullPathHash == Animator.StringToHash ("Base Layer.BossAttack3")) {
				BossFlag = 3;
			} else if (animator.GetCurrentAnimatorStateInfo (0).fullPathHash == Animator.StringToHash ("Base Layer.BossAttack2")) {
				BossFlag = 6;
			}else {
				BossFlag = 0;
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
//最初の処理
		if (other.tag == "Player" && BossFlag == 9) {
			BossFlag = 0;
			animator.SetInteger ("BossFlag",0);
			GodTouches.PlayerMoveScript Pmove = Maincamera.GetComponent<GodTouches.PlayerMoveScript>();
			Pmove.StopPlayer();
		}
	}


//ボスの死亡処理
	public void FlagClear() {
		BossFlag = 4;

		CameraMoveScript.CameraStopper = 0;
		GodTouches.PlayerMoveScript Pmove = Maincamera.GetComponent<GodTouches.PlayerMoveScript>();
		Pmove.StartPlayer();
		Invoke ("clear", 3.0f);
	}

	void clear(){
		BossFlag = 5;
		ClearText.text = "Clear!";
		SystemSEscript systemSE = Maincamera.GetComponent<SystemSEscript>();
		systemSE.ClearSound ();
	}
}
