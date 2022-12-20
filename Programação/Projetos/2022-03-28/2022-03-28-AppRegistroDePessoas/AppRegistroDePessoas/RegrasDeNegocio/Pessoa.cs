using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRegistroDePessoas.RegrasDeNegocio
{
    internal class Pessoa
    {
        // propriedades
        private string nome;
        private string registroGeral;
        private int idade;

        // métodos de acesso

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string RegistroGeral { 
            get { return registroGeral; } 
            set { registroGeral = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
    }
}
