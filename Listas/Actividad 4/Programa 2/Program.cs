using System;
using System.IO;

namespace Tarea1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double result;
			int n;
			float pow = 3 / 2;
			string message;

			for (n =0;;n++) {
				result = (Math.Pow(n, pow) - 1) / 2;

				if (result >= 30) {
					message = "La serie es mayor a 30 cuando n es igual a: " + n;
					Console.WriteLine(message);
					break;
				} else {
					message = n + " : " + result;
				}

				Console.WriteLine(message);
			}

			Console.ReadLine();
		}
	}
}
