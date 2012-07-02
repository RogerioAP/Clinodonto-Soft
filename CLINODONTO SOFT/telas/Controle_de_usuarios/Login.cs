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

        //exibição da tela splash
        public void SplashScreen()
        {
            System.Windows.Forms.Application.Run(new Splash());
        }

        public bool LoginOK { get; set; }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //ao clicar no botão ENTRAR
            Login();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //ao precionar o botão ENTER
                case Keys.Enter:

                    Login();
                    break;
            }
        }

        public void Login()
        {
            //método para testar login e senha
            if (txtLogin.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                MudarLabel();
                MessageBox.Show("Atenção! Todos os campos com * precisam ser preenchidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Login ou senha estão incorretos!\n Tente novamente.");
                }
            }
        }
        
        //alterar textos para melhor vizualização do usuário
        public void MudarLabel()
        {
            lblLogin.Text = "Login *";
            lblSenha.Text = "Senha *";

            lblLogin.ForeColor = Color.Red;
            lblSenha.ForeColor = Color.Red;
        }
    }
}
