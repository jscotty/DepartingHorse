using UnityEngine;
using System.Collections;

public class PickupSpawn : MonoBehaviour {
	/*Spwanen van de pickups*/

	//Scripted by justin
	public GameObject[] pickUps;
	
	void Start(){
	}
	
	void Update(){
		if(Respawn.spawnPickup == true){
			int pickUpsIndex = Random.Range(0, pickUps.Length);
			Instantiate (pickUps[pickUpsIndex], transform.position, transform.rotation);
			Respawn.spawnPickup = false;
		}else{
			
		}
	}
}
