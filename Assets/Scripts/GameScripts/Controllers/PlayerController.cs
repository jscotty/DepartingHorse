using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	/*De player controller is voor de controllen van de player.
	 er is erg veel geprobeert met deze class*/

	// Scripted By Justin

	//public float jumpCounter;
	//private float jumpButtonCounter = 0;

	//public bool jumpOff = false;
	//public DataClass dataClass;
	
	void Start(){
		/*Justin heeft geprobeerd een jump methode te gebruiken met get axis
		 Dit ging niet erg goed maar wij zijn uit eindelijk over gegaan naar
		 addForce en dit werkte prima!*/

		/*Hier probeerde justin de texture size te veranderen*/
		//jumpTexture.Resize(Screen.width/2,Screen.height/3);
		//jumpTexture = new Texture2D (Screen.width/2,Screen.height/3);
		//jumpTexture.Apply();
		//		if (jumping == true) {
	//			jumpSpeed += 1;		
	//
	//		}else{
	//			jumpSpeed = -10;
	//		}
	
}

void Update(){
		if(this.transform.position.y <= -10.5) Application.LoadLevel("JustinMenu"); // als de speler valt gaat het terug naar het menu

		/*if (jumping == true) {
			jumpCounter += 1;		
		} else{
			jumpCounter -=1;
		}
		if (jumpCounter <= 0) {
			jumpCounter = 0;	
		}
		if (jumpCounter <= 10) jumping = false;

		if(jumping == false){
			jumpButtonCounter += 1f;
			jumpSpeed = 20;
		}
		if(jumping == true){
			jumpButtonCounter -= 1f;
			jumpSpeed = 0;
		}
		if (jumpButtonCounter >= 0) {
			jumpButtonCounter = 0;		
		}
		if (jumpButtonCounter >= 10) {
			jumpButtonCounter -= 1;		
		}*/

		//print ("jumping = " + jumping);
		//print ("jumpCounter = " + jumpCounter);
		// ^^ was bedoelt voor jump systeem maar dit is gefixt door addForce
	}

	void OnTriggerEnter2D(Collider2D ground){
		if(ground.gameObject.tag == "Platform")
		{
			PlayerGUI.jumping = true;
		} else{ 				//als jumping = true kan de speler springen
			PlayerGUI.jumping = false;		//zo niet zal de speler naar beneden gaan.
		}
		//print (jumping);
	}


}
