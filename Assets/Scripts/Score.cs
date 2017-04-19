using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public float score = 0f;

	void Update () {
		if(GameObject.Find("PinkieKirby") != null){
			score += Time.deltaTime;
			if((int)(score *100) % 3000 == 0){
				GameObject.Find("PinkieKirby").GetComponent<RunningScript>().maxSpeed += 1f;
			}
		}
	}

	public void IncreaseScore(int amount){
		score += amount;
	}

	void OnGUI(){
		GUIStyle style = new GUIStyle();
		style.fontSize = 20;
		style.normal.textColor = Color.magenta;
		GUI.Label(new Rect(10,10,100,30), "Score: " + (int)(score * 100),style);
	}
}
