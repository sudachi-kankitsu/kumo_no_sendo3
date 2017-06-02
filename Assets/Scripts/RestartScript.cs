using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GodTouches{
	public class RestartScript : MonoBehaviour {

		public GameObject player;
		public GameObject Boss;

		public GameObject ClearImg;
		public GameObject GameOverImg;

		//クリア：プレイヤーだけ動かす＋１秒後にクリア画像とクリア音
		public void ClearAfter1Sec(){
			PlayerMoveScript Pmove = this.GetComponent<PlayerMoveScript>();
			Pmove.StartPlayer();
			Invoke("Clear",1.0f);
		}

		void Clear(){
			ClearImg.gameObject.SetActive (true);
			SystemSEscript systemSE = this.GetComponent<SystemSEscript>();
			systemSE.ClearSound ();
			Invoke ("Restart", 6.0f);
		}

		//ゲームオーバー：カメラを止める＋ゲームオーバーの画像と音
		public void GameOver(){
			CameraMoveScript.CameraCanMove = 0;
			GameOverImg.gameObject.SetActive (true);
			SystemSEscript systemSE = this.GetComponent<SystemSEscript> ();
			systemSE.GameOverSound ();
			Invoke ("Restart", 6.0f);
		}

		void Restart(){
			SceneManager.LoadScene ("main"); 
		}
			
	}
}