/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment 2A
*/

using System;
class Lab2A
{
	public static void Main(string[] arg)
	{
		//Input
		Console.Write("Enter a name: ");
		string name = Console.ReadLine();

		Console.Write("Enter another name: ");
		string aname = Console.ReadLine();

		Console.Write("Enter a verb: ");
		string verb = Console.ReadLine();

		Console.Write("Enter an adverb: ");
		string adverb = Console.ReadLine();


		Console.WriteLine("Once upon a time, there was a person named "+ name + " who had a child named "+ aname + ".This child would "+verb+ " " + adverb +" while singing to strangers. ");



	}
}

