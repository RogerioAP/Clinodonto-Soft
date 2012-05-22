namespace CLINODONTO_SOFT.telas
{
    partial class frmExame_fisico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExame_fisico));
            this.lblGeral = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblExtra_oral = new System.Windows.Forms.Label();
            this.lblIntra_oral = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGeral
            // 
            this.lblGeral.AutoSize = true;
            this.lblGeral.Location = new System.Drawing.Point(29, 24);
            this.lblGeral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGeral.Name = "lblGeral";
            this.lblGeral.Size = new System.Drawing.Size(38, 13);
            this.lblGeral.TabIndex = 0;
            this.lblGeral.Text = "Geral: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 40);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(516, 94);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // lblExtra_oral
            // 
            this.lblExtra_oral.AutoSize = true;
            this.lblExtra_oral.Location = new System.Drawing.Point(29, 148);
            this.lblExtra_oral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtra_oral.Name = "lblExtra_oral";
            this.lblExtra_oral.Size = new System.Drawing.Size(59, 13);
            this.lblExtra_oral.TabIndex = 2;
            this.lblExtra_oral.Tag = "";
            this.lblExtra_oral.Text = "Extra Oral: ";
            // 
            // lblIntra_oral
            // 
            this.lblIntra_oral.AutoSize = true;
            this.lblIntra_oral.Location = new System.Drawing.Point(29, 280);
            this.lblIntra_oral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntra_oral.Name = "lblIntra_oral";
            this.lblIntra_oral.Size = new System.Drawing.Size(56, 13);
            this.lblIntra_oral.TabIndex = 3;
            this.lblIntra_oral.Tag = "";
            this.lblIntra_oral.Text = "Intra Oral: ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(32, 164);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(516, 94);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(32, 299);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(516, 94);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(472, 421);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar:";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmExame_fisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(596, 470);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lblIntra_oral);
            this.Controls.Add(this.lblExtra_oral);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmExame_fisico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExame_fisico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeral;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblExtra_oral;
        private System.Windows.Forms.Label lblIntra_oral;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button btnSalvar;
    }
}