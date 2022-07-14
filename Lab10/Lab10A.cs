/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Lab9A
*/

using System;

public class Lab9A
{
    public static int Maxint(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else return b;

        
    }
    public static int Minint(int a , int b)
    {
        if (a < b)
        {
            return a;
        }
        else return b;
    }

    public static float average(int a , int b)
    {
        float avg = (float) (a + b) / 2;
        return avg;
    }
        

    
        
        public static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());



            int max = Maxint(num1, num2);
            int min = Minint(num1, num2);
            float avge = average(num1 , num2);

            Console.WriteLine("Min is " + min);
            Console.WriteLine("max is " + max);
            Console.WriteLine("Average is " + avge);


        }
    }







