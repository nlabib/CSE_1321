/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 4C
*/

using System;

public class Lab4C
{
	public static void Main(string[] args)
	{

        Console.WriteLine("Welcome!");
        Console.WriteLine("Please input a number: ");
        float num = float.Parse(Console.ReadLine());
		
        Console.WriteLine("");
        Console.WriteLine("What would you like to do to this number: ");
        Console.WriteLine("0- Get the additive inverse of the number");
        Console.WriteLine("1- Get the reciprocal of the number");
        Console.WriteLine("2- Square the number");
        Console.WriteLine("3- Cube the number");
        Console.WriteLine("4- Exit the program");
      
       	

        // [Calculations]
        // Additive inverse 
        float additive = num - (2 * num);
        // Reciprocal of the number
        float reciprocal =  (1 / num);
        // Squre the number
        float square =  num * num;
        // Cube the number
        float cube = num * num * num;

        
      

     
        Console.WriteLine(" ");// Input from the user
        int command = Convert.ToInt32(Console.ReadLine()); // save input
		/*
        if (command != 4){

        
       	 	Console.WriteLine("What would you like to do to this number: ");
        	Console.WriteLine("0- Get the additive inverse of the number");
        	Console.WriteLine("1- Get the reciprocal of the number");
        	Console.WriteLine("2- Square the number");
        	Console.WriteLine("3- Cube the number");
        	Console.WriteLine("4- Exit the program");

        	/*
        	if (command == 0){
        		Console.WriteLine("The additive inverse of " + num + " is " + additive);
        	}
        	else if (command == 1){
        		Console.WriteLine("The reciprocal of " + num + " is " + reciprocal);
        	}
        	else if (command == 2){
        		Console.WriteLine("The square of " + num + " is " + square);
        	}
        	else if (command == 3){
        		Console.WriteLine("The cube " + num + " is " + cube);
        	}
        	
        	// [The loop]


        } 
		*/
		
			switch (command){
            case 0:
            	Console.WriteLine("The additive inverse of " + num + " is " + additive);
            	break;
            case 1:
            	Console.WriteLine("The reciprocal of " + num + " is " + reciprocal);
            	break;
            case 2:
            	Console.WriteLine("The square of " + num + " is " + square);
            	break;
            case 3:
            	Console.WriteLine("The cube of " + num + " is " + cube);
            	break;
            case 4:
            	Console.WriteLine("Thank you, goodbye!");
            	break;   
            default:
               	Console.WriteLine("Invalid input, please try again!"); 
            	break;
		
        	       }



   		}
    } // main 
    //class

        
        

        
  