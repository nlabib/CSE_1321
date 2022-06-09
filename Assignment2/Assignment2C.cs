/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment2C
*/


using System;

public class Assignment2A
{
	public static void Main(string[] args)
	{

		const float candy = 0.0000848327f;
		const float refrigerator = 0.00105745f;


		Console.Write("Enter a number of miles: ");
		float miles = float.Parse(Console.ReadLine());

        int refcalc = (int) ((int) miles / refrigerator);
		int candycalc = (int) ((int) miles / candy);

		Console.WriteLine("");
		Console.WriteLine("You: I walked " + miles + " miles today #fitnessgoals");
		Console.WriteLine("Useless Conversion Bot: Wow, " + miles + " miles is " + refcalc + " refrigerators \nlong!");
		Console.WriteLine("Useless Conversion Bot: " + miles + " miles is " + candycalc + " candy bars \nlong!");
		Console.WriteLine("Useless Conversion Bot: That's a lot.");


	}
}