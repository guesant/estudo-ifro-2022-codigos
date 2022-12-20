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

namespace FormExemploRegistroArq.Formulario
{
    public partial class FormConsultarcliente : Form
    {
        public FormConsultarcliente()
        {
            InitializeComponent();
        }

        private void BuscarCliente()
        {
            
            
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Clear();
            BuscarCliente();
        }

    }
}
