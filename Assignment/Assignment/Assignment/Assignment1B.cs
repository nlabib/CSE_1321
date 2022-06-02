using System;
	public class Assignment1B
	{
		public Assignment1B()
		{
		//Input
		Console.WriteLine("[Tip Calculator]");

		Console.Write("Enter the total price of the meal: ");
		double mprice = Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter the local tax rate: ");
		double tax_rate = Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter the delivery fee: ");
		double dfee = Convert.ToDouble(Console.ReadLine());

		// Math

		double total_tax = mprice * tax_rate;
		double subtotal = mprice * dfee;
		double ten_tip = subtotal * (10 / 100);
		double t_tip = subtotal * (10 / 100);

		double totalten = (ten_tip + subtotal + total_tax);
		double twentytotal = (t_tip + subtotal + total_tax);



		// output
		Console.WriteLine("A 10% tip would be " + ten_tip);
		Console.WriteLine("The total would be " + totalten);

		Console.WriteLine("A 20% tip would be " + t_tip);
		Console.WriteLine("The total would be " + twentytotal);

	}
	}


