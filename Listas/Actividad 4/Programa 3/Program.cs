using System;
using System.IO;

namespace Tarea1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input;
			double num;
			int count;

			while (true) {
				Console.WriteLine ("Ingrese un Número: ");
				input = Console.ReadLine ();

				try {
					num = Convert.ToInt32(input);				
				} catch {
					Console.WriteLine ("Por favor, ingrese sólo números.");
					continue;
				}

				for (count =0; count<1000; count++) {
					if (num % 5 == 0) {
						num += 2;
					}  else if (num % 7 == 0) {
						num += 1;
					} else {
						num += 3;
					}
				}

				Console.WriteLine ("Resultado final: " + num);
				break;
			}

			Console.ReadLine();
		}
	}
}
