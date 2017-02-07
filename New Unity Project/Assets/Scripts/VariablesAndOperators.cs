using UnityEngine;
using System.Collections;

public class VariablesAndOperators : MonoBehaviour {
	private float pi = 3.1415f;
	private float radius = 2.5f;
	private float width = 4f;
	private float length = 9f;
	private float height = 5f;
	private float Base = 7f;

	// Use this for initialization
	void Start () {
		//find the diameter of a circle
		float diameter = 2 * radius;
		print ("The diameter of the circle with radius " + radius + " is " + diameter);

		//find the circumfrance of a circle
		float circumfrance = pi * diameter;
		print ("The circumfrance of the circle with diameter " + diameter + " is " + circumfrance);

		//find the area of a circle
		float area = pi * radius * radius;
		print ("The area of the circle with raidus " + radius + " is " + area);

		/* find the volume of a sphere. The cool thing I learned here was that when calling a float
		and then you divide two numbers by themselves, you have to put an f after it so it reads it correctly */
		float volume = 4f/3f * pi * radius * radius * radius;
		print ("The volume of the sphere with radius " + radius + " is " + volume);

		//find the perimeter of a rectangle
		float perimeter = 2 * (length + width);
		print ("The perimeter of the rectangle with length " + length + " and width " + width + " is " + perimeter);

		//find the volume of a rectangle
		float areaR = width * length;
		print ("The area of the rectangle with width " + width + " and length " + length + " is " + areaR);

		//find the area of a triangle
		float areaT = height * Base / 2;
		print ("The area of the triangle with height " + height + " and base " + Base + " is " + areaT);
	}
	/* it's so cool being able to understand and problem solve with this stuff this semester! I'm understanding
	things a lot more and it's a great feeling! Thank you so much for being my teacher! */
}
