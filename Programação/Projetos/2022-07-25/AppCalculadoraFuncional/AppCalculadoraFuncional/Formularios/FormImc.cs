using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCalculadoraFuncional.RegrasDeNegocio;

namespace AppCalculadoraFuncional.Formularios
{
    public partial class FormImc : Form
    {
        public FormImc()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            var imc = new Imc();

            imc.Peso = Convert.ToDouble(txtPeso.Text);
            imc.Altura = Convert.ToDouble(txtAltura.Text);

            imc.CalcularIMC();

            txtIndice.Text = imc.Indice.ToString("F");
            txtClassificacao.Text = imc.Classificacao();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtIndice.Clear();
            txtClassificacao.Clear();
            txtPeso.Select();
        }
    }
}
