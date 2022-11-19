using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPythonParaEstacionamentoJava.RegrasDeNegocio
{
    internal class Estacionamento
    {
        public int Id { get; set; }

        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public double ValorHora { get; set; }
        public int VeiculoId { get; set; }
        public int VagaId { get; set; }

        public override string ToString()
        {
            return $"{Id};{DataEntrada};{DataSaida};{ValorHora};{VeiculoId};{VagaId}";
        }

        public static Estacionamento FromString(string registroBruto)
        {
            Estacionamento registro = new Estacionamento();

            string[] dados = registroBruto.Split(';');

            registro.Id = Convert.ToInt32(dados[0]);
            registro.DataEntrada = Convert.ToDateTime(dados[1]);
          
            if (dados[2] != "")
            {
                registro.DataSaida = Convert.ToDateTime(dados[2]);
            }
           
            registro.ValorHora = Convert.ToDouble(dados[3]);
            registro.VeiculoId = Convert.ToInt32(dados[4]);
            registro.VagaId = Convert.ToInt32(dados[5]);

            return registro;
        }
    }
}
