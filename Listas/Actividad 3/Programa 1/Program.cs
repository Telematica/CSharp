using System;
using System.IO;

namespace Tarea1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int countCols = 0, countRows = 0, val;
			int cols, rows;
			string input;
			string inputRows;
			string inputCols;
			double num;
			int count = 0;

			while (true) {
				Console.WriteLine ("Ingrese la cantidad de renglones de su matriz: ");
				inputRows = Console.ReadLine ();

				Console.WriteLine ("Ingrese la cantidad de columnas de su matriz: ");
				inputCols = Console.ReadLine ();

				try {
					rows = Convert.ToInt32(inputRows);
					cols = Convert.ToInt32(inputCols);
				} catch {
					Console.WriteLine ("Por favor, ingrese sólo números.");
					continue;
				}

				double[,] array = new double[cols,rows];

				do {
					do {
						try {
							Console.WriteLine ("Ingrese el valor para la posición ["+countCols+","+countRows+"]: ");
							input = Console.ReadLine ();
							val = Convert.ToInt32(input);
							array[countCols,countRows] = val;
						} catch {
							Console.WriteLine ("Por favor, ingrese sólo números.");
							continue;
						}
						countCols++;
					} while(countCols < array.GetLength(0));
					countCols = 0;
					countRows++;
				} while(countRows < array.GetLength(1));

				try {
					Console.WriteLine ("Ingresa el escalar (número) a multiplicar por la matriz: ");
					input = Console.ReadLine ();
					val = Convert.ToInt32(input);
				} catch {
					Console.WriteLine ("Por favor, ingrese sólo números.");
					continue;
				}

				countCols = countRows = 0;
				Console.WriteLine ("Matriz ingresada: ");

				do {
					do {
						Console.Write(array[countCols,countRows]);
						countCols++;
						if(countCols != array.GetLength(0)) {
							Console.Write(" - ");
						}
					} while(countCols < array.GetLength(0));
					Console.Write("\n");
					countCols = 0;
					countRows++;
				} while(countRows < array.GetLength(1));

				countCols = countRows = 0;
				Console.WriteLine ("Matriz multiplicada: ");

				do {
					do {
						Console.Write((array[countCols,countRows])*val);
						countCols++;
						if(countCols != array.GetLength(0)) {
							Console.Write(" - ");
						}
					} while(countCols < array.GetLength(0));
					Console.Write("\n");
					countCols = 0;
					countRows++;

				} while(countRows < array.GetLength(1));

				break;
			}

			Console.ReadLine();
		}
	}
}
