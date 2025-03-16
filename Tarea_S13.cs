using System;
using System.Collections.Generic;

class Program
{
    // Catálogo de revistas
    static List<string> catalogo = new List<string>
    {
        "Revista de Ciencia",
        "Revista de Tecnología",
        "Revista de Historia",
        "Revista de Arte",
        "Revista de Literatura",
        "Revista de Deportes",
        "Revista de Música",
        "Revista de Economía",
        "Revista de Moda",
        "Revista de Salud"
    };

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Catálogo de Revistas");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Buscar un título");
            Console.WriteLine("2. Salir");
            Console.Write("\nSelecciona una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Solicitar título para buscar
                Console.Write("\nIngresa el título de la revista que deseas buscar: ");
                string tituloABuscar = Console.ReadLine();

                // Buscar de manera recursiva
                if (BusquedaRecursiva(catalogo, tituloABuscar, 0))
                {
                    Console.WriteLine("\n¡Título encontrado!");
                }
                else
                {
                    Console.WriteLine("\nTítulo no encontrado.");
                }
            }
            else if (opcion == 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("\nOpción no válida.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    // Método de búsqueda recursiva
    static bool BusquedaRecursiva(List<string> catalogo, string titulo, int index)
    {
        // Caso base: Si hemos revisado todos los elementos
        if (index >= catalogo.Count)
        {
            return false;
        }

        // Si encontramos el título
        if (catalogo[index].ToLower() == titulo.ToLower())
        {
            return true;
        }

        // Llamada recursiva para el siguiente título
        return BusquedaRecursiva(catalogo, titulo, index + 1);
    }
}