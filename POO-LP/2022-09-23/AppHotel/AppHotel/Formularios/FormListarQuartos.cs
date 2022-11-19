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
    public partial class FormListarQuartos : Form
    {
        Dados banco;

        public FormListarQuartos()
        {
            InitializeComponent();

            banco = new Dados();

            bsQuartos.DataSource = banco.ListarQuartos;
            dgvQuartos.DataSource = bsQuartos;
        }
    }
}
