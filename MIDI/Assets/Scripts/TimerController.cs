using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerController : MonoBehaviour {

	public Text textToDisplay;
	private float millis;
	private float sec;
	private float min;
	HandButtonBehaviour Playtab = GameObject.Find ("Playtab").GetComponent<HandButtonBehaviour> ();

	// Use this for initialization
	void Start () {
		millis = 0;
		sec = 0;
		min = 0;
	}
	
	// Update is called once per frame
	void Update () {
		textToDisplay.text = min.ToString () + ":" + sec.ToString () + ":" + millis.ToString ();
		if (Playtab.ButtonPressed == true) {
			startTheClock ();
		}
	}

	void startTheClock() {
		millis = millis + Time.deltaTime;
	}
}
