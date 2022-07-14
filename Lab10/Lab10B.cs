/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Lab10B
*/

using System;

public class Lab10B
{
    public static bool isValid(double a, double b)
    {
        double result = a + b;
        if (result > 30)
        {
            return false; // Check if its above 30 or not
        }
        else return true;
    }

    public static double area(double a, double b)
    {
        double area = a * b;
        return area;
    }

    public static double perimeter(double a, double b)
    {
        double p = 2 * (a) + 2 * (b);
        return p;
    }

    public static void Main(string[] args)
    {
        double w = 0.0;
        double h = 0.0;
        bool test = isValid(w, h);
        char input = 'Y';


        while (test && input == 'Y')
        {
            Console.WriteLine("Enter width: ");
            w = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            h = Convert.ToDouble(Console.ReadLine());


            if (isValid(w, h))
            {
                Console.WriteLine("The area is " + area(w, h));
                Console.WriteLine("The perimeter is " + perimeter(w, h));
                Console.WriteLine("This is an valid rectangle ");

            }
            else
            {
                Console.WriteLine("This is an invalid rectangle \n");
            }
            Console.WriteLine("\nDo you want to enter another width and height (Y/N)? : ");
            input = char.Parse(Console.ReadLine());
            input = char.ToUpper(input);
            }
            Console.WriteLine("Program Ends");



    }
}







