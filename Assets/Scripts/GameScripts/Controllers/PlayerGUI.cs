using UnityEngine;
using System.Collections;

public class PlayerGUI : MonoBehaviour {
	/*Speler buttons en movement */

	//Scripted By Justin
	public static bool catching;
	public static bool jumping = false;
	public static bool pauseVisable = true;
	public GUIStyle style;
	private int catchCounter;
	public Texture2D jumpTexture;
	public Texture2D catchTexture;
	public Texture2D pauseTexture;
	public GameObject player;

	void OnGUI(){
		
		GUI.skin.button = style; 
		GUILayout.RepeatButton ("");
		
		if(pauseVisable == true){
			if (GUI.RepeatButton (new Rect (0, 110,Screen.width/2, Screen.height),jumpTexture)) {
				if(jumping == true){
					player.rigidbody2D.AddForce(Vector2.up * DataClass.jumpSpeed);

				}
			}
		}else{}
		
		if(pauseVisable == true){
			if (GUI.RepeatButton (new Rect (Screen.width/2, 110, Screen.width/2, Screen.height), catchTexture)) {
				catching = true;
			}else{
				catching = false;
			}
		}else{}
		
		// Pause button
		if (pauseVisable == true){
			if (GUI.Button (new Rect (Screen.width/1 -110, Screen.height /40 , 100, 50), pauseTexture)){
				DataClass.paused = true;
				pauseVisable = false;
			}
		}else{
			if (GUI.Button (new Rect (Screen.width/1 -110, Screen.height /40 , 100, 50), pauseTexture)){
				DataClass.paused = false;
				pauseVisable = true;
			}
		}
		
	}
}
