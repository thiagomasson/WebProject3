﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3
{
    public partial class FaleConosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            lblMensagem.ForeColor = Color.Red;
            if (txtNome.Text.Trim() == "")
            {
                lblMensagem.Text = "Digite seu nome";
                txtNome.Focus();
            }
            else if (txtEmail.Text.Trim() == "")
            {
                lblMensagem.Text = "Digite seu e-mail";
                txtEmail.Focus();
            }
            else if (txtMensagem.Text.Trim() == "")
            {
                lblMensagem.Text = "Digite seu e-mail";
                txtEmail.Focus();
            }
            else
            {
                txtNome.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";
                txtMensagem.Text = "";
                lblMensagem.Text = "Mensagem enviada!";
                lblMensagem.ForeColor = Color.Green;
            }
        }
    }
}