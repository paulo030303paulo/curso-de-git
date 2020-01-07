using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo rt = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            rt.Largura = Convert.ToDouble(Console.ReadLine());
            rt.Altura = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Area : " + rt.Area() );
           Console.WriteLine("O Perimetro e: " + rt.Perimetro());
            Console.WriteLine("A Diagonal mede: " + rt.Diagonal());
        }
    }
}
