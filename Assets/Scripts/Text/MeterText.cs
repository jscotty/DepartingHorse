using UnityEngine;
using System.Collections;

public class MeterText : MonoBehaviour {
	
	public GUIText meterText;

	void Awake(){
		DataClass.meters = 0;
		meterText = GameObject.FindGameObjectWithTag ("MeterText").GetComponent<GUIText> ();
		meterText.text = "Meters : " + DataClass.meters;
	}
	
	void Update () {
		meterText.text = "Meters :" + DataClass.meters;
	}
}
