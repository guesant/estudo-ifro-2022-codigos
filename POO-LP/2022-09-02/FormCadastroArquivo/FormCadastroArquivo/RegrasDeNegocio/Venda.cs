using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCadastroArquivo.RegrasDeNegocio
{
    internal class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        
        public int VeiculoId { get; set; }

        public int PessoaId { get; set; }


    }
}
