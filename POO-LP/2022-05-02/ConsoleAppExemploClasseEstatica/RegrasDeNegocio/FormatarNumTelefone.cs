using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleAppExemploClasseEstatica.RegrasDeNegocio
{
    internal static class FormatarNumTelefone
    {
        public static string LimparNumero(string numTelefoneSujo)
        {
            Regex padrao = new Regex("\\D");

            // remove todos os caracteres que não são dígitos [0-9]
            string numTelefoneLimpo = padrao.Replace(numTelefoneSujo, "");

            return numTelefoneLimpo;
        }

        public static string FormatarNumero(string numTelefoneSujo)
        {
            string numTelefone = LimparNumero(numTelefoneSujo);

            string ddd = numTelefone.Substring(0, 2); // 69
            string num1 = numTelefone.Substring(2, 5); // 98888
            string num2 = numTelefone.Substring(7, 4); // 7777

            string mask = $"({ddd})-{num1}-{num2}"; // (69)-98888-7777

            return mask;
        }

       
    }
}
