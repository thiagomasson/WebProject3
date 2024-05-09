<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExibirUsuarios.aspx.cs" Inherits="Projeto3.Admin.ExibirUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="margin-top-60">
        <asp:Button ID="btnInserir" OnClick="btnInserir_Click" runat="server" Text="Novo" />
        <asp:Button ID="btnFechar"  OnClick="btnFechar_Click" runat="server" Text="Fechar" />
        <br />
        <br />
        <asp:GridView ID="GridViewUsuarios" CellPadding="8" BorderColor="Gray" AutoGenerateSelectButton="true" Width="100%" OnSelectedIndexChanged="GridViewUsuarios_SelectedIndexChanged" runat="server"></asp:GridView>
    </div>
</asp:Content>