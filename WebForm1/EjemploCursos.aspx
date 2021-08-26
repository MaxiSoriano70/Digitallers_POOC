<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploCursos.aspx.cs" Inherits="WebForm1.EjemploCursos" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
            <h1>Ejemplo de Curso</h1>
            <h4>Listado de Estudiantes</h4>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Dni</th>
                        <th>Nombre</th>
                        <th>Apellido</th>
                    </tr>
                </thead>
                <tbody>
                    <%foreach (WebForm1.Estudiantes estudiantes in MiCurso.Estudiantes)
                        {%>
                    <tr>
                        <td><%=estudiantes.Dni %></td>
                        <td><%=estudiantes.Nombre %></td>
                        <td><%=estudiantes.Apellido %></td>
                    </tr>
                    <%} %>
                </tbody>
            </table>
            <h4>Datos del Instructor/a</h4>
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>DNI</th>
                        <th>Nombre</th>
                        <th>Apellido</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td><%= MiCurso.Instructor.Dni %></td>
                        <td><%= MiCurso.Instructor.Nombre %></td>
                        <td><%= MiCurso.Instructor.Apellido %></td>
                    </tr>
                </tbody>
            </table>
            <h4>Materias asignadas a la instructor/a</h4>
            <table class="table table-hover table-bordered">
                <tbody>
                    <%foreach (WebForm1.Materia materia in MiCurso.Instructor.Materias)
                        {
                            %>
                    <tr>
                        <td><%=materia.Nombre %></td>
                        <td><%=materia.Programa %></td>
                    </tr>
                    <%} %>
                </tbody>
            </table>
            <h4>Listado de clases del Curso</h4>
            <table class="table table-primary table-bordered">
                <thead>
                    <tr>
                        <th>Inicio</th>
                        <th>Fin</th>
                        <th>Aula</th>
                    </tr>
                </thead>
                <tbody>
                    <%foreach (WebForm1.Clase clase in MiCurso.Clases)
                        {%>
                    <tr>
                        <td><%=clase.Inicio.ToString("dd/MM/yyyy HH:mm") %> HS</td>
                        <td><%=clase.Fin.ToString("dd/MM/yyyy HH:mm") %>HS</td>
                        <td><%=clase.Aula.Codigo %></td>
                    </tr>
                    <%} %>
                </tbody>
            </table>
            <h4>Listado de Cursos</h4>
            <table class="table table-bordered table-success">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Instructor/a</th>
                    <th>Materia</th>
                    <th>Cantidad de Clases</th>
                    <th>Cantidad de estudiantes</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td><%=MiCurso.Id_Curso.ToString() %></td>
                    <td><%=MiCurso.Instructor.Nombre+" "+MiCurso.Instructor.Apellido %></td>
                    <td><%=MiCurso.Materia.Nombre %></td>
                    <td><%=MiCurso.Cantidad_Clases %></td>
                    <td><%=MiCurso.Cantidad_Estudiantes %></td>
                </tr>
            </tbody>
            </table>
        </div>
</asp:Content>
