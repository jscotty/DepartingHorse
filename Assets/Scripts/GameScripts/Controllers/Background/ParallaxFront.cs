using UnityEngine;
using System.Collections;

public class ParallaxFront : MonoBehaviour {

		public float paralScrollSpeed;
		private float scrollSave;
		private float speed;
		
		void Update () {
		if (DataClass.paused == true) {
			paralScrollSpeed = scrollSave;
		}else{
			DataClass.scrollFront += 0.000000001f;
			paralScrollSpeed += DataClass.scrollFront;
			renderer.material.mainTextureOffset = new Vector2 (paralScrollSpeed, 1f);
		}
			scrollSave = paralScrollSpeed;
		}
	}
