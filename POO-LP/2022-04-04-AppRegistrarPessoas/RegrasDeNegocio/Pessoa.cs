using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRegistrarPessoas.RegrasDeNegocio
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private double salario;


        public string? Nome
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


    }
}
