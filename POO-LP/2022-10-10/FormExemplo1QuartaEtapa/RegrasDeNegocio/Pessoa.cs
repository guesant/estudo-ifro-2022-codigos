using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormExemplo1QuartaEtapa.RegrasDeNegocio
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public string ToString()
        {
            string ass = $"{Id};{Nome};{Cpf};{Email}";
            return ass;
        }

        public static List<Pessoa> CarregarLista()
        {
            var listaPessoa = new List<Pessoa>();

            StreamReader sr = new StreamReader("cadastroPessoa.csv", true);

            while (!sr.EndOfStream)
            {
                string registro = sr.ReadLine();
                string[] dados = registro.Split(';');

                Pessoa pessoa = new Pessoa();
                pessoa.Id = Convert.ToInt32(dados[0]);
                pessoa.Nome = dados[1];
                pessoa.Cpf = dados[2];
                pessoa.Email = dados[3];

                listaPessoa.Add(pessoa);
            }

            sr.Close();

            return listaPessoa;
        }
    }
}
