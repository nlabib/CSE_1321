/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 5B
*/

using System;

public class Lab5B
{
   public static void Main(string[] args)
   {

       Console.WriteLine("Enter an integer: ");
       int num = Convert.ToInt32(Console.ReadLine());

       int d2 = num % 2;

       int d3 = num % 3;

       int d5 = num % 5;

       if(d2 == 0){
         Console.WriteLine("This number is divisible by 2");

       }
       else if(d3 == 0){
         Console.WriteLine("This number is divisible by 3");
       }
       else if (d5 == 0){
         Console.WriteLine("This number is divisible by 5");
       }

       else{
         Console.WriteLine("This number is undetermined");
       }



    }
       }
   
