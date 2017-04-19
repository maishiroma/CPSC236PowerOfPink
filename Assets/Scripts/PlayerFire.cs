using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {

	public Transform playerShot;
	public float attackRate = 2f;
	private float coolDown = 0f;

	void Update () {
		if(coolDown > 0f){
			coolDown -= Time.deltaTime;
		}
	}

	public void Fire(){
		if(coolDown <= 0f){
			coolDown = attackRate;
			var shotMade = Instantiate(playerShot) as Transform;
			shotMade.position = this.transform.position;
		}
	}
}
