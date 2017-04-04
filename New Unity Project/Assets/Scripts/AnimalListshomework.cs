using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalListshomework : MonoBehaviour {

	public string animal;
	public List<string> zooRoster = new List<string>();
	
	// Update is called once per frame
	void Start () {
		zooRoster.Add("monkey");
		zooRoster.Add("elephant");
		zooRoster.Add("Zebra");
	}

	/*this function is used to check if there is an animal name in the field and if so, it will add the animal. When clicking on any button,
	make sure to click twice to get it to work*/

	public void AddAnimal()
	{
		if (animal != "") 
		{
			if (zooRoster.Contains (animal) != true) 
			{
				zooRoster.Add(animal);
			}
		}
	}

	/*This function does the oppostie of the above functiona dn tests to see if there is an animal name typed into the input field and deletes that
	 * animal from the list. works also if you type an already existing animal name*/
	public void RemoveAnimal()
	{
		if (animal != "") 
		{
			if (zooRoster.Contains (animal) == true)
			{
				zooRoster.Remove (animal);
			}
		}

		/* Just writing example from class in this comment section so I have for reference later.
		 * {
		 * if (zooRoster.Contains(animal))
		 * {
		 * zooRoster.Remove(animal);
		 * }
		 * }*/

	}

	/*clears all of the items of the list then prints that there are no animals*/
	public void ClearAll()
	{
		zooRoster.Clear();
		print ("No animals to show");
	}

	/*this prints all of the animals in the list*/
	public void PrintAll()
	{
		print ("Zoo Roster:");

		foreach (var animal in zooRoster)
		{
			print(animal);
		}
	}

}
