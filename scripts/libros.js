/*SELECTORES*/
/*
 * Del elemento HTML ej: <p>
 * Clase css ej: .clase-css
 * Id ej #id_elemento
 * Atributo ej: imput[name=nombre_elemnto]
 */

/*
 * $ siempre que vayamos a utilizar jquery es con el $ adelante
 */

$("#ContentPlaceHolder1_mensaje_final").html("Mensaje definido desde JQUERY");
$(".clase_mensaje_error").html("Mensaje desde JQUERY utilizando como selector una clase de CSS");

//CAMBIAMO EL COLOR DEL CSS
$("fieldset").css("background", "red");
$("fieldset").css("margin-bottom", "50px");

$("footer").append("<p>Hola soy un parrafo agregado desde JQUERY.</p>");

//CAMBIAR DE COLOR DEL FOOTER
function cambiarFondo(e) {
    e.preventDefault();
    if ($("footer").hasClass("clase_fondo_verde")) {
        $("footer").removeClass("clase_fondo_verde");
        $("footer").addClass("clase_fondo_azul");
    }
    else
    {
        $("footer").removeClass("clase_fondo_azul");
        $("footer").addClass("clase_fondo_verde");
    }
}
$("#boton_prueba_jquery").click(cambiarFondo);