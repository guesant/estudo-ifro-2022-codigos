using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConseAppExemplosConstrutores.RegrasDeNegocio
{
    internal class Pessoa
    {
        private string nome;
        private string cpf;
        private DateTime dataNasc;

        public Pessoa (string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        public void BingBingBang()
        {
            var momento = DateTime.Now;

            int anos = momento.Year - DataNasc.Year;

            if((momento.Month < DataNasc.Month) || (momento.Month == DataNasc.Month && momento.Day < DataNasc.Day))
            {
                anos--;
            }

            Console.WriteLine($"BingBingBang: Anos: {anos}.");
        }
    }
}
