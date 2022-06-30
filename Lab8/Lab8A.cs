/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Lab 8A
*/

using System;

public class Lab8A
{
   public static void Main(string[] args)
   {
       

        int[] input1 = new int[5];
        int[] input2 = new int[5];
        int[] sum = new int[6];

        //1ST ARRAY
        Console.WriteLine("Please enter 5 integers for the first array: ");
        for(int j =1; j <= 5; j++){
        for(int i = 0; i < input1.Length; i++)
        {
            Console.Write("Integer " + j + ": ");
            input1[i] = Convert.ToInt32(Console.ReadLine());
            j++;

        }}
        

        //2ND ARRAY
        Console.WriteLine("\nPlease enter 5 integers for the second array: ");
        for(int j = 1; j <= 5; ){
        for(int i = 0; i < input2.Length; i++)
        {
            Console.Write("Integer " + j + ": ");
            input2[i] = Convert.ToInt32(Console.ReadLine());
            j++;

        }}
       
        //SUM
        Console.Write("\nThe resulting sums are ");
        for(int i = 0; i < input1.Length; i++){
            sum[i] = input1[i] + input2[i];
            Console.Write(sum[i] + " |");
        }


    }
}



    
       
   
