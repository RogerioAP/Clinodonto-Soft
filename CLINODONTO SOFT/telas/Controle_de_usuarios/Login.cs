using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace CLINODONTO_SOFT
{
    public partial class Login : Form
    {
        public Login()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
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
           /* MySqlConnection conn = new MySqlConnection(Conn.connectionstring);
            MySqlCommand comado = new MySqlCommand("SELECT COUNT(*) FROM Login WHERE Login = @Login and Senha = @Senha", conn);


            comado.Parameters.Add("@Login", MySqlDbType.VarChar).Value = txtLogin.Text;
            comado.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = txtSenha.Text;

            conn.Open();
            long i = (long)comado.ExecuteScalar();

            if (i > 0)
            {

                TelaPrincipal l = new TelaPrincipal();
                l.Show();

                txtSenha.Clear();                
                this.Visible = false;

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Usuario não Cadastrado.");
                txtSenha.Clear();
            }
            conn.Close();*/
        }
    }
}
