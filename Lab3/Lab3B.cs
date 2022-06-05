/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment 3B
*/
using System;

class Program
{
    public static void Main(string[] args)
    {

    	Console.Write("Course 1 hours: ");
    	float c1 = float.Parse(Console.ReadLine());
    	Console.Write("Grade for course 1: ");
    	float g1 = float.Parse(Console.ReadLine());

    	Console.Write("Course 2 hours: ");
    	float c2 = float.Parse(Console.ReadLine());
    	Console.Write("Grade for course 2: ");
    	float g2 = float.Parse(Console.ReadLine());

    	Console.Write("Course 3 hours: ");
    	float c3 = float.Parse(Console.ReadLine());
    	Console.Write("Grade for course 3: ");
    	float g3 = float.Parse(Console.ReadLine());

    	Console.Write("Course 4 hours: ");
    	float c4 = float.Parse(Console.ReadLine());
    	Console.Write("Grade for course 4: ");
    	float g4 = float.Parse(Console.ReadLine());

    	float total_hour =  (c1+c2+c3+c4);
    	float qp = (c1 * g1) + (g2 * c2) + (g3 * c3) + (g4 * c4);


    	float gpa = qp / total_hour;

        double fgpa = Math.Round(gpa, 5);

    	Console.WriteLine("");
    	Console.WriteLine("Total Hours is : " + total_hour);
    	Console.WriteLine("Total Quality Points is : " + qp);
    	Console.WriteLine("Your GPA for this semester is " + fgpa);
        //test
    	}
    }
