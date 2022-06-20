/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment3C
*/

using System;

public class Assignment3C
{
   public static void Main(string[] args)
   {

      Console.WriteLine("[App Checklist]");
      Console.Write("What mobile device do you have? ");
      string pname = Convert.ToString(Console.ReadLine());
      string phone = pname.ToUpper(); // Upper Case

      

     
      switch(phone){
         case "APPLE":
            Console.Write("What IOS Version do you have? "); // Version
            float ios = float.Parse(Console.ReadLine());

            if (ios >= 14){
               Console.WriteLine("Congratulations, you can run the app!");   
            }
               else if (ios <= 14){
                  Console.Write("Does your device support NFC? "); // NFC
                  string n = Convert.ToString(Console.ReadLine());
                  string nfc = n.ToUpper();
                     if (nfc.Equals("YES")){
                        Console.WriteLine("Congratulations, you can run the app!"); 
                     }
                     else {
                           Console.WriteLine("I’m sorry, our app does not support your device.");
                                 }
               }
                  else
                  {
                     Console.WriteLine("I’m sorry, our app does not support your device.");
                  }
         break;
         
         case "ANDROID":
            Console.Write("What version do you have? "); // version
            float version1 = float.Parse(Console.ReadLine());

          

            if (version1 >= 14){
               Console.WriteLine("Congratulations, you can run the app!");   
            }
               else if (version1 <= 14){
                  Console.Write("Does your device support NFC? "); // NFC
                  string b = Convert.ToString(Console.ReadLine());
                  string bluetooth = b.ToUpper();
                     if (bluetooth.Equals("YES")){
                        Console.WriteLine("Congratulations, you can run the app!"); 
                     }
                     else{
                           Console.WriteLine("I’m sorry, our app does not support your device.");

                        }
               }
            else
            {
               Console.WriteLine("I’m sorry, our app does not support your device.");
            }
         
         break;
         default:
            Console.WriteLine("I'm Sorry!");   
         break;
      
      
      }


    }
       }
   
