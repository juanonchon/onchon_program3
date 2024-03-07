namespace funciones
{
    internal class Program{
        static void Main(string[] args)
        {
            
            int valor = suma_numeros(1, 2, 2);
            Console.WriteLine(valor);
            Console.WriteLine();

        }
        static int suma_numeros(int numero1, int numero2, int numero3)
        {
            int respuesta=0;
            respuesta = numero1 + numero2 + numero3;
            

            return respuesta;
        }

    }
}