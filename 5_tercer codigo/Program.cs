using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        EjemploCola();
    }

    static void EjemploCola()
    {
        Queue<string> pedidos = new Queue<string>();

        pedidos.Enqueue("Pizza");
        pedidos.Enqueue("Hamburguesa");
        pedidos.Enqueue("Ensalada");

        Console.WriteLine("Pedidos actuales:");
        foreach (string pedido in pedidos)
        {
            Console.WriteLine(pedido);
        }

        string primerPedido = pedidos.Dequeue();
        Console.WriteLine($"\nAtendiendo: {primerPedido}");

        Console.WriteLine("Pedidos restantes:");
        foreach (string pedido in pedidos)
        {
            Console.WriteLine(pedido);
        }
    }
}
