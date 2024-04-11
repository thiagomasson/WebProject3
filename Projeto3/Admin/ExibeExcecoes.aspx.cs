using System;
using System.Web.UI;

namespace Projeto3
{
    public partial class ExibeExcecoes : Page
    {
        protected string Caminho => Server.MapPath("~/Excecoes.txt");

        protected void Page_Load(object sender, EventArgs e) => MostrarExcecoes();

        protected void btnAtualizar_Click(object sender, EventArgs e) => MostrarExcecoes();

        protected void MostrarExcecoes()
        {
            lblExcecoes.Text = System.IO.File.ReadAllText(Caminho).Replace("\n", "<br>");
        }
    }
}