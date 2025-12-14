using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2.Task2
{
	class BankAccount
	{

		private int balance;

		// سازنده
		public BankAccount(int initialBalance)
		{
			balance = initialBalance;
		}

		// واریز
		public void Deposit(double amount)
		{
			if (amount <= 0)
			{
				Console.WriteLine("Deposit amount must be greater than zero");
				return;
			}

			balance += (int)amount;
			Console.WriteLine($"Deposit successful. Current balance: {balance}");
		}

		// برداشت
		public void Withdraw(double amount)
		{
			if (amount > balance)
			{
				Console.WriteLine("Not enough inventory.");
				return;
			}

			balance -= (int)amount;
			Console.WriteLine($"Withdrawal successful. Current balance: {balance}");
		}

		// نمایش موجودی
		public void ShowBalance()
		{
			Console.WriteLine($"Current account balance: {balance}");
		}
	}
}
