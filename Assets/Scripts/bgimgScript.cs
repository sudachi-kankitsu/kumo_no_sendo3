using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgimgScript : MonoBehaviour {
	public float speed = 1;
	public GameObject Maincamera;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position -= transform.up * 1 * speed * Time.deltaTime;
		if (Maincamera.transform.position.y - this.transform.position.y >= 30){
			this.transform.position += transform.up * 68;
		}
	}
		
}
