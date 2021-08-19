<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colecciones_index.aspx.cs" Inherits="WebForm1.Colecciones1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous" />
    <title>Colecciones</title>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
