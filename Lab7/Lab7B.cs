/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 4C
*/

using System;

public class Lab4B
{
   public static void Main(string[] args)
   {
         

      Console.Write("Please enter a value for the size: ");
      int input = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("This is the requested " + input + "x" + input + " right-triangle:");

      for(int i=0; i < input; ++i){
         for(int j = 0; j <= i; ++j){
            Console.Write("*");
         }
         Console.WriteLine("");
      }





    }
       }
   
