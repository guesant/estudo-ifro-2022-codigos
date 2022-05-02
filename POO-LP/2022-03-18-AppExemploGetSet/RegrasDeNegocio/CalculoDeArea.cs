using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploGetSet.RegrasDeNegocio
{
    internal class CalculoDeArea
    {
        private int ladoA;
        private int ladoB;
        private int area;
        
        private string unidadeDeMedida = "U.M.";


        public int LadoA
        {
            get { return ladoA; } // saída
            set { 
                ladoA = value;
                CalcularArea();
            } // entrada
        }

        public int LadoB
        {
            get { return ladoB; } // saída
            set { 
                ladoB = value;
                CalcularArea();
            } // entrada
        }

        public int Area
        {
            // get { return LadoA * LadoB; } // saída
            get { return area; }
        }

        public string UnidadeDeMedida
        {
            get { return unidadeDeMedida; }
            set { unidadeDeMedida = value; }
        }

        public void CalcularArea()
        {
            area = ladoA * ladoB;
        }

        public void MostrarArea()
        {
            Console.WriteLine($"- Área 1: {Area} {UnidadeDeMedida}²;");
        }
    }
}
