using Datapost.DB;
using System;
using System.Web.UI;

namespace Projeto3.Admin
{
    public partial class ExibirUsuarios : Page
    {
        protected void Page_Load(object sender, EventArgs e) => LerUsuarios();

        protected void LerUsuarios()
        {
            DAO db = new DAO();
            db.DataProviderName = DAO.ProviderName.OleDb;
            string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";
            db.ConnectionString = conexao;

            string comandoSQL = "SELECT UsuarioID, Nome, Email, NomeAcesso, Status FROM Usuarios ORDER BY Nome ASC";

            GridViewUsuarios.DataSource = db.Query(comandoSQL);
            GridViewUsuarios.DataBind();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroUsuario.aspx");
        }

        protected void btnFechar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void GridViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chave = GridViewUsuarios.SelectedRow.Cells[1].Text;
            Response.Redirect($"CadastroUsuario.aspx?key={chave}");
        }
    }
}