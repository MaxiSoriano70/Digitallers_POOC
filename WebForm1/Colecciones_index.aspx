<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colecciones_index.aspx.cs" Inherits="WebForm1.Colecciones1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Colecciones</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Arrays</h1>
            <ul>
            <% //foreach(int item in miArray){ %>
                <li><%=//item; %></li>
            <% for (int i=0;i<miArray.Length;i++){ %>
                <li><%=int item=miArray.GetValue(i); %></li>
            <%}%>
            </ul>
            <hr />
            <h1>List de Strings</h1>
            <ul>
            <%  foreach (string cadena in lisCadenas  ){ %>
                <li><%=int string=.GetValue(i); %></li>
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
                <%  foreach(WebForm1.Persona p in listadoPersonas){ %>
                <tr>
                    <td><%=p.Dni %></td>
                    <td><%=p.Nombre %></td>
                    <td><%=p.Apellido%></td>
                </tr>
                <%} %>
            </table>
        </div>
    </form>
</body>
</html>
