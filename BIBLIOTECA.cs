using System;
using System.Collections.Generic;

class Biblioteca
{
    // Mapa para almacenar libros (ISBN como clave)
    static Dictionary<string, Dictionary<string, string>> biblioteca = new Dictionary<string, Dictionary<string, string>>();

    // Conjunto para almacenar géneros
    static HashSet<string> generos = new HashSet<string>();

    // Función para agregar un libro
    static void AgregarLibro(string isbn, string titulo, string autor, int año, string genero)
    {
        if (!biblioteca.ContainsKey(isbn))
        {
            biblioteca[isbn] = new Dictionary<string, string>
            {
                { "titulo", titulo },
                { "autor", autor },
                { "año", año.ToString() },
                { "genero", genero }
            };
            generos.Add(genero);
            Console.WriteLine($"Libro '{titulo}' agregado correctamente.");
        }
        else
        {
            Console.WriteLine("Error: El ISBN ya existe.");
        }
    }

    // Función para buscar un libro por su ISBN
    static void BuscarLibro(string isbn)
    {
        if (biblioteca.ContainsKey(isbn))
        {
            var libro = biblioteca[isbn];
            Console.WriteLine($"ISBN: {isbn}, Título: {libro["titulo"]}, Autor: {libro["autor"]}, Año: {libro["año"]}, Género: {libro["genero"]}");
        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }

    // Función para listar todos los libros
    static void ListarLibros()
    {
        if (biblioteca.Count == 0)
        {
            Console.WriteLine("No hay libros en la biblioteca.");
            return;
        }

        Console.WriteLine("Listado de libros en la biblioteca:");
        foreach (var libro in biblioteca)
        {
            var detalles = libro.Value;
            Console.WriteLine($"ISBN: {libro.Key}, Título: {detalles["titulo"]}, Autor: {detalles["autor"]}, Año: {detalles["año"]}, Género: {detalles["genero"]}");
        }
    }

    // Función para listar todos los géneros
    static void ListarGeneros()
    {
        if (generos.Count == 0)
        {
            Console.WriteLine("No hay géneros disponibles.");
            return;
        }

        Console.WriteLine("Géneros disponibles:");
        foreach (var genero in generos)
        {
            Console.WriteLine(genero);
        }
    }

    static void Main()
    {
        // Ejemplo de uso
        AgregarLibro("978-84-204-8312-5", "Cien años de soledad", "Gabriel García Márquez", 1967, "Realismo mágico");
        AgregarLibro("978-84-376-0494-7", "1984", "George Orwell", 1949, "Ciencia ficción");

        // Listar los libros y géneros
        ListarLibros();
        ListarGeneros();
    }
}
