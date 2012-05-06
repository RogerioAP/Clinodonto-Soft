using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLINODONTO_SOFT.telas.Controle_de_usuarios
{
    public partial class frmBuscardentista : Form
    {
        public frmBuscardentista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmCadastrardentista().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmNovodentista().ShowDialog();
        }
    }
}
