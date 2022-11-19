using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exemplo1Form.RegraDeNegocio;

namespace Exemplo1Form.Formularios
{
    public partial class FormCalcular : Form
    {
        public FormCalcular()
        {
            InitializeComponent();
        }

        private void FormCalcular_Load(object sender, EventArgs e)
        {
            
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            edMedia.Clear();
            edNome.Clear();
            edNota1.Clear();
            edNota2.Clear();
            edSituacao.Clear();

            edNome.Select();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = edNome.Text;
            aluno.Nota1 = Convert.ToDouble(edNota1.Text);
            aluno.Nota2 = Convert.ToDouble(edNota2.Text);
            
            aluno.CalcularMedia(); // processamento

            edMedia.Text = aluno.Media.ToString();
            edSituacao.Text = $"{aluno.Nome}, você foi {aluno.Situacao}";
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            
            rep = MessageBox.Show("Deseja mesmo fechar?", "2A INF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(rep == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
