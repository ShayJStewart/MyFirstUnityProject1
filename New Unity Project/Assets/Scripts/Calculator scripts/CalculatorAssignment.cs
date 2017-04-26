using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CalculatorAssignment : MonoBehaviour {


	public InputField UserInput1;
	public InputField UserInput2;
	public int minVal = 0;
	public int maxVal = 50;
	public float Result;
	public Text display;
	//private float fallSpeed = 2.5f;
	public Button Addbutton;
	public Button Subtractbutton;
	public Button Multiplybutton;
	public Button Dividebutton;
	public Text Answers;
	public Text GameOverText;

	public List<Text> RandomNumbersList = new List<Text>();


	void Start ()
	{
		RandomNumbers ();
		Add ();
		Subtract ();
		Multiply ();
		Divide ();
		DisableAdd ();
		DisableSubtract ();
		DisableMultiply ();
		DisableDivide ();
	}

	//adds the input fields together
	public void Add()
	{
		Result = float.Parse (UserInput1.text) + float.Parse (UserInput2.text);
		Answers.text = Result.ToString ();
		AnswerEqual ();
	}

	//subtract the input fields together
	public void Subtract()
	{
		Result = float.Parse (UserInput1.text) - float.Parse (UserInput2.text);
		Answers.text = Result.ToString ();
		AnswerEqual ();
	}

	//multiply the input fields together
	public void Multiply()
	{
		Result = float.Parse (UserInput1.text) * float.Parse (UserInput2.text);
		Answers.text = Result.ToString ();
		AnswerEqual ();
	}

	//divide the input fields together
	public void Divide()
	{
		Result = float.Parse (UserInput1.text) / float.Parse (UserInput2.text);
		Answers.text = Result.ToString ();
		AnswerEqual ();
	}

	//randomizes the numbers in the list
	public void RandomNumbers()
	{
		foreach (Text element in RandomNumbersList) 
		{
			int randomNum = Random.Range (minVal, maxVal);
			element.text = randomNum.ToString();
		}
	}

	//Disables the add button after it's clicked
	public void DisableAdd()
	{
		Addbutton.interactable = false;
	}

	//Disables the Subtract button after it's clicked
	public void DisableSubtract()
	{
		Subtractbutton.interactable = false;
	}

	//Disables the Multiply button after it's clicked
	public void DisableMultiply()
	{
		Multiplybutton.interactable = false;
	}

	//Disables the Divide button after it's clicked
	public void DisableDivide()
	{
		Dividebutton.interactable = false;
	}


	public void AnswerEqual()
	{
		foreach (Text element in RandomNumbersList)
		{
			if (Answers.text == element.text) 
			{
				Destroy (element);
			} 
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);
		GameOver ();
	}

	private void GameOver()
	{
		GameOverText.enabled = true;
	}




	// Update is called once per frame
	void Update () {
		//transform.Translate (Vector3.down * fallSpeed * Time.deltaTime, Space.World);

		//reenables all the buttons after it checks to see if all of them have been clicked
		if (Addbutton.interactable == false && Subtractbutton.interactable == false && Multiplybutton.interactable == false && Dividebutton.interactable == false) 
		{
			Addbutton.interactable = true;
			Subtractbutton.interactable = true;
			Multiplybutton.interactable = true;
			Dividebutton.interactable = true;
		}

	}
}
