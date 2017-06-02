using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GodTouches{
	public class PlayerAttackCheckerScript : MonoBehaviour {

		float startTime;
		float CheckTime = 0.2f;
		public GameObject AttackEffect;
		GameObject CollInfo;

		void OnTriggerStay2D (Collider2D other) {
			if (other.tag == "enemy" || other.tag == "Boss") {

				var phase = GodTouch.GetPhase ();
				//タッチ判定
				if (phase == GodPhase.Began) {
					startTime = Time.time;
				} else if (phase == GodPhase.Ended) {
					if (Time.time - startTime < CheckTime) {

						//相手のDamage関数を実行する
						if (other.tag == "enemy") {
							EnemyDamageScript Edam = other.GetComponent<EnemyDamageScript> ();
							Edam.Damage ();
							DamageSeScript DamSEScript = this.GetComponent<DamageSeScript>();
							DamSEScript.EmemyDamageSound ();
						}else if (other.tag == "Boss") {
							BossHPScript BHP = other.GetComponent<BossHPScript> ();
							BHP.Damage ();
							DamageSeScript DamSEScript = this.GetComponent<DamageSeScript>();
							DamSEScript.BossDamageSound ();
						}
						//相手がいたところにエフェクト
						Instantiate (AttackEffect, other.transform.position, Quaternion.identity);
					}
				}
			}
		}
	}
}
