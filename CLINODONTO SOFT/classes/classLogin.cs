using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;

namespace CLINODONTO_SOFT.classes
{
    public class classLogin
    {



        private string Codigo;

        public string codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        private string Nome;

        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public static string codUsuario;
        public static string nomeUsuario;

        public ArrayList Logar(string login, string senha)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT iddentista,nome FROM dentista where login = '" + login + "'  and senha = '" + senha + "' ;";

            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);


            DataTable dt = Conn.ExecuteQuery(commS);

            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    classLogin u = new classLogin();
                    u.codigo = dt.Rows[i][0].ToString();
                    u.nome = dt.Rows[i][1].ToString();

                    arr.Add(u);
                    i++;
                }
            }
            return arr;

        }





    }
}
