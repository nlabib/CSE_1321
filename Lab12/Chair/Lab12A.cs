using System;


    public class Chair
    {
        public int numOfLegs;
        public bool rolling;
        public string material;

        public Chair(int n, bool r, string m)
        {
            numOfLegs = n;
            rolling = r;
            material = m;
        }
    }

    public class Lab12A
    {
        public static void Main(string[] args)
        {
            int legs = 0;
            bool rolling = false;
            string material = " ";

            Console.WriteLine("You are about to create a chair. ");

            Console.WriteLine("How many legs does your chair have: ");
            legs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is your chair rolling (true/false): ");
            rolling = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("What is your chair made of: ");
            material = Convert.ToString(Console.ReadLine());

            string r = " ";
            

            Console.WriteLine("Your chair has " + legs + "legs, is " + r + " and is made of " + material);

            Console.WriteLine("\nThis progam is going to change that.\n");
            Chair onechair = new Chair(legs, rolling, material);

            onechair.numOfLegs = 4;
            onechair.rolling = false;
            onechair.material = "wood";
            if (onechair.rolling)
            {
                  r = "rolling";
            }
            else { r = "not rolling"; }

            Console.WriteLine("Your chair has " + onechair.numOfLegs + "legs, is " + r + " and is made of " + onechair.material);







        }
    }


