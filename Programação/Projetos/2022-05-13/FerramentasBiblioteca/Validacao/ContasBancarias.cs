using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerramentasBiblioteca.Validacao
{
    public static class ContasBancarias
    {
        public static bool ValidarContaBB(string agencia, string numeroConta)
        {
            int total = 0;
            int digitoVerificador, digitoVerificadorCalculado;
            
            numeroConta = numeroConta.PadLeft(9, '0').ToUpper();

            digitoVerificador = numeroConta.Substring(8, 1) == "X" ? 10 : Convert.ToInt32(numeroConta.Substring(8, 1));

            for (int i = 0; i < 8; i++)
            {
                int peso = 9 - i;
                total += Convert.ToInt32(numeroConta[i]) * peso;
            }

            digitoVerificadorCalculado = 11 - (total % 11);

            if(digitoVerificadorCalculado == 11) {
                digitoVerificadorCalculado = 0;
            }

            if(digitoVerificador != digitoVerificadorCalculado)
            {
                Console.Error.WriteLine("Inválido!");
                return false;
            }

            return true;

        }
    }
}
