using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using CLINODONTO_SOFT.classes;
using CLINODONTO_SOFT.telas;

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

                //Conn.Conectar("");
                new Login().ShowDialog();
                //new frmExameDental().ShowDialog();
               //new TelaPrincipal().ShowDialog();
                //new frmControle_Consultas().ShowDialog();

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível a conexão com o banco de dados!\n" + e.Message," " , MessageBoxButtons.OK, MessageBoxIcon.None);
                //new Configuracoes().ShowDialog();
               
            }
            Conn.Close();
        }
    }
}
