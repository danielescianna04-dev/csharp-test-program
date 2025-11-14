using System;
using System.Collections.Generic;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Programma di Test C# ===\n");

            // Test 1: Saluto personalizzato
            Console.Write("Come ti chiami? ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Ciao, {nome}!\n");

            // Test 2: Calcoli semplici
            Console.WriteLine("--- Calcolatrice Semplice ---");
            int a = 10;
            int b = 5;
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}\n");

            // Test 3: Lista e ciclo
            Console.WriteLine("--- Lista di Numeri ---");
            List<int> numeri = new List<int> { 1, 2, 3, 4, 5 };
            foreach (int numero in numeri)
            {
                Console.WriteLine($"Numero: {numero}, Quadrato: {numero * numero}");
            }

            Console.WriteLine("\nProgramma terminato. Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}
