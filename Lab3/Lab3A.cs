/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: Assignment 3A
*/
// i don't know u have to import
using System;
class Program {
  public static void Main (string[] args) {
   
  Console.Write("Amount Owed: ");
  float mowned = float.Parse(Console.ReadLine());

  Console.Write("APR: ");
  float apr = float.Parse(Console.ReadLine());

  
  float mpr = (mowned * (apr / 100) / 12);
  float mp  = (apr / 12);
  double mp_rounded = Math.Round(mp,3);
  double mpr_rounded = Math.Round(mpr,2);

  Console.WriteLine("Monthly percentage rate: " + mp_rounded);   
  Console.WriteLine("Minium payment: " + mpr_rounded);
  }
}