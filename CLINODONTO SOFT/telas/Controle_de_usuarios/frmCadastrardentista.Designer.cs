namespace CLINODONTO_SOFT.telas.Controle_de_usuarios
{
    partial class frmCadastrardentista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrardentista));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.gpbMedicoInformacoes = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.lblCRM = new System.Windows.Forms.Label();
            this.gpbMedicoDPessoais = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.txtEnderecoMedico = new System.Windows.Forms.TextBox();
            this.txtRGMedico = new System.Windows.Forms.TextBox();
            this.txtCPFMedico = new System.Windows.Forms.TextBox();
            this.txtTelefoneMedico = new System.Windows.Forms.TextBox();
            this.txtEmailMedico = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gpbMedicoInformacoes.SuspendLayout();
            this.gpbMedicoDPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(415, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(334, 402);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(22, 402);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(90, 23);
            this.btnApagar.TabIndex = 27;
            this.btnApagar.Text = "Limpar campos";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // gpbMedicoInformacoes
            // 
            this.gpbMedicoInformacoes.Controls.Add(this.textBox2);
            this.gpbMedicoInformacoes.Controls.Add(this.cbxUF);
            this.gpbMedicoInformacoes.Controls.Add(this.lblUF);
            this.gpbMedicoInformacoes.Controls.Add(this.txtCRM);
            this.gpbMedicoInformacoes.Controls.Add(this.lblEspecialidade);
            this.gpbMedicoInformacoes.Controls.Add(this.lblCRM);
            this.gpbMedicoInformacoes.Location = new System.Drawing.Point(22, 244);
            this.gpbMedicoInformacoes.Name = "gpbMedicoInformacoes";
            this.gpbMedicoInformacoes.Size = new System.Drawing.Size(626, 116);
            this.gpbMedicoInformacoes.TabIndex = 24;
            this.gpbMedicoInformacoes.TabStop = false;
            this.gpbMedicoInformacoes.Text = "Informações Profissionais";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 12;
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUF.Location = new System.Drawing.Point(325, 30);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(84, 21);
            this.cbxUF.TabIndex = 8;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(295, 38);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 11;
            this.lblUF.Text = "UF:";
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(88, 31);
            this.txtCRM.MaxLength = 5;
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(110, 20);
            this.txtCRM.TabIndex = 7;
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(6, 60);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(76, 13);
            this.lblEspecialidade.TabIndex = 3;
            this.lblEspecialidade.Text = "Especialidade:";
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(48, 34);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(33, 13);
            this.lblCRM.TabIndex = 0;
            this.lblCRM.Text = "CRO:";
            // 
            // gpbMedicoDPessoais
            // 
            this.gpbMedicoDPessoais.Controls.Add(this.textBox3);
            this.gpbMedicoDPessoais.Controls.Add(this.label4);
            this.gpbMedicoDPessoais.Controls.Add(this.comboBox2);
            this.gpbMedicoDPessoais.Controls.Add(this.label3);
            this.gpbMedicoDPessoais.Controls.Add(this.comboBox1);
            this.gpbMedicoDPessoais.Controls.Add(this.label2);
            this.gpbMedicoDPessoais.Controls.Add(this.textBox1);
            this.gpbMedicoDPessoais.Controls.Add(this.label1);
            this.gpbMedicoDPessoais.Controls.Add(this.txtNomeMedico);
            this.gpbMedicoDPessoais.Controls.Add(this.txtEnderecoMedico);
            this.gpbMedicoDPessoais.Controls.Add(this.txtRGMedico);
            this.gpbMedicoDPessoais.Controls.Add(this.txtCPFMedico);
            this.gpbMedicoDPessoais.Controls.Add(this.txtTelefoneMedico);
            this.gpbMedicoDPessoais.Controls.Add(this.txtEmailMedico);
            this.gpbMedicoDPessoais.Controls.Add(this.lblEndereco);
            this.gpbMedicoDPessoais.Controls.Add(this.lblRG);
            this.gpbMedicoDPessoais.Controls.Add(this.lblCPF);
            this.gpbMedicoDPessoais.Controls.Add(this.lblTelefone);
            this.gpbMedicoDPessoais.Controls.Add(this.lblEmail);
            this.gpbMedicoDPessoais.Controls.Add(this.lblNome);
            this.gpbMedicoDPessoais.Location = new System.Drawing.Point(22, 11);
            this.gpbMedicoDPessoais.Name = "gpbMedicoDPessoais";
            this.gpbMedicoDPessoais.Size = new System.Drawing.Size(626, 221);
            this.gpbMedicoDPessoais.TabIndex = 23;
            this.gpbMedicoDPessoais.TabStop = false;
            this.gpbMedicoDPessoais.Text = "Dados Pessoais";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(273, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cidade:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBox2.Location = new System.Drawing.Point(73, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(84, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "UF:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.comboBox1.Location = new System.Drawing.Point(271, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sexo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Celular:";
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Location = new System.Drawing.Point(73, 29);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(543, 20);
            this.txtNomeMedico.TabIndex = 1;
            // 
            // txtEnderecoMedico
            // 
            this.txtEnderecoMedico.Location = new System.Drawing.Point(73, 56);
            this.txtEnderecoMedico.MaxLength = 100;
            this.txtEnderecoMedico.Name = "txtEnderecoMedico";
            this.txtEnderecoMedico.Size = new System.Drawing.Size(543, 20);
            this.txtEnderecoMedico.TabIndex = 2;
            // 
            // txtRGMedico
            // 
            this.txtRGMedico.Location = new System.Drawing.Point(73, 83);
            this.txtRGMedico.MaxLength = 13;
            this.txtRGMedico.Name = "txtRGMedico";
            this.txtRGMedico.Size = new System.Drawing.Size(145, 20);
            this.txtRGMedico.TabIndex = 3;
            // 
            // txtCPFMedico
            // 
            this.txtCPFMedico.Location = new System.Drawing.Point(268, 84);
            this.txtCPFMedico.MaxLength = 9;
            this.txtCPFMedico.Name = "txtCPFMedico";
            this.txtCPFMedico.Size = new System.Drawing.Size(152, 20);
            this.txtCPFMedico.TabIndex = 4;
            // 
            // txtTelefoneMedico
            // 
            this.txtTelefoneMedico.Location = new System.Drawing.Point(73, 110);
            this.txtTelefoneMedico.MaxLength = 9;
            this.txtTelefoneMedico.Name = "txtTelefoneMedico";
            this.txtTelefoneMedico.Size = new System.Drawing.Size(145, 20);
            this.txtTelefoneMedico.TabIndex = 5;
            // 
            // txtEmailMedico
            // 
            this.txtEmailMedico.Location = new System.Drawing.Point(268, 113);
            this.txtEmailMedico.Name = "txtEmailMedico";
            this.txtEmailMedico.Size = new System.Drawing.Size(348, 20);
            this.txtEmailMedico.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(11, 58);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(41, 87);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 7;
            this.lblRG.Text = "RG:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(232, 87);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(15, 113);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(224, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Expediente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCadastrardentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(671, 437);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.gpbMedicoInformacoes);
            this.Controls.Add(this.gpbMedicoDPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmCadastrardentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Dentista";
            this.gpbMedicoInformacoes.ResumeLayout(false);
            this.gpbMedicoInformacoes.PerformLayout();
            this.gpbMedicoDPessoais.ResumeLayout(false);
            this.gpbMedicoDPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.GroupBox gpbMedicoInformacoes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.GroupBox gpbMedicoDPessoais;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.TextBox txtEnderecoMedico;
        private System.Windows.Forms.TextBox txtRGMedico;
        private System.Windows.Forms.TextBox txtCPFMedico;
        private System.Windows.Forms.TextBox txtTelefoneMedico;
        private System.Windows.Forms.TextBox txtEmailMedico;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button button3;
    }
}