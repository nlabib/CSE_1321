/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Lab13A
*/

using System;
public class BuildingBlueprint
{

    private int numOfStories;
    private int numOfApart;
    private float ocuprate;
    private bool ifFull;

    public int NumOfStories
    {
        get { return numOfStories; }
        set
        {
            
                numOfStories = value;
            
        }
    }

    public int NumOfApart
    {
        get { return numOfApart; }
        set
        {
            numOfApart = value;
        }
    }

    public float Ocuprate
    {
        get { return ocuprate; }
        set
        {
            if (value <= 0)
            {
                ocuprate = 0.0f;
            }
            else if (value >= 1)
            {
                ocuprate = 1.0f;
            }
            else
            {
                ocuprate = value;
            }
        }
    }

    public bool IfFull
    {
        get { return ifFull; }
        set
        {
            if (ocuprate == 1.0)
            {
                ifFull = true;
            }
            else if (ocuprate < 1.0)
            {
                ifFull = false;
            }
        }
    }

    public void Building(int ns, int na, float op, bool iful)
    {
        this.numOfStories = ns;
        this.numOfApart = na;
        this.ocuprate = op;
        this.ifFull = iful;
    }


}

public class main
{
    public static void Main(string[] args)
    {
        BuildingBlueprint b1 = new BuildingBlueprint();
        b1.NumOfStories = 10;
        b1.NumOfApart = 20;
        b1.Ocuprate = 1.0f;
        b1.IfFull = true;
        Console.WriteLine("Year 2020:");
        Console.WriteLine("Building 1 has " + b1.NumOfStories + " floors, " + b1.NumOfApart + " apartments, and is " + (b1.Ocuprate * 100) + "% occupied. Full? " + b1.IfFull);
       
        BuildingBlueprint b2 = new BuildingBlueprint();
        b2.NumOfStories = 30;
        b2.NumOfApart = 30;
        b2.Ocuprate = .75f;
        b2.IfFull = false;
        Console.WriteLine("Building 2 has " + b2.NumOfStories + " floors, " + b2.NumOfApart + " apartments, and is " + (b2.Ocuprate * 100) + "% occupied. Full? " + b2.IfFull);

        Console.WriteLine("\nMany years pass. \n");

        Console.WriteLine("Year 2043: ");
        b1.NumOfStories = 10;
        b1.NumOfApart = 20;
        b1.Ocuprate = 0.0f;
        b1.IfFull = false;
        Console.WriteLine("Building 1 has " + b1.NumOfStories + " floors, " + b1.NumOfApart + " apartments, and is " + (b1.Ocuprate * 100) + "% occupied. Full? " + b1.IfFull);

        b2.NumOfStories = 30;
        b2.NumOfApart = 30;
        b2.Ocuprate = 1.0f;
        b2.IfFull = true;
        Console.WriteLine("Building 2 has " + b2.NumOfStories + " floors, " + b2.NumOfApart + " apartments, and is " + (b2.Ocuprate * 100) + "% occupied. Full? " + b2.IfFull);

      Console.WriteLine("Looks like people prefer taller buildings.");
    }
}






