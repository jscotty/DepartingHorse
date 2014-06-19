using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovementAnimal : MonoBehaviour {
	/* Deze class is geschreven om de animal te laten bewegen.
	 Deze script is geschreven door justin*/

	public float offscreen;
	private float butterflySpeed = -0.11f;
	private float speed;
	//private Animator anim;

	void Start(){
		//anim = GetComponent<Animator> ();
		speed -= 0.00000008f;
	}

	public void Update(){
		

		if (DataClass.paused == true) {
			DataClass.movementSpeed -= 0;		
		}else{
			butterflySpeed += speed;
			transform.Translate (Vector2.right * butterflySpeed);
		}
		
	}
}
