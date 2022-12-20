using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExemploEstatico.RegrasDeNegocio
{
    internal class ContaCorrente
    {

        public int NumeroConta { get; set; }
        public double Valor { get; set; }
        public double Saldo { get; set; }

        private static double saldoGeral;

        public double SaldoGeral
        {
            get { return saldoGeral;  }
            set { saldoGeral = value; }
        }


        public void AtualizarSaldo()
        {
            Saldo = Saldo + Valor;
            SaldoGeral = SaldoGeral + Valor;
        }
    }
}
