using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour {

	void OnGUI(){
		GUIStyle style = new GUIStyle();
		GUIStyle style2 = new GUIStyle();
		style.fontSize = 30;
		style.normal.textColor = Color.magenta;
		style2.fontSize = 15;
		style2.normal.textColor = Color.magenta;


		GUI.Label(new Rect(Screen.width/2-100,Screen.height/2-195,100,200),"The Power of Pink",style);
		GUI.Label(new Rect(Screen.width/2-40,Screen.height/2+80,200,100),"How to Play",style2);
		GUI.Label(new Rect(Screen.width/2-80,Screen.height/2+110,200,100),"Space: Jump/Double Jump",style2);
		GUI.Label(new Rect(Screen.width/2-80,Screen.height/2+140,200,100),"Left Shift: Shoot Star",style2);

		if(GUI.Button (new Rect (Screen.width/2-300, Screen.height/2+100, 100, 50), "Level 1")){
			Application.LoadLevel("MainLevelTwo");
		}
		if(GUI.Button (new Rect (Screen.width/2+200, Screen.height/2+100, 100, 50), "Level 2")){
			Application.LoadLevel("MainLevel");
		}
		//if (GUI.Button (new Rect (Screen.width/2, Screen.height/2, 100, 50), "Start Game")) {

		//}
	}

}
