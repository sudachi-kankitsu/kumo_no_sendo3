using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot1Script : MonoBehaviour {
	public float speed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += transform.up * speed * Time.deltaTime;
	}
}
