/*
 * Algoritmo Ricorsivo - La stessa funzione del programma chiama la propria per progredire fino a quando 
 * non raggiunge una certa condizione e passo dopo passo ritorna alla fine
 */

using System.Diagnostics;
class TestFactorial
{

    public static void Main(string[] args)
    {
        int n = 5;
        long fac = factorial(n);
        Console.WriteLine("The factorial of 5 is: " + fac);
    }

    public static long factorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return factorial(n - 1) * n;        }
    }
}
