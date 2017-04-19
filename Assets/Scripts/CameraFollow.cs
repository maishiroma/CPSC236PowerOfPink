using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform player;
	public int pacesAhead;

	void Update () {	//Follows the player by 6 pixels
		if(player != null){
			transform.position = new Vector3(player.position.x + pacesAhead, 0, -10);
		}
	}

}
