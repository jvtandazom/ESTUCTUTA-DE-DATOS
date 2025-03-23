
using System;

class Nodo
{
    public int Valor;
    public Nodo Izquierda;
    public Nodo Derecha;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierda = null;
        Derecha = null;
    }
}

class ArbolBinario
{
    private Nodo Raiz;

    public ArbolBinario()
    {
        Raiz = null;
    }

    public void Insertar(int valor)
    {
        Raiz = InsertarRec(Raiz, valor);
    }

    private Nodo InsertarRec(Nodo raiz, int valor)
    {
        if (raiz == null)
        {
            raiz = new Nodo(valor);
            return raiz;
        }

        if (valor < raiz.Valor)
            raiz.Izquierda = InsertarRec(raiz.Izquierda, valor);
        else if (valor > raiz.Valor)
            raiz.Derecha = InsertarRec(raiz.Derecha, valor);

        return raiz;
    }

    public void Eliminar(int valor)
    {
        Raiz = EliminarRec(Raiz, valor);
    }

    private Nodo EliminarRec(Nodo raiz, int valor)
    {
        if (raiz == null) return raiz;

        if (valor < raiz.Valor)
            raiz.Izquierda = EliminarRec(raiz.Izquierda, valor);
        else if (valor > raiz.Valor)
            raiz.Derecha = EliminarRec(raiz.Derecha, valor);
        else
        {
            if (raiz.Izquierda == null)
                return raiz.Derecha;
            else if (raiz.Derecha == null)
                return raiz.Izquierda;

            raiz.Valor = MinValor(raiz.Derecha);
            raiz.Derecha = EliminarRec(raiz.Derecha, raiz.Valor);
        }

        return raiz;
    }

    private int MinValor(Nodo raiz)
    {
        int minv = raiz.Valor;
        while (raiz.Izquierda != null)
        {
            minv = raiz.Izquierda.Valor;
            raiz = raiz.Izquierda;
        }
        return minv;
    }

    public bool Buscar(int valor)
    {
        return BuscarRec(Raiz, valor);
    }

    private bool BuscarRec(Nodo raiz, int valor)
    {
        if (raiz == null) return false;
        if (raiz.Valor == valor) return true;

        if (valor < raiz.Valor)
            return BuscarRec(raiz.Izquierda, valor);
        else
            return BuscarRec(raiz.Derecha, valor);
    }

    public void InOrden()
    {
        InOrdenRec(Raiz);
    }

    private void InOrdenRec(Nodo raiz)
    {
        if (raiz != null)
        {
            InOrdenRec(raiz.Izquierda);
            Console.Write(raiz.Valor + " ");
            InOrdenRec(raiz.Derecha);
        }
    }

    public void PreOrden()
    {
        PreOrdenRec(Raiz);
    }

    private void PreOrdenRec(Nodo raiz)
    {
        if (raiz != null)
        {
            Console.Write(raiz.Valor + " ");
            PreOrdenRec(raiz.Izquierda);
            PreOrdenRec(raiz.Derecha);
        }
    }

    public void PostOrden()
    {
        PostOrdenRec(Raiz);
    }

    private void PostOrdenRec(Nodo raiz)
    {
        if (raiz != null)
        {
            PostOrdenRec(raiz.Izquierda);
            PostOrdenRec(raiz.Derecha);
            Console.Write(raiz.Valor + " ");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArbolBinario arbol = new ArbolBinario();
        int opcion, valor;

        do
        {
            Console.WriteLine("\nMenú de Operaciones con Árbol Binario");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Eliminar");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("4. Recorrido In-Orden");
            Console.WriteLine("5. Recorrido Pre-Orden");
            Console.WriteLine("6. Recorrido Post-Orden");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el valor a insertar: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Insertar(valor);
                    break;
                case 2:
                    Console.Write("Ingrese el valor a eliminar: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Eliminar(valor);
                    break;
                case 3:
                    Console.Write("Ingrese el valor a buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    if (arbol.Buscar(valor))
                        Console.WriteLine("Valor encontrado.");
                    else
                        Console.WriteLine("Valor no encontrado.");
                    break;
                case 4:
                    Console.WriteLine("Recorrido In-Orden:");
                    arbol.InOrden();
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("Recorrido Pre-Orden:");
                    arbol.PreOrden();
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("Recorrido Post-Orden:");
                    arbol.PostOrden();
                    Console.WriteLine();
                    break;
                case 7:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 7);
    }
}
