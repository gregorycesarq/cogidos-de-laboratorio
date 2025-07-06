using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        EjemploConjunto();
    }

    static void EjemploConjunto()
    {
        HashSet<string> frutas = new HashSet<string>();

        frutas.Add("Manzana");
        frutas.Add("Banana");
        frutas.Add("Naranja");
        frutas.Add("Manzana"); // No se repite

        Console.WriteLine("Frutas en el conjunto:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        if (frutas.Contains("Banana"))
        {
            Console.WriteLine("\nEl conjunto contiene Banana.");
        }

        if (frutas.Contains("Uva"))
        {
            Console.WriteLine("El conjunto contiene Uva.");
        }
        else
        {
            Console.WriteLine("El conjunto NO contiene Uva.");
        }
    }
}
