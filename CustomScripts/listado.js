$(document).ready(function () {
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

function setearTabla(response)
{
    console.log(response.d);
    if (response.d.length > 0) {
        $.each(response.d, function (key, value) {
            $("#bodyTabla").append(
                "<tr onclick='mostrarModal("+ value.Id +")'>" +
                "<td>" + value.Id + "</td>" +
                "<td>"+ value.Titulo +"</td>" +
                "<td>" + value.Autor.Nombre +"</td>" +
                "<td>"+ value.Editorial.Nombre +"</td>" +
                "</tr>"
            );
        })
    }
}

function mostrarModal(id_libro) {
    console.log("Id del libro elegido: " + id_libro);
    var myModal = new bootstrap.Modal(document.getElementById('modalModificar'), {
        keyboard: false
    })
    myModal.toggle()
    cargarCamposModal();
    getDatoLibroElegido(id_libro);
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
    console.log(response.d);
    $("#select_autor").html("");
    $.each(response.d, function (key, value) {
        $("#select_autor").append(
            "<option value='" + value.Id +"'>" + value.Nombre +"</option>"
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
            // <option value='1'>Lo que sea</option>
            // "'cadena entre comillas'"
        )
    })
}

function getDatoLibroElegido(id_libro) {
    var obj = {
        id_libro_param: id_libro
    }
    var objString = JSON.stringify(obj);
    $.ajax({
        type: 'POST',
        url: 'ListadoAjax.aspx/ObtenerLibroPorId',
        data: objString,
        contentType: 'application/json',
        dataType: 'json'
    })
        .done(cargarDatosModal)
        .fail(setearError)
}

function cargarDatosModal(respuesta) {
    //console.log(respuesta.d)
    $("#modal_titulo").val(respuesta.d.Titulo);
    console.log(respuesta.d.Autor.Id)
    //$("#select_autor").val('3').change();
    document.getElementById("select_autor").value = 3;
    //$("#select_autor option[value=" + respuesta.d.Autor.Id + "]").prop("selected", true);
}


function setearError(error)
{
    console.log(error);
}

// Index.aspx   - www.loquesea.com 