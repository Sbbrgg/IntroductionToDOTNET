//#define SIMPLE_CALC
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
#if SIMPLE_CALC
			while (true)
			{
				Console.WriteLine($"Введите выражение: ");
				string exp = Console.ReadLine();
				if (exp == "exit") break;
				exp.Replace(" ", "");
				char op = ' ';
				foreach (char c in exp)
				{
					if (c == '+' || c == '-' || c == '*' || c == '/')
					{
						op = c;
						break;
					}
				}
				string[] numbers = exp.Split(op);
				if (numbers.Length != 2)
				{
					Console.WriteLine($"Ошибка ввода выражения");
					continue;
				}
				double a = Convert.ToDouble(numbers[0]);
				double b = Convert.ToDouble(numbers[1]);
				double rez = 0;
				switch (op)
				{
					case '+': rez = a + b; break;
					case '-': rez = a - b; break;
					case '*': rez = a * b; break;
					case '/': rez = a / b; break;
					default: Console.WriteLine("Неверное выражение"); continue;
				}
				Console.WriteLine(rez);
			} 
#endif
            Calculate calculator = new Calculate();
            string[] testExpressions = {
                "2+3",
                "5-2",
                "3*4",
                "10/2",
                "2^3",
                "sin(0)",
                "cos(0)",
                "tan(0)",
                "2+3*4",
                "(2+3)*4",
                "sin(0.5)",
                "cos(0.5)"
            };

            // Запуск тестов
            foreach (string expression in testExpressions)
            {
                try
                {
                    double result = calculator.CAlculate(expression);
                    Console.WriteLine($"{expression} = {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{expression} -> Ошибка: {ex.Message}");
                }
            }

            Console.WriteLine("\nИнтерактивный режим");
            Console.WriteLine("===================");
            Console.WriteLine("Введите выражения для вычисления (exit для выхода):");

            // Интерактивный режим
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input?.ToLower() == "exit")
                    break;

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                try
                {
                    double result = calculator.CAlculate(input);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

        }
	}
}
