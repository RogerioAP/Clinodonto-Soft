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
    public partial class frmFicha_clinica : Form
    {
        public frmFicha_clinica()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Odontograma().ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new frmAnamnese().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmExame_fisico().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Cadastro_Exame_Externo().ShowDialog();
        }
    }
}
