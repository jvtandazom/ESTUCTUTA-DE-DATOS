using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();
        int capacidadMaxima = 30;
        string opcion;
        
        do
        {
            Console.WriteLine("\n--- Gestión de Fila para Atracción ---");
            Console.WriteLine("1. Agregar persona a la fila");
            Console.WriteLine("2. Asignar asiento y remover de la fila");
            Console.WriteLine("3. Mostrar estado de la fila");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    if (fila.Count < capacidadMaxima)
                    {
                        Console.Write("Ingrese el nombre de la persona: ");
                        string nombre = Console.ReadLine();
                        fila.Enqueue(nombre);
                        Console.WriteLine($"{nombre} ha sido agregado a la fila.");
                    }
                    else
                    {
                        Console.WriteLine("La fila está llena. No se pueden agregar más personas.");
                    }
                    break;

                case "2":
                    if (fila.Count > 0)
                    {
                        string asignado = fila.Dequeue();
                        Console.WriteLine($"{asignado} ha sido asignado a un asiento y removido de la fila.");
                    }
                    else
                    {
                        Console.WriteLine("No hay personas en la fila para asignar asientos.");
                    }
                    break;

                case "3":
                    if (fila.Count > 0)
                    {
                        Console.WriteLine("Personas en la fila:");
                        foreach (var persona in fila)
                        {
                            Console.WriteLine(persona);
                        }
                    }
                    else
                    {
                        Console.WriteLine("La fila está vacía.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        } while (opcion != "4");
    }
}
