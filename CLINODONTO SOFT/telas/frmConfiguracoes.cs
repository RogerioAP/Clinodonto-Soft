using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CLINODONTO_SOFT.classes;

namespace CLINODONTO_SOFT.telas
{
    public partial class frmConfiguracoes : Form
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
            if (Conn.mConn.State == ConnectionState.Open)
            {
                lblStatusdaconexao.ForeColor = Color.Blue;
                lblStatusdaconexao.Text = "conectado";
            }

        }
        public void MudarLabel()
        {
            lblServer.Text = "Server: *";

            lblUsuario.Text = "Usuário *";

            lblServer.ForeColor = Color.Red;

            lblUsuario.ForeColor = Color.Red;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            
            if (txtServer.Text == string.Empty || txtUsuario.Text == string.Empty)
            {
                MudarLabel();
                MessageBox.Show("Os campos com * não podem ser nulos!", "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else  

      //          AppSettingsSection appSetSec = configfile.AppSettings;
                try
                {
                    this.Cursor = Cursors.WaitCursor;

        //              appSetSec.Settings["hostDb"].Value = txtServer.Text;   
                    
          //            appSetSec.Settings["userDB"].Value = txtUsuario.Text;
            //          appSetSec.Settings["passwordDB"].Value = txtSenha.Text;

                 

                    
              //     configfile.Save(ConfigurationSaveMode.Modified);
                //    ConfigurationManager.RefreshSection("appSettings");

                  Conn.Conectar("odont");
                    if (Conn.mConn.State == ConnectionState.Open)
                    {
                        lblStatusdaconexao.ForeColor = Color.Blue;
                        lblStatusdaconexao.Text = "conectado";

                        MessageBox.Show("Configuração salva com sucesso!", "Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                        this.Close();

                    }
 
                }
                catch (Exception es)
                {
                    MessageBox.Show("Não foi possível conectar.\nMotivo: " + es.Message, "Erro!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                this.Cursor = Cursors.WaitCursor;
                
            }
        }
    
}
