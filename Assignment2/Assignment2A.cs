/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment2A
*/ 


using System;

public class Assignment2A{
	public static void Main(string[] args) {
	
		Console.Write("Enter a number you want to find a multiple of: ");
		int n = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter a second number: ");
		int n2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Calculating...");

		int m = n2 % n;
		int final = n2 - m;

		Console.Write("The nearest multiple of " + n + " from" + n2 + " is" + final + "!");


	}
}