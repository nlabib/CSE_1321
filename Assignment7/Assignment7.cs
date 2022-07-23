/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment7A
*/

using System;using System.Collections;

public class AudioCD
{
   private string cdTitle;
   public string[] artists = new string[3]; // can have only 4 names
   private int releaseYear;
   private string genre;
   private float condition;

   
    // default Constructor
    public  AudioCD()
   {
      cdTitle = " ";
      releaseYear = 1980;
      genre = " ";
      condition = 0.0f;
     //artists [] = {" ", " ", " ", " "};
   }
   
   // OverloadedConstructor
   public AudioCD(string t, int year, string g, float c)
   {
      this.cdTitle = t;
      this.releaseYear = year;
      this.genre = g;
      this.condition = c;
      //this.artists[i] = n;
   }

    // Getter and setter Methods
   public string GetTitle()
   {
      return cdTitle;
   }
   public float GetCondition
   {
      get { return condition; }
      set
      {
         if (value < 0.0f || value > 5.0f)
         {
            condition = 0.0f;
         }
         else { condition = value; }
      }
   }
   public string GetGenre()
   {
      return genre;
   }
   public int GetReleaseYear()
   {
      return releaseYear;
      
   }
   public string getArtists(int index)
   {
      return artists[index];
   }
   public void setArtists(int index, string name)
   {
      this.artists[index] = name;
   }
   
   
}



public class Assignment7A
{
   //Look for cd name with binary serach
   public static string Find(string[] nfinder)
   {
      
   }
   public static void Main(string[] args)
   {
      string cdtofind = " ";
      
      Console.WriteLine("How many CDs do you have lying around your car?");
      int cdcount = Convert.ToInt32(Console.ReadLine());
      AudioCD[] cd = new AudioCD[cdcount];

      int y = 0;
      //User Defines how many times this will run
      for (int i = 0; i < cd.Length; i++)
      {
         y++;
         Console.Write("CD #" + y);
         Console.Write("Enter Title: ");
         string title = Convert.ToString(Console.ReadLine());

         Console.Write("Enter Genre: ");
         string genre = Convert.ToString(Console.ReadLine());

         Console.Write("Enter Release year: ");
         int ryear = Convert.ToInt32(Console.ReadLine());

         Console.Write("Enter Condition: ");
         float conditon = float.Parse(Console.ReadLine());

         cd[i] = new AudioCD(title, ryear, genre, conditon);
         }

       string[] cdnamefinder = new string[cd.Length];
      for (int i = 0; i <= cd.Length; i++)
      {
         cdnamefinder[i] = cd[i].GetTitle();
      }

      string find = Array.Find(cdnamefinder, element => element.StartsWith(cdtofind, StringComparison.Ordinal));
      
      
      
      
      //Loop for Main Menu
      Console.WriteLine("Main Menu");
      Console.WriteLine("1) Album Info");
      Console.WriteLine("2) Find a CD");
      Console.WriteLine("3) Find an artist");
      Console.WriteLine("4) Log Off");
      
      Console.WriteLine("Choice: ");
      int choice = Convert.ToInt32(Console.ReadLine());
      bool logoff = true;

      

      while (logoff)
      {
         switch (choice)
         {
            case 1:
               Console.WriteLine("Which CD do you want");
               int numcd = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("1. "+cd[numcd].GetTitle() + ", " + cd[numcd].GetReleaseYear());
               Console.WriteLine("Genre" + cd[numcd].GetGenre());
               break;
            case 2:
               Console.WriteLine("What is the CD's name? ");
               cdtofind = Convert.ToString(Console.ReadLine());
               
               if () // If it is found
               {
                  Console.WriteLine("There is a match!");
               }
               else{Console.WriteLine("Couldn't find it!");}
               break;
            case 3:
               break;
            case 4:
               logoff = false;
               break;
         }
      }







   }
}






