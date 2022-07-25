/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment7A
*/

using System;using System.Collections;
using System.Linq.Expressions;

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
   public float setCondition
   {
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
   public float GetCondition()
   {
      return condition;
      
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
   //Linear Search to find the CD and display the Information
   public static  int FindCD(string[] cdnamefinder1, string CdToFind)
   {
      int l = cdnamefinder1.Length;
      for (int i = 0; i < cdnamefinder1.Length; i++)
      {
         if (cdnamefinder1[i] == CdToFind) ;
         return i; // Show what position the cd is at
      }
      return -1;
   }
   
   
   public static void Main(string[] args)
   {
      string cdtofind = " ";
      Console.Write("How many CDs do you have lying around your car? ");
      int cdcount = Convert.ToInt32(Console.ReadLine());
      AudioCD[] cd = new AudioCD[cdcount];

      int y = 0;
      //User Defines how many times this will run
      for (int i = 0; i < cd.Length; i++)
      {
         y++;
         Console.Write("CD #" + y);
         Console.Write("\nEnter Title: ");
         string title = Convert.ToString(Console.ReadLine());

         Console.Write("Enter Genre: ");
         string genre = Convert.ToString(Console.ReadLine());

         Console.Write("Enter Release year: ");
         int ryear = Convert.ToInt32(Console.ReadLine());

         Console.Write("Enter Condition: ");
         float conditon = float.Parse(Console.ReadLine());

         cd[i] = new AudioCD(title, ryear, genre, conditon);
         }
     
    
      bool logoff = true; //Sentinal Value for the Loop
      bool Cdfound = false;
      
      //Saves the Cd names to CDnameFinder
      string[] cdnamefinder = new string[cd.Length];
      for (int i = 0; i < cd.Length; i++)
      {
         cdnamefinder[i] = cd[i].GetTitle();
      }
      
      
      //Loop for Main Menu
      do
      {
         Console.WriteLine("\nMain Menu");
         Console.WriteLine("1) Album Info");
         Console.WriteLine("2) Find a CD");
         Console.WriteLine("3) Find an artist");
         Console.WriteLine("4) Log Off");
         Console.Write("Choice: ");
         int choice = Convert.ToInt32(Console.ReadLine());
         switch (choice)
         {
            case 1:
               Console.Write("Which CD do you want: ");
               int numcd = Convert.ToInt32(Console.ReadLine());
               numcd -= numcd;
               int n = numcd + 1;
               Console.WriteLine( n +". " + cd[numcd].GetTitle() + ", " + cd[numcd].GetReleaseYear());
               Console.WriteLine("Genre: " + cd[numcd].GetGenre());
               break;
            case 2:
               Console.Write("What is the CD's name? ");
               cdtofind = Convert.ToString(Console.ReadLine());
               int cdposition = FindCD(cdnamefinder, cdtofind);
               bool view = true;
               if (view)  // If it is found
               {
                  Console.WriteLine("There is a match!");
                  Console.WriteLine(cdposition + ". " + cd[cdposition].GetTitle() + ", " + cd[cdposition].GetReleaseYear());
                  Console.WriteLine("Genre: " + cd[cdposition].GetTitle());
                  Console.WriteLine("Conditon: " + cd[cdposition].GetCondition());
                  view = false;
               }
               else
               {
                  Console.WriteLine("Couldn't find it!");
                  view = false;
               }
               break;
            case 3:
               break;
            case 4:
               logoff = false;
               break;
            default:
               Console.WriteLine("Invalid Choice");
               break;
         }
      } while (logoff);

   }
}






