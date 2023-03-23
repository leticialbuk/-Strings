using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.CompareTo("Teste"));
            Console.WriteLine(texto.CompareTo("teste"));

            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));

            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste"));
        }
    }
}