using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour {

	public int Cookie = 1;
	public int Friends = 6;
	public string Name = "Megan";	
	public string IceCream = "Strawberry";
	public int Valentines = 2;

	void Start () 

	{
		/*In this switch I am seeing how many cookies the player has in his hands between 4-1 cookies. If none of those numbers are met, then it will print 
		 * the default statement below all of the cases. The breaks are used to stop the code so it can move on to the next block of code in the switch statement. 
		 * You have to put a colon after each case of a switch statement in order for it to run. These are a lot cleaner and nicer than if else statements when trying
		 * to compare something like a cookie and quantity.*/
		switch (Cookie) 
		{
		case 4:
			print ("You have 4 cookies, hooray!");
			break;
		case 3:
			print ("What are you doing with 3 cookies?");
			break;
		case 2:
			print ("Only 2 cookies left, are you kidding me?");
			break;
		case 1:
			print ("Why do you only have 1 cookie you crazy person??");
			break;
		default:
			print ("Well, guess you have way too many cookies or way too little, sorry bud.");
			break;
		}

		/*The Friends switch statement will check to see how many friends from 1-6 you have. when also creating a switch statement, you always put the variable
		 * you are comparing in the parentheses after the word switch*/
		switch (Friends)
		{
		case 6:
			print ("You are very popular!");
			break;
		case 5:
			print ("I wish I had 5 friends!");
			break;
		case 4:
			print ("you all must be really good buddies");
			break;
		case 3:
			print ("Have you known them your whole life?");
			break;
		case 2:
			print ("The quantity doesn't matter, as long as they are your friends.");
			break;
		case 1:
			print ("It's better to have 1 true friend then a bunch of back stabbers.");
			break;
		default:
			print ("You'll always have a friend in me!");
			break;
		}

		/* This switch statement checks to see if the string in name matchs the name of the case to see if they match then it spits out whatever compliment
		 * matches the name, but if no name matches, then it says that the name entered is a great person*/
		switch (Name)
		{
		case "Ariel":
			print ("Ariel is very fun and good at coding");
			break;
		case "Dave":
			print ("Dave is an amazing artist");
			break;
		case "Megan":
			print ("Megan is our amazing director for the animation project");
			break;
		case "Maddie":
			print ("Maddi is the Substance Queen");
			break;
		case "Caleb":
			print ("Our resident Music expert in Animation");
			break;
		default:
			print (Name + " " + "is a great person!");
			break;
		}

		/* I was hungry for ice cream when making this can you tell haha? THis switch determines which ice cream the player selected and then spits back an opinion
		 * on the ice cream they chose.*/

		switch (IceCream)
		{
		case "Vanilla":
			print (" Vanilla ice cream is a little boring by itself, but add some mix ins and it's great!");
			break;
		case "Chocolate":
			print ("Chocolate is pretty good, but better with choco chunks");
			break;
		case "Pistachio":
			print("Pistachio.......is green......and weird.");
			break;
		case "Butterscotch":
			print("Do they even have this flavor?");
			break;
		case "Strawberry":
			print (" Strawberry is yummy.");
			break;
		default:
			print ("I'm sorry if you don't like ice cream and can't pick a flavor.");
			break;
		}

		/*Since Valentines just happened, here is a switch and counts how many valentine cards the player has and tells them what it thinks of their number of cards*/

		switch (Valentines) 
		{
		case 0:
			print ("I'm sorry you got none, I still think you're great.");
			break;
		case 2:
			print ("That's a nice number of cards");
			break;
		case 5:
			print ("You have a lot of Valentines cards!");
			break;
		default:
			print ("You are loved!");
			break;

		}


	}

}
