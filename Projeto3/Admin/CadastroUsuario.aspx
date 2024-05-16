<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="Projeto3.Admin.CadastroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="row margin-top-60">
        <div class="col-6">
            <div class="box border">
                <h2>Usuário</h2>
                <br />
                <asp:Label ID="lblAlerta" ForeColor="Red" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblUsuarioID" Font-Size="20px" runat="server"></asp:Label>
                <br />
                <label>Nome</label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <label>E-mail</label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <label>Nome de acesso</label>
                <asp:TextBox ID="txtNomeAcesso" runat="server"></asp:TextBox>
                <label>Senha</label>
                <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
                <label>Status</label>
                <asp:DropDownList ID="ddlStatus" runat="server">
                    <asp:ListItem Text="Ativo" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Inativo" Value="0"></asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="btnSalvar" OnClick="btnSalvar_Click" runat="server" Text="Salvar" />
            </div>
        </div>
    </div>
</asp:Content>
