using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
          double area = Largura * Altura;
            return area;
        }

        public double Perimetro()
        {
            double peri = (Largura + Altura) * 2;
            return peri;
        }

        public double Diagonal()
        {
            double diag = Math.Sqrt(Largura * Largura + Altura * Altura);
            return diag;
                 
        }
    }
}
