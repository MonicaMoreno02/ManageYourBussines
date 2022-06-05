
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
            datos[i].idSeguridadSocial,
            '<button type="button" id="btnEditar" class="btn btn-primary" data-toggle="modal" data-target="#ModalEditarEmpleado">Editar</button>',
            '<button type="button" id="btnEliminar" class="btn btn-danger">Eliminar</button>'

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
        error: function (responde) {
            alert(response.d);
        }

    });

    $(document).on('click', '#btnEditar', function (e) {

        e.preventDefault();
        var fila = $(this).parent().parent();
        datos = tabla.fnGetData(fila);
        $("#txtIDEmpleado").val(datos[0]);
        $("#txtDocumento").val(datos[1]);
        $("#txtNombreEmpleado").val(datos[2]);
        $("#txtApellidos").val(datos[3]);
        $("#txtTipoEmpleado").val(datos[4]);
        $("#txtEmail").val(datos[5]);
        $("#txtClave").val(datos[6]);
        $("#txtSeguridadSocial").val(datos[7]);
    });

    $(document).on('click', '#btnEliminar', function (e) {

        e.preventDefault();

        var fila = $(this).parent().parent()[0];
        var datosFila = tabla.fnGetData(fila);
        var datoSend = datosFila[0];

    })
}