namespace Rotar
{
    public class Program
    {
        static void Main(string[] args)
        {
            rotar();
            
        }

        static void rotar()
        {
            string numero = Console.ReadLine();
            char ultimo = numero[numero.Length - 1];
            string resto = numero.Substring(0, numero.Length - 1);
            string resultado = ultimo + resto;
            Console.WriteLine(resultado);
        }
    }
}