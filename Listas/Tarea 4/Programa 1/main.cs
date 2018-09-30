using System.IO;
using System;

using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<int> valueList = new List<int>();
                
        Console.WriteLine("Generando 1000 términos/valores para la serie: n^2-100n+900"); 
        
        for (int i=1;i<=1000;i++)
        {
            double res = Math.Pow(i,2)-100 * i + 900;
            if (res <0)
            {
                valueList.Add(i);
                Console.WriteLine("Cambio de signo en valor n = "+i+" : "+res);                
            }
        }
        
        Console.WriteLine("Cambio de signo para el valor de la serie, cuando n >= "+valueList[0]+" y n <= "+valueList[valueList.Count-1]);
        Console.ReadLine();
    }
}
