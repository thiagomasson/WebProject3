using Datapost.DB;
using System;
using System.Data;
using System.Drawing;
using System.Web.UI;

namespace Projeto3.Admin
{
    public partial class CadastroUsuario : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.QueryString.HasKeys())
            {
                lblUsuarioID.Text = Request.QueryString["key"].ToString();

                if (int.TryParse(lblUsuarioID.Text, out int idUsuario))
                    LerUsuario(idUsuario);
            }
        }

        protected void LerUsuario(int idUsuario)
        {
            string comandoSQL = $"SELECT * FROM Usuarios WHERE UsuarioID={idUsuario}";
            DataTable tb = ConsultaSQL(comandoSQL);

            txtNome.Text = tb.Rows[0]["Nome"].ToString();
            txtEmail.Text = tb.Rows[0]["Email"].ToString();
            txtNomeAcesso.Text = tb.Rows[0]["NomeAcesso"].ToString();
            txtSenha.Text = tb.Rows[0]["Senha"].ToString();
            ddlStatus.SelectedValue = tb.Rows[0]["Status"].ToString();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            lblAlerta.ForeColor = Color.Red;
            
            if (txtNome.Text.Trim() == "")
            {
                lblAlerta.Text = "Digite o nome";
                txtNome.Focus();
            }
            else if (txtEmail.Text.Trim() == "")
            {
                lblAlerta.Text = "Digite o e-mail";
                txtEmail.Focus();
            }
            else if (txtNomeAcesso.Text.Trim() == "")
            {
                lblAlerta.Text = "Digite o nome de acesso";
                txtNomeAcesso.Focus();
            }
            else if (!NomeDeAcessoValido(txtNomeAcesso.Text.Trim()))
            {
                lblAlerta.Text = "Nome de acesso inválido ou já existente";
                txtNomeAcesso.Focus();
            }
            else if (txtSenha.Text.Trim() == "")
            {
                lblAlerta.Text = "Digite a senha";
                txtSenha.Focus();
            }
            else
            {
                DAO db = new DAO();
                db.DataProviderName = DAO.ProviderName.OleDb;
                string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";
                db.ConnectionString = conexao;

                string comandoSQL;
                if (lblUsuarioID.Text == "")
                {
                    comandoSQL = $"INSERT INTO Usuarios(Nome, Email, NomeAcesso, Senha, Status) VALUES('{txtNome.Text}','{txtEmail.Text}','{txtNomeAcesso.Text}','{txtSenha.Text}',{ddlStatus.SelectedValue})";
                }
                else
                {
                    comandoSQL = $"UPDATE Usuarios SET Nome='{txtNome.Text}', Email='{txtEmail.Text}', NomeAcesso='{txtNomeAcesso.Text}', Senha='{txtSenha.Text}', Status={ddlStatus.SelectedValue} WHERE UsuarioID={lblUsuarioID.Text}";
                }

                db.Query(comandoSQL);
                Response.Redirect("ExibirUsuarios.aspx");
            }
        }

        protected bool NomeDeAcessoValido(string nomeDeAcesso)
        {
            string comandoSQL = $"SELECT NomeAcesso, UsuarioID FROM Usuarios WHERE NomeAcesso='{nomeDeAcesso}';";
            DataTable dt = ConsultaSQL(comandoSQL);

            return dt.Rows.Count <= 0 || dt.Rows[0]["UsuarioID"].ToString() == lblUsuarioID.Text;
        }

        protected DataTable ConsultaSQL(string query)
        {
            DAO db = new DAO();
            db.DataProviderName = DAO.ProviderName.OleDb;
            string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";
            db.ConnectionString = conexao;
  
            return (DataTable)db.Query(query);
        }
    }
}