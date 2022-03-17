using System;

namespace Curso

{
     class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double a =  Largura * Altura;
            return a;
        }

        public double Perimetro()
        {
            double p = Largura + Largura + Altura + Altura;
            return p;
        }

        public double Diagonal()
        {
            double d = Math.Sqrt((Largura * Largura) + (Altura * Altura));
            return d;
        }
    }
}
