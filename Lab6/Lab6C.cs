/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 6C
*/

using System;

public class Lab6C
{
   public static void Main(string[] args)
   {
         
         int balance = 1000;
         int input = 100; // so it doesn't defult to zero
         Console.WriteLine("Welcome!");
         Console.WriteLine("You have $1000 in your account.");
         
   
        char user;
         
         do {
         Console.WriteLine("Menu");
         Console.WriteLine("0 - Make a deposit");
         Console.WriteLine("1 - Make a withdrawal");
         Console.WriteLine("2 - Display account value");
         
         Console.Write("Please make a selection: ");
         input = Convert.ToInt32(Console.ReadLine());
         
         if(input == 0){
            
               Console.Write("How much would you like to deposit? : ");
               int deposit = Convert.ToInt32(Console.ReadLine());
               balance = balance + deposit;
               Console.WriteLine(" Your current balance is $ " + balance);
                       }

         else if(input == 1){
               Console.Write("How much would you like to withdraw? : ");
               int withdraw = Convert.ToInt32(Console.ReadLine());
               balance = balance - withdraw;
               Console.WriteLine(" Your current balance is $ " + balance);              
         }

         else if(input == 2){
               Console.WriteLine(" Your current balance is $ " + balance);
                  
         }
         else{
            Console.WriteLine("Invalid entry, please try again. ");
         }

         Console.Write("Would you like to return to the main menu (Y/N)? : ");
          user = Char.Parse(Console.ReadLine());

      } while(user == 'Y' || user == 'y');
      Console.WriteLine("Thank you for banking with us!");





    }
       }
   
