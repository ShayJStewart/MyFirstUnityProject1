using UnityEngine;
using System;
using System.Collections;

public class VoidFunction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CurrentTime ();
	}
	

	public void CurrentTime() 
	{
		string greeting;
		int hour = DateTime.Now.Hour;

		if (hour < 12)
			greeting = "Good morning";
		else if (hour < 17)
			greeting = "Good afternoon";
		else
			greeting = "Good evening";
		print(string.Format("{0}, the current time is {1}. ", greeting, DateTime.Now.ToLongTimeString()));
	}

	public void CurrentDate()
	{
		print (DateTime.Now.ToLongDateString());
	}
}
