using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemSEscript : MonoBehaviour {
	public AudioSource BGM;
	public AudioSource GameOver;
	public AudioSource Clear;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GameOverSound(){
		BGM.volume = 0.0f;
		GameOver.PlayOneShot (GameOver.clip);
	}

	public void ClearSound(){
		BGM.volume = 0.0f;
		Clear.PlayOneShot (Clear.clip);
	}
}
