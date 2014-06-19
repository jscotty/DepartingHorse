using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	/*Main Menu*/

	//Scripted By Justin
	//private string title = "SHOP!";
	public GUIStyle style;
	public Texture2D startButton;

	void Start(){

	}
	void OnGUI(){
		GUI.skin.button = style;
		GUILayout.Button ("");



		if (GUI.Button (new Rect (Screen.width /2 -50, Screen.height /1.35f, 150, 100), startButton)) {
			Application.LoadLevel ("JustinGame");	
		}
		/*if (GUI.Button (new Rect (Screen.width /2 -50, Screen.height /2, 150, 100), "Shop")){
			Application.LoadLevel ("Shop");	
		}*/

		//title = GUI.TextArea(new Rect(Screen.width / 2, 10, 60, 600), title, 25);

	}

}
