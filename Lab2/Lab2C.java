/*
Class: CSE 1321L
Section: w2
Term: Summer 2022
Instructor: Kavitha Muppa
Name: Nasimul Labib
Lab#: 2C
*/ 
import java.util.Scanner;
public class Lab2C{
	public static void main(String[] args) {
		

		Scanner w = new Scanner(System.in);
		System.out.print("Enter a width: ");
		int width = w.nextInt();

		Scanner h = new Scanner(System.in);
		System.out.print("Enter a height: ");
		int height = h.nextInt();

		int p = 2*(width+height);
		int a = (height*width);

		System.out.println("The area is " + a);
		System.out.println("The perimeter is " + p);



	}
}