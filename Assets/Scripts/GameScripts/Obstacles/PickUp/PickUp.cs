using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	/*Als de object met de tag player de pickup aanraakt destroyd het de pickup en geeft het de score
	 waarde van wat er in de inspector aangegeven is bij pickupScore*/

	//scripted by Alex
	public float pickupScore;

 	void OnTriggerEnter2D(Collider2D player)
	{
		if (player.transform.tag == "Player")
		{
			Destroy(gameObject);
			PickThePickUp();
		}
	}

	virtual protected void PickThePickUp()
	{
		DataClass.score += pickupScore;
	}
}
