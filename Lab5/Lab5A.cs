/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 4C
*/

using System;
public class Lab5A{
public static void Main(string[] args)
   {

         Console.WriteLine("Do you have a driving permit (Y/N)?");
         char first = Convert.ToChar(Console.ReadLine());

      
         if(first.Equals('Y') || first.Equals('y')){
            Console.WriteLine("Do you have a commercial driving license (Y/N)? ");
            char second = Convert.ToChar(Console.ReadLine());
            if (second.Equals('Y') || second.Equals('y')){
               Console.WriteLine("Congratulations! You can purchase a vehicle, let’s start talking options!");
            }
            else{
               Console.WriteLine("Commercial driving license is a prerequisite to purchase a vehicle!");
            }
            
         }
       else{
          Console.WriteLine("Driving permit is a prerequisite to purchase a vehicle! ");
       }
}
    }