using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datapost.DB;

namespace Projeto3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            DAO db = new DAO();
            db.DataProviderName = DAO.ProviderName.OleDb;
            string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";
            db.ConnectionString = conexao;

            string[] values = { 
                "'Diogenes','diogenes@gmail.com', 'xxxx', '12345', 1", 
                "'Zem','zem@gmail.com', 'zem', '12345', 1",
                "'Vicentini','vicentini@gmail.com', 'vicentini', '12345', 1"
            };

            foreach (string val in values)
            {
                string comandoSql = "INSERT INTO Usuarios(Nome,Email,NomeAcesso,Senha,Status) VALUES(" + val + ");";
                db.Query(comandoSql);
            }
        }
    }
}