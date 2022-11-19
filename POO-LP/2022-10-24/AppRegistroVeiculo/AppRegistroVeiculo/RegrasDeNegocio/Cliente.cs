using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRegistroVeiculo.RegrasDeNegocio
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }

        public string ToString()
        {
            return $"{Id};{Cpf};{Nome}";
        }
    }
}
