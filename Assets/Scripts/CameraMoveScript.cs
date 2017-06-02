using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour {
	public static int CameraCanMove = 1;

	void Start(){
		CameraCanMove = 1;
	}
		
	void Update () {
	this.transform.position += transform.up * GodTouches.PlayerMoveScript.playerYspeed * Time.deltaTime * CameraCanMove;
	}
}
