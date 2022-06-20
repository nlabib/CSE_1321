/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment3B
*/

using System;
public class Assignment3B {
   public static void Main(string[] args)
   {
      Console.WriteLine("[Instructor Scheduler]");
      Console.Write("What day of the week is it? ");
      char w = Convert.ToChar(Console.ReadLine());
      char week = char.ToUpper(w);
      
      Console.Write("What time of day? ");
      char t = Convert.ToChar(Console.ReadLine());
      char timeofday = char.ToLower(t);


      switch (week){
         case 'M':
               if (timeofday == 'a'){
                  Console.WriteLine("On Monday Morning, you'll be teaching C++, section E04!");
               }
               else if(timeofday == 'p'){
                  Console.WriteLine("On Monday Afternoon, you'll be teaching Java, section J0!");
               }
               break;
         case 'T':
               if (timeofday == 'a'){
                  Console.WriteLine("On Tuesday Morning, you'll  have Office Hours!");
               }
               else if(timeofday == 'p'){
                  Console.WriteLine("On Tuesday Afternoon, you'll be teaching c#, section W#1!");
               }
               break;
         case 'W':
               if (timeofday == 'a'){
                  Console.WriteLine("On Wednesday Morning, you'll be teaching C#, section #02!");
               }
               else if(timeofday == 'p'){
                  Console.WriteLine("On Wednesday Afternoon, you'll have Free Time!");
               }
               break;
         case 'R':
               if (timeofday == 'a'){
                  Console.WriteLine("On Thursday Morning, you'll  have Office Hours!");
               }
               else if(timeofday == 'p'){
                  Console.WriteLine("On Thursday Afternoon, you'll be teaching c++, section WE3!");
               }
               
               break;
         case 'F':
               if (timeofday == 'a'){
                  Console.WriteLine("On Friday Morning, you'll be teaching Java, section WJ3!");
               }
               else if(timeofday == 'p'){
                  Console.WriteLine("On Friday Afternoon, you'll have Free Time!");
               }
               break;
         default:
            Console.WriteLine("Tha's not a valid day or time!");
         break;

}
}
}
            

       
   
