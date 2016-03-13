using UnityEngine;
using System.Collections;

public class CubeNoteBehaviour : MonoBehaviour {

	public int NoteToPlay;

	void onTriggerEnter (Collider other) {
		if (other.tag == "joint") {
			Debug.Log (this.NoteToPlay);
			// Sende la OSC
		}
	}
}
