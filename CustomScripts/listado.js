//console.log("Hola Mundo!!!");
/*$(document).ready
 ES EL EQUIVALENTE PAGE LOAD EN C#
 */
$(document).ready(function () {
    //console.log("Document loaded");
    obtenerLibros();
})

function obtenerLibros() {
    $.ajax({
        type: 'GET',
        url: 'ListadoAjax.aspx/ObtenerLibrosAjax',
        data: {},
        contentType: 'application/json',
        dataType: 'json'
    })
        .done(setearTabla)
        .fail(setearError)
}
function setearTabla(response) {
    //console.log(response.d);
    if (response.d.length > 0) {
        $.each(response.d, function (key, value){
            $("#bodyTable").append(
                "<tr onclick='mostrarModal()'>" +
                "<td>" + value.Id + "</td>" +
                "<td>" + value.Titulo + "</td>" +
                "<td>" + value.Autor + "</td>" +
                "<td>" + value.Editorial + "</td>" +
                "</tr>"
            );
        })
    }
}
function mostrarModal() {
    //MOSTRAR EL MODAL
    var myModal = new bootstrap.Modal(document.getElementById('modalModificar'), {
        keyboard: false
    })
    // toggle al hacer click mostrar y ocultar
    myModal.toggle();
    cargarCamposModal();
    
}
function cargarCamposModal() {
    cargarAutoresModal();
    cargarEditorialesModal();
}
function cargarAutoresModal() {
    $.ajax({
        type: 'GET',
        url: 'ListadoAjax.aspx/ObtenerAutores',
        data: {},
        contentType: 'application/json',
        dataType: 'json'
    })
        .done(cargarComboAutores)
        .fail(setearError)
}
function cargarComboAutores(response) {
    $("#select_autor").html("");
    $.each(response.d, function (key, value) {
        $("#select_autor").append(
            "<option value='" + value.Id + "'>" + value.Nombre + "</option>"
        )
    })
}
function cargarEditorialesModal() {
    $.ajax({
        type: 'GET',
        url: 'ListadoAjax.aspx/ObtenerEditoriales',
        data: {},
        contentType: 'application/json',
        dataType: 'json'
    })
        .done(cargarComboEditoriales)
        .fail(setearError)
}
function cargarComboEditoriales(response) {
    $("#select_editorial").html("");
    $.each(response.d, function (key, value) {
        $("#select_editorial").append(
            "<option value='" + value.Id_editorial + "'>" + value.Nombre + "</option>"
        )
    })
}
function setearError(error) {
    console.log(error);
}