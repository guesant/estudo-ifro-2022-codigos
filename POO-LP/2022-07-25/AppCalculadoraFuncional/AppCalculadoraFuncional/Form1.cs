using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCalculadoraFuncional.Formularios;

namespace AppCalculadoraFuncional
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btAlcParaHec_Click(object sender, EventArgs e)
        {
            var form = new FormConverterParaHec();
            form.ShowDialog();
            // form.Show();
        }

        private void btHecParaAlq_Click(object sender, EventArgs e)
        {
            var form = new FormConverterParaAlc();
            form.ShowDialog();
        }

        private void btIMC_Click(object sender, EventArgs e)
        {
            var form = new FormImc();
            form.ShowDialog();
        }

        private void btFiguasGeometricas_Click(object sender, EventArgs e)
        {
            var form = new FormFiguraGeometrica();
            form.ShowDialog();
        }

        private void btCalcularArea_Click(object sender, EventArgs e)
        {
            var form = new FormFiguraGeometricaAA();
            form.ShowDialog();
        }
    }
}
