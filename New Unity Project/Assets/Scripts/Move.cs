using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float horizontalSpeed = .2f;
	public float verticalSpeed = .2f;


	// Update is called once per frame
	void Update () {
		//code used to move the player left on the X axis using the left arrow
		if (Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.Translate (-horizontalSpeed, 0, 0);
		}
		//code for moving the player right in the X axis using right arrow
		if (Input.GetKey (KeyCode.RightArrow)) {
			gameObject.transform.Translate (horizontalSpeed, 0, 0);
		}
		// code for moving player up in the Y axis using the up arrow
		if (Input.GetKey (KeyCode.UpArrow)) {
			gameObject.transform.Translate (0, verticalSpeed, 0);
		}
		//code for moving player down in the Y axis using the down arrow
		if (Input.GetKey (KeyCode.DownArrow)) {
			gameObject.transform.Translate (0, -verticalSpeed, 0);
		}

}
}