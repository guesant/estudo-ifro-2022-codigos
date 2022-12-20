using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleAppExemploClasseEstatica.RegrasDeNegocio
{
    internal static class FormarPFePJ
    {
        public static string Limpar(string numeroSujo)
        {
            Regex padrao = new Regex("\\D");

            // remove todos os caracteres que não são dígitos [0-9]
            string numeroLimpo = padrao.Replace(numeroSujo, "");

            return numeroLimpo;
        }

        public static string FormatarCPF(string cpfSujo)
        {
            string cpfLimpo = Limpar(cpfSujo);

            string part1 = cpfLimpo.Substring(0, 3);
            string part2 = cpfLimpo.Substring(3, 3);
            string part3 = cpfLimpo.Substring(6, 3);
            string part4 = cpfLimpo.Substring(9, 2);

            string msk = $"{part1}.{part2}.{part3}- {part4}";
            
            return msk;
        }


        public static string FormatarCNPJ(string cnpjSujo)
        {
            string cnpjLimpo = Limpar(cnpjSujo);

            string part1 = cnpjLimpo.Substring(0, 2);
            string part2 = cnpjLimpo.Substring(2, 3);
            string part3 = cnpjLimpo.Substring(5, 3);
            string part4 = cnpjLimpo.Substring(8, 4);
            string part5 = cnpjLimpo.Substring(11, 2);

            string msk = $"{part1}.{part2}.{part3}/{part4}-{part5}";

            return msk;
        }
    }
}
