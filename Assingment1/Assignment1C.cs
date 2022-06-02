/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment 1C
*/

using System;
class Assignment1C
{
	public static void Main(string[] arg)
	{
		//Input
		Console.WriteLine("[KSU NetID Generator]");
		Console.Write("Enter the first letter of your first name: ");
		string fname = Console.ReadLine();

		Console.Write("Enter your last name: ");
		string lname = Console.ReadLine();

		Console.Write("Enter a valid whole number : ");
		int n = Convert.ToInt32(Console.ReadLine());

		//Convert everything into a string

		string netID = (string) fname + lname + n;

	
		Console.WriteLine("Your KSU NetID is "+ netID + ". You can log into KSU computers with this NetID as your username and your email password as thepassword.");
		Console.WriteLine("Your email adress is " + netID + "@student.kennesaw.edu");






	}
}

