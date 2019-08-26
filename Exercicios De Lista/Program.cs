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
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Empregado(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Insira o ID do funcionário que terá aumento salarial : ");
            int searchId = int.Parse(Console.ReadLine());

            Empregado emp = list.Find(x => x.Id == searchId);
            if (emp != null) {
                Console.Write("Entre com á porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
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
