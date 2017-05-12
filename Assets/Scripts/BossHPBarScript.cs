using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHPBarScript : MonoBehaviour {
	float BossFullHP = 5;
	public Image BossHPBar;
	public GameObject Boss;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		BossDamageScript Bdam = Boss.GetComponent <BossDamageScript> ();
		BossHPBar.fillAmount =  Bdam.HPsend() / BossFullHP;
	}
}
