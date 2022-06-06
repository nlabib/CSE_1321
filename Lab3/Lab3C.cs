/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment 3C
*/
using System;

class Program
{
    public static void Main(string[] args)
    {
    	float quarters = .25f;
    	float dime = .10f;
    	float nickels = .05f;
    	float pennies = .01f;


    	Console.Write("Enter the number of quarters: ");
    	float q = float.Parse(Console.ReadLine());
    	
    	Console.Write("Enter the number of quarters: ");
    	float d = float.Parse(Console.ReadLine());

    	Console.Write("Enter the number of quarters: ");
    	float n = float.Parse(Console.ReadLine());

    	Console.Write("Enter the number of quarters: ");
    	float p = float.Parse(Console.ReadLine());

    	quarters = quarters * q;
    	dime = dime * d;
    	nickels = nickels * n;
    	pennies = pennies * p;

    	Console.WriteLine("You entered " + q + " Quarters.");
    	Console.WriteLine("You entered " + d + " dime");
    	Console.WriteLine("You entered " + n + " nickels.");
    	Console.WriteLine("You entered " + p + " pennies.");

    	float total = quarters + dime + nickels + pennies;
    	//Console.WriteLine(total);

    	int dollar =  (int) Math.Floor((quarters + dime + nickels + pennies));

    	//Console.WriteLine(dollar);

    	float cent = (float) (total - dollar);

    	float cent1 = (float) Math.Round(cent , 2);
    	//Console.WriteLine(cent1);

    	Console.WriteLine("Your total is " + dollar + " dollars and "+ cent1 +  " .");



    	}
    }
