using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCadastroArquivo.RegrasDeNegocio
{
    internal class Veiculos
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public string Placa { get; set; }
        public int Ano { get; set; }    

        public double Valor { get; set; }

    }
}
