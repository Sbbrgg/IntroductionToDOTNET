using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine($"Введите выражение: ");
				string exp = Console.ReadLine();
				if (exp == "exit") break;
				exp.Replace(" ", "");
				char op = ' ';
				foreach(char c in exp)
				{
					if(c == '+' || c == '-'|| c == '*' || c == '/')
					{
						op = c;
						break;
					}
				}
				string[] numbers = exp.Split(op);
				if(numbers.Length != 2)
				{
					Console.WriteLine($"Ошибка ввода выражения");
					continue;
				}
				double a = Convert.ToDouble(numbers[0]);
				double b = Convert.ToDouble(numbers[1]);
				double rez = 0;
				switch(op)
				{
					case '+': rez = a + b; break;
					case '-': rez = a - b; break;
					case '*': rez = a * b; break;
					case '/': rez = a / b; break;
					default: Console.WriteLine("Неверное выражение"); continue;
				}
				Console.WriteLine(rez);
			}
		}
	}
}
