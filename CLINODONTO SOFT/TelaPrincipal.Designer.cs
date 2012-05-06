namespace CLINODONTO_SOFT
{
    partial class TelaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeDentistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeSecretáriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tópicosDeAjudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOClinodontoSoftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioativo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(741, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarConsultasToolStripMenuItem,
            this.controleDeConsultasToolStripMenuItem,
            this.controleDeDocumentosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.consultaToolStripMenuItem.Text = " Consultas";
            // 
            // agendarConsultasToolStripMenuItem
            // 
            this.agendarConsultasToolStripMenuItem.Name = "agendarConsultasToolStripMenuItem";
            this.agendarConsultasToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.agendarConsultasToolStripMenuItem.Text = "Agendar  consultas";
            this.agendarConsultasToolStripMenuItem.Click += new System.EventHandler(this.agendarConsultasToolStripMenuItem_Click);
            // 
            // controleDeConsultasToolStripMenuItem
            // 
            this.controleDeConsultasToolStripMenuItem.Name = "controleDeConsultasToolStripMenuItem";
            this.controleDeConsultasToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.controleDeConsultasToolStripMenuItem.Text = "Efetuar consulta";
            this.controleDeConsultasToolStripMenuItem.Click += new System.EventHandler(this.controleDeConsultasToolStripMenuItem_Click);
            // 
            // controleDeDocumentosToolStripMenuItem
            // 
            this.controleDeDocumentosToolStripMenuItem.Name = "controleDeDocumentosToolStripMenuItem";
            this.controleDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.controleDeDocumentosToolStripMenuItem.Text = "Controle de consultas";
            this.controleDeDocumentosToolStripMenuItem.Click += new System.EventHandler(this.controleDeDocumentosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeDentistaToolStripMenuItem,
            this.cadastroDeSecretáriaToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // cadastroDeDentistaToolStripMenuItem
            // 
            this.cadastroDeDentistaToolStripMenuItem.Name = "cadastroDeDentistaToolStripMenuItem";
            this.cadastroDeDentistaToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.cadastroDeDentistaToolStripMenuItem.Text = "Cadastro de dentista";
            this.cadastroDeDentistaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeDentistaToolStripMenuItem_Click);
            // 
            // cadastroDeSecretáriaToolStripMenuItem
            // 
            this.cadastroDeSecretáriaToolStripMenuItem.Name = "cadastroDeSecretáriaToolStripMenuItem";
            this.cadastroDeSecretáriaToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.cadastroDeSecretáriaToolStripMenuItem.Text = "Cadastro de secretária";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleDePacientesToolStripMenuItem,
            this.cadastrarPacienteToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // controleDePacientesToolStripMenuItem
            // 
            this.controleDePacientesToolStripMenuItem.Name = "controleDePacientesToolStripMenuItem";
            this.controleDePacientesToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.controleDePacientesToolStripMenuItem.Text = "Controle de pacientes";
            this.controleDePacientesToolStripMenuItem.Click += new System.EventHandler(this.controleDePacientesToolStripMenuItem_Click);
            // 
            // cadastrarPacienteToolStripMenuItem
            // 
            this.cadastrarPacienteToolStripMenuItem.Name = "cadastrarPacienteToolStripMenuItem";
            this.cadastrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.cadastrarPacienteToolStripMenuItem.Text = "Cadastrar paciente";
            this.cadastrarPacienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPacienteToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.bancoDeDadosToolStripMenuItem.Text = "banco de dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tópicosDeAjudaToolStripMenuItem,
            this.sobreOClinodontoSoftToolStripMenuItem});
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.ajudaToolStripMenuItem1.Text = "Ajuda";
            // 
            // tópicosDeAjudaToolStripMenuItem
            // 
            this.tópicosDeAjudaToolStripMenuItem.Name = "tópicosDeAjudaToolStripMenuItem";
            this.tópicosDeAjudaToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.tópicosDeAjudaToolStripMenuItem.Text = "Tópicos de Ajuda";
            // 
            // sobreOClinodontoSoftToolStripMenuItem
            // 
            this.sobreOClinodontoSoftToolStripMenuItem.Name = "sobreOClinodontoSoftToolStripMenuItem";
            this.sobreOClinodontoSoftToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.sobreOClinodontoSoftToolStripMenuItem.Text = "Sobre o Clinodonto Soft";
            this.sobreOClinodontoSoftToolStripMenuItem.Click += new System.EventHandler(this.sobreOClinodontoSoftToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioativo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(741, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuarioativo
            // 
            this.lblUsuarioativo.Name = "lblUsuarioativo";
            this.lblUsuarioativo.Size = new System.Drawing.Size(111, 20);
            this.lblUsuarioativo.Text = "Usuário Ativo: _";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 441);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeDentistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeSecretáriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tópicosDeAjudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOClinodontoSoftToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioativo;
    }
}