using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ForEachLoop : MonoBehaviour {

	public List<string> superheroRoster;
	public List<string> favoriteSuperheroes;
	public List<string> noLikeSuperhero;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < superheroRoster.Count; i++) {
			
			switch(superheroRoster[i])
			{
			case "Spider-man":
				favoriteSuperheroes.Add (superheroRoster[i]);
				superheroRoster.Remove (superheroRoster [i]);
				break;

			case "Superman":
				noLikeSuperhero.Add (superheroRoster [i]);
				superheroRoster.Remove (superheroRoster [i]);
				break;
			}	

		}


		foreach (string superhero in superheroRoster) 
		{
			print (superhero);

			switch(superhero)
			{
			case "Spider-man":
				favoriteSuperheroes.Add (superhero);
				break;

			case "Superman":
				noLikeSuperhero.Add (superhero);
				break;
			}	
		}
	
		superheroRoster.Clear ();
}

}
