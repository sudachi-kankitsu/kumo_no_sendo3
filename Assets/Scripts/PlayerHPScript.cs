using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPScript : MonoBehaviour {
	float playerHP = 10;
	float playerFullHP;
	float mutekiTime = 3;
	bool muteki = false;
	public Image HPbar;
	public GameObject GameOverImg;
	public GameObject Maincamera;

	float interval = 0.25f;
	public Renderer rend;

	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		playerFullHP = playerHP;
		HPbar.fillAmount = 1;
		GameOverImg.gameObject.SetActive (false);
	}
	
//無敵時間中ちかちか
	void Update () {
		if (muteki == true) {
			mutekiTime -= Time.deltaTime;
			interval -= Time.deltaTime;
			if (interval <= 0){
				rend.enabled = !rend.enabled;
				interval = 0.25f;
			}
		}

		if (mutekiTime <= 0){
			mutekiTime = 3;
			muteki = false;
			rend.enabled = true;
		}
			
	}


//敵に当たったら１ダメージ+無敵に入る
	void OnTriggerStay2D (Collider2D other){
		if ((other.tag == "enemy" || other.tag == "nonDestroyableEnemy" || other.tag == "Boss") && muteki == false) {
			playerHP -= 1;
			muteki = true;
			rend.enabled = false;
			HPbar.fillAmount = playerHP / playerFullHP;
			PlayerSEscript SEscript = this.gameObject.GetComponent<PlayerSEscript>();
			SEscript.damageSound ();

			if (playerHP <= 0) {
				GameOver ();
			}
		}
	}

	void GameOver() {
		GodTouches.PlayerMoveScript.playerYspeed = 0;
		this.gameObject.SetActive (false);
		GameOverImg.gameObject.SetActive(true);
		SystemSEscript systemSE = Maincamera.GetComponent<SystemSEscript>();
		systemSE.GameOverSound ();
	}
}
