using UnityEngine;
using System.Collections;

public class ParalaxController : MonoBehaviour {
	/*Deze class is voor de speed van de bomen op de achtergrond.*/

	//scripted By Justin
	public float paralScrollSpeed = 0.05f;
	private float scrollSave;
	public float speed = 0.0001f;

	void Update () {
		if (DataClass.paused == true) { // als de game op pause staat
			speed += 0f; // is de speed 0
			paralScrollSpeed = scrollSave;	// en de paralScrollSpeed is de scrollSave.
											// Dit is omdat anders de texture offset weer terug gaat naar 0
		}else{
			speed += 0.00000005f;
			paralScrollSpeed += speed;
			renderer.material.mainTextureOffset = new Vector2 (paralScrollSpeed, 1f); // Rondraaien van de texture
		}
		scrollSave = paralScrollSpeed; // deze waarde bewaart de scrollspeed
	}
}
