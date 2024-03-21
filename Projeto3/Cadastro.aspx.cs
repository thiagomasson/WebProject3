using System;
using System.Drawing;

namespace Projeto3
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected string Caminho => Server.MapPath("~/cadastro.txt");

        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarCadastros();
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
            else
            {
                
                string conteudo = txtNome.Text.Trim() + "\n";
                conteudo += txtEmail.Text.Trim() + "\n";
                conteudo += txtTelefone.Text.Trim() + "\n";
                conteudo += "-------------------\n";

                System.IO.File.AppendAllText(Caminho, conteudo);

                txtNome.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";
                lblMensagem.Text = "Cadastro concluído!";
                lblMensagem.ForeColor = Color.Green;

                MostrarCadastros();
            }
        }

        protected void MostrarCadastros() 
        {
            lblDados.Text = System.IO.File.ReadAllText(Caminho).Replace("\n", "<br>");
        }
    }
}