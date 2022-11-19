using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadoraFuncional.RegrasDeNegocio
{
    internal class FiguraGeometrica
    {
        public double Altura { get; set; }

        public double Base { get; set; }

        public double DiagonalMaior { get; set; }
        
        public double DiagonalMenor { get; set; }


        public double Area { get; set;  }

        public void CalcularAreaDoRetangulo()
        {
            Area = Altura * Base;
        }

        public void CalcularAreaDoTrianguloRetangulo()
        {
            Area = (Altura * Base) / 2;
        }

        public void CalcularAreaDoLosangulo()
        {
            Area = (DiagonalMaior * DiagonalMenor) / 2;
        }
    }
}
