#define DATA_TYPES
//#define CONSTANTS
//#define TYPE_CONVERTIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const string delimiter = "\n-------------------------------------------------\n";
#if DATA_TYPES
			Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти, класс обвертка Boolean;");
			Console.WriteLine(bool.FalseString);
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));

			Console.WriteLine(delimiter);

			/////////////////////////////////////////////////////////////////////////////////////
			Console.WriteLine
				(
$@"char занимает {sizeof(char)} Байт памяти и принимает значения в диапазоне
от {(int)char.MinValue} до {(int)char.MaxValue}. Класс-обвёртка - {typeof(char)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"byte занимает {sizeof(byte)} Байт памяти и принимает значения в диапазоне 
от {byte.MinValue} до {byte.MaxValue}, класс-обвёртка - {typeof(byte)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"sbyte занимает {sizeof(sbyte)} Байт памяти и принимает значения в диапазоне 
от {sbyte.MinValue} до {sbyte.MaxValue}, класс-обвёртка - {typeof(sbyte)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"short занимает {sizeof(short)} Байт памяти и принимает значения
в диапазоне от {short.MinValue} до {short.MaxValue}, класс обвертка {typeof(short)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"ushort занимает {sizeof(ushort)} Байт памяти и принимает значения
в диапазоне от {ushort.MinValue} до {ushort.MaxValue}, класс обвертка {typeof(ushort)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"int занимает {sizeof(int)} Байт памяти и принимает значения
в диапазоне от {int.MinValue} до {int.MaxValue}, класс обвертка {typeof(int)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"uint занимает {sizeof(uint)} Байт памяти и принимает значения
в диапазоне от {uint.MinValue} до {uint.MaxValue}, класс обвертка {typeof(uint)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"long занимает {sizeof(long)} Байт памяти и принимает значения
в диапазоне от {long.MinValue} до {long.MaxValue}, класс обвертка {typeof(long)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"ulong занимает {sizeof(ulong)} Байт памяти и принимает значения
в диапазоне от {ulong.MinValue} до {ulong.MaxValue}, класс обвертка {typeof(ulong)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"float занимает {sizeof(float)} Байта памяти и принимает значения
в диапазоне от {float.MinValue} до {float.MaxValue}, класс обвертка {typeof(float)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"double занимает {sizeof(double)} Байта памяти и принимает значения
в диапазоне от {double.MinValue} до {double.MaxValue}, класс обвертка {typeof(double)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"decimal занимает {sizeof(decimal)} Байтов памяти и принимает значения
в диапазоне от {decimal.MinValue} до {decimal.MaxValue}, класс обвертка {typeof(decimal)}"
				);
#endif

#if CONSTANTS
			Console.WriteLine(delimiter);
			Console.WriteLine("Hello".GetType()); 

			Console.WriteLine(delimiter);
			Console.WriteLine(5.9.GetType());
#endif

#if TYPE_CONVERTIONS
			int n = 5;
			while (n-- > 0)
			{
				Console.WriteLine(n);
			}
			Console.WriteLine(delimiter);
			//ushort b = (ushort) - 2;
			//Console.WriteLine(b);
			double a = 2.2;
			short b = (short)a;
			Console.WriteLine(b); 

#endif
		}
	}
}
