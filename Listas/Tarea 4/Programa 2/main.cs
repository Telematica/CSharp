using System.IO;
using System;

using System.Collections.Generic;


class Program
{
    static void Main()
    {
        double low, high;
        string input1, input2;
        
        Comienzo:
            Console.WriteLine("Ingrese el número menor: ");
            input1 = Console.ReadLine();
            Console.WriteLine("Ingrese el número mayor: ");
            input2 = Console.ReadLine();
                
        try 
        {
            low = Convert.ToInt32(input1);
            high = Convert.ToInt32(input2);
            
            if (low > high)
            {
                Console.Write("El número menor no puede superar al mayor.");
                Console.WriteLine("Ingrese de nuevo los números.");
                goto Comienzo;
            }
            
            Program.fibonacci(low,high);
        } 
        catch 
        {  
            Console.WriteLine("Por favor, ingrese sólo números.");
            goto Comienzo;
        }
        
        Console.ReadLine();
    }
    
    public static int fibonacci(double x, double y, int step = 1)
    {
        double currF = y, nextF = x + y;
        
        Console.Write(nextF);
        
        if (step >= 100)
        {
            Console.Write("\n\nPenúltimo término de la secuencia Fibonacci ");
            Console.WriteLine("(100 iteraciones): " + currF);
            Console.Write("Último término de la secuencia Fibonacci ");
            Console.WriteLine("(100 iteraciones): " + nextF);
            
            return 1;
        }
        
        Console.Write(" - ");
        
        
        Program.fibonacci(currF, nextF,++step);
        
        return 1;
    }
}
