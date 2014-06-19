using UnityEngine;
using System.Collections;

public class ParalaxBackground : MonoBehaviour {

	public float paralScrollSpeed;
	private float scrollSave;
	private float speed;
	
	void Update () {
		if (DataClass.paused == true) {
			speed += 0f;
			paralScrollSpeed = scrollSave;
		}else{
			paralScrollSpeed += speed;
			speed += 0.0000001f;
			renderer.material.mainTextureOffset = new Vector2 (paralScrollSpeed, 1f);
		}
		scrollSave = paralScrollSpeed;
	}
}
