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
    public partial class frmFicha_clinica_selecionar : Form
    {
        public frmFicha_clinica_selecionar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmFicha_clinica().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmFicha_clinica().ShowDialog();
        }
    }
}
