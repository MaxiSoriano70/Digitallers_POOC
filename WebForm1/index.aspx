<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebForm1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous">
    <title>Clase 1 App</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Formulario</h1>
            <div class="row">
                <div class="form-group col-4">
                    <label>Nombre:</label>
                    <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control"/>
                </div>
                <div class="form-group col-4">
                    <label>Apellido:</label>
                    <asp:TextBox ID="txt_apellido" runat="server" CssClass="form-control"/>
                </div>
            </div>
            <asp:Button ID="btn_enviar" CssClass="btn btn-primary mt-3" runat="server" Text="Enviar Datos"/>
        </div>
    </form>
</body>
</html>
