<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Projeto3.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="row margin-top-120 margin-bottom-100 min-height-400">
        <!-- Formulário -->
        <div class="col-6">
            <div class="box border margin-right-20">
                <h2>Cadastro</h2>
                <br />
                *Obrigatório
                <br />
                <asp:Label ID="lblMensagem" ForeColor="Red" Font-Size="16px" runat="server"></asp:Label>
                <label>Nome*</label>
                <asp:TextBox ID="txtNome" runat="server" MaxLength="60"></asp:TextBox>
                <label>E-mail*</label>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" MaxLength="60"></asp:TextBox>
                <label>Telefone</label>
                <asp:TextBox ID="txtTelefone" runat="server" MaxLength="20"></asp:TextBox>
                <br />
                <asp:Button ID="btnEnviar" OnClick="btnEnviar_Click" runat="server" Text="Enviar" />
            </div>
        </div>

        <div class="col-6">
            <div class="box border">
                <asp:Label ID="lblDados" runat="server"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
