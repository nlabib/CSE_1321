using System.Text;

public class NPC
{
    // attributes
    private readonly string name;
    private readonly string classID;
    private float hp;
    private readonly float attack;
    private readonly float defense;

    /**
     * constructor
     * 
     * @param name
     * @param classID
     */
    public NPC(string name, int classID)
    {
        this.name = name;
        // assign values to attributes based on classID
        if (classID == 1)
        {
            hp = 120;
            attack = 40;
            defense = 0.20f;
            this.classID = "Sword Fighter";
        }
        else if (classID == 2)
        {
            hp = 80;
            attack = 35;
            defense = 0.60f;
            this.classID = "Unicorn Sorcerer";
        }
        else if (classID == 3)
        {
            hp = 100;
            attack = 20;
            defense = 0.42f;
            this.classID = "Dance Battler";
        }
    }

    public string getName()
    {
        return name;
    }

    public string getClassID()
    {
        return classID;
    }

    public float getHp()
    {
        return hp;
    }

    public float getAttack()
    {
        return attack;
    }

    public float getDefense()
    {
        return defense;
    }

    public void setHp(float humanResult)
    {
        hp -= humanResult;
        if (hp < 0) hp = 0;
    }

    public float calAttak(float oppDefensePercentages)
    {
        return attack * (1 - oppDefensePercentages);
    }

    public void caldef(float oppAttackPower)
    {
        hp -= oppAttackPower * (1 - defense);
    }

    /**
     * @return true if the object's HP is less than or equal to 0
     */
    public bool isStillAlive()
    {
        return hp > 0;
    }
}

public class Assignment7B
{
    public static void Main(string[] args)
    {
        Console.WriteLine("[Generic RPG Battle System]");
        // Prompt the user for a cusotm name and class and create an NPC object
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your battle class: ");
        string charName = Console.ReadLine();
        string battleClass = 1;
        // based on the character name entered by the user assign classID
        if (charName.Equals("Sword Fighter")) battleClass = 1;
        else if (charName.Equals("Unicorn Sorcerer")) battleClass = 2;
        else if (charName.Equals("Dance Battler")) battleClass = 3;
        string human = new NPC(name, battleClass);

        // random generate two vakyes
        string lower = "abcdefghijklmnopqrstuvwxyz";
        // create random string builder
        string sb = new StringBuilder();
        for (string i = 0; i < 5; i++)
        {
            // generate random index number
            string index = new Random().Next(lower.Length);
            // get character specified by index
            // from the string
            string randomChar = lower[index];
            // append the character to string builder
            sb.Append(randomChar);
        }

        string opponentName = sb.ToString();
        opponentName = char.ToUpper(opponentName[0]) + opponentName.Substring(1);
        string opponentClassID = new Random().Next(1, 3);

        // construct a opponent NPC player
        string computer = new NPC(opponentName, opponentClassID);
        Console.WriteLine(human.GetName() + " the " + human.GetClassID() + ", your opponent is " + computer.GetName() +
                          " the " + computer.GetClassID() + "!");
        Console.WriteLine();
        string roundNumber = 0;

        // run until both are alive
        while (human.IsStillAlive() && computer.IsStillAlive())
        {
            roundNumber++;
            Console.WriteLine("- Round " + roundNumber + "-");
            // ask user choice
            Console.Write("Do you (a)ttack or (d)efend? ");
            string userChoice = Console.ReadLine();
            // select choice of player if 1 attack else 2 defend
            string randomChoice = new Random().Next(1, 2);
            string computerChoice = randomChoice == 1 ? "a" : "d";
            if (userChoice.Equals("d") && computerChoice.Equals("d"))
            {
                Console.WriteLine(human.GetName() + " the " + human.GetClassID() + " is on guard.");
                Console.WriteLine(computer.GetName() + " the " + computer.GetClassID() + " is on guard.");
            }
            else if (userChoice.Equals("a") && computerChoice.Equals("a"))
            {
                string humanResult = human.calAttak(computer.GetDefense());
                string computerResult = computer.calAttak(human.GetDefense());
                human.SetHp(humanResult);
                computer.SetHp(computerResult);
                Console.WriteLine(human.GetName() + " the " + human.GetClassID() + " attacked " + computer.GetName() +
                                  " the " + computer.GetClassID() + "!");
                Console.WriteLine(computer.GetName() + " now has " + computer.GetHp().ToString("0") + " HP.");
                Console.WriteLine(computer.GetName() + " the " + computer.GetClassID() + " attacked " +
                                  human.GetName() + " the " + human.GetClassID() + "!");
                Console.WriteLine(human.GetName() + " now has " + human.GetHp().ToString("0") + " HP.");
            }
            else
            {
                if (userChoice.Equals("d"))
                {
                    human.caldef(computer.GetDefense());
                    Console.WriteLine(human.GetName() + " the " + human.GetClassID() + " is on guard.");
                    Console.WriteLine(computer.GetName() + " the " + computer.GetClassID() + " attacked " +
                                      human.GetName() + " the " + human.GetClassID() + "!");
                }
                else
                {
                    computer.caldef(human.GetDefense());
                    Console.WriteLine(computer.GetName() + " the " + computer.GetClassID() + " is on guard.");
                    Console.WriteLine(human.GetName() + " the " + human.GetClassID() + " attacked " +
                                      computer.GetName() + " the " + computer.GetClassID() + "!");
                }
            }

            Console.WriteLine();
        }

        // print the result
        if (human.IsStillAlive())
        {
            Console.WriteLine(computer.GetName() + " the " + computer.GetClassID() + " was defeated...");
            Console.WriteLine(human.GetName() + " the " + human.GetClassID() + " wins!");
        }
        else
        {
            Console.WriteLine(human.GetName() + " the " + human.GetClassID() + " was defeated...");
            Console.WriteLine(computer.GetName() + " the " + computer.GetClassID() + " wins!");
        }
    }
}