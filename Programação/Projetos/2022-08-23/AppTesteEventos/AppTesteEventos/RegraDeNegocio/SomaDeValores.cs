using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTesteEventos.RegraDeNegocio
{
    internal class SomaDeValores
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }

        public double Total { get; set; }

        public void Calcular()
        {
            Total = Valor1 + Valor2; 
        }
    }
}
