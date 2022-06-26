/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Lab 6B
*/

using System;

public class Lab6B
{
    public static void Main(string[] args)
    {

        Random randomnumber = new Random();
        int num = 0;
        int count = 0;

        Console.Write("Enter a number between 1 and 1000 : ");
        int user = Convert.ToInt32(Console.ReadLine());

        while (1 > user || user > 1000)
        {
            Console.Write("Enter a number between 1 and 1000 : ");
             user = Convert.ToInt32(Console.ReadLine());

        }

        int min = 0;
        int max = 0;


        if (user > 1 && user < 250)
        {
            min = 1;
            max = 250;

        }
        else if (user > 250 && user < 500)
        {

            min = 250;
            max = 500;

        }
        else if (user > 500 && user < 700)
        {
            min = 500;
            max = 700;
        }
        else if (user > 700 && user < 1000){
            min = 700;
            max = 1000;
        }
        else
        {
            min = 0;
            max = 1000;
        }


        while (num != user)
        {
            num = randomnumber.Next(min, max)+1;
            Console.WriteLine("");
            Console.WriteLine("My guess was " + num);
            count++;
            if (num == user)
            {

                Console.WriteLine("\nI guessed the number was " + num + " and it only took me " + count + " guesses.");

                break;
            }
        }



    }
}
