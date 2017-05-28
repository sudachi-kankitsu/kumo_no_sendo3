using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GodTouches{
	public class RestartScript : MonoBehaviour {

		public GameObject player;
		public GameObject title;

		void Update(){
			var phase = GodTouch.GetPhase ();
			if (phase == GodPhase.Began) {
				if ((player.activeSelf == false && title.activeSelf == false)|| BossFlagControllerScript.BossFlag == 9) {
					Invoke ("Restart", 2.0f);
					title.SetActive (true);
					titleScript titleS = title.gameObject.GetComponent <titleScript>();
					titleS.fadeIn ();
				}
			}
		}

		void Restart(){
			SceneManager.LoadScene ("main"); 
		}
	}
}