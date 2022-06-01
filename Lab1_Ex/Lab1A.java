/*
Class: CSE 1321L
Section: ...
Term: Summer 2022
Instructor: ...
Name: Nasimul Labib
Lab#: 1A
*/ 
// Program Lab1A
// Demonstrate the difference between print and println.
public class Lab1A
{
 // Prints two lines of output representing a rocket countdown.
 public static void main (String[] args)
 {
 System.out.print ("Three... ");
 System.out.print ("Two... ");
 System.out.print ("One... "); // missing a ";"
 System.out.print ("Zero... ");
 System.out.println ("Liftoff!"); // appears on first line
 System.out.println ("Houston, we have a problem.");
 }
} 