using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        int totalCiudadanos = 500;
        int totalPfizer = 75;
        int totalAstraZeneca = 75;
        
        HashSet<string> ciudadanos = new HashSet<string>();
        HashSet<string> vacunadosPfizer = new HashSet<string>();
        HashSet<string> vacunadosAstraZeneca = new HashSet<string>();
        HashSet<string> vacunadosAmbas = new HashSet<string>();

        for (int i = 1; i <= totalCiudadanos; i++)
        {
            ciudadanos.Add($"Ciudadano {i}");
        }
        
        Random rand = new Random();
        List<string> ciudadanosLista = ciudadanos.ToList();
        
        for (int i = 0; i < totalPfizer; i++)
        {
            vacunadosPfizer.Add(ciudadanosLista[rand.Next(totalCiudadanos)]);
        }
        
        for (int i = 0; i < totalAstraZeneca; i++)
        {
            vacunadosAstraZeneca.Add(ciudadanosLista[rand.Next(totalCiudadanos)]);
        }
        
        vacunadosAmbas = new HashSet<string>(vacunadosPfizer.Intersect(vacunadosAstraZeneca));
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos.Except(vacunadosPfizer).Except(vacunadosAstraZeneca));
        HashSet<string> vacunadosPfizerSolo = new HashSet<string>(vacunadosPfizer.Except(vacunadosAstraZeneca));
        HashSet<string> vacunadosAstraZenecaSolo = new HashSet<string>(vacunadosAstraZeneca.Except(vacunadosPfizer));

        string folderPath = "tarea_semana_10";
        Directory.CreateDirectory(folderPath);
        string filePath = Path.Combine(folderPath, "reporte_vacunacion.txt");
        
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Listado de ciudadanos NO vacunados:");
            writer.WriteLine(string.Join("\n", noVacunados));
            writer.WriteLine("\nListado de ciudadanos con ambas vacunas:");
            writer.WriteLine(string.Join("\n", vacunadosAmbas));
            writer.WriteLine("\nListado de ciudadanos vacunados SOLO con Pfizer:");
            writer.WriteLine(string.Join("\n", vacunadosPfizerSolo));
            writer.WriteLine("\nListado de ciudadanos vacunados SOLO con AstraZeneca:");
            writer.WriteLine(string.Join("\n", vacunadosAstraZenecaSolo));
        }

        Console.WriteLine("Reporte generado en la carpeta: " + folderPath);
    }
}