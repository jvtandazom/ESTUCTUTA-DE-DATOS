
// Clase Nodo que representa un elemento de la lista enlazada
public class Nodo
{
    public int Valor;
    public Nodo Siguiente;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

// Clase ListaEnlazada que contiene métodos para manipular la lista
public class ListaEnlazada
{
    private Nodo cabeza;

    // Método para agregar un nodo al final de la lista
    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    // Método para calcular el número de elementos en la lista
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // Método para imprimir la lista
    public void Imprimir()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    // Método para eliminar nodos fuera de un rango
    public void EliminarFueraDeRango(int minimo, int maximo)
    {
        while (cabeza != null && (cabeza.Valor < minimo || cabeza.Valor > maximo))
        {
            cabeza = cabeza.Siguiente;
        }

        Nodo actual = cabeza;
        while (actual != null && actual.Siguiente != null)
        {
            if (actual.Siguiente.Valor < minimo || actual.Siguiente.Valor > maximo)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
            else
            {
                actual = actual.Siguiente;
            }
        }
    }
}

// Clase principal
class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        Random random = new Random();

        // Crear una lista enlazada con 50 números aleatorios entre 1 y 999
        for (int i = 0; i < 50; i++)
        {
            lista.Agregar(random.Next(1, 1000));
        }

        Console.WriteLine("Lista original:");
        lista.Imprimir();

        Console.WriteLine($"Número de elementos en la lista: {lista.ContarElementos()}");

        // Leer rango desde el teclado
        Console.Write("Ingrese el valor mínimo del rango: ");
        int minimo = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo del rango: ");
        int maximo = int.Parse(Console.ReadLine());

        // Eliminar nodos fuera del rango
        lista.EliminarFueraDeRango(minimo, maximo);

        Console.WriteLine("Lista después de eliminar elementos fuera del rango:");
        lista.Imprimir();
    }
}
