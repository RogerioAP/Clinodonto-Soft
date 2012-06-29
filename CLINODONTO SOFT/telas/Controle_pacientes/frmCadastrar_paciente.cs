using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CLINODONTO_SOFT.classes;

namespace CLINODONTO_SOFT.telas
{
    public partial class frmCadastrar_paciente : Form
    {
        ArrayList arr = new ArrayList();
        int aux = 0;
        int cpff;
        public frmCadastrar_paciente()
        {
            InitializeComponent();
        }
        public frmCadastrar_paciente(int cpf)
        {
            aux = 1;
            InitializeComponent();
            cpff = cpf;
            classPaciente paciente = new classPaciente();
            arr = paciente.bucareditar(cpf.ToString());
            if (arr.Count == 1)
            {
                DateTime Data = new DateTime();//((classPaciente)arr[0]).Datanascimento;
                //minhaData.Add(((classPaciente)arr[0]).Datanascimento);
               
                Data = DateTime.Parse(((classPaciente)arr[0]).Datanascimento);
                
                //string minhaDataFormatada = minhaData.ToString("dd/MM/yyyy");

                 txtNome.Text = ((classPaciente)arr[0]).Nome;
                 txtCpf.Text = ((classPaciente)arr[0]).Cpf.ToString();
                 txtRg.Text = ((classPaciente)arr[0]).Rg.ToString();
                 txtOrgaoexp.Text = ((classPaciente)arr[0]).Orgaoexpedidor;        
                 txtEstado.Text = ((classPaciente)arr[0]).Estadocivil;
                 txtNaturalidade.Text = ((classPaciente)arr[0]).Naturalidade;
                 txtNacionalidade.Text = ((classPaciente)arr[0]).Nacionalidade;
                 txtProfissao.Text = ((classPaciente)arr[0]).Profissao;
                 cbxSexo.Text = ((classPaciente)arr[0]).Sexo;
                 txtCurso.Text = ((classPaciente)arr[0]).Curso;
                 txtNascimento.Text = Data.ToString("dd/MM/yyyy");
                 txtEndecoprof.Text = ((classPaciente)arr[0]).Enderecoprofissional;
                 txtEnderecores.Text = ((classPaciente)arr[0]).Enderecoresidencial;
                 txtCpf.Enabled = false;
            }
            else
            {                
                  MessageBox.Show("Erro interno do sistema.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  this.Close();
            }
 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList ar =  new ArrayList();
            classPaciente paciente = new classPaciente();
            ar = paciente.bucareditar(txtCpf.Text.ToString());
                DateTime Dat = new DateTime();
                if (aux == 0)
                {
                    if (txtNome.Text != "" && cbxSexo.Text != "" && txtCurso.Text != "" && txtNascimento.Text != "" && txtCpf.Text != "")
                    {
                        if (int.Parse(ar.Count.ToString()) == 0)
                        {
                            Dat = DateTime.Parse(txtNascimento.Text);
                            paciente.Nome = txtNome.Text;
                            paciente.Rg = int.Parse(txtRg.Text);
                            paciente.Orgaoexpedidor = txtOrgaoexp.Text;
                            paciente.Cpf = int.Parse(txtCpf.Text);
                            paciente.Estadocivil = txtEstado.Text;
                            paciente.Naturalidade = txtNaturalidade.Text;
                            paciente.Nacionalidade = txtNacionalidade.Text;
                            paciente.Profissao = txtProfissao.Text;
                            paciente.Sexo = cbxSexo.Text;
                            paciente.Curso = txtCurso.Text;
                            paciente.Datanascimento = Dat.ToString("yyyy-MM-dd");
                            paciente.Enderecoprofissional = txtEndecoprof.Text;
                            paciente.Enderecoresidencial = txtEnderecores.Text;

                            paciente.Salvar();
                            
                            MessageBox.Show("Paciente cadastrado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("CPF inválido.\n Este número de cpf já está sendo usado por outro paciente. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Todos os campos com * não podem estar vazios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    if (aux == 1)
                    {
                        if (txtNome.Text != "" && cbxSexo.Text != "" && txtCurso.Text != "" && txtNascimento.Text != "" && txtCpf.Text != "")
                        {
                           
                                Dat = DateTime.Parse(txtNascimento.Text);

                                paciente.Nome = txtNome.Text;
                                paciente.Rg = int.Parse(txtRg.Text);
                                paciente.Orgaoexpedidor = txtOrgaoexp.Text;
                            
                                paciente.Estadocivil = txtEstado.Text;
                                paciente.Naturalidade = txtNaturalidade.Text;
                                paciente.Nacionalidade = txtNacionalidade.Text;
                                paciente.Profissao = txtProfissao.Text;
                                paciente.Sexo = cbxSexo.Text;
                                paciente.Curso = txtCurso.Text;
                                paciente.Datanascimento = Dat.ToString("yyyy-MM-dd");
                                paciente.Enderecoprofissional = txtEndecoprof.Text;
                                paciente.Enderecoresidencial = txtEnderecores.Text;

                                paciente.Editar(cpff.ToString());

                                MessageBox.Show("Dados alterados com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.Close();

                          
                           
                        }
                        else
                        {
                            MessageBox.Show("Todos os campos com * não podem estar vazios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                }


         
           
        }

       
    }
}
