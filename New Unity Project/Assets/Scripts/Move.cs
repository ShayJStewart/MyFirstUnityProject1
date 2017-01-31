using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.Translate (-.5f, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			gameObject.transform.Translate (.5f, 0, 0);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			gameObject.transform.Translate (0, .5f, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			gameObject.transform.Translate (0, -.5f, 0);
		}
	}

}
