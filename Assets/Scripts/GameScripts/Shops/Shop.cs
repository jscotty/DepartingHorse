using UnityEngine;
using System.Collections;

public class Shop : MonoBehaviour {
 /*De shop is gemaakt door Justin dit hier zijn guiButtons gemaakt die
	 weergegeven worden als er op pause gedrukt is. als er op de button
	 geklikt word , worden de gegevens in de Dataclass aangepast*/

	void OnGUI () {
		if (PlayerGUI.pauseVisable == false) {
			GUI.Box(new Rect(Screen.width/18,50,Screen.width/1.12f,Screen.height/1),"Welcome to the shop!");

			if(GUI.Button(new Rect(150,150,200,150), "Run Upgrade cost 200")){
				if(DataClass.score >= 200){
					DataClass.speed +=  0.000004f;
					DataClass.scrollBackground += 0.00000005f;
					DataClass.scrollFront += 0.000001f;
					DataClass.score -= 200;
				}
			}
			if(GUI.Button(new Rect(150,450,200,150), "jump Upgrade cost 400")){
				if(DataClass.score >= 400){
					DataClass.score -= 400;
					DataClass.jumpSpeed += 5;
				}
			}else{}
	}
}
}