using UnityEngine;
using System.Collections;

public class ObjectScript : MonoBehaviour {
	virtual protected void OnCollisionEnter2D(Collision2D player)
	{
		if (player.transform.tag == "Player")
		{
			Destroy(player.gameObject);
		}
	}
}
