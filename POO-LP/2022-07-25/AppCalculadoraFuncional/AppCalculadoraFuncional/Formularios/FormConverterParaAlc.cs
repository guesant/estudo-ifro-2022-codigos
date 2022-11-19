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
    public partial class FormConverterParaAlc : Form
    {
        public FormConverterParaAlc()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            var conversor = new Conversao();

            conversor.Hectare = Convert.ToDouble(txtHectares.Text);
            conversor.ConverterParaAlqueire();

            txtAlqueires.Text = Convert.ToString(conversor.Alqueire);
        }

        private void txtHectares_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCalcular_Click(sender, e);
            }
        }
    }
}
