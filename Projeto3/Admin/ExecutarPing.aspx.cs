using System;
using System.Net.NetworkInformation;

namespace Projeto3
{
    public partial class ExecutarPing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Ping exPing = new Ping();
                PingReply retorno = exPing.Send(txtEndereco.Text);

                if (retorno.Status == IPStatus.Success)
                {
                    lblResultado.Text = "Status: " + retorno.Status.ToString() + "<br>";
                    lblResultado.Text += "Endereço " + retorno.Address.ToString() + "<br>";
                    lblResultado.Text += "Tempo: " + retorno.RoundtripTime.ToString() + " ms<br>";
                    lblResultado.Text += "Bytes: " + retorno.Buffer.Length.ToString() + "<br>";
                    lblResultado.Text += "Nós: " + retorno.Options.Ttl.ToString() + "<br>";
                    lblResultado.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblResultado.Text = "Falha na execução<br>";
                    lblResultado.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {
                lblResultado.Text = "Falha na execução<br>";
                lblResultado.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}