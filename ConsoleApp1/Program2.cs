using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            //Chamar uma classe de outro arquivo: 
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            Console.WriteLine("Nome primeiro funcionario: ");
            Console.Write("Nome: ");
            Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome primeiro funcionario: ");
            Console.Write("Nome: ");
            Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine());
            //pegar media
            double media = (f1.Salario + f2.Salario) / 2.0;
            Console.WriteLine("Salario medio = " + media.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
} 
