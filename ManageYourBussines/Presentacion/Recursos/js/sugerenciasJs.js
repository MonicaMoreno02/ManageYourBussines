var tabla, datos
EnvioDataAjax();
function agregarFilas(datos) {
    console.log(datos);
    tabla = $("#dtSugerencias").dataTable();
    for (var i = 0; i < datos.length; i++) {

        tabla.fnAddData([
            datos[i].idSugerencias,
            datos[i].nombreCliente,
            datos[i].opinion   
        ]);
    }
}

function EnvioDataAjax() {
    $.ajax({
        type: "POST",
        url: "frmSugerencias.aspx/mtdListarSugerenciasP",
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
