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
using Avaliacao_3Etapa.Formularios;

namespace Avaliacao_3Etapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Registro(); 
        }

        private void Registro()
        {
            Dados dado = new Dados();
            dado.AddLog(SystemInformation.UserName, DateTime.Now);
        }

        private void btCadastrarInfracao_Click(object sender, EventArgs e)
        {
            var form = new FormCadastrarInfracao();
            form.ShowDialog();
        }

        private void btCadastrarMorador_Click(object sender, EventArgs e)
        {
            var form = new FormCadastrarMorador();
            form.ShowDialog();
        }

        private void btCadastrarOcorrencia_Click(object sender, EventArgs e)
        {
            var form = new FormCadastrarOcorrecia();
            form.ShowDialog();
        }

        private void btExibirRelatorio_Click(object sender, EventArgs e)
        {
            var form = new FormExibirRelatorio();
            form.ShowDialog();
        }
    }
}
