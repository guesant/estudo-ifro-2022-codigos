using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FormExemploRegistroArq.Formulario;

namespace FormExemploRegistroArq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

       

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar form = new FormCadastrar();
            form.ShowDialog();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            FormListarCadastro form = new FormListarCadastro();
            form.ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FormConsultarcliente form = new FormConsultarcliente();
            form.ShowDialog(); 
        }
    }
}
