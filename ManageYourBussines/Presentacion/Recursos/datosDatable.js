
$(document).on('click', '#btnModal', function (e) {

    e.preventDefault();
    var fila = $(this).parent().parent();
    datos = tabla.fnGetData(fila);
    $("#lblImagen").val(datos[0]);
    $("#lblNombre").val(datos[1]);
    $("#lblPrecio").val(datos[2]);
    $("#lblMaterial").val(datos[3]);
    
});

var tabla, datos
sendDataAjax();
