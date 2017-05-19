using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GodTouches{
	public class titleScript : MonoBehaviour {
		public GameObject player;
		public GameObject TitleImg;
		public GameObject TitleBG;
		public GameObject Maincamera;

		public float speed = 30f;  //透明化の速さ
		float alfa;    //A値を操作するための変数
		float red, green, blue;    //RGBを操作するための変数
		int fadeChecker = 9; //9は何もしない。0は待機。1ならフェードイン。2ならフェードアウト。


		void Start () {
			player.SetActive (false);
			TitleImg.SetActive (true);
			TitleBG.SetActive (true);
			fadeChecker = 9;
			red = this.GetComponent<Image>().color.r;
			green = this.GetComponent<Image>().color.g;
			blue = this.GetComponent<Image>().color.b;
			alfa = this.GetComponent<Image>().color.a;
		}

		void Update () {
			if (fadeChecker == 9){
				this.GetComponent<Image> ().color = new Color (red, green, blue, alfa);
				alfa -= Time.deltaTime;
				if (alfa <= 0) {
					fadeOn ();
				}
			} else {
				var phase = GodTouch.GetPhase ();
				if (phase == GodPhase.Began && fadeChecker == 0) {
					fadeIn ();
					SoundWind ();
					Invoke ("StartPlay", 1.5f);
					Invoke ("fadeOut", 2.0f);
					Invoke ("fadeOff", 4.0f);
				}
				if (fadeChecker == 1) {
					this.GetComponent<Image> ().color = new Color (red, green, blue, alfa);
					alfa += Time.deltaTime;
				} else if (fadeChecker == 2) {
					this.GetComponent<Image> ().color = new Color (red, green, blue, alfa);
					alfa -= Time.deltaTime;
				}
			}
		}

		void StartPlay(){
			player.SetActive (true);
			PlayerMoveScript pMoveS = Maincamera.GetComponent<PlayerMoveScript> ();
			pMoveS.StartPlayer();
			TitleImg.gameObject.SetActive (false);
			TitleBG.gameObject.SetActive (false);
		}

		void fadeOut(){
			fadeChecker = 2;
		}

		public void fadeIn(){
			fadeChecker = 1;
		}

		void fadeOn(){
			fadeChecker = 0;
		}

		void fadeOff(){
			this.gameObject.SetActive (false);
		}

		void SoundWind(){
			SystemSEscript seS = Maincamera.GetComponent<SystemSEscript> ();
			seS.WindSound ();
		}

	}
}
