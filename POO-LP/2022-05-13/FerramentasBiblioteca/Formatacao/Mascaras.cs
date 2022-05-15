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
       
    // MICROSOFT, PQ VC ME.ODEIA?w
    }
}
