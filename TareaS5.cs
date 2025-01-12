// Ejercicio 1 - Mostrar asignaturas de un curso
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de asignaturas
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        Console.WriteLine("Asignaturas del curso:");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine("- " + asignatura);
        }
    }
}

// Ejercicio 2 - Mostrar asignaturas con el mensaje personalizado
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de asignaturas
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        Console.WriteLine("Asignaturas que estoy estudiando:");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}

// Ejercicio 3 - Números ganadores de la lotería
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numerosGanadores = new List<int>();

        Console.WriteLine("Ingrese los números ganadores de la lotería primitiva (6 números):");
        while (numerosGanadores.Count < 6)
        {
            Console.Write($"Número {numerosGanadores.Count + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
            {
                numerosGanadores.Add(numero);
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }

        numerosGanadores.Sort();
        Console.WriteLine("Números ganadores ordenados de menor a mayor:");
        Console.WriteLine(string.Join(", ", numerosGanadores));
    }
}

// Ejercicio 4 - Números del 1 al 10 en orden inverso
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        numeros.Reverse();

        Console.WriteLine("Números del 1 al 10 en orden inverso:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}

// Ejercicio 5 - Abecedario eliminando posiciones múltiplos de 3
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<char> abecedario = new List<char>();

        // Agregar letras al abecedario
        for (char letra = 'A'; letra <= 'Z'; letra++)
        {
            abecedario.Add(letra);
        }

        // Eliminar letras en posiciones múltiplos de 3
        for (int i = abecedario.Count - 1; i >= 0; i--)
        {
            if ((i + 1) % 3 == 0)
            {
                abecedario.RemoveAt(i);
            }
        }

        Console.WriteLine("Abecedario sin posiciones múltiplos de 3:");
        Console.WriteLine(string.Join(", ", abecedario));
    }
}
