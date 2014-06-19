using UnityEngine;
using System.Collections;

public class ScoreText : MonoBehaviour {

	public GUIText scoreText;

	void Awake(){
		scoreText = GameObject.FindGameObjectWithTag ("ScoreText").GetComponent<GUIText> ();
		scoreText.text = "Score: " + DataClass.score;
	}

	void Update () {
		scoreText.text = "Score :" + DataClass.score;
	}
}
