/* Selectores */
/*
 * elemento html Ej: <p>
 * clase css Ej: .clase-css
 * Id Ej: #id_elemento
 * Atributo Ej: input[name=nombre_elemento]
 */

/*
 * $
 */

$("#ContentPlaceHolder1_mensaje_final").html("Mensaje definido desde Jquery");
$(".clase_mensaje_error").html("Mensaje desde Jquery utilizando como selector una clase css");
$("fieldset").css("background", "red"); /*<fieldset></fieldset>*/
$("fieldset").css("margin-bottom", "50px");
$("footer").append("<p>Hola soy un párrafo agregado desde jquery</p>");

function cambiarFondo(e) {
    e.preventDefault();
    if ($("footer").hasClass("clase_fondo_verde")) {
        $("footer").removeClass("clase_fondo_verde");
        $("footer").addClass("clase_fondo_azul");
    } else {
        $("footer").addClass("clase_fondo_verde");
        $("footer").removeClass("clase_fondo_azul");
    }
}

$("#boton_prueba_jquery").click(cambiarFondo);


