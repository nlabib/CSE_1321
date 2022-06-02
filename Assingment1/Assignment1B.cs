/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment 1B
*/ 
using System;
	public class Assignment1B
	{
		public static void Main(string[] arg)
		{
		//Input
		Console.WriteLine("\n[Tip Calculator]");

		Console.Write("Enter the total price of the meal: ");
		double mprice = Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter the local tax rate: ");
		double tax_rate = Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter the delivery fee: ");
		double dfee = Convert.ToDouble(Console.ReadLine());

		// Math

		double total_tax = mprice * tax_rate;
		double subtotal = mprice * dfee;
		double ten_tip = subtotal * .10;
		double t_tip = subtotal * .20;

		double totalten = (ten_tip + subtotal + total_tax);
		double twentytotal = (t_tip + subtotal + total_tax);


	
		// output
		Console.Write("\n");
		Console.WriteLine("A 10% tip would be " + ten_tip);
		Console.WriteLine("The total would be " + totalten);
		Console.Write("\n");
		Console.WriteLine("A 20% tip would be " + t_tip);
		Console.WriteLine("The total would be " + twentytotal);

	}
	}


