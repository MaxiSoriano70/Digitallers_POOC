<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Fin.aspx.cs" Inherits="WebForm1.Fin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Fin</h1>
    <div class="mb-3">
        <label for="Nombre" class="form-label">Nombre:</label>
        <asp:TextBox Cssclass="form-control" runat="server" ID="txt_nombre" ReadOnly="true"/>
    </div>
    <div class="mb-3">
        <label for="Apellido" class="form-label">Apellido:</label>
        <asp:TextBox Cssclass="form-control" runat="server" ID="txt_apellido" ReadOnly="true"/>
    </div>
</asp:Content>
