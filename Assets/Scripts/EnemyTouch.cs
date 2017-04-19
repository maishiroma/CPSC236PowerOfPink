using UnityEngine;
using System.Collections;

public class EnemyTouch : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D player){
		CharacterHealth playerH = player.gameObject.GetComponent<CharacterHealth>();
		if(playerH != null){
			playerH.Damage(1);
		}
	}
}
