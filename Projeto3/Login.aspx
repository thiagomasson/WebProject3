﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto3.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="row margin-top-60">
        <div class="col-3">
            <div class="box padding-20">
                <h1>Entrar</h1>
                <br />
                <br />
                <asp:Label ID="txtMsg" runat="server"></asp:Label>
                <br />
                <label>NOME DE ACESSO</label>
                <asp:TextBox ID="txtNomeAcesso" runat="server"></asp:TextBox>
                <label>SENHA</label>
                <asp:TextBox ID="txtSenha" TextMode="Password" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnEntrar" OnClick="btnEntrar_Click" runat="server" Text="Entrar" />
                <br />
            </div>
        </div>
    </div>
</asp:Content>
