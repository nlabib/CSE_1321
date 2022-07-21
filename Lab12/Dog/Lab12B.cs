using System;

    public class dog
    {
        public int age;
        public double weight;
        public string name;
        public string furColor;
        public string breed;

        public void bark()
        {
            Console.WriteLine("make sound");
        }
        public void rname(string n)
        {
            this.name = n;
        }
        public void eat(double a)
        {
            this.weight += a;
        }
    }
    public class main
    {
        public static void Main(string[] args)
        {
            dog dog1 = new dog();
            
            Console.WriteLine("You are about to create a dog. ");
            Console.Write("How old is the dog:");
            dog1.age = Convert.ToInt32(Console.ReadLine());

            Console.Write("How much does the dog weigh: ");
            dog1.weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the dog’s name: ");
            dog1.name = Convert.ToString(Console.ReadLine());

            Console.Write("What color is the dog: ");
            dog1.furColor = Convert.ToString(Console.ReadLine());

            Console.Write("What breed is the dog: ");
            dog1.breed = Convert.ToString(Console.ReadLine());

            Console.WriteLine(dog1.name + "is a " + dog1.age + " year old " + dog1.furColor + " " + dog1.breed + " that weighs " + dog1.weight);

            dog1.bark();

            Console.WriteLine("");
            Console.Write(dog1.name + " is hungry, how much should he eat: ");
            int food = Convert.ToInt32(Console.ReadLine());

            dog1.eat(food);

            Console.Write(dog1.name + "isn't a very good name. What should they be rename to: ");
            string n = Convert.ToString(Console.ReadLine());

            dog1.rname(n);

            Console.WriteLine(dog1.name + " is a " + dog1.age + " year old " + dog1.furColor + " " + dog1.breed + " that weighs " + dog1.weight);







        }
    }


