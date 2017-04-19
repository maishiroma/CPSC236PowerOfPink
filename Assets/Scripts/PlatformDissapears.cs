using UnityEngine;
using System.Collections;

public class PlatformDissapears : MonoBehaviour {
	
	void Start () {
		Invoke("DissapearIfPlayerIsStuck",10);
	}
	
	void DissapearIfPlayerIsStuck(){
		Destroy (this.gameObject);
	}
}
