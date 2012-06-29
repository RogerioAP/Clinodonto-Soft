using System;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CLINODONTO_SOFT.classes;
using System.Xml;

namespace CLINODONTO_SOFT.telas
{
    
    public partial class frmControle_pacientes : Form
    {
        ArrayList arr = new ArrayList();

        public frmControle_pacientes()
        {
            InitializeComponent();
        }
        public void atualiza_grid()
        {
            classPaciente paci = new classPaciente();
            dataGridView1.Rows.Clear();
            arr.Clear();
            try
            {
                arr = paci.bucar(txtbuscar.Text);
                for (int i = 0; i < arr.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = ((classPaciente)arr[i]).Nome;
                    dataGridView1[1, i].Value = ((classPaciente)arr[i]).Cpf;
                    dataGridView1[2, i].Value = DateTime.Parse(((classPaciente)arr[i]).Datanascimento).ToString("dd/MM/yyyy");
                    dataGridView1[3, i].Value = ((classPaciente)arr[i]).Curso;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
         
        
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (arr.Count > 0)
                {

                    int ind = dataGridView1.CurrentRow.Index;
                    new frmCadastrar_paciente(((classPaciente)arr[ind]).Cpf).Show();
                    dataGridView1.Rows.Clear();
                    arr.Clear();
                }
                else
                {
                    MessageBox.Show("Nenhum paciente está selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



                }
           
         
         
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            arr.Clear();
            dataGridView1.Rows.Clear();
            new frmCadastrar_paciente().ShowDialog();
        }

        private void btnProntuario_Click(object sender, EventArgs e)
        {
            new frmProntuario().ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            arr.Clear();
            classPaciente paciente = new classPaciente();
            arr = paciente.bucar(txtbuscar.Text);
            for (int i = 0; i < arr.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = ((classPaciente)arr[i]).Nome;
                dataGridView1[1, i].Value = ((classPaciente)arr[i]).Cpf;
                dataGridView1[2, i].Value = DateTime.Parse(((classPaciente)arr[i]).Datanascimento).ToString("dd/MM/yyyy");
                dataGridView1[3, i].Value = ((classPaciente)arr[i]).Curso;                
            }
        }

        private void frmControle_pacientes_Load(object sender, EventArgs e)
        {
            try
            {
                classPaciente paci = new classPaciente();
                dataGridView1.Rows.Clear();

                arr = paci.bucar(txtbuscar.Text);
                for (int i = 0; i < arr.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = ((classPaciente)arr[i]).Nome;
                    dataGridView1[1, i].Value = ((classPaciente)arr[i]).Cpf;
                    dataGridView1[2, i].Value = DateTime.Parse(((classPaciente)arr[i]).Datanascimento).ToString("dd/MM/yyyy");
                    dataGridView1[3, i].Value = ((classPaciente)arr[i]).Curso;
                }
            }
            catch (Exception p)
            {
                throw p;
            }
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (arr.Count > 0)
                {
                    int ind = dataGridView1.CurrentRow.Index;

                    if (MessageBox.Show("Você deseja realmente excluir este paciente juntamento com todos seus dados?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        classPaciente paci = new classPaciente();
                        string x = paci.Deletar(((classPaciente)arr[ind]).Cpf.ToString());
                        if (x == "1")
                        {

                            MessageBox.Show("Paciente excluido com sucesso.");
                            arr = paci.bucar(txtbuscar.Text);
                            dataGridView1.Rows.Clear();
                            for (int i = 0; i < arr.Count; i++)
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1[0, i].Value = ((classPaciente)arr[i]).Nome;
                                dataGridView1[1, i].Value = ((classPaciente)arr[i]).Cpf;
                                dataGridView1[2, i].Value = DateTime.Parse(((classPaciente)arr[i]).Datanascimento).ToString("dd/MM/yyyy");
                                dataGridView1[3, i].Value = ((classPaciente)arr[i]).Curso;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não é permitido excluir este paciente\n. já existem dados gravados relativos a ele", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                        }

                    }
                }
                else
                {
                    MessageBox.Show("Nenhum paciente está selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            
               
            }
            catch (Exception p)
            {
                throw p;
            }
           
        }

        private void frmControle_pacientes_EnabledChanged(object sender, EventArgs e)
        {
            classPaciente paci = new classPaciente();
            arr.Clear();
            dataGridView1.Rows.Clear();

            arr = paci.bucar(txtbuscar.Text);
            for (int i = 0; i < arr.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = ((classPaciente)arr[i]).Nome;
                dataGridView1[1, i].Value = ((classPaciente)arr[i]).Cpf;
                dataGridView1[2, i].Value = DateTime.Parse(((classPaciente)arr[i]).Datanascimento).ToString("dd/MM/yyyy");
                dataGridView1[3, i].Value = ((classPaciente)arr[i]).Curso;
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (arr.Count > 0)
                {
                    ArrayList lis = new ArrayList();
                    ArrayList anamn = new ArrayList();
                    ArrayList dental = new ArrayList();
                    ArrayList face = new ArrayList();
                    ArrayList dentista = new ArrayList();
                    ArrayList aux = new ArrayList();

                    classPaciente paci = new classPaciente();
                    classTratamento trat = new classTratamento();
                    SaveFileDialog sfd = new SaveFileDialog();

                    sfd.Filter = "XML|*.xml";
                    sfd.FilterIndex = 1;
                    sfd.Title = "Exportar aluno";

                    //sfd.Filter = "Texto Comum|*.txt|Formato WordPad|*.rtf|Formato Word|*.doc|PDF|*.pdf|Todos os Arquivos|*.*"; 
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        //Caminho onde o arquivo será salvo
                        string strFilePath = sfd.FileName;

                        XmlTextWriter xtw = new XmlTextWriter(strFilePath, Encoding.UTF8);

                        //A linha abaixo vai identar o código
                        xtw.Formatting = Formatting.Indented;
                        int ind = dataGridView1.CurrentRow.Index;
                        aux = paci.bucareditar(((classPaciente)arr[ind]).Cpf.ToString());
                        if (aux.Count == 1)
                        {
                            int num = paci.bucarficha(((classPaciente)arr[0]).Cpf.ToString());

                            lis = trat.listar_ficha_clinica(((classPaciente)arr[0]).Idpaciente.ToString());
                            //Escreve a declaração do documento <?xml version="1.0" encoding="utf-8"?>
                            xtw.WriteStartDocument();

                            xtw.WriteStartElement("dados");
                            xtw.WriteStartElement("cadastro");
                            xtw.WriteAttributeString("nome", ((classPaciente)arr[0]).Nome.ToString());
                            xtw.WriteAttributeString("estado_civil", ((classPaciente)arr[0]).Estadocivil.ToString());
                            xtw.WriteAttributeString("orgao_expedidor", ((classPaciente)arr[0]).Orgaoexpedidor.ToString());
                            xtw.WriteAttributeString("rg", ((classPaciente)arr[0]).Rg.ToString());
                            xtw.WriteAttributeString("naturalidade", ((classPaciente)arr[0]).Naturalidade.ToString());
                            xtw.WriteAttributeString("cpf", ((classPaciente)arr[0]).Cpf.ToString());
                            xtw.WriteAttributeString("profissao", ((classPaciente)arr[0]).Profissao.ToString());
                            xtw.WriteAttributeString("nacionalidade", ((classPaciente)arr[0]).Nacionalidade.ToString());
                            xtw.WriteAttributeString("data_de_nascimento", DateTime.Parse(((classPaciente)arr[0]).Datanascimento).ToString("yyyy-MM-dd"));
                            xtw.WriteAttributeString("endereco_profissional", ((classPaciente)arr[0]).Enderecoprofissional.ToString());
                            xtw.WriteAttributeString("endereco_residencial", ((classPaciente)arr[0]).Enderecoresidencial.ToString());
                            xtw.WriteAttributeString("curso", ((classPaciente)arr[0]).Curso.ToString());
                            xtw.WriteEndElement();

                            xtw.WriteStartElement("tratamentos");



                            xtw.WriteAttributeString("quantidade", num.ToString());
                            for (int i = 0; i < lis.Count; i++)
                            {
                                anamn = trat.listar_anamnese(((classTratamento)lis[i]).Id_fichaclinica.ToString());

                                xtw.WriteStartElement("tratamento");
                                //dados dentista
                                dentista = trat.listar_dentista(((classTratamento)lis[i]).Id_dentista.ToString());
                                xtw.WriteStartElement("dentista");
                                xtw.WriteAttributeString("nome", ((classTratamento)dentista[0]).Dentista.ToString());
                                xtw.WriteAttributeString("cpf", ((classTratamento)dentista[0]).Dent_cpf.ToString());
                                xtw.WriteAttributeString("orgao_expedidor", ((classTratamento)dentista[0]).Den_org.ToString());
                                xtw.WriteAttributeString("rg", ((classTratamento)dentista[0]).Den_rg.ToString());
                                xtw.WriteAttributeString("cro", ((classTratamento)dentista[0]).Cro.ToString());
                                xtw.WriteEndElement();
                                //tabela ficha clinica
                                xtw.WriteStartElement("ficha_clinica");

                                xtw.WriteAttributeString("status", ((classTratamento)lis[i]).Status.ToString());
                                xtw.WriteAttributeString("plano", ((classTratamento)lis[i]).Plano.ToString());
                                xtw.WriteAttributeString("intra_oral", ((classTratamento)lis[i]).Intra_oral.ToString());
                                xtw.WriteAttributeString("extra_oral", ((classTratamento)lis[i]).Extra_oral.ToString());
                                xtw.WriteAttributeString("geral", ((classTratamento)lis[i]).Geral.ToString());
                                xtw.WriteEndElement();
                                //tabela Anamnese
                                xtw.WriteStartElement("anamnese");
                                xtw.WriteAttributeString("idficha_clinica", ((classTratamento)lis[i]).Id_fichaclinica.ToString());
                                xtw.WriteAttributeString("data", ((classTratamento)anamn[i]).Data.ToString());
                                xtw.WriteAttributeString("local", ((classTratamento)anamn[i]).Local.ToString());
                                xtw.WriteAttributeString("queixa_principal", ((classTratamento)anamn[i]).Queixa_principal.ToString());
                                xtw.WriteAttributeString("sofre_doenca", ((classTratamento)anamn[i]).Sofre_doenca.ToString());
                                xtw.WriteAttributeString("sofre_doenca_quais", ((classTratamento)anamn[i]).Sofre_doenca_quais.ToString());
                                xtw.WriteAttributeString("esta_em_tratamento", ((classTratamento)anamn[i]).Esta_em_tratamento.ToString());
                                xtw.WriteAttributeString("gravidez", ((classTratamento)anamn[i]).Gravidez.ToString());
                                xtw.WriteAttributeString("usa_medicacao", ((classTratamento)anamn[i]).Usa_medicacao.ToString());
                                xtw.WriteAttributeString("usa_medicacao_quais", ((classTratamento)anamn[i]).Usa_medicacao.ToString());
                                xtw.WriteAttributeString("usa_medicacao_medico", ((classTratamento)anamn[i]).Usa_medicacao_quais.ToString());
                                xtw.WriteAttributeString("alergia", ((classTratamento)anamn[i]).Alergia.ToString());
                                xtw.WriteAttributeString("alergia_quais", ((classTratamento)anamn[i]).Alergia_quais.ToString());
                                xtw.WriteAttributeString("operado", ((classTratamento)anamn[i]).Operado.ToString());
                                xtw.WriteAttributeString("operado_quais", ((classTratamento)anamn[i]).Operado_quais.ToString());
                                xtw.WriteAttributeString("operado_cicatrizacao", ((classTratamento)anamn[i]).Operado_cicatrizacao.ToString());
                                xtw.WriteAttributeString("operado_anestezia", ((classTratamento)anamn[i]).Operado_anestezia.ToString());
                                xtw.WriteAttributeString("operado_hemorragia", ((classTratamento)anamn[i]).Operado_hemorragia.ToString());
                                xtw.WriteAttributeString("febre_reumatica", ((classTratamento)anamn[i]).Febre_reumatica.ToString());
                                xtw.WriteAttributeString("cardiacos", ((classTratamento)anamn[i]).Cardiacos.ToString());
                                xtw.WriteAttributeString("renais", ((classTratamento)anamn[i]).Renais.ToString());
                                xtw.WriteAttributeString("gastricos", ((classTratamento)anamn[i]).Gastricos.ToString());
                                xtw.WriteAttributeString("respiratorios", ((classTratamento)anamn[i]).Respiratorios.ToString());
                                xtw.WriteAttributeString("alergicos", ((classTratamento)anamn[i]).Alergicos.ToString());
                                xtw.WriteAttributeString("articulares", ((classTratamento)anamn[i]).Articulares.ToString());
                                xtw.WriteAttributeString("diabetes", ((classTratamento)anamn[i]).Diabetes.ToString());
                                xtw.WriteAttributeString("hipertencao", ((classTratamento)anamn[i]).Hipertencao.ToString());
                                xtw.WriteAttributeString("habitos", ((classTratamento)anamn[i]).Habitos.ToString());
                                xtw.WriteAttributeString("ante_familiares", ((classTratamento)anamn[i]).Ante_familiares.ToString());
                                xtw.WriteAttributeString("observacoes", ((classTratamento)anamn[i]).Observacoes.ToString());
                                xtw.WriteEndElement();
                                // tabelas dente e faces
                                xtw.WriteStartElement("Exame dental");
                                dental = trat.listar_dente(((classTratamento)lis[i]).Id_fichaclinica.ToString());
                                for (int b = 0; b < dental.Count; b++)
                                {
                                    xtw.WriteStartElement("dente");
                                    xtw.WriteAttributeString("iddente", ((classTratamento)dental[b]).Iddente.ToString());
                                    xtw.WriteAttributeString("descricao", ((classTratamento)dental[b]).Descricao.ToString());
                                    face = trat.listar_face(((classTratamento)lis[i]).Id_fichaclinica.ToString(), ((classTratamento)dental[b]).Iddente.ToString());
                                    for (int u = 0; u < face.Count; u++)
                                    {
                                        xtw.WriteStartElement("face");
                                        xtw.WriteAttributeString("idface", ((classTratamento)face[u]).Idface.ToString());
                                        xtw.WriteAttributeString("cor", ((classTratamento)face[u]).Cor.ToString());
                                        xtw.WriteEndElement();
                                    }
                                    xtw.WriteEndElement();
                                }

                                xtw.WriteEndElement();


                            }


                            xtw.WriteEndElement();
                            xtw.WriteEndElement();
                            xtw.WriteEndDocument();

                            //libera o XmlTextWriter
                            xtw.Flush();
                            //fechar o XmlTextWriter
                            xtw.Close();

                            // GerarPDF2(sfd.FileName);

                        }
                        else
                        {
                            MessageBox.Show("Erro do sistema,\n não foi possivel concluir esta ação", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }



                }
                else
                {
                    MessageBox.Show("Nenhum paciente está selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



                }
           
            }
            catch (Exception p)
            {
                throw p;
            }
            
        }

        private void frmControle_pacientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                if (txtbuscar.Focused == true)
                {
                    dataGridView1.Rows.Clear();
                    arr.Clear();
                    classPaciente paciente = new classPaciente();
                    arr = paciente.bucar(txtbuscar.Text);
                    for (int i = 0; i < arr.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1[0, i].Value = ((classPaciente)arr[i]).Nome;
                        dataGridView1[1, i].Value = ((classPaciente)arr[i]).Cpf;
                        dataGridView1[2, i].Value = DateTime.Parse(((classPaciente)arr[i]).Datanascimento).ToString("dd/MM/yyyy");
                        dataGridView1[3, i].Value = ((classPaciente)arr[i]).Curso;
                    }
                }
            
            }
        }
    }
}
