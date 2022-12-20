using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRegistroVeiculo.RegrasDeNegocio
{
    internal class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }

        public double ValorDaVenda { get; set; }

        public int VeiculoId { get; set; } // fk

        public int ClienteId { get; set; } // fk

        public string ToString()
        {
            return $"{Id};{DataVenda};{ValorDaVenda};{VeiculoId};{ClienteId}";
        }
    }
}
