using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ViendoQueOndav2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EL IVAN SE LA COME

            ////int cuadradoxd = resultado(5);
            //Console.WriteLine($"El cuadrado del numero 5");

            //Console.WriteLine(Cuadrado(5));
            Predicate<int> miPredicao = a => a%2 == 0;

            Console.WriteLine(Sumatoria((a, b) => a + b, 5));
            var listaNumeros = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17,
            };

            var numerosPares = listaNumeros.FindAll(miPredicao);
            
            foreach(int i in numerosPares)
            {
                Console.WriteLine(i);
            }


        }
        static public Func<int, int> resultado = a =>  a * a;


        //Esto es otra forma de hacerlo haciendole un cuerpo!!
        //static public Func<int, int> resultado = a =>
        //{
        //    return a * a;
        //};
       
        static public int Sumatoria(Func<int,int,int> sumaxd, int number)
        {
            var resultado = sumaxd(number,number);
            return resultado;
        }
        
        public static int Cuadrado(int x) 
        {
            return x*x;
        }
    }
}