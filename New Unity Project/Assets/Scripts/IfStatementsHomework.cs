using UnityEngine;
using System.Collections;

public class IfStatementsHomework : MonoBehaviour {
	private string superhero = "Spider-man";
	private bool snoring = true;
	private int MyAge = 20;
	private float MyFriendAge = 22f;
	private string LegendaryDefender = "Pidge";
	private int MyLuckyNumber = 7;


	// Use this for initialization
	void Start () {
		/* the next two statements check to see if the string is the same as the string it's being compared against. if it is, it tells the 
		 person to  pick a better superhero, and if it isn't the same, it tells them that their superhero is better than superman*/
		
		if (superhero == "superman")
		{
			print ("Pick again");
		}
		if (superhero != "superman") 
		{
			print (superhero + " is way better than superman! ");
		}

		/*the next two statements check to see if the bool 'snoring' is true and if it is, it plays the message to shut up and if it is not true
		it plays the message about peace and quiet.*/

		if (snoring == true) 
		{
			print ("shut up!");
		}
		if (snoring != true) 
		{
			print ("finally, some piece and quiet!");
		}

		/* the next set of statements are using an int and a float to figure out how many years are between my friend and I*/
		if (MyAge == MyFriendAge)
		{
			print ("Wow, we're the same age!");
		}
		if (MyAge < MyFriendAge) 
		{
			print ("You are " + ( MyFriendAge - MyAge ) + " years older than me! ");
		}
		if (MyAge > MyFriendAge) 
		{
			print ("I am " + ( MyAge - MyFriendAge ) + " years older than you! ");
		}

		/* The next set of if statements are to print statements about my favorite Netflix show Voltron Legendary Defender characters. The person inputs
		  a name of one of the paladins and it prints out an awesome saying about the character they chose*/

		if (LegendaryDefender == "Shiro") 
		{
			print ("Shiro is the best leader ever and better than Zarkon!");
		}

		if (LegendaryDefender == "Lance")
		{
			print ("Lance is a ladies' man!");
		}

		if (LegendaryDefender == "Keith") 
		{
			print ("Keith is a Galra, Gasp!");
		}

		if (LegendaryDefender == "Hunk") 
		{
			print ("Hunk is the best chef in the Galaxy!");
		}

		if (LegendaryDefender == "Pidge")
		{
			print ("Pidge is my favorite Voltron Legendary Defender Character and she is the smartest girl on the team!");
		}
		// If statements below are used to determine if the number put in is higher or lower than my favorite numbers
		if (MyLuckyNumber >= 8)
		{
			print ("hey, that's close to my favorite number!");
		}
		if (MyLuckyNumber <= 7) 
		{
			print ("That's pretty close to my Lucky number!");
		}

	}

	}

