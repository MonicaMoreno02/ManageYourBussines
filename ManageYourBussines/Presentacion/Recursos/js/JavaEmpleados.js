var tabla, datos
sendDataAjax();
function agregarFilas(datos) {
    console.log(datos);
    tabla = $("#dtEmpleado").dataTable();
    for (var i = 0; i < datos.length; i++) {

        tabla.fnAddData([
            datos[i].idEmpleado,
            datos[i].documento,
            datos[i].nombreEmpleado,
            datos[i].apellidos,
            datos[i].tipoEmpleado,
            datos[i].email,
            datos[i].clave,
            '<button type="button" id="btnEditar" class="btn btn-primary btn-edit" data-toggle="modal" data-target="#ModalDatos">Editar</button>',
            '<button type="button" id="btnEliminar" class="btn btn-danger btn-delete">Eliminar</button>'
        ]);
    }
}

function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "frmEmpleados.aspx/mtdListar",
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


    $(document).on('click', '#btnEditar', function (e) {

        e.preventDefault();
        var fila = $(this).parent().parent();
        datos = tabla.fnGetData(fila);
        $("#txtID").val(datos[0]);
        $("#txtDocumento").val(datos[1]);
        $("#txtNombres").val(datos[2]);
        $("#txtApellidos").val(datos[3]);
        $("#txtEmail").val(datos[4]);
        $("#txtCelular").val(datos[5]);
    });