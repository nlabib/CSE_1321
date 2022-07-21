/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment6A
*/

using System;

public class Assignment6A
{
    //Linear Serach
    public static int linear(int[] numberlist, int target)
    {
        int count = 0;
        for (int i = 0; i < numberlist.Length; i++)
        {
            count++ ;
            if (numberlist[i] == target)
            {
                break;
            }
        }
        return count;
    }

    //Binary search
    public static int binary(int[] numberlist , int target)
    {
        int low = 0, mid = 0, guess = 0;
        int high = numberlist.Length - 1;

        while (high >= low)
        {
            mid = (low + high) / 2;
            guess++;

            if(numberlist[mid] < target)
            {
                low = mid + 1;
            }
            else if(numberlist[mid] > target)
            {
                high = mid - 1;
            }
            else if(numberlist[mid] == target)
            {
                break;
                
            }
        }
        return guess;
    }

    public static void Main(string[] args)
    {
        int samplesize = 1000000;
        int[] list = new int[samplesize];

        for (int i = 0; i < list.Length; i++)
        {
            list[i] = i;
        }
        Array.Reverse(list); // Reverses the list to where the index of [0] is 999,999.

        Random num = new Random();
        int randomnumber = num.Next(samplesize); // the max it can ask for
        
        // Initating linear search

        int Linerserachcount = linear(list, randomnumber);

        int binarysearchcount = binary(list, randomnumber);

        
        //Printout
        Console.WriteLine("[Linear Vs. Binary Search]");
        Console.WriteLine("The target value is " + randomnumber);
        Console.WriteLine("Linear Search: " + Linerserachcount + " loop(s)");
        Console.WriteLine("Binary Search: " + binarysearchcount + " guess(s)");

        if(Linerserachcount > binarysearchcount)
        {
            Console.WriteLine("Binary Search is faster this time!");
        }
        else { Console.WriteLine("Linear Search is faster this time!"); }




    }

}






