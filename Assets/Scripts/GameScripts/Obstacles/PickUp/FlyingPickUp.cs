using UnityEngine;
using System.Collections;

public class FlyingPickUp : MonoBehaviour {
	/*Flying Pickup*/
	//Scripted by Alex
	void OnTriggerEnter2D(Collider2D player)
	{
		if (player.transform.tag == "Player")
		{
			Application.LoadLevel("AlexGame");
		}
	}
}

