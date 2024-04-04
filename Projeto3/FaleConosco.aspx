<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FaleConosco.aspx.cs" Inherits="Projeto3.FaleConosco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="row margin-top-120 margin-bottom-100 min-height-400">
        <!-- Formulário -->
        <div class="col-6">
            <div class="box border margin-right-20">
                <h2>Fale Conosco</h2>
                <asp:Label ID="lblAlerta" ForeColor="red" Font-Size="16px" runat="server"></asp:Label>
                <br />
                <asp:Panel ID="Formulario" runat="server">
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
                    <label>Mensagem*</label>
                    <asp:TextBox ID="txtMensagem" runat="server" TextMode="MultiLine" Rows="6" MaxLength="255"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnEnviar" OnClick="btnEnviar_Click" runat="server" Text="Enviar" />
                </asp:Panel>
            </div>
        </div>

        <div class="col-6">
            <div class="box border margin-right-20">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1300.9653070047036!2d-47.35000708845518!3d-22.739925738491053!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c89bea5cdb94f9%3A0xffb368bd91ea12ae!2sFatec%20Americana%20-%20Faculdade%20de%20Tecnologia%20de%20Americana%20Ministro%20Ralph%20Biasi!5e0!3m2!1spt-BR!2sbr!4v1711034718290!5m2!1spt-BR!2sbr" width="100%" height="100%" style="border: 0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
            </div>
        </div>
    </div>
</asp:Content>
