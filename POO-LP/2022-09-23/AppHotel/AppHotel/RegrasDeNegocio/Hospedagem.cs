using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel.RegrasDeNegocio
{
    internal class Hospedagem
    {
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public int IdCliente { get; set; }

        public int IdQuarto { get; set; }
    }
}
