using System;
using System.IO;

namespace Tarea1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float[] asignaturas;
			float promedio = 0;
			int count = 1;
			string input;

			while (true) {
				Console.WriteLine ("Ingrese la cantidad de asignaturas de su semestre: ");
				input = Console.ReadLine ();

				try {
					asignaturas = new float[Convert.ToInt32(input)];
				} catch {
					Console.WriteLine ("Por favor, ingrese sólo números.");
					continue;
				}

				while (count <= asignaturas.Length) {
					try {
						Console.WriteLine ("Ingrese la calificación correspondiente a la asignatura número "+count+": ");
						input = Console.ReadLine ();
						asignaturas[count-1] = float.Parse(input);
					} catch {
						Console.WriteLine ("Por favor, ingrese sólo números.");
						continue;
					}

					count++;
				}

				for (int i=0; i<asignaturas.Length; i++) {
					promedio += asignaturas [i];
				}

				Console.WriteLine ("Usted cursó "+asignaturas.Length+" asignaturas, y su promedio es de: " + (promedio/asignaturas.Length));
				break;
			}

			Console.ReadLine();
		}
	}
}
