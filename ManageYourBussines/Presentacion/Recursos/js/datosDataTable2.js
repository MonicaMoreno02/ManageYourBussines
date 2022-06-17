var tabla, datos
sendDataAjax();
function agregarFilas(datos) {
    console.log(datos);
    tabla = $("#dtDatosPersonal").dataTable();
    for (var i = 0; i < datos.length; i++) {

        tabla.fnAddData([
            datos[i].idTareas,
            datos[i].nombresTareas,
            datos[i].descripcionTareas,
            datos[i].estado,
            datos[i].Tiempo,
            '<button type="button" id="btnEditar" class="btn btn-primary btn-edit" data-toggle="modal" data-target="#ModalDatos">Editar</button>',
            '<button type="button" id="btnEliminar" class="btn btn-danger btn-delete">Eliminar</button>'
        ]);
    }
}



function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "frmTareas.aspx/mtdListarTareas",
        data: '{}',
        contentType: "application/json; charset=utf-8",
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