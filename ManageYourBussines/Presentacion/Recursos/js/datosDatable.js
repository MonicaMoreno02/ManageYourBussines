///summary
var tabla, datos
$(document).on('click', '#btnModal', function (e) {

    e.preventDefault();
    var fila = $(this).parent().parent();
    datos = tabla.fnGetData(fila);
    $("#lblImagen").val(datos[0]);
    $("#lblNombre").val(datos[1]);
    $("#lblPrecio").val(datos[2]);
    $("#lblMaterial").val(datos[3]);
    '<button type="button" id="btnDetalles" class="btn btn-success" data-toggle="modal" data-target="#exampleModal">Detalles</button>'
});


function senDataAjax() {
    $.ajax({
        type: "POST",
        url: "index.aspx/mtdListarP",
        data: '{}',
        contentType: "aplication/json; charset=utf-8",
        dataType: "json",

        success: function (datos) {
            agregarFilas(datos.d);
        },
        failure: function (response) {
            alert(response);
        },
        error: function (response) {
            alert(response.d);
        }
    });
  }
