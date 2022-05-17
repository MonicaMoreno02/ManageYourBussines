///summary
$(document).on('click', '#btnModal', function (e) {

    e.preventDefault();
    var fila = $(this).parent().parent();
    datos = tabla.fnGetData(fila);
    $("#lblImagen").val(datos[0]);
    $("#lblNombre").val(datos[1]);
    $("#lblPrecio").val(datos[2]);
    $("#lblMaterial").val(datos[3]);
    '<button type="button" id="btnModal" class="btn btn-success" data-toggle="modal" data-target="#myModal">Detalles</button>'
});

var tabla, datos
sendDataAjax();
