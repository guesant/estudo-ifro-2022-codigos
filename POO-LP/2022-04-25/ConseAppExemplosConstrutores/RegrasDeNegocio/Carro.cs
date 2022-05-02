using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConseAppExemplosConstrutores.RegrasDeNegocio
{
    internal class Carro
    {
        private string corDoCarro;
        private string modeloCarro;
        private int anoFabricacao;
        private string placa;

        public Carro(string modeloCarro, string corDoCarro, int anoFabricacao, string placa)
        {
            this.ModeloCarro = modeloCarro;
            this.CorDoCarro = corDoCarro;
            this.Placa = placa;
            this.AnoFabricacao = anoFabricacao;
        }

        public string CorDoCarro
        {
            get { return corDoCarro; }
            set { corDoCarro = value; }
        }

        public string ModeloCarro
        {
            get { return modeloCarro; }
            set { modeloCarro = value; }
        }

        public int AnoFabricacao
        {
            get { return anoFabricacao; }
            set { anoFabricacao = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
    }
}
