using System;
using System.IO;

namespace Tarea1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[,] array;
			int cols, rows, count = 0, count2 = 0, result = 0, steps = 0;
			string input, inputCols, inputRows;

			//Este es el ciclo principal para obtener los valores de la matriz
			while (true) {

				//Se capturan los valores de la matriz
				Console.WriteLine ("Por favor, ingrese las Columnas: ");
				inputCols = Console.ReadLine();
				Console.WriteLine ("Por favor, ingrese las Renglones: ");
				inputRows = Console.ReadLine();

				//Se valida si los valores ingresados son representaciones correctas de enteros
				try {
					cols = Convert.ToInt32(inputCols);
					rows = Convert.ToInt32(inputRows);
					array = new int[cols,rows];

					//Se valida si la cantidad de elementos en el arreglo es mayor a 10 (acorde a las instrucciones)
					if(array.Length > 10) {
						Console.WriteLine ("Su Matriz: ["+cols+","+rows+"] contiene más de 10 elementos, por favor, configure una matriz más pequeña.");
						continue;
					}
				} catch {
					Console.WriteLine ("Por favor, ingrese sólo números.");
					continue;
				}

				//Este ciclo, y su ciclo anidado, capturan los valores de cada uno de los elementos (posiciones) de la matriz
				while (count < array.GetLength(0)) {
					while (count2 < array.GetLength(1)) {
						Console.WriteLine("Por favor ingrese el valor para el elemento ["+count+","+count2+"] de su matriz:");
						input = Console.ReadLine ();

						try {
							//Se hace parsing del valor ingresado, y se valida si es un entero válido
							array[count,count2] = Convert.ToInt32(input);

							//Se valida si el entero ingresado es mayor a 1000
							if (array[count,count2] < 1000) {
								Console.WriteLine ("Su número: "+array[count,count2]+" es menor a 1000, por favor, ingrese sólo valores mayores a 1000.");
								continue;
							}
						} catch {
							Console.WriteLine ("Por favor, ingrese sólo números (enteros).");
							continue;
						}

						count2++;
					}
					count2 = 0;
					count++;
				}

				count = count2 = 0;

				//Este ciclo (y su ciclo anidado) imprime valores conforme a la Conjetura de Collatz (3n+1)
				while (count < array.GetLength(0)) {
					while (count2 < array.GetLength(1)) {

						result = array [count, count2];

						//Este ciclo obtiene la cantidad de pasos para llegar a 1
						//Se repite en el siguiente paso (puede mejorar usando "Recursión", jeje...)
						while (result != 1) {
							if (result % 2 == 0) {
								result = result / 2;
							} else {
								result = (result * 3) + 1;
							}

							steps++;
						}

						Console.WriteLine("\n\nPara el valor: "+array[count,count2]+", del elemento: ["+count+","+count2+"] fueron necesarios "+steps+" pasos para llegar a 1, y son los siguientes:");

						steps = 0;
						result = array [count, count2];

						while (result != 1) {
							if (result % 2 == 0) {
								result = result / 2;
							} else {
								result = (result * 3) + 1;
							}

							Console.Write (" Paso "+(steps+1)+": " + result);
							steps++;

							if (result != 1) {
								Console.Write(" - ");
							}
						}

						steps = 0;
						count2++;
	
					}
				
					count2 = 0;
					count++;
				}

				break;

			}

			Console.WriteLine ("\n\n\nFin de la Rutina.");
			Console.ReadLine ();
		}
	}
}
