// See https://aka.ms/new-console-template for more information
using HomeWork2.Task1;
using HomeWork2.Task2;
using HomeWork2.Task3;
using HomeWork2.Task4;

class Program
{
	static void Main()
	{
		//task1
		Student student = new Student("Ali", 22);
		student.Introduce();

		//task2
		BankAccount account = new BankAccount(1000);
		account.ShowBalance();
		account.Deposit(500);
		account.Withdraw(300);
		account.Withdraw(2000);

		//task3
		Console.Write("Enter first number: ");
		int num1 = int.Parse(Console.ReadLine());

		Console.Write("Enter second number: ");
		int num2 = int.Parse(Console.ReadLine());

		int num3;

		Console.WriteLine("\nBefore method call:");
		Console.WriteLine($"First: {num1}, Second: {num2}");

		Statistics.AnalyzeNumbers(num1, ref num2, out num3);

		Console.WriteLine("\nAfter method call:");
		Console.WriteLine($"First: {num1}");
		Console.WriteLine($"Second (squared): {num2}");
		Console.WriteLine($"Third (sum): {num3}");




		//task4
		Console.Write("Enter array size: ");
		int size = int.Parse(Console.ReadLine());

		int[] numbers = new int[size];

		for (int i = 0; i < size; i++)
		{
			Console.Write($"Enter element {i + 1}: ");
			numbers[i] = int.Parse(Console.ReadLine());
		}

		int max = 0;     
		double average;   

		ArrayAnalyzer.AnalyzeArray(numbers, ref max, out average);

		Console.WriteLine($"Maximum value: {max}");
		Console.WriteLine($"Average value: {average}");
	}
}