var table, dato
sendDataAjaxS();

function agregarFilasS(datos) {
    console.log(dato);
    table = $("#dtSeguridad").dataTable();
    for (var i = 0; i < dato.length; i++) {
        table.fnAddData([
            dato[i].idSeguridadSocial,
            dato[i].porcentajePension,
            dato[i].porcentajeSalud,
            dato[i].smlv,
            dato[i].fecha

        ]);
    }
}


function sendDataAjaxS() {
    $.ajax({
        type: "POST",
        url: "frmSeguridadSocial.aspx/mtdListarSeguridad",
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
