using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMoveScript : MonoBehaviour {
	public static int CameraStopper = 1;

		void Start () {
		CameraStopper = 1;
		}
		

		void Update () {
		this.transform.position += transform.up * GodTouches.PlayerMoveScript.playerYspeed * Time.deltaTime * CameraStopper;
		}

}
