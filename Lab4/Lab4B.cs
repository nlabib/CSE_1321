/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 4A
*/

using System;

public class Lab4B
{
	public static void Main(string[] args)
	{


		Console.Write("Enter the day: ");
		string day = Convert.ToString(Console.ReadLine());

		string dayoftheweek = day.ToUpper();

		switch (dayoftheweek)
        {
			case "MONDAY":
				Console.WriteLine("I have class today!");
				break;
			case "TUESDAY":
				Console.WriteLine("I should use this time to do my homework.");
				break;
			case "WEDNESDAY":
				Console.WriteLine("I have class today!");
				break;
			case "THURSDAY":
				Console.WriteLine("I should use this time to do my homework.");
				break;
			case "FRIDAY":
				Console.WriteLine("It’s Friday! Friday! Gotta get down on Friday!");
				break;
			case "SATURDAY":
				Console.WriteLine("I should use this time to do my homework.");
				break;
			case "SUNDAY":
				Console.WriteLine("I should use this time to do my homework.");
				break;

		}

	}
}