/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment5B
*/

using System;

public class Assignment5B
{
   public static void Main(string[] args)
   {
     
    Console.WriteLine("[Maze Game]");

    string [ , ] maze = new string [ , ] {{"O", "X", "_", "X", "X"}, 
                          {"_","X","_","X","W"},
              
              {"_","_","_","X","_"},
              
              {"X","X","_","_","_"},
              
              {"_","_","_","X","X"}};

    Console.WriteLine("Which direction do you want to move? ");
    string userinput = Convert.ToString(Console.ReadLine());
    

    int x = 0;
    int y = 0;


     
   }//main
}//class



