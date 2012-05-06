using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLINODONTO_SOFT.telas
{
    public partial class frmControle_pacientes : Form
    {
        public frmControle_pacientes()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new frmCadastrar_paciente().ShowDialog();
        }

        private void btnProntuario_Click(object sender, EventArgs e)
        {
            new frmProntuario().ShowDialog();
        }
    }
}
