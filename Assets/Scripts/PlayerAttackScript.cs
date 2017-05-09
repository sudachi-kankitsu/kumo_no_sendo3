using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GodTouches{
	public class PlayerAttackScript : MonoBehaviour {
		
		float startTime;
		float CheckTime = 0.3f;
		public GameObject AttackEffect;

		void Start () {
			
		}
		

		void Update () {

		}

		void OnTriggerStay2D (Collider2D other) {
			if (other.tag == "enemy") {
			
				var phase = GodTouch.GetPhase ();
			//タッチ判定
				if (phase == GodPhase.Began) {
					startTime = Time.time;
				}
				else if (phase == GodPhase.Ended) {
					if (Time.time - startTime < CheckTime) {

			//攻撃して相手を消す
						Destroy (other.gameObject);
			//相手がいたところにエフェクト
						Instantiate(AttackEffect,other.transform.position,Quaternion.identity);
					}
				}
			}

		}

	}
}
