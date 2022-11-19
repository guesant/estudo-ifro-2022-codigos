using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1Form.RegraDeNegocio
{
    internal class Aluno
    {
        public string Nome { get; set; }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public double Media { get; set; }


        public string Situacao
        {
            get
            {
                string situacao = "REPROVADO";

                if(Media >= 60)
                {
                    situacao = "APROVADO";
                }

                return situacao;
            }
        }

        public void CalcularMedia()
        {
            this.Media = (this.Nota1 + this.Nota2) / 2;
        }
    }
}
