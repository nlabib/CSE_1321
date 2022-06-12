/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 4A
*/

using System;

public class Assignment2A
{
	public static void Main(string[] args)
	{

		Console.Write("Enter the score of your exam: ");
		float grade = float.Parse(Console.ReadLine());
		
		int g = (int) Math.Round(grade, 0);

		if (g >= 98 && g <= 100)
		{
			Console.WriteLine("Letter g is: A+");
		}
		else if (g >= 95 && g <= 97)
		{
			Console.WriteLine("Letter g is: A");
		}
		else if (g >= 92 && g <= 94)
		{
			Console.WriteLine("Letter g is: A-");
		}
		else if (g >= 89 && g <= 91)
		{
			Console.WriteLine("Letter g is: B+");

		}
		else if (g >= 86 && g <= 88)
		{
			Console.WriteLine("Letter g is: B");

		}
		else if (g >= 83 && g <= 85)
		{
			Console.WriteLine("Letter g is: B-");

		}
		else if (g >= 80 && g <= 82)
		{
			Console.WriteLine("Letter g is: C+");

		}
		else if (g >= 77 && g <= 79)
		{
			Console.WriteLine("Letter g is: C");

		}
		else if (g >= 74 && g <= 76)
		{
			Console.WriteLine("Letter g is: C-");
		}
		else if (g >= 71 && g <= 73)
		{
			Console.WriteLine("Letter g is: D+");
		}
		else if (g >= 68 && g <= 70)
		{
			Console.WriteLine("Letter g is: D");
		}
		else if (g >= 65 && g <= 67)
		{
			Console.WriteLine("Letter g is: D-");
		}
		else 
		{
			Console.WriteLine("Letter g is: F");
		}

	}
}