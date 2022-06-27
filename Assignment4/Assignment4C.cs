/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment4C
*/

using System;

public class Assignment4C
{
   public static void Main(string[] args)
   {
         

      Console.WriteLine("[Mathletes Game]");
      
      Console.Write("Choose a game mode (0 = Easy, 1 = hard) : ");  
      int gamemode = Convert.ToInt32(Console.ReadLine());
      
      //Makes use the game is 0 or 1
      while(gamemode > 2){
         Console.Write("Choose a game mode (0 = Easy, 1 = hard) : ");  
          gamemode = Convert.ToInt32(Console.ReadLine());
      }

      //Random Number Generrator
      Random num1 = new Random();
      Random num2 = new Random();

      int numberright = 0;
      int wrong = 0; // keeps tack of the number or time question the user gets wrong
      int questioncount = 1; // Keeps track of the quesiton count

      switch (gamemode){
         // EASY MODE
         case 0: 
            Console.WriteLine("Playing on easy mode, huh? Okay!");
            do{
            int n1 = num1.Next(-255, 255);
            int n2 = num2.Next(-255, 255);
            int sum = (n1  * n2);
            Console.WriteLine("Q" + questioncount + ". " + n1 + " * " + n2 + " = "+ " ?");
            int answer = Convert.ToInt32(Console.ReadLine());
            
             if(answer == sum){
                  Console.WriteLine("Correct");
                  numberright++;
                  questioncount++;
               }
               else if(answer != sum){
                  Console.WriteLine("Incorrect! Try again. ");
                  wrong++;
                  questioncount++;
                  
                     if(wrong == 2){
                        Console.WriteLine("Game over");
                        break;
                     }
               }

            }while(questioncount <= 5);
            Console.WriteLine("You win!");
         break;
         // HARD MODE
         case 1:
         Console.WriteLine("So, you want a challenge? Okay!");
         
         do{
            int n1 = num1.Next(-255, 255);
            int n2 = num2.Next(-225, 255);
            int sum = (n1  * n2);
            Console.WriteLine("Q" + questioncount + ". " + n1 + " * " + n2 + " = " + " ?");
            int answer = Convert.ToInt32(Console.ReadLine());
            
               if(answer == sum){
                  Console.WriteLine("Correct");
                  numberright++;
                  questioncount++;
               }
               else if(answer != sum){
                  Console.WriteLine("Incorrect!");
                  Console.WriteLine("Game over....");
                  questioncount = 5;
                  break;
               }

            }while(questioncount <= 5);
         break;
}//Switch
    }//main
       }//class
   
