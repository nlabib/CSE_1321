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
    public static void changeposition(int x, int y)
    {
        string[,] maze = new string[,]
                  { {"_","X","_","X","X"},
                    {"_","X","_","X","X"},
                    {"_","_","_","X","_"},
                    {"X","X","_","_","_"},
                    {"_","_","_","X","X"}};
        x = x - 1;
        y = y - 1;
        
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
        int x = 0;
        int y = 0;


        while (true)
        {
            Console.Write("Which direction do you want to move? ");
            String user_input = Convert.ToString(Console.ReadLine());

            user_input = user_input.ToUpper;
            
            switch (user_input)
            {
                // I couldn't finish this lab/
            }



        }



    }//main
}//class



