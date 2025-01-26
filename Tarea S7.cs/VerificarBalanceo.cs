using System;
using System.Collections.Generic;

class VerificarBalanceo
{
    public static bool EsBalanceado(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char caracter in expresion)
        {
            if (caracter == '(' || caracter == '[' || caracter == '{')
            {
                pila.Push(caracter);
            }
            else if (caracter == ')' || caracter == ']' || caracter == '}')
            {
                if (pila.Count == 0) return false;

                char tope = pila.Pop();

                if (!Coinciden(tope, caracter)) return false;
            }
        }

        return pila.Count == 0;
    }

    private static bool Coinciden(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '[' && cierre == ']') ||
               (apertura == '{' && cierre == '}');
    }

    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese la expresión a verificar:");
        string expresion = Console.ReadLine();

        if (EsBalanceado(expresion))
        {
            Console.WriteLine("La expresión está balanceada.");
        }
        else
        {
            Console.WriteLine("La expresión no está balanceada.");
        }
    }
}