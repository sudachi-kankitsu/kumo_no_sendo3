using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemSEscript : MonoBehaviour {
	public AudioSource BGM;
	public AudioClip title;
	public AudioClip field;
	public AudioSource GameSE;
	public AudioClip GameOver;
	public AudioClip Clear;
	public AudioClip Wind;

	void Start () {
		BGM.clip = title;
		GameSE.clip = Wind;
	}


	public void GameOverSound(){
		Debug.Log ("gameoverSound");
		BGM.volume = 0.0f;
		GameSE.PlayOneShot (GameOver);
	}

	public void ClearSound(){
		BGM.volume = 0.0f;
		GameSE.PlayOneShot (Clear);
	}

	public void WindSound(){
		BGM.volume = 0.1f;
		Invoke ("fieldBGMplay", 2.0f);
		GameSE.PlayOneShot (Wind,0.8f);
	}

	void fieldBGMplay(){
		BGM.clip = field;
		BGM.Play ();
		BGM.volume = 0.3f;
	}
}
