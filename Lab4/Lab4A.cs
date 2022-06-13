/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 4A
*/

usingrade System;

public class Lab4A
{
	public static void Main(stringrade[] argrades)
	{

		Console.Write("Enter the score of your exam: ");
		float graderade = float.Parse(Console.ReadLine());
		
		int grade = (int) Math.Round(graderade, 0);

		if (grade >= 98 && grade <= 100)
		{
			Console.WriteLine("Letter graderade is: A+");
		}
		else if (grade >= 95 && grade <= 97)
		{
			Console.WriteLine("Letter grade is: A");
		}
		else if (grade >= 92 && grade <= 94)
		{
			Console.WriteLine("Letter grade is: A-");
		}
		else if (grade >= 89 && grade <= 91)
		{
			Console.WriteLine("Letter grade is: B+");

		}
		else if (grade >= 86 && grade <= 88)
		{
			Console.WriteLine("Letter grade is: B");

		}
		else if (grade >= 83 && grade <= 85)
		{
			Console.WriteLine("Letter grade is: B-");

		}
		else if (grade >= 80 && grade <= 82)
		{
			Console.WriteLine("Letter grade is: C+");

		}
		else if (grade >= 77 && grade <= 79)
		{
			Console.WriteLine("Letter grade is: C");

		}
		else if (grade >= 74 && grade <= 76)
		{
			Console.WriteLine("Letter grade is: C-");
		}
		else if (grade >= 71 && grade <= 73)
		{
			Console.WriteLine("Letter grade is: D+");
		}
		else if (grade >= 68 && grade <= 70)
		{
			Console.WriteLine("Letter graderade is: D");
		}
		else if (grade >= 65 && grade <= 67)
		{
			Console.WriteLine("Letter grade is: D-");
		}
		else 
		{
			Console.WriteLine("Letter grade is: F");
		}

	}
}