using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploDesc.RegrasDeNegocio
{
    internal class Desconto
    {
        private double valorCompra;
        private double desconto;
        
        // computed getter
        // private double valorFinal;

        public double ValorCompra
        {
            get { return valorCompra; }
            set { valorCompra = value; }
        }

        public double RazaoDesconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        public double PercentualDeDesconto
        {
            get { return desconto / 100.0; }
            set { desconto = value / 100.0; }
        }

        // não precisamos de atualizar o valorFinal sempre que o percentual
        // (juntamente com a chamda das funções CalcularDesconto*)
        // ou o valor da compra mudam, podemos fazer isso com um computed getter.
        public double ValorFinal
        {
            get { return valorCompra * (1 - RazaoDesconto); }
        }

        public void CalcularDescontoComum()
        {
            PercentualDeDesconto = 5;
        }

        public void CalcularDescontoVip()
        {
            PercentualDeDesconto = 10;
        }

        public void CalcularDescontoMaster()
        {
            PercentualDeDesconto = 15;
        }

        public void CalcularDescontoGerente(double percentual)
        {
            PercentualDeDesconto = percentual;
        }
    }
}
