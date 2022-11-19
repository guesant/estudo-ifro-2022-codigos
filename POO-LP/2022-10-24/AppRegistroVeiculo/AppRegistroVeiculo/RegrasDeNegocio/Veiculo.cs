using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRegistroVeiculo.RegrasDeNegocio
{
    internal class Veiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public string Placa { get; set; }
        public int Ano { get; set; }

        public double Valor { get; set; }

        public string ToString()
        {
            return $"{Id};{Modelo};{Marca};{Placa};{Ano};{Valor}";
        }
    }
}
