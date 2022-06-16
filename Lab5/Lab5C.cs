/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 5C
*/

using System;

public class Lab5C
{
   public static void Main(string[] args)
   {

       Console.Write("Enter x: ");
       int x = Convert.ToInt32(Console.ReadLine());

       Console.Write("Enter y: ");
       int y = Convert.ToInt32(Console.ReadLine());


      if (x == 0 && y == 0){
         Console.WriteLine("This point is on the origin.");

      }
      else if(x > 0 && y > 0){
         Console.WriteLine("This point is in the first quadrant.");
      }
      else if(x < 0 && y > 0){
         Console.WriteLine("This point is in the second quadrant.");
      }
      else if (x < 0 && y < 0){
         Console.WriteLine("This point is in the third quadrant.");
      }
      else if (x > 0 && y < 0){
         Console.WriteLine("This point is in the fourth quadrant.");
      }
      else if (x == 0){
         Console.WriteLine("This point is on the y axis.");
      }
      else if (y == 0){
         Console.WriteLine("This point is on the x axis.");
      }
      else
      {
         Console.WriteLine("Number error.");
      }


    }
       }
   
