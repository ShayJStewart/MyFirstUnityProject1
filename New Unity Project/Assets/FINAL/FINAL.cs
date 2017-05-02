using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public class FINAL : MonoBehaviour {

	public List<int> Items = new List<int>();

	// Use this for initialization
	void Start () {
	
		Hello ();
		Question2 (10, 4);
		Average ();
		Measurements (24, false);
		Trains (25, 50, 3);
	}
	
	void Hello()
	{
		print ("Hello, my name is Shayla" + "The Day and time is " + DateTime.Now);
	}

	void Question2(float X, float Y)
	{
		float Add = X + Y;
		float Subtract = X - Y;
		float Multiply = X * Y;
		float Divide = X / Y;

		print (Add);
		print (Subtract);
		print (Multiply);
		print (Divide);
	}

	void Average()
	{
		int Listsize;
		int Sum = 0;
		Items.Add (0);
		Items.Add (5);
		Items.Add (10);
		Items.Add (6);
		Items.Add (9);
		Listsize = Items.Count;
		foreach (int element in Items) 
		{
			Sum += element;

		}
		int Averages = Sum / Listsize;
		print ("The average is: " + Averages);
	}

	void Measurements(int X, bool Y)
	{
		switch(Y)
		{

		case true:
			print (X * 12 + " inches ");
			break;
		case false:
			print (X / 12 + " feet ");
			break;

		}

	}

	void Trains(int X, int Y, int Z)
	{
		int answer1 = X * Z;
		int answer2 = Y * Z;
		int answer = answer1 + answer2;

		print (" A train Leaves City A and drives west at " + X + "MPH." + "Another train leaves City A and drives east at " + Y +
		"MPH." + " How many miles apart are the trains after " + Z + "hours?");
		
		print ("They would be " + answer + " Miles apart.");
	}
}
