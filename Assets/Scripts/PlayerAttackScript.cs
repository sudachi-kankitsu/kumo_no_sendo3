using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GodTouches{
	public class PlayerAttackScript : MonoBehaviour {
		
		float startTime;
		float CheckTime = 0.2f;
		public GameObject Maincamera;

		Animator animator;

		void Start(){
			animator = this.gameObject.GetComponent<Animator>();
		}

		void Update(){
			
				var phase = GodTouch.GetPhase ();
				//タッチ判定
				if (phase == GodPhase.Began) {
					startTime = Time.time;
				} else if (phase == GodPhase.Ended) {
					if (Time.time - startTime < CheckTime) {
					AttackMitame ();
					}
				}
		}

		void AttackMitame(){
			PlayerSEscript SEscript = this.gameObject.GetComponent<PlayerSEscript>();
			animator.SetBool ("Attack",true);
			Invoke ("AttackAnimationOFF",0.1f);
			SEscript.attackSound ();

			//プレイヤーを操作不可にする
			GodTouches.PlayerMoveScript Pmove = Maincamera.GetComponent<GodTouches.PlayerMoveScript>();
			Pmove.DisableControll(CheckTime + 0.3f);
		}

		void AttackAnimationOFF(){
			animator.SetBool ("Attack",false);
		}
	}
}
