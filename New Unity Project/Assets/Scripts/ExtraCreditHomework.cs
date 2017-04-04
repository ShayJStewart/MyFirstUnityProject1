using UnityEngine;
using System.Collections;

public class ExtraCreditHomework : MonoBehaviour {

	//float EC6 = 0;
	string[] names = {"Harry", "Hermione", "Tonks", "lilly", "Snape"};
	string[] colors = {"red", "blue", "yellow", "pink", "green"};

	// Use this for initialization
	void Start () {
		ExtraCreditOne ();
		ExtraCreditTwo ();
		ExtraCreditFive ();
		//ExtraCreditSix ();
	}
	void ExtraCreditOne()
	{
		float A = 8;
		float B = 3;
		float C = 10;
		float Result = (A * B * C);
		print (Result);
	}

	void ExtraCreditTwo()
	{
		print (names[1]+ "'s favorite color is " + colors[2]);
	}

	void ExtraCreditFive()
	{
		float A = 5;
		float B = 9;
		float Result1 = (A + B);
		print (Result1);
	}

	/*void ExtraCreditSix()
	{
		int i = 5;
		while (i <= 15) 
		{
			print (i * EC6);
			EC6++;
		}
		print ("yay for multiplying!");
	}*/


}
