using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{
	public partial class Program
	{
		public static double first_operand;

		public static double second_operand;
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter first number: ");

			first_operand = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter operator: ");

			var operat = char.Parse(Console.ReadLine());

			Console.WriteLine("Enter second number: ");

			second_operand = double.Parse(Console.ReadLine());

			switch (operat)
			{
				case '-':
					Subtracd();
					break;
				case '+':
					Addition();
					break;
				case '/':
					Division();
					break;
				case '%':
					Remainder();
					break;
				case '*':
					Multiply();
					break;				
			}

			Console.ReadKey();
		}
		private static void Multiply()
		{
			Console.WriteLine("Result: {0}", Math.Round(first_operand * second_operand,2));
		}
		private static void Division()
		{
			Console.WriteLine("Result: {0}", Math.Round(first_operand / second_operand,2));
		}									 
		private static void Subtracd()				 
		{									 
			Console.WriteLine("Result: {0}", Math.Round(first_operand - second_operand,2));
		}									 
		private static void Remainder()			 
		{									 
			Console.WriteLine("Result: {0}", Math.Round(first_operand % second_operand,2));
		}									
		private static void Addition()				 
		{									
			Console.WriteLine("Result: {0}", Math.Round(first_operand + second_operand,2));
		}
	}
}
