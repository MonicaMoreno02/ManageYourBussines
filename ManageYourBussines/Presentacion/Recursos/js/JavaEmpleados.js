alert("Entrando al ejemplo");

var table, datos
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
            datos[i].Clave,
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
        error: function (responde) {
            alert(response.d);
        }

    });
}