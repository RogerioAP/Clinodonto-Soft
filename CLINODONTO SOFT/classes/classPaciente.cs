using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;

namespace CLINODONTO_SOFT.classes
{
    public class classPaciente
    {
        private int idpaciente;
        private string estadocivil;
        private string orgaoexpedidor;
        private string sexo;
        private string nome;
        private int rg;
        private string naturalidade;
        private int cpf;
        private string profissao;
        private string nacionalidade;
        private string datanascimento;
        private string enderecoprofissional;
        private string enderecoresidencial;
        private string curso;
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public int Idpaciente
        {
            get { return idpaciente; }
            set { idpaciente = value; }
        }
        public string Estadocivil
        {
            get { return estadocivil; }
            set { estadocivil = value; }
        }
        public string Orgaoexpedidor
        {
            get { return orgaoexpedidor; }
            set { orgaoexpedidor = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public string Naturalidade
        {
            get { return naturalidade; }
            set { naturalidade = value; }
        }
        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }
        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }
        public string Datanascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }
        public string Enderecoprofissional
        {
            get { return enderecoprofissional; }
            set { enderecoprofissional = value; }
        }
        public string Enderecoresidencial
        {
            get { return enderecoresidencial; }
            set { enderecoresidencial = value; }
        }
        

        


        public ArrayList bucar(string busca)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM paciente where nome like '%" + busca + "%' or cpf like '%" + busca + "%';" ;
          
          
         
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    classPaciente pa = new classPaciente();
                    pa.Idpaciente = int.Parse(dt.Rows[i][0].ToString());
                    pa.Estadocivil = dt.Rows[i][1].ToString();
                    pa.Orgaoexpedidor = dt.Rows[i][2].ToString();
                    pa.Sexo = dt.Rows[i][3].ToString();
                    pa.Nome = dt.Rows[i][4].ToString();
                    pa.Rg = int.Parse(dt.Rows[i][5].ToString());
                    pa.Naturalidade = dt.Rows[i][6].ToString();
                    pa.Cpf = int.Parse(dt.Rows[i][7].ToString());
                    pa.Profissao = dt.Rows[i][8].ToString();
                    pa.Nacionalidade = dt.Rows[i][9].ToString();
                    pa.Datanascimento = dt.Rows[i][10].ToString();
                    pa.Enderecoprofissional = dt.Rows[i][11].ToString();
                    pa.Enderecoresidencial = dt.Rows[i][12].ToString();
                    pa.Curso = dt.Rows[i][13].ToString();
                    arr.Add(pa);
                    i++;
                }
            }
            return arr;
        }
        public ArrayList bucareditar(string cp)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM paciente where cpf = '" + cp + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    classPaciente pa = new classPaciente();
                    pa.Idpaciente = int.Parse(dt.Rows[i][0].ToString());
                    pa.Estadocivil = dt.Rows[i][1].ToString();
                    pa.Orgaoexpedidor = dt.Rows[i][2].ToString();
                    pa.Sexo = dt.Rows[i][3].ToString();
                    pa.Nome = dt.Rows[i][4].ToString();
                    pa.Rg = int.Parse(dt.Rows[i][5].ToString());
                    pa.Naturalidade = dt.Rows[i][6].ToString();
                    pa.Cpf = int.Parse(dt.Rows[i][7].ToString());
                    pa.Profissao = dt.Rows[i][8].ToString();
                    pa.Nacionalidade = dt.Rows[i][9].ToString();
                    pa.Datanascimento = dt.Rows[i][10].ToString();
                    pa.Enderecoprofissional = dt.Rows[i][11].ToString();
                    pa.Enderecoresidencial = dt.Rows[i][12].ToString();
                    pa.Curso = dt.Rows[i][13].ToString();
                    arr.Add(pa);
                    i++;
                }
            }
            return arr;
        }

        public int bucarconsulta(string id)
        {
            string sql = "SELECT * FROM consulta where paciente = '" + id + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);        
            return dt.Rows.Count;
        }
        public int bucarficha(string id)
        {
            string sql = "SELECT * FROM ficha_clinica where id_paciente = '" + id + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            return dt.Rows.Count;
        }
       
        public void Salvar()
        {
            string sql = "INSERT INTO paciente VALUES(null,'" + Estadocivil + "','" + Orgaoexpedidor + "','" + Sexo + "','" + Nome + "','" + Rg + "','" + Naturalidade + "','" + Cpf + "','" + Profissao + "','" + Nacionalidade + "','" + Datanascimento + "','" + Enderecoprofissional + "','" + Enderecoresidencial + "','" + Curso + "');";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Editar(string cp)
        {       
           string sql = "UPDATE PACIENTE set estado_civil = '" + Estadocivil + "',orgao_expedidor = '" + Orgaoexpedidor + "',sexo = '" + Sexo + "',nome = '" + Nome + "',rg = '" + Rg + "',naturalidade = '" + Naturalidade + "',profissao = '" + Profissao + "',nacionalidade = '" + Nacionalidade + "',data_de_nascimento = '" + Datanascimento + "', endereco_profissional = '" + Enderecoprofissional + "',endereco_residencial = '" + Enderecoresidencial + "', curso = '" + Curso + "' where cpf = '"+cp+"';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string Deletar(string cp)
        {
            ArrayList arrr = new ArrayList();
            classPaciente pa = new classPaciente();
            arrr = pa.bucareditar(cp);
            int aux = ((classPaciente)arrr[0]).Idpaciente;

            if (pa.bucarconsulta(aux.ToString()) == 0 || pa.bucarficha(aux.ToString()) == 0)
            {
                string sql = "DELETE FROM paciente WHERE cpf = '" + cp + "';";
                MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

                try
                {
                    Conn.ExecuteNonQuery(commS);
                   
                }
                catch (Exception e)
                {
                    throw e;
                }
                return "1";
            }
            else
            {

                return "0";
            }

           
        }

     
    }
}
