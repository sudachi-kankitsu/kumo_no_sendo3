using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgimgScript : MonoBehaviour {
//2枚の背景画像が入れ替わるようにループする。speed変更可

	public float speed = 1;
	public GameObject Maincamera;

	void Update () {
		this.transform.position -= transform.up * 1 * speed * Time.deltaTime;
		if (Maincamera.transform.position.y - this.transform.position.y >= 30){
			this.transform.position += transform.up * 68;
		}
	}
		
}