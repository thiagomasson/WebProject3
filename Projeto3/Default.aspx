<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <!-- Place somewhere in the <body> of your page -->
    <div class="flexslider">
        <ul class="slides">
            <li>
                <img src="Images/banner0.png" />
            </li>
            <li>
                <img src="Images/banner1.png" />
            </li>
            <li>
                <img src="Images/banner2.png" />
            </li>
            <li>
                <img src="Images/banner3.png" />
            </li>
            <li>
                <img src="Images/banner4.png" />
            </li>
        </ul>
    </div>

    <script>
        // Can also be used with $(document).ready()
        $(window).load(function () {
            $('.flexslider').flexslider({
                animation: "slide"
            });
        });
    </script>

    <div class="row min-height-400 margin-top-120 margin-bottom-100">
        <!-- Coluna 1 -->
        <div class="col-3">
            <div class="box border margin-right-20">
                <img src="Images/si1.png" width="100%" />
                <br />
                <h2>Segurança da Informação</h2>
                <br />
                <p>
                    Aliquam quis viverra massa. Fusce eget magna quis eros convallis scelerisque. Aenean vitae ante sagittis, molestie nisl sed, malesuada enim. Aliquam ac ultrices dolor. Vivamus ultrices placerat mauris ac ultricies. Cras ut justo metus. Ut sapien leo, elementum vel dui vel, accumsan efficitur erat.
                </p>
                <br />
                <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Seguranca.aspx" runat="server">Saiba mais</asp:HyperLink>
            </div>
        </div>
        <!-- Coluna 2 -->
        <div class="col-3">
            <div class="box border margin-right-20">
                <asp:Button ID="btnInserir" OnClick="btnInserir_Click" runat="server" Text="Inserir" />
            </div>
        </div>
        <!-- Coluna 3 -->
        <div class="col-3">
            <div class="box border margin-right-20">
                COLUNA3
            </div>
        </div>
        <!-- Coluna 4 -->
        <div class="col-3">
            <div class="box border">
                COLUNA4
            </div>
        </div>

    </div>

</asp:Content>
