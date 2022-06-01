/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 1A
*/ 
using System;
// Program Lab1C.cs
public class Lab1C
{
 // Calculates fuel efficiency based on values entered by the user.
 public static void Main (String[] args)
 {
 int miles;
 double gallons, mpg;
 Console.Write ("Enter the number of miles: ");
 miles = Convert.ToInt32(Console.ReadLine());

 Console.Write ("Enter the gallons of fuel used: ");
 gallons = Convert.ToInt32(Console.ReadLine());

 mpg = miles / gallons;
 Console.WriteLine ("Miles Per Gallon: " + mpg);
 }
} 