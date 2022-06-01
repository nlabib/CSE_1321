/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 2A
*/ 
import java.util.Scanner;
public class Lab2A{

public static void main(String[] args) {
	Scanner n = new Scanner(System.in);
	System.out.print("Enter a name: ");
	String name = n.nextLine();

	Scanner n1 = new Scanner(System.in);
	System.out.print("Enter a second name: ");
	String name2 = n1.nextLine();

	Scanner v = new Scanner(System.in);
	System.out.print("Enter a verb: ");
	String verb = v.nextLine();

	Scanner averb = new Scanner(System.in);
	System.out.print("Enter an adverb: ");
	String adverb = averb.nextLine();


	System.out.println("Once upon a time, there was a person named " + name + " who had a child named " + name2 + "." + " This child would " + verb + " " + adverb + " while singing to strangers.");

}
}