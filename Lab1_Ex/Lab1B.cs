/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 1A
*/ 
using System;
// Program Lab1B.cs
// Demonstrate reading a string from the user.
public class Lab1B
{
 // Reads a character string from the user and prints it.
 public static void Main (String[] args)
 {
 String message;
 Console.Write("Enter a line of text: ");
 message = Console.ReadLine();
 Console.WriteLine("You wrote'" + message + "'");
 }
} 
