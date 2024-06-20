using System;

namespace Fibonacci2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de termos da sequência de Fibonacci:");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                Console.WriteLine("Sequência de Fibonacci:");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(Fibonacci(i));
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro positivo.");
            }
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
