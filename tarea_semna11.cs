
using System;
using System.Collections.Generic;

class Traductor
{
    static void Main()
    {
        // Diccionario de traducción inglés-español
        Dictionary<string, string> diccionario = new Dictionary<string, string>
        {
            {"Time", "tiempo"},
            {"Person", "persona"},
            {"Year", "año"},
            {"Way", "camino/forma"},
            {"Day", "día"},
            {"Thing", "cosa"},
            {"Man", "hombre"},
            {"World", "mundo"},
            {"Life", "vida"},
            {"Hand", "mano"},
            {"Part", "parte"},
            {"Child", "niño/a"},
            {"Eye", "ojo"},
            {"Woman", "mujer"},
            {"Place", "lugar"},
            {"Work", "trabajo"},
            {"Week", "semana"},
            {"Case", "caso"},
            {"Point", "punto/tema"},
            {"Government", "gobierno"},
            {"Company", "empresa/compañía"}
        };

        int opcion;

        do
        {
            // Menú principal
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Traducir una frase
                    Console.Write("Ingrese la frase: ");
                    string frase = Console.ReadLine();
                    string[] palabras = frase.Split(' ');

                    for (int i = 0; i < palabras.Length; i++)
                    {
                        if (diccionario.ContainsKey(palabras[i]))
                        {
                            palabras[i] = diccionario[palabras[i]];
                        }
                    }

                    Console.WriteLine("Su frase traducida es: " + string.Join(" ", palabras));
                    Console.ReadLine();
                    break;

                case 2:
                    // Agregar más palabras al diccionario
                    Console.Write("Ingrese la palabra en inglés: ");
                    string palabraIngles = Console.ReadLine();
                    Console.Write("Ingrese la traducción en español: ");
                    string traduccion = Console.ReadLine();

                    if (!diccionario.ContainsKey(palabraIngles))
                    {
                        diccionario.Add(palabraIngles, traduccion);
                        Console.WriteLine("Palabra añadida exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("La palabra ya está en el diccionario.");
                    }
                    Console.ReadLine();
                    break;

                case 0:
                    // Salir del programa
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    Console.ReadLine();
                    break;
            }

        } while (opcion != 0);
    }
}
