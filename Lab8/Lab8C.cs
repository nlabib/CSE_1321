/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Lab8C
*/

using System;

public class Lab8C
{
   public static void Main(string[] args)
   {
        Console.Write("Please enter the number of rows: "); // I
        int r = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the number of columns: "); // j
        int c = Convert.ToInt32(Console.ReadLine());

        int[,] userinput = new int[r,c]; 

        int number = 1;
     int num2 = number;
        int sum = r * c;
        Console.WriteLine("\nI have "+ r + " rows and "+ c + " columns. I need to fill-up " + sum+ " spaces.\n"); 
   //2d 
      Console.WriteLine("The " + r + "x" + c + " array:");
        for (int i = 1; i <= userinput.GetLength(0); i++) // row
          {
            for (int j = 1; j <= userinput.GetLength(1); j++) // columns
            {   
              Console.Write(number +"|");
              number++;
            }
        Console.WriteLine("");
        }
    Console.WriteLine("\nThe " + r + "x" + c+ " 2-D array flattened into a "+sum+ " cell 1-D array: \n"); 
     //1D
    Console.WriteLine("The " + r + "x" + c + " array:");

     for (int i = 1; i <= userinput.GetLength(0); i++) // row
          {
            for (int j = 1; j <= userinput.GetLength(1); j++) // columns
            {   
              Console.Write(num2 +"|");
              num2++;
            }
 }

     
   }//main
}//class