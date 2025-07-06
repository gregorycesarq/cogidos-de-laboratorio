using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        EjemploPila();
    }

    static void EjemploPila()
    {
        Stack<int> libros = new Stack<int>();

        libros.Push(101);
        libros.Push(102);
        libros.Push(103);

        Console.WriteLine("Libros en la pila (de arriba a abajo):");
        foreach (int libro in libros)
        {
            Console.WriteLine(libro);
        }

        int ultimoLibro = libros.Pop();
        Console.WriteLine($"\nSe ha sacado el libro: {ultimoLibro}");

        Console.WriteLine("Libros restantes en la pila:");
        foreach (int libro in libros)
        {
            Console.WriteLine(libro);
        }
    }
}
