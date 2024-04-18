<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExibeExcecoes.aspx.cs" Inherits="Projeto3.ExibeExcecoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="margin-top-60">

        <div class="box margin-right-20">
            <h1>Exceções</h1>
            <br />
            <asp:Label ID="lblExcecoes" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Button ID="btnAtualizar" runat="server" OnClick="btnAtualizar_Click" Text="Atualizar" />
    </div>
</asp:Content>
