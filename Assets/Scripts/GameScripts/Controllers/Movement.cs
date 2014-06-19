using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	/*Dit is de movement van de platforms*/

	//scripted by Justin

	public float offscreen;

	public void StartTest(){
	}


	public void Update(){
		if (DataClass.paused == true) {
			DataClass.movementSpeed += 0;		
		}else{

	

		transform.Translate (Vector2.right * DataClass.movementSpeed);
		}

	}
}
