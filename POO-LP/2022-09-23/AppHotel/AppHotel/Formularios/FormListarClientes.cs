using AppHotel.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHotel.Formularios
{
    public partial class FormListarClientes : Form
    {
        Dados banco;
        
        public FormListarClientes()
        {
            InitializeComponent();

            banco = new Dados();

            bsClientes.DataSource = banco.ListarClientes;
            dgvClientes.DataSource = bsClientes;
        }
    }
}
