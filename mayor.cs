namespace Mayores
{
    internal class Program{
        static void Main(string[] args)
        {
            int Elvalor1 = 3;
            int Elvalor2 = 5;
            int Elvalor3 = 7;

            int resultado = mayor(Elvalor1, mayor(Elvalor2, Elvalor3));

        }
        static int mayor(int numer1, int numer2){

            if (numer1 > numer2){
                return numer1;
            }
            else{
                return numer2;
            }

        }
            



    }
}