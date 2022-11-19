using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel.RegrasDeNegocio
{
    internal class ConsultaHospedagem
    {
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public int IdCliente { get; set; }

        public int IdQuarto { get; set; }

        public string Cpf { get; set; }
        public string Nome { get; set; }

        public string Tipo { get; set; }//descrição do quarto

        public double ValorDiaria { get; set; }

        public double ValorAPagar { get; set; }


    }
}
