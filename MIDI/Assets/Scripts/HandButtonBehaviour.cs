using UnityEngine;
using System.Collections;

public class HandButtonBehaviour : MonoBehaviour {

	//public Transform Pivot;
	public GameObject Button;
	private bool ButtonPressed;
	public Transform Pressedpos;
	public Transform Homepos;
	//private bool ButtoninTransit;
	//public int RotationSpeed;
	//public int RotationDetent1;
	//public int RotationDetent2;

	void Start () {
		//rigidbody = GetComponent<Rigidbody> ();
		ButtonPressed = false;
	}
	
	//void Update () {
		/*if(ButtoninTransit == true)
		{
			//Debug.Log("Booled");
			SmoothRotate();
		}
		if (Button.GetComponent<Rigidbody>().rotation.x > RotationDetent1 && RotationSpeed > 0) 
		{
			Debug.Log ("STOP");
			ButtoninTransit = false;
		}
		if (Button.GetComponent<Rigidbody>().rotation.x < RotationDetent2 && RotationSpeed < 0) 
		{
			Debug.Log ("STOP");
			ButtoninTransit = false;
		}*/
	//}

	void FixedUpdate () {
		if (Input.GetButton ("Fire1") ) {
			GetComponent<Rigidbody> ().MovePosition (Pressedpos.position);
			//ButtonPressed = true;
			/*Debug.Log ("Pressed");
			RotationSpeed = -RotationSpeed;
			ButtoninTransit = true;*/
		} else {
			GetComponent<Rigidbody> ().MovePosition (Homepos.position);
			//ButtonPressed = false;
		}
	}

	/*void SmoothRotate () {
		Button.transform.RotateAround (Pivot.position, Pivot.right, RotationSpeed * Time.deltaTime);
	}*/
}
