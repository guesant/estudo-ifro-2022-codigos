using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_3Etapa.RegrasDeNegocio
{
    internal class Relatorio
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public int IdMorador { get; set; }

        public int IdInfracao { get; set; }

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public string Tipo { get; set; }//descrição da multa

        public double ValorMulta { get; set; }

        public double ValorAPagar { get; set; }
    }
}
