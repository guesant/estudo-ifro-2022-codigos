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
    public partial class FormConverterParaHec : Form
    {
        public FormConverterParaHec()
        {
            InitializeComponent();
        }

        private void FormConverterParaHec_Load(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            var conversor = new Conversao();
            conversor.Alqueire = Convert.ToDouble(txtAlqueire.Text);
            
            conversor.ConverterParaHectare();
            
            txtHectares.Text = Convert.ToString(conversor.Hectare);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAlqueire_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btCalcular_Click(sender, e);
            }
        }
    }
}
