using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPythonParaEstacionamentoJava.RegrasDeNegocio
{
    internal class Vaga
    {
        public int Id { get; set; }

        public int Numero { get; set; }
        
        public int? VeiculoId { get; set; }

        public override string ToString()
        {
            return $"{Id};{Numero};{VeiculoId}";
        }

        public static Vaga FromString(string linhaBruta)
        {
            string[] dados = linhaBruta.Split(';');

            Vaga vaga = new Vaga();

            vaga.Id = Convert.ToInt32(dados[0]);
            vaga.Numero = Convert.ToInt32(dados[1]);
            vaga.VeiculoId = null;

            if(dados[2] != "")
            {
                vaga.VeiculoId = Convert.ToInt32(dados[2]);
            }

            return vaga;
        }
    }
}
