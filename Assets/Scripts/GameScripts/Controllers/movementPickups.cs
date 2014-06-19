using UnityEngine;
using System.Collections;

public class movementPickups : MonoBehaviour {
	/*Dit is de script van de movement van de pickups dit is vrijwel
	 het zelfde principe als de movement script van de platform*/

	//scripted by justin
	public float offscreen;

	void Update(){
		if (DataClass.paused == true) {
			DataClass.movementSpeedPickup += 0;		
		}else{
			transform.Translate (Vector2.right * DataClass.movementSpeedPickup);
		}
		
	}
}
