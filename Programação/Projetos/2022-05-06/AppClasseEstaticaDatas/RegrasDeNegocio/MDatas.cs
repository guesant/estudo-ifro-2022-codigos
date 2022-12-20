using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClasseEstaticaDatas.RegrasDeNegocio
{
    internal static class MDatas
    {
        public static DateTime CarregarData(string entradaDataNascimento)
        {
            if(entradaDataNascimento == "") {
                return DateTime.Today;
            }

            // Índice x Data
            // 0 1 2 3 4 5 6 7 8 9 
            // 0 0 / 1 1 / 2 0 0 0

            int dia = Convert.ToInt32(entradaDataNascimento.Substring(0, 2));
            int mes = Convert.ToInt32(entradaDataNascimento.Substring(3, 2));
            int ano = Convert.ToInt32(entradaDataNascimento.Substring(6, 4));

            return new DateTime(ano, mes, dia);
        }

        static public int CalcularIdade(string entradaDataNascimento, string entradaDataAlvo)
        {
            DateTime dataNascimento = CarregarData(entradaDataNascimento);

            DateTime dataAlvo = CarregarData(entradaDataAlvo);

            TimeSpan diff = dataAlvo - dataNascimento;

            int idade = (int)(diff.Days / 365.2425);

            return idade;
        }

        public static int CalcularMesesDeVida(string entradaDataNascimento, string entradaDataAlvo)
        {
            DateTime dataNascimento = CarregarData(entradaDataNascimento);

            DateTime dataAlvo = CarregarData(entradaDataAlvo);

            TimeSpan diff = dataAlvo - dataNascimento;

            int meses = (int)(diff.Days / 30.436875);

            return meses;
        }

        public static int CalcularDiasDeVida(string entradaDataNascimento, string entradaDataAlvo)
        {
            DateTime dataNascimento = CarregarData(entradaDataNascimento);

            DateTime dataAlvo = CarregarData(entradaDataAlvo);

            TimeSpan diff = dataAlvo - dataNascimento;

            int dias = diff.Days;            

            return dias;
        }
    }
}
