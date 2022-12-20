using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FormCadastroArquivo.RegrasDeNegocio
{
    public static class ValidacoesSociais2
    {
        public static string ManterApenasNumeros(string entrada)
        {
            // \\D significa: "tudo o que não for digito" ... vai ser substituido por ""
            return new Regex("\\D").Replace(entrada, "");
        }

        public static string ColocarMascaraDoTelefone(string num)
        {
            num = ManterApenasNumeros(num);

            string ddd = num.Substring(0, 2);
            string num1 = num.Substring(2, 5);
            string num2 = num.Substring(7, 4);
            //colocar máscara

            string msk = "(" + ddd + ")-" + num1 + "-" + num2;
            return msk;
        }

        public static string ColocarMascaraDoTelefone(long num)
        {
            return ColocarMascaraDoTelefone(Convert.ToString(num));
        }

        public static string LimparCPF(string cpf)
        {
            return ManterApenasNumeros(cpf).PadLeft(11, '0').Substring(0, 11);
        }

        public static string Mensagem(string m)
        {
            return m;
        }

        public static bool ValidarCpf(string cpf)
        {
            bool verificado;
            int primeiroDigitoVerificador, primeiroDigitoVerificadorCalculado, segundoDigitoVerificador, segundoDigitoVerificadorCalculado, total = 0, peso = 10;

            cpf = LimparCPF(cpf);
            primeiroDigitoVerificador = Convert.ToInt32(cpf.Substring(9, 1));
            segundoDigitoVerificador = Convert.ToInt32(cpf.Substring(10, 1));

            for (int i = 0; i < 9; i++)
            {
                total += Convert.ToInt32(cpf.Substring(i, 1)) * peso;
                peso--;
            }

            primeiroDigitoVerificadorCalculado = 11 - (total % 11);

            if (primeiroDigitoVerificadorCalculado >= 10)
            {
                primeiroDigitoVerificadorCalculado = 0;
            }

            total = 0;
            peso = 11;

            for (int i = 0; i < 10; i++)
            {
                int digitoAtual;

                if (i < 9)
                {
                    digitoAtual = Convert.ToInt32(cpf.Substring(i, 1));

                }
                else
                {
                    digitoAtual = primeiroDigitoVerificador;
                }


                total += digitoAtual * peso;
                peso--;
            }

            segundoDigitoVerificadorCalculado = 11 - (total % 11);

            if (segundoDigitoVerificadorCalculado >= 10)
            {
                segundoDigitoVerificadorCalculado = 0;
            }

            verificado = (primeiroDigitoVerificador == primeiroDigitoVerificadorCalculado) && (segundoDigitoVerificador == segundoDigitoVerificadorCalculado);

            if (!verificado)
            {
                Console.Error.WriteLine("Inválido!");
            }

            return verificado;
        }

    }
}
