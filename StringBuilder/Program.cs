using System;
using System.Text;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = new StringBuilder();
            texto.Append("Este texto é um teste");
            texto.Append("Este texto");
            texto.Append("um teste");
            texto.Append("Este é um teste");

            Console.WriteLine(texto);
        }
    }
}