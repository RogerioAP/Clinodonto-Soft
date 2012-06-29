using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using CLINODONTO_SOFT.classes;
using System.Collections;


namespace CLINODONTO_SOFT
{
    public partial class Login : Form
    {
        ArrayList arr = new ArrayList();
     
        public Login()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
            
        }

        public void SplashScreen()
        {
            System.Windows.Forms.Application.Run(new Splash());
        }

        public bool LoginOK { get; set; }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Atenção, todos os campos presisão ser preenchidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                classLogin log = new classLogin();
                arr = log.Logar(txtLogin.Text.ToString(), txtSenha.Text.ToString());
                int aux = arr.Count;
                if (aux == 1)
                {
                    classLogin.codUsuario = (((classLogin)arr[0]).codigo);
                    classLogin.nomeUsuario = (((classLogin)arr[0]).nome);
                    this.Hide();
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    LoginOK = true;



                }
                else
                {
                    MessageBox.Show("Login ou senha estão incorretos,\n tente novamente.");

                }

            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.Enter:
                   
                    if (txtLogin.Text == string.Empty || txtSenha.Text == string.Empty)
                    {
                        MessageBox.Show("Atenção, todos os campos presisão ser preenchidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        classLogin log = new classLogin();
                        arr = log.Logar(txtLogin.Text.ToString(), txtSenha.Text.ToString());
                        int aux = arr.Count;
                        if (aux == 1)
                        {
                            classLogin.codUsuario = (((classLogin)arr[0]).codigo);
                            classLogin.nomeUsuario = (((classLogin)arr[0]).nome);
                            this.Hide();
                            txtLogin.Text = "";
                            txtSenha.Text = "";
                            LoginOK = true;



                        }
                        else
                        {
                            MessageBox.Show("Login ou senha estão incorretos,\n tente novamente.");

                        }

                    }
                    break;
            }
        }

       
    }
}
