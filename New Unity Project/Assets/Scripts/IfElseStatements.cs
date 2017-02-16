using UnityEngine;
using System.Collections;

public class IfElseStatements : MonoBehaviour {
	private string Teacher = "Clayton";
	private string Student = "Dave";
	private string StarWars = "A New Hope";
	private string StarTrek = "The Next Frontier";

	// Use this for initialization
	void Start () {
		/*The following If and else statements are checking to see if the student and teacher are the same. if they aren't the same, then it spits out the 
		 * teacher and student's name and the phrase ' teacher is student's scripting teacher, but with the names replaced with their names. If the teacher and student 
		 * are the same, then it spits out that the teacher has now become the student*/

		if (Teacher == Student) 
		{
			print ("The Teacher Has now become the student");
		} 
		else 
		{
			print (Teacher + " Is " + Student + "'s" + " Scripting teacher!");
		}

		/* This if statement was really just for fun. I'm checking to see if both the movie titles or fields entered in the variable are the same. I'm neither a trekkie
		 * or a star wars die hard fan so I don't care either way, but decided that I have some friends who are super into either and I wanted to do an else
		 * statement that would make them frustrated if they saw it haha*/

		if (StarWars == StarTrek)
		{
			print ("Star Wars and Star Trek are one and the same");
		} 
		else
		{
			print (StarTrek + " " +StarWars + " Are NOT the Same thing!");
		}


		/* With this if else statement I recreated the variable Teacher to a new string  and called the variable Teacher2 and had it check to see which teacher 
		 * is being called out, then it prints a statement about them in the console, but if there is none of the else if statements met, then it just 
		 * spits out the teacher's name with a default statement in the else part*/

		string Teacher2 = "Anthony";
			
			if (Teacher2 == "Anthony")
			{
				print ("Anthony LOVES HOT POCKETS!");
			}
			else if (Teacher2 == "Marty")
			{
				print ("Marty has a white beard like Santa sometimes.");
			}
			else if (Teacher2 == "Clayton")
			{
				print ("Clayton worked on Voltron!");
			}
			else
			{
				print (Teacher2 + " is amazing!");
			}
				
		/* The next If else statement is checking to see what year in school you are. When the code runs it will see if you are more than or less than 5 years
		 * of school. If you are less then 5, it will go on to the otehr else if statements until it's requirements are met or until it gets to the very bottom default 
		 * else statement*/

		int SchoolYear = 4;
		if (SchoolYear > 5) 
		{
			print ("You're a senior senior in school");
		} 
		else if (SchoolYear == 4) 
		{
			print ("You are a senior in school!");
		} 
		else if (SchoolYear == 3) 
		{
			print ("You are a junior!");
		} 
		else if (SchoolYear == 2) 
		{
			print ("You are a sophomore in school!");
		} 
		else 
		{
			print ("You just started school or you haven't started!");
		}

	
		/* This last example, so number 5 is an example of the else if function. In this one I have a pie with 4 sections and I amd checking to see how
		 * much of the pie has been eaten. with else if statements it lets you look for and run code if that requirement is met and if it is not met, 
		 * it will move on to the next statement and if none are met, it will go to the else statement at the end*/

		float Pie = 4.0f;
		if (Pie == 1.0f) 
		{
			print ("You ate a fourth of the pie!");
		} 
		else if (Pie == 2.0f)
		{
			print ("You ate half the pie!");
		} 
		else if (Pie == 4.0f) 
		{
			print ("You ate the whole pie, wow!");
		} 
		else 
		{
			print ("You ate no pie...bummer...");
		}



		/* I wanted to try practicing while loops since these are kinda hard for me to understand, but I'm finally understanding them. This while loop
		 * will start at  1 and get timesed by 3 until it stops when it reaches 27 */

		int RandomNumber = 1;
		while (RandomNumber < 27)
		{
			print (RandomNumber);
			RandomNumber*=3;
		}

		/* I got to admit, this is a lot of fun haha. Here I used a switch statement to check for the hair color of a random human. I check to see if their hair color
		 * is blonde like the default hair I put in*/

		string Hair = "Blonde";
		switch(Hair)
		{
			case "Brunette":
			print("Brunette");
			break;

			case "Pink":
			print("Pink");
			break;

			case "Blonde":
			print("Blonde");
			break;
		}

		/*so far I've struggled the most with for loops, but I'm starting to understand. You set certain ' hoops' the code has to jump through in order to run
		 * and it runs until all the requiremebts/ 'hoops' are met. In this case, it runs until the number is 4 away from 20. It also prints along the way what the
		 * numbers are as it works it's way to 20*/

		for (int x = 0; x < 20; x+=4)
		{
			print(x);
		}
	}

}
