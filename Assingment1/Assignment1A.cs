/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment 1A
*/ 

using System;
	class Assignment1A{
		public static void Main(string[] args){
			Console.Write("Math Mad Libs");
			

			Console.WriteLine("x + (y / z) * w = ?");
			Console.Write("Enter the first term: ");
			double x = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine(x + " + (y / z) * w = ?");

			Console.Write("Enter the second term: ");
			double y = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(x + " + (" + y + " / z) * w = ?");

			Console.Write("Enter the third term: ");
			double z = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(x + " + (" +  y + " / " + z + ") * w = ?");

			Console.Write("Enter the fourth term: ");
			double w = Convert.ToDouble(Console.ReadLine());


			double sum = x + (y / z) * w;
			Console.WriteLine(x + " + (" + y + " / " + z + ") * " +  w + "= " + sum);
		}
	}
