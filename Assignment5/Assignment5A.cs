/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment5A
*/

using System;

public class Assignment5A
{
   public static void Main(string[] args)
   {
      Console.WriteLine("[Fibonacci Sequence Generator]");
      Console.Write("How long should the Fibonacci Sequence be?: ");
      int input = Convert.ToInt32(Console.ReadLine());
      // Verify
     while(input < -1){
       Console.Write("How long should the Fibonacci Sequence be?: ");
       input = Convert.ToInt32(Console.ReadLine());
     }
     
     
    

     // Fib Formula
    int [] fib = new int[input]; // create 
    // Standard
    // formula for FIB
     /*
    f0 = 1
    f1 = f2 = 1
    fn > 2 for fn = fn-1 + fn-2;
     */
    fib[0] = 0;
    fib[1] = 1;
    fib[2] = 1;
     
     for(int x = 3; x < fib.Length; x++)
     {
      fib[x] = fib[x - 1] + fib[x -2];
       //fn = fn-1 + fn-2
     }

    for(int i = 0; i < fib.Length; i++)
     {
       Console.Write(fib[i] + ", ");
     }
     
     


    




     
   }//main
}//class



