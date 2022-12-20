using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadoraFuncional.RegrasDeNegocio
{
    internal class Imc
    {
        public double Peso { get; set; }

        public double Altura { get; set; }

        public double Indice { get; set; }

        public void CalcularIMC()
        {
            Indice = Peso / (Altura * Altura);
        }

        public string Classificacao()
        {
            string situacao;

            if(Indice < 18.5)
            {
                situacao = "MAGREZA";
            }
            else if (Indice < 24.9)
            {
                situacao = "NORMAL";
            }
            else if (Indice < 29.9)
            {
                situacao = "SOBREPESO";
            }
            else if (Indice < 34.9)
            {
                situacao = "OBESIDADE GRAU I";
            }
            else if (Indice < 39.9)
            {
                situacao = "OBESIDADE GRAU II";
            }
            else
            {
                situacao = "OBESIDADE GRAU III";
            }

            return situacao;
        }
    }
}


