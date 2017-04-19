using UnityEngine;
using System.Collections;

public class CharacterHealth : MonoBehaviour {

	public int maxHP;
	public bool isEnemy = false;

	void Update () {
		if(isEnemy == false){
			if(maxHP <= 0){
				//Call the game over screen.
				Destroy(this.gameObject);
				GameOver go = GameObject.Find("Main Camera").gameObject.GetComponent<GameOver>();
				if(go != null){
					go.playerDead = true;
				}
			}
		}
		else{
			if(maxHP <= 0){
				Destroy (this.gameObject);
				Score s = GameObject.Find("HUD").gameObject.GetComponent<Score>();
				s.IncreaseScore(1);
			}
		}
	}

	public void Damage(int damage){
		maxHP -= damage;
	}

	void OnTriggerEnter2D(Collider2D other){
		AttackShot shot = other.gameObject.GetComponent<AttackShot>();
		if(shot != null && isEnemy == true){
			Damage(shot.damage);
			Destroy(shot.gameObject);
		}
	}
}
