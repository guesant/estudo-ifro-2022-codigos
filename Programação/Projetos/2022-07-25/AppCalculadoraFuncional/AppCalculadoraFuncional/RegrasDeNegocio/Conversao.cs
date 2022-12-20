using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadoraFuncional.RegrasDeNegocio
{
    internal class Conversao
    {
        public double Hectare { get; set; }

        public double Alqueire { get; set; }

        public void ConverterParaHectare()
        {
            Hectare = Alqueire * 2.42;
        }

        public void ConverterParaAlqueire()
        {
            Alqueire = Hectare / 2.42;
        }
    }
}
