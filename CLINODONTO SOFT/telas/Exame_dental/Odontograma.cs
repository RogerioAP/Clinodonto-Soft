using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLINODONTO_SOFT
{
    public partial class Odontograma : Form
    {
        public Odontograma()
        {
            InitializeComponent();
        }

        private void pbxBrancoCima_Click(object sender, EventArgs e)
        {
            pbxBrancoCima.Visible = false;
            pbxAmareloCima.Visible = true;
        }

        private void pbxAmareloCima_Click(object sender, EventArgs e)
        {
            pbxAmareloCima.Visible = false;
            pbxVermelhoCima.Visible = true;
        }

        private void pbxVermelhoCima_Click(object sender, EventArgs e)
        {
            pbxVermelhoCima.Visible = false;
            pbxAzulCima.Visible = true;
        }

        private void pbxAzulCima_Click(object sender, EventArgs e)
        {
            pbxAzulCima.Visible = false;
            pbxBrancoCima.Visible = true;
        }

        private void pbxBrancoEsquerda_Click(object sender, EventArgs e)
        {
            pbxBrancoEsquerda.Visible = false;
            pbxAmareloEsquerda.Visible = true;
        }

        private void pbxAmareloEsquerda_Click(object sender, EventArgs e)
        {
            pbxAmareloEsquerda.Visible = false;
            pbxVermelhoEsquerda.Visible = true;
        }

        private void pbxVermelhoEsquerda_Click(object sender, EventArgs e)
        {
            pbxVermelhoEsquerda.Visible = false;
            pbxAzulEsquerdo.Visible = true;
        }

        private void pbxAzulEsquerdo_Click(object sender, EventArgs e)
        {
            pbxAzulEsquerdo.Visible = false;
            pbxBrancoEsquerda.Visible = true;
        }

        private void pbxBrancoMeio_Click(object sender, EventArgs e)
        {
            pbxBrancoMeio.Visible = false;
            pbxAmareloMeio.Visible = true;
        }

        private void pbxAmareloMeio_Click(object sender, EventArgs e)
        {
            pbxAmareloMeio.Visible = false;
            pbxVermelhoMeio.Visible = true;
        }

        private void pbxVermelhoMeio_Click(object sender, EventArgs e)
        {
            pbxVermelhoMeio.Visible = false;
            pbxAzulMeio.Visible = true;
        }

        private void pbxAzulMeio_Click(object sender, EventArgs e)
        {
            pbxAzulMeio.Visible = false;
            pbxBrancoMeio.Visible = true;
        }

        private void pbxBrancoDireito_Click(object sender, EventArgs e)
        {
            pbxBrancoDireito.Visible = false;
            pbxAmareloDireito.Visible = true;
        }

        private void pbxAmareloDireito_Click(object sender, EventArgs e)
        {
            pbxAmareloDireito.Visible = false;
            pbxVermelhoDireto.Visible = true;
        }

        private void pbxVermelhoDireto_Click(object sender, EventArgs e)
        {
            pbxVermelhoDireto.Visible = false;
            pbxAzulDireito.Visible = true;
        }

        private void pbxAzulDireito_Click(object sender, EventArgs e)
        {
            pbxAzulDireito.Visible = false;
            pbxBrancoDireito.Visible = true;
        }

        private void pbxBrancoBaixo_Click(object sender, EventArgs e)
        {
            pbxBrancoBaixo.Visible = false;
            pbxAmareloBaixo.Visible = true;
        }

        private void pbxAmareloBaixo_Click(object sender, EventArgs e)
        {
            pbxAmareloBaixo.Visible = false;
            pbxVermelhoBaixo.Visible = true;
        }

        private void pbxVermelhoBaixo_Click(object sender, EventArgs e)
        {
            pbxVermelhoBaixo.Visible = false;
            pbxAzulBaixo.Visible = true;
        }

        private void pbxAzulBaixo_Click(object sender, EventArgs e)
        {
            pbxAzulBaixo.Visible = false;
            pbxBrancoBaixo.Visible = true;
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Clicou");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
