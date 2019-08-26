using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicios_De_Lista {
    class Empregado {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregado(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void aumento(double porcentagem) {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString() {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
    

