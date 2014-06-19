using System;
using UnityEngine;
using System.Collections;

public class DataClass : MonoBehaviour {

	/*Deze data class is een class waarin wij alle nodige informaties
	opslaan. Alex en Justin hebben hiervoor gekozen zodat wij er vanuit elke
	class bij kunnen komen en wij deze class niet laten destroyen.
	Deze class is alleen voor het opslaan van scores/meters/speeds en pause */ 

	// Scripted by Justin.
	public static bool paused = false;
	public static float score;
	public static float meters;
	public static float speed;
	public static float scrollBackground;
	public static float scrollFront;
	public static float movementSpeed;
	public static float movementSpeedPickup;
	public static float jumpSpeed;

	public float scoreCounter;

	void Awake(){
		DontDestroyOnLoad (gameObject); // Dit object zal niet destroyd worden bij het laden van een nieuwe scene
	}

	void Start(){
		// in de start heeft justin alle floats weer hun begin waarde gegeven
		// omdat het spel anders door gaat met de zelfde snelheid.
		speed = 0.0000008f;
		scrollFront = 0.003f;
		scrollBackground = 0.0000001f;
		movementSpeed = 0.15f;
		movementSpeedPickup = 0.17f;
		jumpSpeed = 28f;
		paused = false;
	}

	void Update(){
		movementSpeed += speed;
		movementSpeedPickup += speed;

		if(paused == true){ // als het spel op pause staat update het niets

		}else{ // Geen pause dus de game speelt verder
		movementSpeed += speed; //movementSpeed += speed is voor de snelheid van de platformen 

		scoreCounter += 1; // counter teller

			if(scoreCounter >= 60f){
				scoreCounter = 0f; // counter voor de score anders gaat deze te snel
				score += 1; //score
			}else if(scoreCounter == 30){
				meters += 1; // eerder meters als score
			}
		}
	}
}
