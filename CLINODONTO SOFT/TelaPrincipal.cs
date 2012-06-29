using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CLINODONTO_SOFT.telas;
using CLINODONTO_SOFT.telas.Controle_de_usuarios;
using CLINODONTO_SOFT.classes;

namespace CLINODONTO_SOFT
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            lblUsuarioativo.Text = lblUsuarioativo.Text + " " + classLogin.nomeUsuario;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConfiguracoes().ShowDialog();
        }

        private void controleDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmControle_pacientes().ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
        private void controleDeConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void agendarConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAgendamento_selecionar().ShowDialog();
        }

        private void controleDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmControle_Consultas().ShowDialog();
        }

        private void cadastrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new frmCadastrar_paciente().ShowDialog();

        }

        private void sobreOClinodontoSoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSobre().ShowDialog();
        }

         private void cadastroDeDentistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new frmBuscardentista().ShowDialog();
        }

         private void button1_Click(object sender, EventArgs e)
         {
             new frmFicha_clinica().Show();
         }

      
    }
}
