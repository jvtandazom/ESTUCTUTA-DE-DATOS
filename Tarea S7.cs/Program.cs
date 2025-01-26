using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Verificar balanceo de expresiones matemáticas");
        Console.WriteLine("2. Resolver Torres de Hanoi");
        Console.Write("Opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                VerificarBalanceo.Ejecutar();
                break;
            case 2:
                TorresDeHanoi.Ejecutar();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}