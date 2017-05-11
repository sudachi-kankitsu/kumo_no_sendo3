using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPScript : MonoBehaviour {
	int playerHP = 1;
	float mutekiTime = 3;
	bool muteki = false;
	public Text HP;

	float interval = 0.25f;
	public Renderer rend;

	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}
	
//無敵時間中ちかちか
	void Update () {
		HP.text = "HP : " + playerHP.ToString();
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
		if ((other.tag == "enemy" || other.tag == "nonDestroyableEnemy") && muteki == false) {
			playerHP -= 1;
			muteki = true;
			rend.enabled = false;

			if (playerHP <= 0) {
				GameOver ();
			}
		}
	}

	void GameOver() {
		HP.text = "GameOver!";
		GodTouches.PlayerMoveScript.playerYspeed = 0;
		this.gameObject.SetActive (false);
	}
}
