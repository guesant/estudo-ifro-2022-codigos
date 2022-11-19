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
    public partial class FormFiguraGeometricaAA : Form
    {
        public FormFiguraGeometricaAA()
        {
            InitializeComponent();
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opc = cbOpcao.SelectedIndex;

            if(opc == 0)
            {
                lbValor1.Text = "DIAGONAL MAIOR: ";
                lbValor2.Text = "DIAGONAL MENOR: ";
                lbResultado.Text = "ÁREA DO LOSÂNGULO: ";
            }
            else if (opc == 1)
            {
                lbValor1.Text = "BASE: ";
                lbValor2.Text = "ALTURA: ";
                lbResultado.Text = "ÁREA DO RETÂNGULO: ";
            }
            else if (opc == 2)
            {
                lbValor1.Text = "BASE: ";
                lbValor2.Text = "ALTURA: ";
                lbResultado.Text = "ÁREA DO TRIÂNGULO RETÂNGULO: ";
            }

            if(opc == -1)
            {
                edValor1.ReadOnly = true;
                edValor2.ReadOnly = true;
            } else
            {
                edValor1.ReadOnly = false;
                edValor2.ReadOnly = false;
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int opc = cbOpcao.SelectedIndex;

            var fg = new FiguraGeometrica();            

            if (opc == 0)
            {
                fg.DiagonalMaior = Convert.ToDouble(edValor1.Text);
                fg.DiagonalMenor = Convert.ToDouble(edValor2.Text);
                
                fg.CalcularAreaDoLosangulo();
            }
            else if (opc == 1)
            {
                fg.Base = Convert.ToDouble(edValor1.Text);
                fg.Altura = Convert.ToDouble(edValor2.Text);

                fg.CalcularAreaDoRetangulo();
            }
            else if (opc == 2)
            {
                fg.Base = Convert.ToDouble(edValor1.Text);
                fg.Altura = Convert.ToDouble(edValor2.Text);

                fg.CalcularAreaDoTrianguloRetangulo();
            }


            if(opc == -1)
            {
                MessageBox.Show("Você precisa selecionar uma figura geométrica.", "Figura Geométrica Não Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                edResultado.Text = fg.Area.ToString();
            }            
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            edValor1.Text = "";
            edValor2.Text = "";
            edResultado.Text = "";
            cbOpcao.SelectedIndex = -1;
            cbOpcao.Focus();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair?", "2A INF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
