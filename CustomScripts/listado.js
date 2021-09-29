$(document).ready(function () {
    obtenerLibros();
    cargarCamposModal();
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
    myModal.toggle();
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
        dataType: 'json',
        success: function (response) {
            cargarAutoresModal();
            cargarEditorialesModal();
            $("#modal_titulo").val(response.d.Titulo);
            setTimeout(function (response) {
                $("#select_autor").val(response.d.Autor.Id);//DUDA
                $("#select_editorial").val(response.d.Editorial.Id_editorial);//DUDA
            },250)
        },
        error: function (error) {
            console.log(error);
        }
    })
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

var i =1;
$("#btn_guardar").click(function () {
    console.log(i + " Boton guardar presionado");
    i++;
})
// Index.aspx   - www.loquesea.com 