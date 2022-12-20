using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExemploSobrecarga.RegrasDeNegocio
{
    internal class Pessoa
    {
        private string nome = string.Empty;
        private int idade;
        private double salario;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public Pessoa(string nome, string idade)
        {
            this.nome = nome;
            this.idade = Convert.ToInt32(idade);
        }

        public Pessoa(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public Pessoa()
        {
            this.salario = 1500.00;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public bool VerificarCpf(string cpf)
        {
            return true;
        }

        public bool VerificarCpf(long cpf)
        {
            return true;
        }
    }
}
