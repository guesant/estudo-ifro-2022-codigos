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
    public partial class FormConsultarHospedagens : Form
    {
        Dados banco = new Dados();

        public FormConsultarHospedagens()
        {
            InitializeComponent();

            bsHospedagens.DataSource = banco.ListarHospedagem;
            dgvHospedagens.DataSource = bsHospedagens;
        }
    }
}
