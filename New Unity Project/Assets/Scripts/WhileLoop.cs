using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {
	
	private int Paladin = 0;
	private int Monkeys = 5;
	private int Num = 0;
	private bool Hot= true;
	private int Toys = 2;
	private int Girls = 10;
	private int Socks = 5;
	private int Followers = 15;
	private int Boys = 5;
	private int Players = 11;

	// Use this for initialization
	void Start () {
		
		/* This While loop is checking to see how many Paladins of Voltron there are. If there is less than 6 then it keeps running, but stops when the loop goes
		 * thru a 6th time since there are not 6 paladins of Voltron then it exits the loop and runs the next line of code which tells it to print a saying
		 * don't forget Coran and Allura*/

		while (Paladin < 6)
		{
			print(Paladin + " Paladins of Voltron");
			Paladin++;
		}
		print ("Don't Forget Coran and Allura!");

		/* This while loop is based off the monkeyes jumping on a bed song. It checks to see how many monkeys are jumping on the bed and keeps running until there is 
		 * less than 1 monkey jumping on the bed and it ends the loop and prints that no more monkeys are jumping on the bed*/

		while (Monkeys > 0)
		{
			print (Monkeys + " monkeys Jumping on the bed, one fell off and broke his head!");
			Monkeys-=1;
		}
		print ("No more monkeys jumping on the bed!");

		/* a while loop that adds 2 to the given number up until it's 22*/

		while (Num < 20)
		{
			print (Num);
			Num+=2;
		}

		/* Here I tried to challenge myself a little and do a bool. I had to break the while loop after the statements, so that isn't super affective,
		 * but I'm trying to do new things */

		while (Hot == true)
		{
			print ("My pants are on fire!");
			Hot= false;
		}
		print (" Oh....guess I'm dead now...");

		//while loop to see how many toys we have
		while (Toys < 12) 
		{
			print ("Did you get those toys from Santa?");
			Toys++;
		}
		print ("all gone");

		//While loop to see if we're cold
		while (Girls > Boys)
		{
			print ("More Girls than boys!");
			Boys++;
		}
		print ("Not anymore!");
	
		//using an int here I check to see how many socks they have 
		while (Socks > 4) 
		{
			print ("You have lots of socks!");
			Socks--;
		}
		print ("You need more socks!");

		//a while loop to check and print out how many followers you have up to 30
		while (Followers < 30)
		{
			print ("You're on your way to getting more followers!");
			Followers++;
		}
		print ("You have " + Followers + " + " + " On Facebook!");

		//practicing using bools more again. I still don't know if strings work the best with while loops, so I didn't try any this time
		while (Boys < Toys)
		{
			print ("Need more boys!");
			Boys++;
		}
		print ("No more boys!");

		//using an int an da while loop I check for if the team has more than 0 players.
		while (Players > 0) 
		{
			print ("you have " + Players + " on your team!");
			Players--;
		}
		print ("Oh no, you have no players on your team");

	
	}



}
