using System;

class TorresDeHanoi
{
    public static void ResolverHanoi(int n, string origen, string auxiliar, string destino)
    {
        if (n == 1)
        {
            Console.WriteLine($"Mover disco 1 de {origen} a {destino}");
            return;
        }

        ResolverHanoi(n - 1, origen, destino, auxiliar);
        Console.WriteLine($"Mover disco {n} de {origen} a {destino}");
        ResolverHanoi(n - 1, auxiliar, origen, destino);
    }

    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese el número de discos:");
        int numDiscos = int.Parse(Console.ReadLine());

        Console.WriteLine("Los pasos para resolver las Torres de Hanoi son:");
        ResolverHanoi(numDiscos, "Origen", "Auxiliar", "Destino");
    }
}