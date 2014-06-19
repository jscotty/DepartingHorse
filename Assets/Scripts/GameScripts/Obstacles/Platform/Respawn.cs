using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {
	/*Respawn van de platform en dieren en pickups*/

	//Scripted by Alex en Justin
	public float offscreen;
	public static bool spawn;
	public static bool spawnPickup;
	public static bool spawnPickupFly;
	private float timer;
	private float timerFly;
	private float spawnTimer;
	private float spawnTimerFly;
	void Start(){
		spawnTimer = Random.Range (1,10);	
		spawnTimerFly = Random.Range (30,60);
	}
	void Update () 
	{
		timer += Time.deltaTime;
		if (timer >= spawnTimer) {
		spawnPickup = true;
		timer = 0;
		spawnTimer = Random.Range(1,10);
	}
		timerFly += Time.deltaTime;
		if (timer >= spawnTimerFly) {
			spawnPickupFly = true;
			timerFly = 0;
			spawnTimerFly = Random.Range(30,60);
		}
		if (transform.position.x <= offscreen)
		{
			//Spawn();
			//transform.position = new Vector2(92.04021f,-4.765321f);
			spawn = true;
			Destroy(gameObject);
		}
	}
}