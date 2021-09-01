<%@ Page Title="" Language="C#" MasterPageFile="~/Capas.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Capas.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Libros</h1>
    <p>
        Título: <asp:Label runat="server" ID="lb_titulo" />
    </p>
    <p>
        Editorial: <asp:Label runat="server" ID="lb_editorial" />
    </p>
</asp:Content>
