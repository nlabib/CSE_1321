using System; 

public class Program {

  public static void Main(string[] args) {
    
  
  Console.Write("Amount Owed: $");
  float mowned = float.Parse(Console.ReadLine());

	float m = Math.Round(mowned, 1);
	Console.Write(m);
  
  }
}
				



