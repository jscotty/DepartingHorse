using UnityEngine;
using System.Collections;

public class MovementRock : MonoBehaviour {

	public float offscreen;
	private float speed = -0.002f;
	
	public void Update(){
		
		
		if (DataClass.paused == true) {
			speed -= 0;	
		}else{
			speed -= 0.0001f;
			transform.Translate (Vector2.right * speed);
		}

		if (transform.position.x <= offscreen)
		{
			Destroy(gameObject);
		}
		
	}
}
