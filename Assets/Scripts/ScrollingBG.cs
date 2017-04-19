using UnityEngine;
using System.Collections;

public class ScrollingBG : MonoBehaviour {

	public Vector2 speed;
	public int direction;
	public bool linkedToCamera = false;

	void Update () {
		GameObject player =  GameObject.Find("PinkieKirby");
		if(player != null){
			int temp = (int)player.transform.position.x;
			if(temp % 15 == 0 && temp > 0){
				Vector3 newP = new Vector3(player.transform.position.x - 6f,2.7f,10f);
				this.transform.position = newP;
			}
			
			Vector2 moddedSpeed = new Vector2(speed.x * direction, speed.y * direction);
			moddedSpeed *= Time.deltaTime;
			transform.Translate(moddedSpeed);
			if(linkedToCamera){
				Camera.main.transform.Translate(moddedSpeed);
			}
		}
	}
}
