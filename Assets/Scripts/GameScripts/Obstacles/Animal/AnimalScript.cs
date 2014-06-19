using UnityEngine;
using System.Collections;

public class AnimalScript : MonoBehaviour {
	/*Script voor het dier*/

	//Scripted By Alex
	void Update(){
		if (transform.position.x <= -43) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D player)
	{
		if (player.transform.tag == "Player")
		{
			if(PlayerGUI.catching == false){
				Application.LoadLevel("JustinMenu");

		}else if (PlayerGUI.catching == true) {
			Destroy(gameObject);	
			DataClass.score += 10;
		}
		}
	}
}