var table, datos
sendDataAjax();
function agregarFilas(datos) {
    console.log(datos);
    tabla = $("#dtCliente").dataTable();
    for (var i = 0; i < datos.length; i++) {

        tabla.fnAddData([
            datos[i].idCliente,
            datos[i].documento,
            datos[i].nombres,
            datos[i].apellidos,
            datos[i].telefono,
            datos[i].direccion,
            datos[i].email,
            datos[i].clave
        ]);
    }
}

function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "frmClientes.aspx/mtdListarP",
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