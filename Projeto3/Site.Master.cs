using System;
using System.Web.UI;

namespace Projeto3
{
    public partial class Site : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool autenticado = Session["autenticado"] != null;

            ExPing.Visible = ExExcecoes.Visible = lnkSair.Visible = autenticado;
            lnkEntrar.Visible = !autenticado;
        }
    }
}