using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GodTouches{
	public class RestartScript : MonoBehaviour {

		public GameObject player;

		void Update(){
			var phase = GodTouch.GetPhase ();
			if (phase == GodPhase.Began) {
				if (player.activeSelf == false || BossFlagControllerScript.BossFlag == 5) {
					BossFlagControllerScript.BossFlag = 0;
					SceneManager.LoadScene ("main"); 
				}
			}
		}
	}
}