using UnityEngine;
using System.Collections;

public class SpawnPlatform : MonoBehaviour {
	/*Spawnen van platform Scripted by Justin*/
	public GameObject[] platform;


	void Update(){
		if(Respawn.spawn == true){
			int platformIndex = Random.Range(0, platform.Length);
			Instantiate (platform[platformIndex], transform.position, transform.rotation);
			Respawn.spawn = false;
		}else{

		}
	}
}
