using UnityEngine;
using System.Collections;

public class ArrayMadLib : MonoBehaviour {

	string[] name1 = { "Luke", "Sally", "Barbara", "Poppy", "Paul" };
	string[] verb1 = { "running", "walking", "skipping", "jogging", "sitting" }; 
	string[] place = { " the park", "a house", " a tree", "a car", "a food place" };
	string[] weather = { "sunny", "cloudy", "windy", "snowy", "rainy" };
	int[] num1 = { 1, 5, 10, 25, 63 };
	int[] num2 = { 0, 4, 8, 9, 3 };
	string[] adj1 = { "amazing", "weird", "crazy", "cool", "legit" };
	string[] person = { "friends", "enemies", "stalkers", "bosses", "teachers" };
	string[] item1 = { "a pencil", "a notebook", "a knife", "a water bottle", "a rock" };
	string[] verb2 = { "laughing", "walking", "dancing", "whistling", "hopping" };

	// Use this for initialization
	void Start () 

	{
		//this block of code is trying to randomly generate the random string to insert into the mad lib
		//now commented out because it wasn't working and I reworked it into the print code
		/*return name1 [Random.Range (0, name1.Length)];
		return verb1 [Random.Range (0, verb1.Length)];
		return place [Random.Range (0, place.Length)];
		return weather[Random.Range (0, weather.Length)];
		return num1 [Random.Range (0, num1.Length)];
		return num2 [Random.Range (0, num2.Length)];
		return adj1 [Random.Range (0, adj1.Length)];
		return person [Random.Range (0, person.Length)];
		return item1 [Random.Range (0, item1.Length)];
		return verb2 [Random.Range (0, verb2.Length)];*/

		//this code block prints the story with the random elements generated inside of it. This was so cool because I thought I wouldn't be able to debug this and I did!!:D
		string sentence1 = "Once upon a time " + name1[Random.Range (0, name1.Length)] + " was bored and decided to go " + verb1[Random.Range (0, verb1.Length)] + " in " + place[Random.Range (0, place.Length)] + " . " + " It was a " + weather [Random.Range (0, weather.Length)] + " day and great for going on a trip with their " + num1 [Random.Range (0, num1.Length)] + " dogs.";
		string sentence2 = "Along the way, they met up with " + num2 [Random.Range (0, num2.Length)] + " of their " + adj1 [Random.Range (0, adj1.Length)] + " " + person [Random.Range (0, person.Length)] + "." + " The others were quite confused why they were with their dogs and pulled out " + item1 [Random.Range (0, item1.Length)] + " trying to decide.";
		string sentence3 = "Would they want to play with the item in their hands or help with the dogs?" + " eventually they decide to help walk the dogs and they went off towards the ice cream shop " + verb2 [Random.Range (0, verb2.Length)] + ".";

		print (sentence1 + "\n " + sentence2 + "\n");

		//for some reason every time I tried to print more than 2 lines, it wouldn't print the last line 
		print (sentence3);


	}

}
