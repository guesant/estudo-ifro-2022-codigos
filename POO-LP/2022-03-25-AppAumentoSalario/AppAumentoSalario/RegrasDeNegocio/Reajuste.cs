using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAumentoSalario.RegrasDeNegocio
{
    internal class Reajuste
    {
        private double salarioAtual;
        private double razaoAumento;

        //métodos get e set

        public double SalarioAtual
        {
            get { return salarioAtual; }
            set { salarioAtual = value;}
        }

        public double PercentualDeAumento
        {
            get { return razaoAumento * 100.0;}
            set { razaoAumento = value / 100.0;}
        }

        public double SalarioReajustado
        {
            get { return SalarioAtual * (1 + razaoAumento); }
        }

        // métodos para reajuste do salário

        public void CalcularAumentoAuxiliarDeServicosGerais ()
        {
            PercentualDeAumento = 10;
        }


        public void CalcularAumentoTecnicosOperativos()
        {
            PercentualDeAumento = 15;
        }

        public void CalcularAumentoSupervisores()
        {
            PercentualDeAumento = 17;
        }

        public void CalcularAumentoLivre(double percentual)
        {
            PercentualDeAumento = percentual;
        }

    }
}
