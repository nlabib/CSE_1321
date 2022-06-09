/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment2B
*/ 


using System;

public class Assignment2A{
	public static void Main(string[] args) {



		Console.Write("[Pentagon Calculator]\n");
		Console.Write("Enter the length of the side: ");
		double l = Convert.ToDouble(Console.ReadLine());
		double a = (Math.Sqrt(5 * (5 + 2 * (Math.Sqrt(5)))) * l * l) / 4;;
		double p = 5 * (l); // Calculating Perimeter
		double area = Math.Round(a ,2);
	
		Console.WriteLine("Pentagon Perimeter = " + p);
		Console.WriteLine("Pentagon Area = " + area);



		// [Hexagon Calculator]
		Console.WriteLine("");
		Console.WriteLine("[Hexagon Calculator]");
		Console.Write("Enter the length of the side: ");
		double len = Convert.ToDouble(Console.ReadLine());

		double a1 = ((3 * Math.Sqrt(3)) / 2 ) * (len * len);

		double per = 6 * (len); // Calculating Perimeter
		double parea = Math.Round(a1 ,2);
	
		Console.WriteLine("Hexagon Perimeter = " + per);
		Console.WriteLine("Hexagon Area = " + parea);

		}
	}