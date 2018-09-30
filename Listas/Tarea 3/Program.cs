using System;
using System.IO;

namespace Tarea1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[][] maestros; //Jagged Array, Arreglo dentado
			string input;
			int cantidadEscuelas, count = 0, count2 = 0;

			while (true) {
				Console.WriteLine ("¿En cuántas escuelas has estado en tu vida académica?: ");
				input = Console.ReadLine ();

				try {
					cantidadEscuelas = Convert.ToInt32 (input);
				} catch {
					Console.WriteLine ("Por favor, ingrese sólo números.");
					continue;
				}

				maestros = new string[cantidadEscuelas][];

				while (count < cantidadEscuelas) {
					while (true) {
						Console.WriteLine ("Ingresa la cantidad de Maestros que tuviste en la escuela Número "+(count+1)+":");
						input = Console.ReadLine ();

						try {
							maestros[count] = new string[Convert.ToInt32 (input)];
						} catch {
							Console.WriteLine ("Por favor, ingresa sólo números.");
							continue;
						}

						break;
					}
					count++;
				}

				count = 0;

				while (count < cantidadEscuelas) {
					while (count2 < maestros[count].Length) {
						Console.WriteLine ("Ingresa el nombre del Maestro Número: "+(count2+1)+" de la escuela Número: "+(count+1));
						input = Console.ReadLine ();
						maestros [count] [count2] = input;
						count2++;
					}
					count2 = 0;
					count++;
				}

				count = 0; 
				count2 = 0;

				while (count < cantidadEscuelas) {
					Console.Write("\nEl arreglo "+(count+1)+" (Escuela) tiene "+maestros[count].Length+" Nombres. Los Maestro son: ");
					while (count2 < maestros[count].Length) {
						Console.Write (maestros[count][count2]);
						count2++;
						if (!(count2 == maestros [count].Length)) {
							Console.Write (", ");
						}
					}
					count2 = 0;
					count++;
				}

				break;
			}

			Console.WriteLine ("\nFin de la Rutina.");
			Console.ReadLine ();
		}
	}
}
