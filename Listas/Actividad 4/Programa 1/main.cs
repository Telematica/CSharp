using System.IO;
using System;

class Program
{
    static void Main()
    {
        double count = 0, counter = 0, ingresado;
        string input;
        
        while(true)
        {
            Console.WriteLine("Ingrese un número (usted ha ingresado " + count + " números): ");
            input = Console.ReadLine();
            
            try
            {
                ingresado = Convert.ToInt32(input);    
            }
            catch
            {
                Console.WriteLine("Por favor, ingrese sólo números.");
                continue;
            }

            if (ingresado >= 100)
            {
                Console.WriteLine("Por favor, ingrese un número menor a 100.");
                continue;
            }

            if (ingresado == 0)
            {
                Console.WriteLine("Usted introdujo: " + count + " números.");
                Console.WriteLine("La suma de dichos números es: " + counter);
                Console.WriteLine("El promedio es: " + (counter/count));
                break;
            }
            
            count++;
            counter += ingresado;
        }
        
        Console.ReadLine();
    }
}