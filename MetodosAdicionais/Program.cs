namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.Insert(11, "AQUI "));
            Console.WriteLine(texto.Remove(11, 5));
            Console.WriteLine(texto.Length);
        }
    }
}