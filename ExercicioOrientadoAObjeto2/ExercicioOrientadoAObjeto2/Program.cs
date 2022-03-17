using System;

    namespace Course
{
    class Programa2
    {
        static void Main(string[] args)
        {
            Funcionario x, y;

            x = new Funcionario();
            y = new Funcionario();

            double salariomed;

    Console.WriteLine("digite o nome do primeiro funcionário: ");
            x.Nome = string.Format(Console.ReadLine());
            Console.WriteLine("digite o sobrenome do primeiro funcionário:");
            x.SobreNome = string.Format(Console.ReadLine());
            Console.WriteLine("digite o salário do primeiro funcionário: ");
            x.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o nome do segundo funcionário: ");
            y.Nome = string.Format(Console.ReadLine());
            Console.WriteLine("digite o sobrenome do segundo funcionário:");
            y.SobreNome = string.Format(Console.ReadLine());
            Console.WriteLine("digite o salário do segundo funcionário: ");
            y.Salario = double.Parse(Console.ReadLine());

            salariomed = (x.Salario + y.Salario) / 2;
            Console.WriteLine(salariomed.ToString("F2"));


        }
    }
}