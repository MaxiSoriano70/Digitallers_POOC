<%@ Page Title="" Language="C#" MasterPageFile="~/Capas.Master" AutoEventWireup="true" CodeBehind="ListadoAjax.aspx.cs" Inherits="Capas.ListadoAjax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Listado</h1>
    <table class="table table-bordered table-hover">
        <thead>
            <tr>
                <th>#</th>
                <th>Título</th>
                <th>Autor</th>
                <th>Editorial</th>
            </tr>
        </thead>
        <tbody id="bodyTabla">
        </tbody>
    </table>
    <!-- Modal -->
    <div class="modal fade" id="modalModificar" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-lg"">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Actualizar Libro</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="mb-3">
                        <label for="Titulo" class="col-form-label">Título:</label>
                        <input type="text" class="form-control" id="modal_titulo" name="titulo" />
                    </div>
                    <div class="mb-3">
                        <label for="select_autor" class="col-form-label">Autor:</label>
                        <select class="form-control" id="select_autor" name="select_autor"></select>
                    </div>
                    <div class="mb-3">
                        <label for="select_editorial" class="col-form-label">Editorial:</label>
                        <select class="form-control" id="select_editorial" name="select_editorial"></select>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
                    <button type="button" class="btn btn-primary">Guardar Cambios</button>
                </div>
            </div>
        </div>
    </div>
    <script src="scripts/jquery-3.6.0.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <script src="CustomScripts/listado.js"></script>
</asp:Content>
