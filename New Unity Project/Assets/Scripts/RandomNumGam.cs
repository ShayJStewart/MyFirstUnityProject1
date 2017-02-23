using UnityEngine;
using System.Collections;

public class RandomNumGam : MonoBehaviour {

	private bool gameOn = true;

	public int minVal = 0;
	public int maxVal = 100;
	public int pickNum =  25;
	private int counter = 0;
	// Use this for initialization

	//I took a look at my code which was breaking and I used the reference code from class to fix mine
	void Start () {
		while (gameOn == true) 
		{
			int randomNum = Random.Range(minVal, maxVal);

			if (randomNum == pickNum) 
			{
				print ("on try " + counter + "You guessed " + randomNum + " You're number is correct! the number chosen was " + pickNum );
				gameOn = false;
			} 
			else if (randomNum < pickNum) 
			{
				print ("on try " + counter + "You guessed " + randomNum + " You're number is too low, try higher!");
				minVal = randomNum;
			} 
			else 
			{
				print ("on try " + counter + "You guessed " + randomNum + " You're number is too high, try lower!");
				maxVal = randomNum;
			}

		}
		print ("You win, game is over!");

		//this is just a part of my bad script I commented out that wasn't working right
		/*if (randomNum == pickNum)
		{
			print ("you win!");
			gameOn = false;
			print ("GameOver!");
		}*/


		//reference scripting from class
		/*
public class RandomNumGam : MonoBehaviour {

	private bool gameOn = true;

	public int minRange = 0;
	public int maxRange = 100;
	public int target = 42;
	private int counter = 0;

	// Use this for initialization
	void Start () {
		int counter = 0;

		while (true) 
		{
			int guess = Random.Range (minRange, maxRange);
			counter++;

			if (guess == target) {
				print ("attempt " + counter + " : you guessed the correct number, " + target + " . ");
				break;
			} 
			else if (guess < target)
			{
				print ("attempt " + counter + " :  " + guess + " is too low.");
				minRange = guess;
			} 
			else 
			{
				print ("attempt " + counter + " :  " + guess + " is too high.");
				maxRange = guess;
			}
		}
		print ("You win!");

	}*/


	}
}
