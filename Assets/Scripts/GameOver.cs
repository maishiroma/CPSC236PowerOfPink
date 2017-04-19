using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public bool playerDead = false;


	void OnGUI()
	{
		if(playerDead == true){
			AudioSource soundMain = GameObject.Find("Main Camera").gameObject.GetComponent<AudioSource>();
			if(soundMain != null){
				soundMain.Pause();
			}
			GUIStyle style = new GUIStyle();
			style.fontSize = 30;
			style.normal.textColor = Color.red;
			GUI.Label(new Rect(Screen.width/2-100,Screen.height/2-195,100,200),"GAME OVER",style);

			if (GUI.Button(new Rect(Screen.width/2,Screen.height/2, 80, 50),"Try Again"))
			{
				Application.LoadLevel(Application.loadedLevelName);
			}
			
			if (GUI.Button(new Rect(Screen.width/2-10, Screen.height/2+50, 100, 50),"Back to menu"))
			{
				Application.LoadLevel("Menu");
			}
		}
	}
}
