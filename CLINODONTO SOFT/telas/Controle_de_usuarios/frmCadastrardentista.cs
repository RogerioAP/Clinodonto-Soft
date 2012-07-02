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
    public partial class frmCadastrardentista : Form
    {
        public frmCadastrardentista()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmExpediente().ShowDialog();
        }

        //limpa todos campos
        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtRG.Text = string.Empty;
            mkdCPF.Text = string.Empty;
            mkdTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mkdCelular.Text = string.Empty;
            cbxSexo.Text = string.Empty;
            cbxUFMedico.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtCRO.Text = string.Empty;
            cbxUFProfissional.Text = string.Empty;
            txtEspecialidade.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //verifica se existe algum campo em branco
            if (txtNome.Text == string.Empty || txtEndereco.Text == string.Empty || txtRG.Text == string.Empty
                || mkdCPF.Text == string.Empty || mkdTelefone.Text == string.Empty || txtEmail.Text == string.Empty
                || mkdCelular.Text == string.Empty || cbxSexo.Text == string.Empty || cbxUFProfissional.Text == string.Empty
                || txtCidade.Text == string.Empty || txtCRO.Text == string.Empty || cbxUFProfissional.Text == string.Empty
                || txtEspecialidade.Text == string.Empty)
            {
                MessageBox.Show("O campos com * não podem ser nulos!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //caso os campos estiverem corretamente preenchidos...


            }
        }

        public void MudarLabel()
        {
            lblNome.Text = "Nome: *";
            lblEndereco.Text = "Endereço: *";
            lblRG.Text = "RG: *";
            lblCPF.Text = "CPF: *";
            lblTelefone.Text = "Telefone: *";
            lblEmail.Text = "Email: *";
            lblCelular.Text = "Celular: *";
            lblSexo.Text = "Sexo: *";
            lblUFPessoal.Text = "UF: *";
            lblCidade.Text = "Cidade: *";
            lblCRO.Text = "CRO: *";
            lblUFProfissional.Text = "UF: *";
            lblEspecialidade.Text = "Especialidade: *";

            lblNome.ForeColor = Color.Red;
            lblEndereco.ForeColor = Color.Red;
            lblRG.ForeColor = Color.Red;
            lblCPF.ForeColor = Color.Red;
            lblTelefone.ForeColor = Color.Red;
            lblEmail.ForeColor = Color.Red;
            lblCelular.ForeColor = Color.Red;
            lblSexo.ForeColor = Color.Red;
            lblUFPessoal.ForeColor = Color.Red;
            lblCidade.ForeColor = Color.Red;
            lblCRO.ForeColor = Color.Red;
            lblUFProfissional.ForeColor = Color.Red;
            lblEspecialidade.ForeColor = Color.Red;

        }
    }
}
