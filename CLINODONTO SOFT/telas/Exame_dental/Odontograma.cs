﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLINODONTO_SOFT
{
    public partial class frmExameDental : Form
    {
        public frmExameDental()
        {
            InitializeComponent();
        }

        /*Dentes Renomeados - Concluido*/

        /*Eventos do DENTE 1*/
        private void pbxBrancoCima_Click(object sender, EventArgs e)
        {
            pbxBrancoCima.Visible = false;
            pbxAmareloCima.Visible = true;
        }

        private void pbxAmareloCima_Click(object sender, EventArgs e)
        {
            pbxAmareloCima.Visible = false;
            pbxRedCima.Visible = true;
        }

        private void pbxRedCima_Click(object sender, EventArgs e)
        {
            pbxRedCima.Visible = false;
            pbxAzulCima.Visible = true;
        }

        private void pbxAzulCima_Click(object sender, EventArgs e)
        {
            pbxAzulCima.Visible = false;
            pbxBrancoCima.Visible = true;
        }

        private void pbxBrancoBaixo_Click(object sender, EventArgs e)
        {
            pbxBrancoBaixo.Visible = false;
            pbxAmareloBaixo.Visible = true;
        }

        private void pbxAmareloBaixo_Click(object sender, EventArgs e)
        {
            pbxAmareloBaixo.Visible = false;
            pbxRedBaixo.Visible = true;
        }

        private void pbxRedBaixo_Click(object sender, EventArgs e)
        {
            pbxRedBaixo.Visible = false;
            pbxAzulBaixo.Visible = true;
        }

        private void pbxAzulBaixo_Click(object sender, EventArgs e)
        {
            pbxAzulBaixo.Visible = false;
            pbxBrancoBaixo.Visible = true;
        }

        private void pbxBrancoLeft_Click(object sender, EventArgs e)
        {
            pbxBrancoLeft.Visible = false;
            pbxAmareloLeft.Visible = true;
        }

        private void pbxAmareloLeft_Click(object sender, EventArgs e)
        {
            pbxAmareloLeft.Visible = false;
            pbxRedLetf.Visible = true;
        }

        private void pbxRedLetf_Click(object sender, EventArgs e)
        {
            pbxRedLetf.Visible = false;
            pbxAzulLeft.Visible = true;
        }

        private void pbxAzulLeft_Click(object sender, EventArgs e)
        {
            pbxAzulLeft.Visible = false;
            pbxBrancoLeft.Visible = true;
        }

        private void pbxBrancoMeio_Click(object sender, EventArgs e)
        {
            pbxBrancoMeio.Visible = false;
            pbxAmareloMeio.Visible = true;
        }

        private void pbxAmareloMeio_Click(object sender, EventArgs e)
        {
            pbxAmareloMeio.Visible = false;
            pbxRedMeio.Visible = true;
        }

        private void pbxRedMeio_Click(object sender, EventArgs e)
        {
            pbxRedMeio.Visible = false;
            pbxAzulMeio.Visible = true;
        }

        private void pbxAzulMeio_Click(object sender, EventArgs e)
        {
            pbxAzulMeio.Visible = false;
            pbxBrancoMeio.Visible = true;
        }

        private void pbxBrancoRight_Click(object sender, EventArgs e)
        {
            pbxBrancoRight.Visible = false;
            pbxAmareloRight.Visible = true;
        }

        private void pbxAmareloRight_Click(object sender, EventArgs e)
        {
            pbxAmareloRight.Visible = false;
            pbxRedRight.Visible = true;
        }

        private void pbxRedRight_Click(object sender, EventArgs e)
        {
            pbxRedRight.Visible = false;
            pbxAzulRight.Visible = true;
        }

        private void pbxAzulRight_Click(object sender, EventArgs e)
        {
            pbxAzulRight.Visible = false;
            pbxBrancoRight.Visible = true;
        }

        //Eventos do Dente 2
        private void pbxBrancoCima2_Click(object sender, EventArgs e)
        {
            pbxBrancoCima2.Visible = false;
            pbxAmareloCima2.Visible = true;
        }

        private void pbxAmareloCima2_Click(object sender, EventArgs e)
        {
            pbxAmareloCima2.Visible = false;
            pbxRedCima2.Visible = true;
        }

        private void pbxRedCima2_Click(object sender, EventArgs e)
        {
            pbxRedCima2.Visible = false;
            pbxAzulCima2.Visible = true;
        }

        private void pbxAzulCima2_Click(object sender, EventArgs e)
        {
            pbxAzulCima2.Visible = false;
            pbxBrancoCima2.Visible = true;
        }

        private void pbxBrancoLeft2_Click(object sender, EventArgs e)
        {
            pbxBrancoLeft2.Visible = false;
            pbxAmareloLeft2.Visible = true;
        }

        private void pbxAmareloLeft2_Click(object sender, EventArgs e)
        {
            pbxAmareloLeft2.Visible = false;
            pbxRedLeft2.Visible = true;
        }

        private void pbxRedLeft2_Click(object sender, EventArgs e)
        {
            pbxRedLeft2.Visible = false;
            pbxAzulLeft2.Visible = true;
        }

        private void pbxAzulLeft2_Click(object sender, EventArgs e)
        {
            pbxAzulCima2.Visible = false;
            pbxBrancoLeft2.Visible = true;
        }

        private void pbxBrancoMeio2_Click(object sender, EventArgs e)
        {
            pbxBrancoMeio2.Visible = false;
            pbxAmareloMeio2.Visible = true;
        }

        private void pbxAmareloMeio2_Click(object sender, EventArgs e)
        {
            pbxAmareloMeio2.Visible = false;
            pbxRedMeio2.Visible = true;
        }

        private void pbxRedMeio2_Click(object sender, EventArgs e)
        {
            pbxRedMeio2.Visible = false;
            pbxAzulMeio2.Visible = true;
        }

        private void pbxAzulMeio2_Click(object sender, EventArgs e)
        {
            pbxAzulMeio2.Visible = false;
            pbxBrancoMeio2.Visible = true;
        }

        private void pbxBrancoRight2_Click(object sender, EventArgs e)
        {
            pbxBrancoRight2.Visible = false;
            pbxAmareloRight2.Visible = true;
        }

        private void pbxAmareloRight2_Click(object sender, EventArgs e)
        {
            pbxAmareloRight2.Visible = false;
            pbxRedRight2.Visible = true;
        }

        private void pbxRedRight2_Click(object sender, EventArgs e)
        {
            pbxRedRight2.Visible = false;
            pbxAzulRight2.Visible = true;
        }

        private void pbxAzulRight2_Click(object sender, EventArgs e)
        {
            pbxAzulRight2.Visible = false;
            pbxBrancoRight2.Visible = true;
        }

        private void pbxBrancoBaixo2_Click(object sender, EventArgs e)
        {
            pbxBrancoBaixo2.Visible = false;
            pbxAmareloBaixo2.Visible = true;
        }

        private void pbxAmareloBaixo2_Click(object sender, EventArgs e)
        {
            pbxAmareloBaixo2.Visible = false;
            pbxRedBaixo2.Visible = true;
        }

        private void pbxRedBaixo2_Click(object sender, EventArgs e)
        {
            pbxRedBaixo2.Visible = false;
            pbxAzulBaixo2.Visible = true;
        }

        private void pbxAzulBaixo2_Click(object sender, EventArgs e)
        {
            pbxAzulBaixo2.Visible = false;
            pbxBrancoBaixo2.Visible = true;
        }
    }
}
