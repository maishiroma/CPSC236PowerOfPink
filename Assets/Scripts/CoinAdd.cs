using UnityEngine;
using System.Collections;

public class CoinAdd : MonoBehaviour {

	public int amountToAdd;

	void OnTriggerEnter2D(Collider2D other){
		Score s = GameObject.Find("HUD").GetComponent<Score>();
		if(s != null && other.tag == "Player"){
			s.IncreaseScore(amountToAdd);
			Destroy (this.gameObject);
		}
	}
}
