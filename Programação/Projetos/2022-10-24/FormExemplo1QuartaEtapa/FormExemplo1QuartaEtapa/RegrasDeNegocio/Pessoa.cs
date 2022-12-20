using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormExemplo1QuartaEtapa.RegrasDeNegocio
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }   

        public string ToString()
        {
            string ass = Id+";"+Nome+";"+Cpf+";"+Email;
            return ass; 
        }
    }
}
