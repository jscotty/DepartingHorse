using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnAnimal : MonoBehaviour {
	/*Hier word de animal tusen 2/15 seconden iedere keer gespawned*/
	//Scripted by Alex , Array toegevoegt voor Justin
	public Transform animal;
	public float spawnTimer;
	public GameObject[] animalList;
	private float timer = 0;

	void Start(){
		spawnTimer = Random.Range(2, 15); // waarde tussen 2 en 15
	}
	
	void Update () {
		if(DataClass.paused == false){
		timer += Time.deltaTime; // tijd teller
		if (timer >= spawnTimer) {
			spawnTimer = Random.Range(2, 15); // pakt weer een random waarde tussen 2 en 15
			SpawnTheAnimal();
			timer = 0;
		}
		}else{}
	}

	void SpawnTheAnimal(){

		int animalIndex = Random.Range(0, animalList.Length); // kiest een random element van de array
		Instantiate (animalList[animalIndex], transform.position, this.transform.rotation); //addchild de animal
	}
}
