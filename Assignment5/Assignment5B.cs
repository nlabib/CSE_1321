/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment5B
*/

using System;

public class Assignment5B
{

     public static int x1, y1 = 0; // The main location of O

    // Method to change the location of "O"
    public static void changeposition(int x, int y)
    {
        string[,] maze = new string[,]
                  { {"_","X","_","X","X"},
                    {"_","X","_","X","X"},
                    {"_","_","_","X","_"},
                    {"X","X","_","_","_"},
                    {"_","_","_","X","X"}};
        x = x - 1;
        x1 = x;

        y = y - 1;
        y1 = y;
        maze[y, x] = "O";

        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write(maze[i, j]);
            }
            Console.WriteLine();
        }


    }

   

    public static void Main(string[] args)
    {

        Console.WriteLine("[Maze Game]");

      //  Console.WriteLine("Which direction do you want to move? ");
       // string userinput = Convert.ToString(Console.ReadLine());

        //string userinput1 = userinput.ToUpper();


       changeposition(1, 5);// win
       while(changeposition(1 ,5) != "O")
        {

        }
        


        


  

    }//main
}//class



