/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment4B
*/

using System;

public class Assignment4B
{
    public static void Main(string[] args)
    {

        Console.Write("Enter the checkerboard’s width: ");
        int width = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter the checkerboard’s height: ");
        int height = Convert.ToInt32(Console.ReadLine());



        //loop to veify
        while(width < 0 || height < 0) {
         Console.WriteLine("Please enter a valid width!");
         Console.Write("Enter the checkerboard’s width: ");
         width = Convert.ToInt32(Console.ReadLine());
}     
         while(height < 0) {
         Console.WriteLine("Please enter a valid height!");
         Console.Write("Enter the checkerboard’s height: ");
         height = Convert.ToInt32(Console.ReadLine());

}
        //loop
        char white = '■';
        char black = '□';

        
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
               
               int check = (i + j) % 2;
               if (check == 1) Console.Write(white);
               else  Console.Write(black);
                
            }
         
            Console.WriteLine("");
    }
}}
       
   

  