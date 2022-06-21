var table, dato
sendDataAjax();

function agregarFilasS(dato) {
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


function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "frmSeguridadSocial.aspx/mtdListarSeguridad",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",

        success: function (dato) {
            agregarFilasS(dato.d);
        },
        failure: function (response) {
            alert(response);
        },
        error: function (responde) {
            alert(response.d);
        }
    })
}
