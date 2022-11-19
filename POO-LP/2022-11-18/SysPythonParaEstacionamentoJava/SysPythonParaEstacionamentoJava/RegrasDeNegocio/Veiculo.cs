using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPythonParaEstacionamentoJava.RegrasDeNegocio
{
    internal class Veiculo
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public string Placa { get; set; }

        public string Cor { get; set; }
     
        public override string ToString()
        {
            return $"{Id};{Modelo};{Marca};{Placa};{Cor}";
        }

        public static Veiculo FromString(string registroBruto)
        {
            Veiculo registro = new Veiculo();

            string[] dados = registroBruto.Split(';');

            registro.Id = Convert.ToInt32(dados[0]);
            registro.Modelo = dados[1];
            registro.Marca = dados[2];
            registro.Placa = dados[3];
            registro.Cor = dados[4];

            return registro;
        }
    }
}
