/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment 3A
*/

using System;

public class Assignment3A
{
   public static void Main(string[] args)
   {

       Console.WriteLine("[Scrappy’s Bucket List Rewards]");
       Console.Write("How many events have you attended? ");
      
      double e = Convert.ToDouble(Console.ReadLine());
      
      double ep = (e  / 63) * 100;
      
      double attend = Math.Round(ep , 0);
       if (e == 0){
         Console.WriteLine("Check out events at https://studentaffairs.kennesaw.edu/scrappysbucketlist/!");
       }
      else if (ep <= 10){
         Console.WriteLine("You've been to " +  attend + "% of all SBL events!");
         Console.WriteLine("You've earned a Drawstring Bag");

      }
      else if (ep <= 25){
         Console.WriteLine("You've been to " +  attend + "% of all SBL events!");
         Console.WriteLine("You've earned a Drawstring Bag!");
         Console.WriteLine("You've earned a Hat!");
      }
      else if (ep <= 50){
         Console.WriteLine("You've been to " +  attend + "% of all SBL events!");
         Console.WriteLine("You've earned a Drawstring Bag");
         Console.WriteLine("You've earned a Hat!");
         Console.WriteLine("You've earned a T-Shirt!");

      }
      else if (ep <= 75){
         Console.WriteLine("You've been to " +  attend + "% of all SBL events!");
         Console.WriteLine("You've earned a Drawstring Bag");
         Console.WriteLine("You've earned a Hat!");
         Console.WriteLine("You've earned a T-Shirt!");
         Console.WriteLine("You've earned a Glass Water Bottle!");
      }
      else if (ep <= 100){
         Console.WriteLine("You've been to " +  attend + "% of all SBL events!");
         Console.WriteLine("You've earned a Drawstring Bag");
         Console.WriteLine("You've earned a Hat!");
         Console.WriteLine("You've earned a T-Shirt!");
         Console.WriteLine("You've earned a Glass Water Bottle!");
         Console.WriteLine("You've earned a Hoodie!");

         if(ep == 100){
               Console.WriteLine("Are you graduating? ");
               string g = Convert.ToString(Console.ReadLine());
               string graduating = g.ToUpper();

               if (graduating == "YES"){
                  Console.WriteLine("You've earned a Challenge Coin and Special graduating Cord");
               }
               else {
                  Console.WriteLine("There’s a special reward when you graduate!");
               }
            }
            
                  }

       else {
      }
      
      
}
      



    }



       
   
