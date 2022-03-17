using System;

namespace Curso
{
    class ProgramaPrincipal
    {
        static void Main (string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("dados do funcionario: " + f);

            Console.WriteLine("\n Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcent);

            Console.WriteLine("\n dados atualizados: " + f);

        }
    }
}