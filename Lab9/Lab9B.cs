/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Lab9B
*/

using System;

public class Lab9B
{
   //Binary Serach
  public static int sort(int[] numberlist)
    {
        int low = 0, mid = 0;
        int high = searchArray.Length - 1;
        bool found = false;
        while(high >= low){
          mid = (low + high) / 2;
          if(find < searchArray[mid]){
            high = mid - 1;
          }
          else if(find == searchArray[mid]){
            found = true;
            break;
          }
        }
    }

   public static void Main(string[] args)
   {
	 //Gets the list of Number set   
        int[] numberlist = new int[11];
        Console.WriteLine("Please enter 11 numbers: ");

        //Print from Integer 1
        for (int i = 0; i < numberlist.Length; i++)
        {
            Console.Write("Integer " + (i + 1) + ": ");
            int number = Convert.ToInt32(Console.ReadLine());
            numberlist[i] = number;
        }

        Console.Write("What is the target number: ");
        int find = Convert.ToInt32(Console.ReadLine());

        

   }//main
}//class
