using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHPScript : MonoBehaviour {
	float EnemyHP = 1;
	float EnemyFullHP;
	public GameObject BossFlagController;
	public GameObject Maincamera;
	public Image BossHPBar;


	void Start(){
		EnemyFullHP = EnemyHP;
	}

	void Update(){
		BossHPBar.fillAmount = EnemyHP / EnemyFullHP;
	}

	public void Damage(){
		EnemyHP -= 1;

		//ボスが倒されたらクリアを呼ぶ
		if (EnemyHP <= 0) {
			GodTouches.RestartScript ResS = Maincamera.GetComponent <GodTouches.RestartScript> ();
			ResS.ClearAfter1Sec();
			this.gameObject.SetActive(false);
		}
	}
}
