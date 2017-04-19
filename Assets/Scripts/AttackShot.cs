using UnityEngine;
using System.Collections;

public class AttackShot : MonoBehaviour {

	public Vector2 speed;
	public int damage = 1;

	void Start () {	//Destroys itself after 5 secs of not hitting anything
		Destroy(this.gameObject,3);
	}

	void FixedUpdate(){
		GetComponent<Rigidbody2D>().velocity = speed;
	}
}
