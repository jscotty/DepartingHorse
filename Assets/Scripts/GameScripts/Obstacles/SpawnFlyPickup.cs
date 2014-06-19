using UnityEngine;
using System.Collections;

public class SpawnFlyPickup : MonoBehaviour {
	/*Spawning van de flypickup*/

	//scripted by Justin
	public GameObject flyPickup;
	
	void Start(){
	}
	
	void Update(){
		if(Respawn.spawnPickupFly == true){
			Instantiate (flyPickup, transform.position, transform.rotation);
			Respawn.spawnPickupFly = false;
		}else{
			
		}
	}
}
