using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicios_De_Lista {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Empregado> list = new List<Empregado>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Empregado #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Empregado(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Insira o ID do funcionário que terá aumento salarial : ");
            int procurarId = int.Parse(Console.ReadLine());

            Empregado emp = list.Find(x => x.Id == procurarId);
            if (emp != null) {
                Console.Write("Entre com á porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.aumento(porcentagem);
            }
            else {
                Console.WriteLine("Este ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de empregado atualizada:");
            foreach (Empregado obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
