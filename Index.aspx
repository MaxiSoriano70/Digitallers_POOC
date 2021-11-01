<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Entity1.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Método genérico</h1>
            <asp:Label ID="dato_generico" runat="server" />
            <h1>Extended</h1>
            <h3>Herencia</h3>
            <asp:Label ID="valor_clasea" runat="server" /><br />
            <asp:Label ID="valor_claseb" runat="server" />
            <h3>Extended</h3>
            <asp:Label ID="valor_extended" runat="server" /> <br />
            <asp:Label ID="valor_suma" runat="server" />
            <h1>Inferencia de Tipo</h1>
            <asp:Label ID="valor_inferencia" runat="server" />
            <h1>Valores anónimos</h1>
            Tipo de dato:<asp:Label ID="valor_tipo_anonima" runat="server" /><br />
            Titulo:<asp:Label ID="valor_titulo" runat="server" /><br />
            Propiedad1 : <asp:Label ID="valor_prop1" runat="server" /><br />
            Propiedad2 : <asp:Label ID="valor_prop2" runat="server" />
            <h1>Clase Parcial</h1>
            Método archivo ClaseA: <asp:Label ID="valor_parcial_a" runat="server" /><br />
            Método archivo ClaseB: <asp:Label ID="valor_parcial_b" runat="server" /><br />
            Método archivo ClaseC: <asp:Label ID="valor_parcial_c" runat="server" />
        </div>
    </form>
</body>
</html>
