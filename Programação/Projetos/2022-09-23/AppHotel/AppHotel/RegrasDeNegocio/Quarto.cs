using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel.RegrasDeNegocio
{
    internal class Quarto
    {
        public int Id { get; set; }
        
        public string Tipo { get; set; }//descrição do quarto

        public double ValorDiaria { get; set; }
    }
}
