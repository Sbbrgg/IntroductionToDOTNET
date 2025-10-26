using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			int x = Console.WindowWidth / 2;
			int y = Console.WindowHeight / 2;

			while (true)
			{
				if (x < 0) x = 0;
				if (x > Console.WindowWidth) x = Console.WindowWidth - 1;
				if (y < 0) y = 0;
				if (y > Console.WindowHeight) y = Console.WindowHeight - 1;

				Console.SetCursorPosition(x, y);
				Console.Write("*");

				ConsoleKey key = Console.ReadKey(true).Key;
				Console.SetCursorPosition(x, y);
				Console.Write(" ");
				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W: y--; break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S: y++; break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A: x--; break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D: x++; break;
					case ConsoleKey.Escape: return;
					default: break;
				}
				Console.Write(" ");
			}	
		}
	}
}
