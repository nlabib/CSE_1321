using System;


    public class Chair
    {
        public int numOfLegs;
        public bool rolling;
        public string material;

        
    }

    public class Lab12A
    {
        public static void Main(string[] args)
        {
            Chair chair = new Chair();
            Console.WriteLine("You are about to create a chair. ");

            Console.Write("How many legs does your chair have: ");
            chair.numOfLegs = Convert.ToInt32(Console.ReadLine());

            Console.Write("Is your chair rolling (true/false): ");
            chair.rolling = Convert.ToBoolean(Console.ReadLine());

            Console.Write("What is your chair made of: ");
            chair.material = Convert.ToString(Console.ReadLine());
            string roll = " ";
            
            if(chair.rolling)
            {
                  roll = "rolling";
            }
            else { roll = "not rolling"; }

            Console.WriteLine("Your chair has " + chair.numOfLegs + " legs, is " + roll + ", and is made of " + chair.material + ".");

            Console.WriteLine("\nThis program is going to change that.\n");
            
            chair.numOfLegs = 4;
            chair.rolling = false;
            chair.material = "wood";

           if(chair.rolling)
            {
                  roll = "rolling";
            }
            else { roll = "not rolling"; }

            Console.WriteLine("Your chair has " + chair.numOfLegs + " legs, is " + roll + ", and is made of " + chair.material + ".");







        }
    }


