//#define CONSOLE 
//#define FIO
#define HOMEWORK
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		const string BLACK_BOX = "  ";
		const string WHITE_BOX = "\u2588\u2588";
		static string StringMultiply(string s1, int s2)
		{
			string rez = "";
			for (int i = 0; i < s2; i++)
			{
				rez += s1;
			}
			return rez;
		}
		static void Main(string[] args)
		{
#if CONSOLE
            Console.Write("Hello .NET\t");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World");
            Console.WriteLine();
            //Console.Title = "Introduction to .NET";
            //Console.Beep(37, 20);
            Console.CursorLeft = 25;
            Console.CursorTop = 5;
            Console.WriteLine("SetCursorPosition");
            Console.SetCursorPosition(22, 8);
            Console.WriteLine("AnotherPosition");
            Console.ResetColor(); 
#endif

#if FIO
			Console.Write("Введите Ваше имя: ");
			string firstname = Console.ReadLine();

			Console.Write("Введите вашу фамилию: ");
			string lastname = Console.ReadLine();

			Console.Write("Введите ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(lastname + " " + firstname + " " + age);  // Конкатенация строк

			Console.WriteLine(String.Format("{0} {1} {2}", lastname, firstname, age));  //Форматирование строк

			Console.WriteLine($"{lastname} {firstname} {age}"); 
#endif

#if HOMEWORK
			Console.Write("Введите длину стороны: ");
			int n = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("1)");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("2)");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("3)");
			for (int i = 0; i < n; i++)
			{
				for (int j = n; j > i; j--)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("4)");
			for (int i = 0; i < n; i++)
			{
				//space = StringMultiply("  ", i);
				//Console.Write(space);
				Console.Write(StringMultiply("  ", i));
				for (int j = n; j > i; j--)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("5)");
			for (int i = 0; i < n; i++)
			{
				Console.Write(StringMultiply("  ", n - i - 1));
				for (int j = 0; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("6)");
			for (int i = 0; i < n; i++)
			{
				//Console.Write(StringMultiply(" ", n - i - 1));
				Console.Write(new string(' ', n - i - 1));
				Console.Write("/");
				//Console.Write(StringMultiply(" ", i*2));
				Console.Write(new string(' ', i * 2));
				Console.Write("\\");
				Console.WriteLine();
			}
			for (int i = n - 1; i >= 0; i--)
			{
				//Console.Write(StringMultiply(" ", n - i - 1));
				Console.Write(new string(' ', n - i - 1));
				Console.Write("\\");
				//Console.Write(StringMultiply(" ", i*2));
				Console.Write(new string(' ', i * 2));
				Console.Write("/");
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("7)");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					//if ((i + j) % 2 == 0) Console.Write("+ "); else Console.Write("- ");
					Console.Write(i % 2 == j % 2 ? "+ " : "- ");
				}
				Console.WriteLine();
			}
			Console.WriteLine("\t\tHARD CHESS");
			for (int i = 0; i < n * n; i++)
			{
				for (int j = 0; j < n * n; j++)
				{

					if ((((i) / n) + ((j) / n)) % 2 == 0) Console.Write(WHITE_BOX);
					else Console.Write(BLACK_BOX);
				}
				Console.WriteLine();
			}
#endif

		}
	}
}
