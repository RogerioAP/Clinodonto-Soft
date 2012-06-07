using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace CLINODONTO_SOFT.classes
{
    public class Conn
    {
        public static MySqlConnection mConn;
        //buscar das variaveis de programa
        static string connectionstring;
        static MySqlConnectionStringBuilder myCSB = new MySqlConnectionStringBuilder();

        static public String hostDB { get; set; }

        static public String userDB { get; set; }

        static public String passwdDB { get; set; }

        static public String Database { get; set; }

        public static void CriarTabelas(string sql)
        {
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            Conn.ExecuteNonQuery(commS);
        }

        public static void Conectar(string bd)   //esse parâmetro vai ser o BD a qual o software vai se conectar no cado "odont"
        {
            try
            {

                connectionstring = "server=" + ConfigurationSettings.AppSettings["hostDB"].ToString();
                connectionstring += ";database=" + bd/*ConfigurationSettings.AppSettings["database"].ToString()*/;
                connectionstring += ";uid=" + ConfigurationSettings.AppSettings["userDB"].ToString();
                connectionstring += ";pwd='" + ConfigurationSettings.AppSettings["passwordDB"].ToString() + "'";

                mConn = new MySqlConnection(connectionstring);
                mConn.Open();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public static void ExecuteNonQuery(MySqlCommand commS)
        {
            if (mConn.State == ConnectionState.Open)
            {
                try
                {
                    int i = commS.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    throw e;

                }
            }

        }

        public static DataTable ExecuteQuery(MySqlCommand commS)
        {
            if (mConn.State == ConnectionState.Open)
            {
                //Executa a SQL no banco de dados
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = commS;
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
                catch (MySqlException e)
                {
                    throw e; 
                }
            }
            return null;
        }
       

        static public void Close()
        {
            mConn.Close(); //encerra a conexão com o MYSQL
            mConn.Dispose();
        }
       
    }
}
