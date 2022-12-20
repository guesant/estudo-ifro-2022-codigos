using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FerramentasBiblioteca.Formatacao
{
    public static class Mascaras
    {
        public static string RemoverMascaraCPF(string cpfSujo)
        {
            var cpfLimpo = new Regex("\\D").Replace(cpfSujo, "");
            return cpfLimpo;
        }

        public static string AplicarMascaraCPF(string cpfSujo)
        {
            var cpfLimpo = RemoverMascaraCPF(cpfSujo);

            // Índice x Caractere
            // 0 1 2 3 4 5 6 7 8 9 10
            // 1 1 1 2 2 2 3 3 3 9 9

            string num1 = cpfLimpo.Substring(0, 3);
            string num2 = cpfLimpo.Substring(3, 3);
            string num3 = cpfLimpo.Substring(6, 3);
            string num4 = cpfLimpo.Substring(9, 2);

            return $"{num1}.{num2}.{num3}-{num4}";
        }

        public static string RemoverMascaraTelefone(string numTelefoneSujo)
        {
            /*
            numTelefoneSujo = numTelefoneSujo.Replace("-", "");
            numTelefoneSujo = numTelefoneSujo.Replace("(", "");
            numTelefoneSujo = numTelefoneSujo.Replace(")", "");
            */

            // remove todos os caracteres que não são dígitos [0-9]
            Regex padrao = new Regex("\\D");
            string numTelefoneLimpo = padrao.Replace(numTelefoneSujo, "");            

            return numTelefoneLimpo;
        }

        public static string AplicarMascaraTelefone(string numTelefoneSujo)
        {
            string numTelefone = RemoverMascaraTelefone(numTelefoneSujo);

            // 6 9 9 8 8 8 8 7 7 7 7
            // 0 1 2 3 4 5 6 7 8 9 10

            string ddd = numTelefone.Substring(0, 2); // 69
            string num1 = numTelefone.Substring(2, 5); // 98888
            string num2 = numTelefone.Substring(7, 4); // 7777

            string mask = $"({ddd})-{num1}-{num2}"; // (69)-98888-7777

            return mask;
        }

    }
}
