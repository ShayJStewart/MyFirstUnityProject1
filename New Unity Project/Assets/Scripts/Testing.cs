using UnityEngine;
using System.Collections;

public class Testing : MonoBehaviour {

	float A = 1;
	float B = 5;
	float C = 10;
	string[] names = {"Harry", "Hermione", "Tonks", "lilly", "Snape"};
	string[] colors ={"red", "blue", "yellow", "pink", "green"};

	// Use this for initialization
	void Start () {
	
		Test();
		Sentence();
	}

	void Test()
	{
		float result = (A * B * C);
		print (result);
	}

	void Sentence()
	{
		print (names[1]+ "'s favorite color is " + colors[0]);

	}

	void Numbers()
	{
		for (int i = 0; i < 10; i++) 
		{
			
		}
	}
}
