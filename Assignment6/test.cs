// C# program to create 3 overloaded methods to sort an array of integers, floats and characters and perform sorting on the array based on user input

using System;

class OverloadedSorting {
    
    /**
    * overloaded method that takes as input an array of integers
    * and sorts the input array in ascending order
    */
    static void sortArray(int[] array)
    {
        // loop over the array from start to second last element of the array
        for(int i=0;i<array.Length-1;i++)
        {
            // inner loop over the array, comparing the adjacent elements of the unsorted array and swapping the elements when out of order
            for(int j=0;j<array.Length-1-i;j++)
            {
                if(array[j] > array[j+1])
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
    }

    /**
    * overloaded method that takes as input an array of floats
    * and sorts the input array in ascending order
    */
    static void sortArray(float[] array){
        
        // loop over the array from start to second last element of the array
        for(int i=0;i<array.Length-1;i++)
        {
            // inner loop over the array, comparing the adjacent elements of the unsorted array and swapping the elements when out of order
            for(int j=0;j<array.Length-1-i;j++)
            {
                if(array[j] > array[j+1])
                {
                    float temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
    }
    
    /**
    * overloaded method that takes as input an array of characters
    * and sorts the input array in ascending order
    */
    static void sortArray(char[] array)
    {
        // loop over the array from start to second last element of the array
        for(int i=0;i<array.Length-1;i++)
        {
            // inner loop over the array, comparing the adjacent elements of the unsorted array and swapping the elements when out of order
            for(int j=0;j<array.Length-1-i;j++)
            {
                if(array[j] > array[j+1])
                {
                    char temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
    }
    
    static void Main() {
    
        string dataType;
        // create 3 arrays of size 8 for integers, floats and characters
        int[] intArray = new int[8];
        float[] floatArray = new float[8];
        char[] charArray = new char[8];
        
        // input the data type of values to enter
        Console.Write("What data type do you want to enter? ");
        dataType = Console.ReadLine();
        
        if(dataType.ToLower() == "integer") // integer data
        {
            // loop to input 8 integers into the array
            for(int i=0;i<intArray.Length;i++)
            {
                Console.Write("Value " + (i+1) + ": ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Calling sortArray()...");
            sortArray(intArray); // sort the integer array in ascending order
            
            // display the sorted array
            Console.WriteLine("The sorted values are:");
            
            for(int i=0;i<intArray.Length;i++)
                Console.Write(intArray[i] + ", ");
            Console.WriteLine();
        }
        else if(dataType.ToLower() == "char") // character data
        {
            // loop to input 8 characters into the array
            for(int i=0;i<intArray.Length;i++)
            {
                Console.Write("Value " + (i+1) + ": ");
                charArray[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Calling sortArray()...");
            sortArray(charArray); // sort the character array in ascending order
            
            // display the sorted array
            Console.WriteLine("The sorted values are:");
            
            for(int i=0;i<charArray.Length;i++)
                Console.Write(charArray[i] + ", ");
            Console.WriteLine();
        }
        else if(dataType.ToLower() == "float") // float data
        {
            // loop to input 8 floats into the array
            for(int i=0;i<floatArray.Length;i++)
            {
                Console.Write("Value " + (i+1) + ": ");
                floatArray[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Calling sortArray()...");
            sortArray(floatArray); // sort the float array in ascending order
            
            // display the sorted array
            Console.WriteLine("The sorted values are:");
            
            for(int i=0;i<floatArray.Length;i++)
                Console.Write(floatArray[i].ToString("0.0") + ", ");
            Console.WriteLine();
        }
  }
}

// end of program