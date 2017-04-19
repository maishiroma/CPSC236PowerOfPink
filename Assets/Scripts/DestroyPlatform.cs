using UnityEngine;
using System.Collections;

public class DestroyPlatform : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			GameOver go = GameObject.Find("Main Camera").gameObject.GetComponent<GameOver>();
			if(go != null){
				go.playerDead = true;
			}
		} 
		if(other.gameObject.transform.parent){
			Destroy(other.gameObject.transform.parent.gameObject);
		}
		else {
			Destroy(other.gameObject);
		}
	}
}
