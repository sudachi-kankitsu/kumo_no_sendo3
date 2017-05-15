using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GodTouches{
	public class PlayerAttackScript : MonoBehaviour {
		
		float startTime;
		float CheckTime = 0.3f;

		void Update(){
			
				var phase = GodTouch.GetPhase ();
				//タッチ判定
				if (phase == GodPhase.Began) {
					startTime = Time.time;
				} else if (phase == GodPhase.Ended) {
					if (Time.time - startTime < CheckTime) {
						PlayerSEscript SEscript = this.gameObject.GetComponent<PlayerSEscript>();
						SEscript.attackSound ();
					}
				}
		}
	}
}
