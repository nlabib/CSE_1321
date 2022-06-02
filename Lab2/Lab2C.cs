/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 2C
*/ 
using System;

public class Lab2C{
	public static void Main(string[] args) {
		


		Console.Write("Enter a width: ");
		int width = Convert.ToInt32(Console.ReadLine());

		
		Console.Write("Enter a height: ");
		int height = Convert.ToInt32(Console.ReadLine());

		int p = 2*(width+height);
		int a = (height*width);

		Console.WriteLine("The area is " + a);
		Console.WriteLine("The perimeter is " + p);




	}
}