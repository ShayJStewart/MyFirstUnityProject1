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

	public void RemoveAnimal()
	{
		if (animal != "") 
		{
			if (zooRoster.Contains (animal) == true)
			{
				zooRoster.Remove (animal);
			}
		}
		/*if (animal == selected
		zooRoster.Remove(animal);*/
	}

	/*public void PrintAll()
	{
		print (" Your zoo list :" + zooRoster[(0, zooRoster.Length)]);
	}*/

	public void ClearAll()
	{
		zooRoster.Clear();
		print ("No animals to show");
	}

	public void PrintAll()
	{
		print ("Zoo Roster:");

		foreach (var animal in zooRoster)
		{
			print(animal);
		}
	}

}
