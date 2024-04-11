<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExecutarPing.aspx.cs" Inherits="Projeto3.ExecutarPing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="margin-top-60">
        <div class="row">
            <div class="col-6">
                <div class="box margin-right-20">
                    <h1>Executar Ping</h1>
                    <br />
                    <label>Endereço</label>
                    <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
                    <asp:Button ID="btnEnviar" OnClick="btnEnviar_Click" runat="server" Text="Enviar" />
                </div>
            </div>
            <div class="col-6">
                <div class="box">
                    <h1>Resultado</h1>
                    <br />
                    <asp:Label ID="lblResultado" Font-Size="16px" runat="server"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
