using UnityEngine;
using System.Collections;

public class SpawnGround : MonoBehaviour {

	public GameObject objToSpawn;
	public int minTimeSpawn;
	public int maxTimeSpawn;
	public bool bottomFloor = false;	//Only for ground that will conatantly be spawning. 
	private bool alreadyNoSpawn = false;	//controls if a ground already didn't spawn

	void Start () {
		SpawnObjects();
	}

	void SpawnObjects(){
		if(GameObject.Find("PinkieKirby") != null){
			if(bottomFloor == true){
				if(Random.Range(0,10) > 5 || alreadyNoSpawn == true){	//If false, no ground will spawn for 2 sec
					Vector3 spawnGroundP = new Vector3(transform.position.x,transform.position.y,5);
					Instantiate(objToSpawn,spawnGroundP,Quaternion.identity);
					Invoke("SpawnObjects",Random.Range(minTimeSpawn,maxTimeSpawn));
					alreadyNoSpawn = false;
				}
				else{
					Invoke("SpawnObjects",2);
					alreadyNoSpawn = true;
				}
			}
			else{
				Vector3 spawnGroundP = new Vector3(transform.position.x,transform.position.y,5);
				Instantiate(objToSpawn,spawnGroundP,Quaternion.identity);
				Invoke("SpawnObjects",Random.Range(minTimeSpawn,maxTimeSpawn));
			}
		}
	}

}
