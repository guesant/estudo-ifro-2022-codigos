using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_3Etapa.RegrasDeNegocio
{
    internal class Infracao
    {
        public int Id { get; set; }
        public string Tipo { get; set; } //descrição da multa
        public double ValorMulta{ get; set; }
    }
}
