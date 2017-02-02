using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	public float speed;

	// Use this for initialization
	void Start () {
		//code used for giving each object a random rotation
		speed= Random.Range (.5f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		//code used to determine the speed at which the object rotates
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime * speed);
	}
}
