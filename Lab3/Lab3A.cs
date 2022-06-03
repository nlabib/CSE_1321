/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment 3A
*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Amount Owed: ");
        float amount = 0.000f;
       	amount =  float.Parse(Console.ReadLine());

        Console.Write("APR: ");
        float apr = 0.0f;
        apr = float.Parse(Console.ReadLine());

        int mpr = (int) (((apr * 1000) / 12) / 1000.0f);

        int minpay = (int) ((amount * (apr/1200)) / 100.0f);

        Console.WriteLine("Monthly Percentage rate : " + mpr);
     	Console.WriteLine("Minimum payment: " + minpay);

 }
}
