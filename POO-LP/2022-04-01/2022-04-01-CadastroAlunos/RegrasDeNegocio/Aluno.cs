using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_01_CadastroAlunos.RegrasDeNegocio
{
    internal class Aluno
    {

        private string nome = "";
        private double nota1;
        private double nota2;
        private double media;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public double Media
        {
            get { return media; }
            set { media = value; }
        }

        public void CalcularMedia()
        {
            Media = (Nota1 + Nota2) / 2.0 ;
        }

        public string Situacao()
        {
            if(Media >= 70)
            {
                return "Aprovado!";
            }

            return "Reprovado.";
        }
    }
}
