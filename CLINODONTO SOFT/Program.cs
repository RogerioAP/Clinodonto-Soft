using System;
using System.Windows.Forms;
using CLINODONTO_SOFT.classes;
using System.Data;

namespace CLINODONTO_SOFT
{
    static class Program
    {
         [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           

           try 
            {
                Conn.Conectar("odont");
                if (Conn.mConn.State == ConnectionState.Open)
                {
                  
                    Login log = new Login();
                    log.ShowDialog();
                    if (log.LoginOK == true)
                    {

                        //Conn.Conectar();
                        
                       new TelaPrincipal().ShowDialog();
                        

                        Conn.Close();
                    }


                } 

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível a conexão com o banco de dados!\n" + e.Message," " , MessageBoxButtons.OK, MessageBoxIcon.None);
                //new frmConfiguracoes().ShowDialog();
               
            }
            Conn.Close();
        }
    }
}
