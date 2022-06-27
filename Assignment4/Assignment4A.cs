/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment4A
*/

using System;

public class Assignment4A
{
   public static void Main(string[] args)
   {
        
      Console.WriteLine("[Times Table Generator]");
      Console.Write("Enter your start number: ");
      int number = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the limit you want to multiply to: ");
      int limit = Convert.ToInt32(Console.ReadLine());


      // loop to test positive number
      while(number < 0){
         Console.Write("Enter your start number: ");
         number = Convert.ToInt32(Console.ReadLine());
      }

      //loop for printing the number
      for(int i = 1; i <= limit; ++i){
            int total = number * i;
            Console.WriteLine(number + " * " + i + " = " + total);
        

   }
   }
   }
   
