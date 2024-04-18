using System;
using System.Drawing;
using System.Net.Mail;

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
                try
                {
                    // Criar uma instancia da Classe System.Net.Mail.MailMessage()

                    MailMessage mail = new MailMessage();
                    mail.To.Add("contato@seudominio.com.br");
                    MailAddress from = new MailAddress("contato@seudominio.com.br");
                    mail.From = from;
                    mail.Subject = "Enviado pelo Fale Conosco";

                    mail.Body = "Nome: " + txtNome.Text + "\n";
                    mail.Body += "Email: " + txtEmail.Text + "\n";
                    mail.Body += "Telefone: " + txtTelefone.Text + "\n";
                    mail.Body += "Mensagem: " + txtMensagem.Text + "\n";

                    mail.IsBodyHtml = false;

                    // Cria uma instância da clase SMTPClient()
                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "seudominio.com.br",
                        Credentials = new System.Net.NetworkCredential("contato@seudominio.com.br", "suasenha")
                    };
                    smtp.Send(mail);

                    Formulario.Visible = false;
                    lblAlerta.Text = "Seu e-mail foi envido com sucesso";
                    lblAlerta.ForeColor = Color.Green;
                } 
                catch (Exception ex)
                {
                    lblAlerta.Text = "Houve uma falha ao enviar o e-mail. Tente novamente mais tarde :)";

                    //  Grave em um arquivo de texto denominado "Excecoes.txt" os dados recuperados em "ex.StackTrace"

                    string conteudo = DateTime.Now
                        + "\n" + ex.Message 
                        + "\n" + ex.StackTrace
                        + "\n----------------------------------\n";

                    System.IO.File.AppendAllText(Server.MapPath("~/Excecoes.txt"), conteudo);

                }
            }
        }
    }
}