<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebForm1.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Inicio</h1>
    <div class="mb-3">
        <label for="Nombre" class="form-label">Nombre:</label>
        <asp:TextBox Cssclass="form-control" runat="server" ID="txt_nombre" />
    </div>
    <div class="mb-3">
        <label for="Apellido" class="form-label">Apellido:</label>
        <asp:TextBox Cssclass="form-control" runat="server" ID="txt_apellido" />
    </div>
    <div class="mb-3">
        <asp:Button CssClass="btn btn-primary" runat="server" Text="GET" ID="btn_get" OnClick="btn_get_click" />
        <asp:Button CssClass="btn btn-secondary" runat="server" Text="POST" ID="btn_post" PostBackUrl="~/Fin.aspx"/>
    </div>
</asp:Content>
