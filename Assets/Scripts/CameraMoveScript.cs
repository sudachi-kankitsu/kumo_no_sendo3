using System.Collections;
using System.Collections.Generic;
using UnityEngine;


	public class CameraMoveScript : MonoBehaviour {

		void Start () {
		}
		

		void Update () {
			this.transform.position += transform.up * GodTouches.PlayerMoveScript.playerYspeed * Time.deltaTime;
		}

}
