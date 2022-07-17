/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Lab11B
*/

using System;

public class Lab11B
{

    public static string validtester(string password)
    {
        int pass_lenght = password.Length;
        bool number = false;
        bool upperletter = false;
        string index = password;

        for (int i = 0; i < password.Length; i++)
        {
            if (index[i] >= 48 && index[i] <= 57)
            {
                number = true;
            }
            if (index[i] >= 65 && index[i] <= 90)
            {
                upperletter = true;
            }
        }

        if (pass_lenght >= 8 && number && upperletter)
        {
            return "Valid Password";
        }
        else return "Invalid Password";
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a password: ");
        string pass = Console.ReadLine();

        Console.WriteLine(validtester(pass));
        Console.WriteLine("Program Ends");
    }
}






