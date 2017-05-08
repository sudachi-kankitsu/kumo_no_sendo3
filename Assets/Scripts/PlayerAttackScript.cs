using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GodTouches{
	public class PlayerAttackScript : MonoBehaviour {

		float startTime;
		float CheckTime = 0.3f;

		void Start () {
			
		}
		

		void Update () {
			
			var phase = GodTouch.GetPhase ();
			//タッチ開始
			if (phase == GodPhase.Began) 
			{
				startTime = Time.time;
			}
			//タッチ中
			else if (phase == GodPhase.Moved) 	
			{

			}
			//タッチ終了
			else if (phase == GodPhase.Ended) 	
			{
				if (Time.time - startTime < CheckTime) {
					Debug.Log("Attack!");
				}
			}
		}
	}
}
