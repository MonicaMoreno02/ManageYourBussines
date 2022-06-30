var tabla, datos
sendDataAjax();
function agregarFilas(datos) {
    console.log(datos);
    tabla = $("#dtTareas").dataTable();
    for (var i = 0; i < datos.length; i++) {
        tabla.fnAddData([
            datos[i].idTareas,
            datos[i].nombreTarea,
            datos[i].descripcionTarea,
            datos[i].estado,
            datos[i].tiempo
        ]);
    }
}



function sendDataAjax() {
    $.ajax([
        type: "POST",
        url: "frmTareas.aspx/mtdListarTareas",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",

        success: function (datos) {
            agregarFilas(datos.d);
        },
        failure: function (response) {
            alert: (response);
        },
        error: function (response) {
            alert(response.d);
        }
    ]);
}