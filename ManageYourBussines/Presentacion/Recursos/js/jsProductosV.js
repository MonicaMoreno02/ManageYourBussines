/*En este archivo js vamos a llenar la tabla productos*/
var tabla, datos, img
sendDataAjax();
function agregarFilas(datos) {
    console.log(datos);
    tabla = $("#dtProductosVendedor").dataTable();
    for (var i = 0; i < datos.length; i++) {

        tabla.fnAddData([
            datos[i].idProducto,
            datos[i].nombreProducto,
            datos[i].descripcion,
            datos[i].precio,
            datos[i].cantidadStock,
            datos[i].largo,
            datos[i].ancho,
            datos[i].profundidad,
            datos[i].material,
            datos[i].caracteristicas,
            '<img src=' + datos[i].imagen + ' width="100" height="100"/>'

        ]);
    }
}

/*Esta funcion nos trae los datos de la tabla que retorna el metodo mtdListarProducto*/

function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "frmProductosVendedor.aspx/mtdListarProducto",
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
