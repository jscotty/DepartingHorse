using UnityEngine;
using System.Collections.Generic;

public class PlatformSpawn : MonoBehaviour {

	public float offscreen;
	
	void Update () 
	{
		
		while (transform.position.x < offscreen)
		{
			transform.position = new Vector2(30.95991f,-2.603266f);
		}
	}
}
