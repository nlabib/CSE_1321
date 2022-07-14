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
    public static void Main(string[] args)
    {

        //Gets the list of Number set   
        int[] numberlist = new int[10];
        Console.WriteLine("Please enter 10 numbers: ");

        for (int i = 0; i < numberlist.Length; i++)
        {
            Console.Write("Integer " + (i + 1) + ": ");
            int number = Convert.ToInt32(Console.ReadLine());

            numberlist[i] = number;
        }
        Console.Write("What is the target number: ");
        int target = Convert.ToInt32(Console.ReadLine());

        int result = search(numberlist, target);
       
        if (result == 1)
            Console.WriteLine("\nThe target is not in the set.");
        else
        {
            Console.WriteLine("\nThe target is in the set.");
        }
    }
    //Linar Search

    public static int search(int[] numberlist, int target)
    {
        for (int i = 0; i < numberlist.Length; i++)
        {
            if (numberlist[i] == target)
                return i;
        }
        return 1;
    }}







