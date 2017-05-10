using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GodTouches
{
	public class PlayerMoveScript : MonoBehaviour
	{
		public GameObject player;
		float ScreenLeft;
		float ScreenRight;
		public static float playerYspeed = 2;	//縦に動く速さ（一定）
		public static float playerXspeed = 2;	//横に動く速さ（最大）
		float Xcontroller = 0;			//横の速さの調節用
		float dragspeed;

		void Start()
		{
	//画面端を取得
			Camera camera = GetComponent<Camera>();
			Vector3 minpos = camera.ViewportToWorldPoint(new Vector3(0,0,10));
			Vector3 maxpos = camera.ViewportToWorldPoint(new Vector3(1,1,10));
			ScreenLeft = minpos.x + 0.1f;	//画面外チェック
			ScreenRight = maxpos.x - 0.1f;
		}

		void Update()
		{
	//移動処理
			player.transform.position += transform.up * playerYspeed * Time.deltaTime;

			if (player.transform.position.x <= ScreenLeft && Xcontroller < 0) {
				Xcontroller += 1 * Time.deltaTime;
			} else if (player.transform.position.x >= ScreenRight && Xcontroller > 0) {
				Xcontroller -= 1 * Time.deltaTime;
			} else {
				player.transform.position += transform.right * Xcontroller * playerXspeed * Time.deltaTime;
			} 

	//回転処理
			player.transform.rotation = Quaternion.Euler(0,0,Xcontroller * -80);


			var phase = GodTouch.GetPhase ();
	//タッチ開始
			if (phase == GodPhase.Began) 
			{
				
			}
	//タッチ中
			else if (phase == GodPhase.Moved) 	
			{
		//ドラッグの移動量でXcontrollerを変化（-1から1の中で）
				dragspeed = GodTouch.GetDeltaPosition().x / Screen.width/1.5f;
				if (Xcontroller >= 1) {
					Xcontroller -= 3 * Time.deltaTime;
				} else if (Xcontroller <= -1) {
					Xcontroller += 3 * Time.deltaTime;
				} else {
					Xcontroller += dragspeed;
				}
			}
	//タッチ終了
			else if (phase == GodPhase.Ended) 	
			{
				
			}
		}
	}
}