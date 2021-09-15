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
    <hr />
    <h1>Listado de libros</h1>
    <% if (libros.Count > 0)
                { %>
    <div class="row">
        <% foreach (Entities.Libro libro in libros)
            { %>
      <div class="col-sm-3 mt-3">
        <div class="card">
          <img src="images/fondo d@ 3.png" class="card-img-top" alt="...">
          <div class="card-body">
            <h5 class="card-title"><%= libro.Titulo %></h5>
            <h6 class="card-subtitle mb-2 text-muted"><%= libro.Autor %></h6>
            <p class="card-text"><i>Editorial:</i><%= libro.Editorial %></p>
          </div>
        </div>
      </div>
        <% } %>
    </div>
    <% 
            }%>
    <hr />
    <div class="alert alert-danger" role="alert">
        <asp:Label runat="server" ID="mensaje_error" />
    </div>
    <div class="alert alert-primary" role="alert">
        <asp:Label runat="server" ID="mensaje_final" />
    </div>
    
</asp:Content>

