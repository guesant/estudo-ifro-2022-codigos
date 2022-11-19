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
    public partial class FormFiguraGeometrica : Form
    {
        public FormFiguraGeometrica()
        {
            InitializeComponent();
        }

        FiguraGeometrica getFiguraGeometrica()
        {
            var obj = new FiguraGeometrica();
            obj.Altura = Convert.ToDouble(txtAltura.Text);
            obj.Base = Convert.ToDouble(txtBase.Text);
            return obj;
        }

        private void btnRetangulo_Click(object sender, EventArgs e)
        {
            var obj = getFiguraGeometrica();
            obj.CalcularAreaDoRetangulo();
            txtArea.Text = obj.Area.ToString();
        }

        private void btnTrianguloRetangulo_Click(object sender, EventArgs e)
        {
            var obj = getFiguraGeometrica();
            obj.CalcularAreaDoTrianguloRetangulo();
            txtArea.Text = obj.Area.ToString();
        }
    }
}
