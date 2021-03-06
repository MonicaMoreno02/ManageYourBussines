
var tabla, datos
sendDataAjax();
sendDataAjaxS();


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
            '<button type="button" id="btnEditarD" class="btn btn-primary" data-toggle="modal" data-target="#ModalEditarEmpleado">Editar</button>',
            '<button type="button" id="btnEliminarD" class="btn btn-danger" data-toggle="modal" data-target="#ModalEliminar">Eliminar</button>'

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

    $(document).on('click', '#btnEditarD', function (e) {

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

    $(document).on('click', '#btnEliminarD', function (e) {

        
        e.preventDefault();

        var fila = $(this).parent().parent()[0];
        var datosFila = tabla.fnGetData(fila);
        var datoSend = datosFila[0];

        $("#txtIDEmpleadoB").val(datoSend);

    })
}


var table, dato

function agregarFilasS(datos) {
    console.log(dato);
    table = $("#dtSeguridad").dataTable();
    for (var i = 0; i < dato.length; i++) {
        table.fnAddData([
            dato[i].idSeguridadSocial,
            dato[i].porcentajePension,
            dato[i].porcentajeSalud,
            dato[i].smlv,
            dato[i].año

        ]);
    }
}


function sendDataAjaxS() {
    $.ajax({
        type: "POST",
        url: "frmEmpleados.aspx/mtdListarSeguridad",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",

        success: function (dato) {
            agregarFilas(dato.d);
        },
        failure: function (response) {
            alert(response);
        },
        error: function (responde) {
            alert(response.d);
        }
    })
}