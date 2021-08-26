<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colecciones_index.aspx.cs" Inherits="WebForm1.Colecciones1" MasterPageFile="~/Secundario.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Arrays</h1>
        <!-- CON FOREACH-->
        <ul>
            <% foreach(int item in miArray){ %>
            <li><%=item %></li>
            <%}%>
        </ul>
        <!--CON FOR-->
        <ul>
            <% for (int i=0;i<miArray.Length;i++){ %>
            <li><%=miArray.GetValue(i)%></li>
            <%}%>
        </ul>
        <!--CON FOR DE OTRA MANERA-->
        <ul>
            <% for (int i=0;i<miArray.Length;i++){
                        int item = (int)miArray.GetValue(i);%>
            <li><%=item%></li>
            <%}%>
        </ul>
        <hr />
        <h1>List de Strings</h1>
        <ul>
            <% foreach (string cadena in listCadenas){ %>
            <li><%=cadena%></li>
            <%}%>
        </ul>
        <hr />
        <h1>Tabla de personas</h1>
        <table class="table table-bordered table-hover">
            <thead>
                <tr>
                    <th>DNI</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                </tr>
            </thead>
            <tr>
                <td>1234578</td>
                <td>Pablo</td>
                <td>Jota</td>
            </tr>
        </table>
        <h1>Tabla de personas con forech</h1>
        <table class="table table-bordered table-hover">
            <thead>
                <tr>
                    <th>DNI</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                </tr>
            </thead>
            <%foreach(WebForm1.Persona p in listadoPersonas){ %>
            <tr>
                <td><%=p.Dni %></td>
                <td><%=p.Nombre %></td>
                <td><%=p.Apellido%></td>
            </tr>
            <%} %>
        </table>
    </div>
</asp:Content>
