/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Lab11A
*/

using System;

public class Lab11A
{
    // Prints out the input according to what the user selects
    public static String printout(int input){

    string r0 = "Hello!";
    string r1 = "Ok, Bye.";
    string r2 = "WHOA!";

        if (input == 0)
        {
            return r0;
        }
        else if (input == 1)
        {
            return r1;
        }
        else if (input == 2)
        {
            return r2;
        }
        else return "Program Ends";
}

public static void Main(string[] args)
{
        string rerun = "YES";
        
        while (rerun.ToUpper().Equals("YES"))
        {
            Console.WriteLine("Menu");
            Console.WriteLine("0 - Hello World");
            Console.WriteLine("1 - Goodbye Moon");
            Console.WriteLine("2 - Walking on Sunshine");

            Console.Write("What would you like to do: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(printout(num));

            Console.Write("Type YES to rerun. ");
            rerun = Convert.ToString(Console.ReadLine());

        }
        Console.WriteLine("Program Ends");
    }
}




       
   
