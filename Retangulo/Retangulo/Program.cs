using System;

namespace Curso
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)

        {
            Retangulo x;

            x = new Retangulo();

            Console.WriteLine("Digita a largura do retângulo: ");
            x.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a altura do retângulo: ");
            x.Altura = double.Parse(Console.ReadLine());

            double area = x.Area();
            Console.WriteLine("Area = " + area.ToString("F2"));

            double perimetro = x.Perimetro();
            Console.WriteLine("Perimetro = " + perimetro.ToString("F2"));

            double diagonal = x.Diagonal();
            Console.WriteLine("Diagonal = " + diagonal.ToString("F2"));

        }
    }
}