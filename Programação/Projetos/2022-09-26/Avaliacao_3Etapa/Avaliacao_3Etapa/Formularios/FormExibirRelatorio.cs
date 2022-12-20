using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avaliacao_3Etapa.Contexto;

namespace Avaliacao_3Etapa.Formularios
{
    public partial class FormExibirRelatorio : Form
    {
        public FormExibirRelatorio()
        {
            InitializeComponent();

            Dados banco = new Dados();

            bsRelatorios.DataSource = banco.RelatorioOcorrencia;
            dtRelatorio.DataSource = bsRelatorios;
        }
    }
}
