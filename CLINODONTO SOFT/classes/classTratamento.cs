using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;

namespace CLINODONTO_SOFT.classes
{
    public class classTratamento
    {
        //ficha clinica 
        private string plano;
        private int id_paciente;
        private int id_dentista;
        private int id_fichaclinica;
        private int status;
        private string extra_oral;
        private string intra_oral;
        private string geral;

        //anamnese

        private string data;
  private string local;
                                                       
private string queixa_principal;
                             private int sofre_doenca;
                             private string sofre_doenca_quais;
                             private int esta_em_tratamento;
                             private int gravidez;
                             private int usa_medicacao;
                             private string usa_medicacao_quais;
                             private string usa_medicacao_medico;
                             private int alergia;
                             private string alergia_quais;
                             private int operado;
                             private string operado_quais;
                             private string operado_cicatrizacao;
                             private string operado_anestezia;
                             private string operado_hemorragia;
                             private int febre_reumatica; 
                             private int cardiacos;
                             private int renais;
                             private int gastricos;
                             private int respiratorios;
                             private int alergicos;
                             private int articulares;
                             private int diabetes;
                             private int hipertencao;
                             private string habitos;
                             private string ante_familiares;
                             private string observacoes; 
        //dente e faces
        private string descricao;
        private int iddente;
        private int idface;
        private string cor;
        
        //dentista
        private string cro;
        private string dentista;
        private int dent_cpf;
        private int den_rg;
        private string den_org;

        //ficha clinica 
        public string Plano
        {
            get { return plano; }
            set { plano = value; }
        }
        public int Id_paciente
         {
            get { return id_paciente; }
            set { id_paciente = value; }
        }
        public int Id_dentista
        {
            get { return id_dentista; }
            set { id_dentista = value; }
        }
        public int Id_fichaclinica
            {
            get { return id_fichaclinica; }
            set { id_fichaclinica = value; }
        }
        public int Status
            {
            get { return status; }
            set { status = value; }
        }
        public string Extra_oral
            {
            get { return extra_oral; }
            set { extra_oral = value; }
        }
        public string Intra_oral
            {
            get { return intra_oral; }
            set { intra_oral = value; }
        }
        public string Geral
            {
            get { return geral; }
            set { geral = value; }
        }

        //anamnese

        public string Data
            {
            get { return data; }
            set { data = value; }
        }
        public string Local
            {
            get { return local; }
            set { local = value; }
        }
                                                       
        public string Queixa_principal
            {
            get { return queixa_principal; }
            set { queixa_principal = value; }
        }
        public int Sofre_doenca
        {
            get { return sofre_doenca; }
            set { sofre_doenca = value; }
        }
       public string Sofre_doenca_quais
           {
            get { return sofre_doenca_quais; }
            set { sofre_doenca_quais = value; }
        }
       public int Esta_em_tratamento
           {
            get { return esta_em_tratamento; }
            set { esta_em_tratamento = value; }
        }
       public int Gravidez
           {
            get { return gravidez; }
            set { gravidez = value; }
        }
      public int Usa_medicacao
          {
            get { return usa_medicacao; }
            set { usa_medicacao = value; }
        }
       public string Usa_medicacao_quais
           {
            get { return usa_medicacao_quais; }
            set { usa_medicacao_quais = value; }
        }
      public string Usa_medicacao_medico
          {
            get { return usa_medicacao_medico; }
            set { usa_medicacao_medico = value; }
        }
      public int Alergia
      {
            get { return alergia; }
            set { alergia = value; }
        }
      public string Alergia_quais
       {
            get { return alergia_quais; }
            set { alergia_quais = value; }
        }
      public int Operado
      {
            get { return operado; }
            set { operado = value; }
        }
      public string Operado_quais
{
            get { return operado_quais; }
            set { operado_quais = value; }
        }
      public string Operado_cicatrizacao
{
            get { return operado_cicatrizacao; }
            set { operado_cicatrizacao = value; }
        }
     public string Operado_anestezia
{
            get { return operado_anestezia; }
            set { operado_anestezia = value; }
        }
      public string Operado_hemorragia
{
            get { return operado_hemorragia; }
            set { operado_hemorragia = value; }
        }
      public int Febre_reumatica
      {
          get { return febre_reumatica; }
          set { febre_reumatica = value; }
      
      }
      public int Cardiacos
{
            get { return cardiacos; }
            set { cardiacos = value; }
        }
     public int Renais
{
            get { return renais; }
            set { renais = value; }
        }
      public int Gastricos
{
            get { return gastricos; }
            set { gastricos = value; }
        }
     public int Respiratorios
{
            get { return respiratorios; }
            set { respiratorios = value; }
        }
     public int Alergicos
{
            get { return alergicos; }
            set { alergicos = value; }
        }
     public int Articulares
{
            get { return articulares; }
            set { articulares = value; }
        }
      public int Diabetes
{
            get { return diabetes; }
            set { diabetes = value; }
        }
     public int Hipertencao
{
            get { return hipertencao; }
            set { hipertencao = value; }
        }
     public string Habitos
{
            get { return habitos; }
            set { habitos = value; }
        }
    public string Ante_familiares
{
            get { return ante_familiares; }
            set { ante_familiares = value; }
        }
    public string Observacoes
{
            get { return observacoes; }
            set { observacoes = value; }
        }
        //dente e faces
        public string Descricao
            {
            get { return descricao; }
            set { descricao = value; }
        }
        public int Iddente
            {
            get { return iddente; }
            set { iddente = value; }
        }
        public int Idface
            {
            get { return idface; }
            set { idface = value; }
        }
        public string Cor
            {
            get { return cor; }
            set { cor = value; }
        }
        
        //dentista
        public string Cro
            {
            get { return cro; }
            set { cro = value; }
        }
        public string Dentista
            {
            get { return dentista; }
            set { dentista = value; }
        }
        public int Dent_cpf
            {
            get { return dent_cpf; }
            set { dent_cpf = value; }
        }
        public int Den_rg
            {
            get { return den_rg; }
            set { den_rg = value; }
        }
        public string Den_org{
            get { return den_org; }
            set { den_org = value; }
        }

        public ArrayList listar_ficha_clinica(string idpaciente)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM ficha_clinica where id_paciente = '" + idpaciente + "';";

            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    classTratamento trat = new classTratamento();
                    trat.Id_fichaclinica = int.Parse(dt.Rows[i][0].ToString());
                    trat.extra_oral = dt.Rows[i][1].ToString();
                    trat.intra_oral = dt.Rows[i][2].ToString();
                    trat.geral = dt.Rows[i][3].ToString();
                    trat.plano = dt.Rows[i][4].ToString();
                    trat.Id_dentista = int.Parse(dt.Rows[i][5].ToString());
                    trat.status = int.Parse(dt.Rows[i][7].ToString());
                   

                    arr.Add(trat);
                    i++;
                }
            }
            return arr;
        }
        public ArrayList listar_anamnese(string ficha_clinica)
        {
            ArrayList arr = new ArrayList();
            
            string sql = "SELECT * FROM anamnese where idficha_clinica = '" + ficha_clinica + "';";

            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    classTratamento trat = new classTratamento();
                   
                    trat.data = dt.Rows[i][1].ToString();
                    trat.local = dt.Rows[i][2].ToString();
                    trat.queixa_principal = dt.Rows[i][3].ToString();
                    trat.sofre_doenca = int.Parse(dt.Rows[i][4].ToString());
                    trat.sofre_doenca_quais = dt.Rows[i][5].ToString();
                    trat.esta_em_tratamento = int.Parse(dt.Rows[i][6].ToString());
                    trat.gravidez = int.Parse(dt.Rows[i][7].ToString());
                    trat.usa_medicacao = int.Parse(dt.Rows[i][8].ToString());
                    trat.usa_medicacao_quais = dt.Rows[i][9].ToString();
                    trat.usa_medicacao_medico = dt.Rows[i][10].ToString();
                    trat.alergia = int.Parse(dt.Rows[i][11].ToString());
                    trat.alergia_quais = dt.Rows[i][12].ToString();
                    trat.operado = int.Parse(dt.Rows[i][13].ToString());
                    trat.operado_quais = dt.Rows[i][14].ToString();
                    trat.operado_cicatrizacao = dt.Rows[i][15].ToString();
                    trat.operado_anestezia = dt.Rows[i][16].ToString();                  
                    trat.operado_hemorragia = dt.Rows[i][17].ToString();
                    trat.febre_reumatica = int.Parse(dt.Rows[i][18].ToString());
                    trat.cardiacos = int.Parse(dt.Rows[i][19].ToString());
                    trat.renais = int.Parse(dt.Rows[i][20].ToString());
                    trat.gastricos = int.Parse(dt.Rows[i][21].ToString());
                    trat.respiratorios = int.Parse(dt.Rows[i][22].ToString());
                    trat.alergicos = int.Parse(dt.Rows[i][23].ToString());
                    trat.articulares = int.Parse(dt.Rows[i][24].ToString());
                    trat.diabetes = int.Parse(dt.Rows[i][25].ToString());
                    trat.hipertencao = int.Parse(dt.Rows[i][26].ToString());
                    trat.habitos = dt.Rows[i][27].ToString();
                    trat.ante_familiares = dt.Rows[i][28].ToString();
                    trat.observacoes = dt.Rows[i][29].ToString(); 
                    arr.Add(trat);
                    i++;
                }
            }
            return arr;
        }
        public ArrayList listar_dente(string ficha)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM dente where idficha_clinica = '" + ficha + "';";

            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    classTratamento trat = new classTratamento();
                    trat.Descricao = dt.Rows[i][0].ToString();
                    trat.Iddente = int.Parse(dt.Rows[i][2].ToString());
                    arr.Add(trat);
                    i++;
                }
            }
            return arr;
        }
        public ArrayList listar_face(string ficha,string dent)
        {
            ArrayList arr = new ArrayList();
            
            string sql = "SELECT * FROM faces where idficha_clinica = '" + ficha + "' and iddente = '" + dent + "';";

            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    classTratamento trat = new classTratamento();
                    trat.Idface = int.Parse(dt.Rows[i][0].ToString());
                    trat.Cor = dt.Rows[i][1].ToString();
                 
                    arr.Add(trat);
                    i++;
                }
            }
            return arr;
        }
        public ArrayList listar_dentista(string dentist)
        {
            ArrayList arr = new ArrayList();

            string sql = "SELECT * FROM dentista where iddentista = '" + dentist + "';";

            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    classTratamento trat = new classTratamento();
                    trat.Dent_cpf = int.Parse(dt.Rows[i][1].ToString());
                    trat.Den_rg = int.Parse(dt.Rows[i][2].ToString());
                    trat.den_org = dt.Rows[i][3].ToString();
                    trat.Dentista = dt.Rows[i][4].ToString();
                    trat.Cro = dt.Rows[i][5].ToString();

                    arr.Add(trat);
                    i++;
                }
            }
            return arr;
        }


    }
}
