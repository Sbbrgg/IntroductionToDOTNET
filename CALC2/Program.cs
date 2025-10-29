//#define CALC_IF
//#define CALC_SWITCH
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CALC2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите арифметическое выражение: ");
			string expression = "22+33-44/2+8*3";
			//string expression = Console.ReadLine();
			expression = expression.Replace(".", ",");
			expression = expression.Replace(" ", "");
			Console.WriteLine(expression);

			char[] operators = new char[] { '+', '-', '*', '/' };
			string[] operands = expression.Split(operators);
			double[] values = new double[operands.Length];
			for (int i = 0; i < operands.Length; i++)
			{
				values[i] = Convert.ToDouble(operands[i]);
				Console.Write($"{values[i]}\t");
			}
			Console.WriteLine();

			char[] digits = "0123456789.".ToCharArray();
			//for (int i = 0; i < digits.Length; i++)
			//{
			//	Console.Write($"{digits[i]}");
			//}
			//Console.WriteLine();

			string[] operations = expression.Split(digits);
			operations = operations.Where(o => o != "").ToArray();
			for (int i = 0; i < operations.Length; i++)
			{
				Console.Write($"    {operations[i]}\t");
			}
			Console.WriteLine();


			char[] ops = new char[operations.Length];
			for(int i = 0; i < ops.Length; i++)
			{
				ops[i] = Convert.ToChar(operations[i]);	
			}


			for (int i = 0; i < ops.Length; i++)
			{
				if (ops[i] == '*' || ops[i] == '/')
				{
					double result = 0;
					if (ops[i] == '*') result = values[i] * values[i + 1];
					else if (ops[i] == '/') result = values[i] / values[i + 1];

					values[i] = result;

					for (int j = i + 1; j < values.Length - 1; j++)
						values[j] = values[j + 1];
					for (int j = i; j < ops.Length - 1; j++)
						ops[j] = ops[j + 1];

					Array.Resize(ref values, values.Length - 1);
					Array.Resize(ref ops, ops.Length - 1);

					i--;
				}
			}

			for (int i = 0; i < ops.Length; i++)
			{
				double result = 0;
				if (ops[i] == '+') result = values[i] + values[i + 1];
				else if (ops[i] == '-') result = values[i] - values[i + 1];

				values[i] = result;

				for (int j = i + 1; j < values.Length - 1; j++)
					values[j] = values[j + 1];
				for (int j = i; j < ops.Length - 1; j++)
					ops[j] = ops[j + 1];

				Array.Resize(ref values, values.Length - 1);
				Array.Resize(ref ops, ops.Length - 1);

				i--;
			}

			Console.WriteLine($"Результат: {values[0]}");

			#region CALC_TRY1
			//string[] OperationsSorted = new string[operations.Length];
			//Array.Copy(operations, OperationsSorted, operations.Length);
			//Array.Sort(OperationsSorted);

			/*int[] ArrayOfPriority = new int[operations.Length];
			int PriorityIndex = 0;
			for(int i = 0; i < operations.Length; i++)
			{
				if (operations[i] == "*" || operations[i] == "/")
				{
					ArrayOfPriority[PriorityIndex] = i;
					PriorityIndex++;
				}
			}
			for(int i = 0;i<operations.Length;i++)
			{
				if (operations[i] == "+" ||  operations[i] == "-")
				{
					ArrayOfPriority[PriorityIndex] = i; 
					PriorityIndex++;
				}
			}

			double[] CurrentValues = (double[])values.Clone();
			string[] CurrentOperations = (string[])operations.Clone();
			int CurrentSize = CurrentValues.Length;

			for(int i = 0; i < ArrayOfPriority.Length ; i++)
			{
				if (ArrayOfPriority[i] >= CurrentOperations.Length) continue;

				double left = CurrentValues[ArrayOfPriority[i]];
				double right = CurrentValues[ArrayOfPriority[i] + 1];
				double OperationResult = 0;

				switch (CurrentOperations[ArrayOfPriority[i]])
				{
					case "*":
						OperationResult = left * right;
						break;
					case "/":
						OperationResult = left / right;
						break;
					case "-":
						OperationResult = left - right;
						break;
					case "+":
						OperationResult = left + right;
						break;
				}
				CurrentValues[ArrayOfPriority[i]] = OperationResult;
				
			}

			Console.WriteLine(CurrentValues[0]);
			*/
			//for(int i = 0; i < operations.Length; i++)
			//{
			//	int j = Array.IndexOf(operands, );
			//}
			// +	-	/	+	*
			// 2 4 0 1 3
			#endregion


#if CALC_IF
			if (expression.Contains("+"))
				Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}");
			else if (expression.Contains("-"))
				Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}");
			else if (expression.Contains("*"))
				Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}");
			else if (expression.Contains("/"))
				Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}");
			else Console.WriteLine("Error: no operation"); 
#endif

#if CALC_SWITCH
			switch (expression[expression.IndexOfAny(operators)])
			{
				case '+': Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}"); break;
				case '-': Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}"); break;
				case '*': Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}"); break;
				case '/': Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}"); break;
			} 
#endif

		}
	}
}
