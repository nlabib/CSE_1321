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
    	
    	Console.Write("Enter the number of dimes: ");
    	float d = float.Parse(Console.ReadLine());

    	Console.Write("Enter the number of nickels: ");
    	float n = float.Parse(Console.ReadLine());

    	Console.Write("Enter the number of pennies: ");
    	float p = float.Parse(Console.ReadLine());

    	quarters = quarters * q;
    	dime = dime * d;
    	nickels = nickels * n;
    	pennies = pennies * p;
        Console.WriteLine("");
    	Console.WriteLine("You entered " + q + " quarters.");
    	Console.WriteLine("You entered " + d + " dimes.");
    	Console.WriteLine("You entered " + n + " nickels.");
    	Console.WriteLine("You entered " + p + " pennies.");

    	float total = quarters + dime + nickels + pennies;
    	//Console.WriteLine(total);

    	int dollar =  (int) Math.Floor((quarters + dime + nickels + pennies));

    	//Console.WriteLine(dollar);

    	float cent = (float) (total - dollar);

    	float cent1 = (float) Math.Round(cent , 2);
    	//Console.WriteLine(cent1);

    	float cent2 = cent1 * 100;
        Console.Write("\n");
    	Console.WriteLine("Your total is " + dollar + " dollars and "+ cent2 +  " cents.");



    	}
    }
