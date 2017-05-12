using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GodTouches{
	public class PlayerAttackScript : MonoBehaviour {
		
		float startTime;
		float CheckTime = 0.3f;
		public GameObject AttackEffect;

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
						}else if (other.tag == "Boss") {
							BossDamageScript Bdam = other.GetComponent<BossDamageScript> ();
							Bdam.Damage ();
						}
						//相手がいたところにエフェクト
						Instantiate (AttackEffect, other.transform.position, Quaternion.identity);
					}
				}
			}
		}

	}
}
