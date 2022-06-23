/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Lab 6A
*/

using System;

public class Lab6B
{
   public static void Main(string[] args)
   {
      int n = 0;
      for (int i = 1; i < 11; i++){
         Console.Write("Please enter number " + i + ": ");
         int a = Convert.ToInt32(Console.ReadLine());
         if (n < a){
            n = a;
         }
      }
   
      Console.WriteLine("The largest number was " + n);
   }
   }