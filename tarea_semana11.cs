
using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"time", "tiempo"},
        {"person", "persona"},
        {"year", "año"},
        {"way", "camino/forma"},
        {"day", "día"},
        {"thing", "cosa"},
        {"man", "hombre"},
        {"world", "mundo"},
        {"life", "vida"},
        {"hand", "mano"},
        {"part", "parte"},
        {"child", "niño/a"},
        {"eye", "ojo"},
        {"woman", "mujer"},
        {"place", "lugar"},
        {"work", "trabajo"},
        {"week", "semana"},
        {"case", "caso"},
        {"point", "punto/tema"},
        {"government", "gobierno"},
        {"company", "empresa/compañía"},
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"camino", "way"},
        {"forma", "way"},
        {"día", "day"},
        {"cosa", "thing"},
        {"hombre", "man"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"parte", "part"},
        {"niño", "child"},
        {"niña", "child"},
        {"ojo", "eye"},
        {"mujer", "woman"},
        {"lugar", "place"},
        {"trabajo", "work"},
        {"semana", "week"},
        {"caso", "case"},
        {"punto", "point"},
        {"tema", "point"},
        {"gobierno", "government"},
        {"empresa", "company"},
        {"compañía", "company"}
    };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                TraducirFrase();
            }
            else if (opcion == "2")
            {
                AgregarPalabra();
            }
            else if (opcion == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }
        }
    }

    static void TraducirFrase()
    {
        Console.Write("Ingrese la frase: ");
        string frase = Console.ReadLine();
        string[] palabras = frase.Split(' ');
        string fraseTraducida = "";

        foreach (string palabra in palabras)
        {
            string palabraLimpia = palabra.ToLower().Trim(new char[] { '.', ',', '!', '?' });
            if (diccionario.ContainsKey(palabraLimpia))
            {
                fraseTraducida += diccionario[palabraLimpia] + " ";
            }
            else
            {
                fraseTraducida += palabra + " ";
            }
        }

        Console.WriteLine("Su frase traducida es: " + fraseTraducida.Trim());
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en inglés: ");
        string palabraIngles = Console.ReadLine().ToLower();
        Console.Write("Ingrese la traducción en español: ");
        string palabraEspanol = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(palabraIngles))
        {
            diccionario.Add(palabraIngles, palabraEspanol);
            diccionario.Add(palabraEspanol, palabraIngles);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}
