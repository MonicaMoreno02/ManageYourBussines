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
            datos[i].clave,
            '<button type="button" id="btnDetalles" class="btn btn-primary btn-details" data-toggle="modal" data-target="#ModalDetalles">Ver Detalles</button>'

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

    //$(document).on('click', '#btnDetalles', function (e) {
    //    /*llenar tabla para datos de detalles de venta */
    //    e.preventDefault();

    //    var tablaDetalles, datosDetalle
    //    sendDataAjaxDetalles();
    //    function agregarFilasDetalle(datosDetalle) {
    //        console.log(datosDetalle);
    //        tablaDetalles = $("#dtDetalles").dataTable();
    //        for (var i = 0; i < datosDetalle.length; i++) {

    //            tablaDetalles.fnAddData([
    //                datosDetalle[i].idCliente,
    //                datosDetalle[i].nombreCliente,
    //                datosDetalle[i].fechaVenta,
    //                datosDetalle[i].codigoVenta,
    //                datosDetalle[i].totalVenta,
    //                datosDetalle[i].nombreEmpleado,
    //                datosDetalle[i].valorTotal,
    //                datosDetalle[i].nombreProducto,
    //                '<button type="button" id="btnDetalles" class="btn btn-primary btn-details" data-toggle="modal" data-target="#ModalDetalles">Ver Detalles</button>'

    //            ]);
    //        }
    //    }

    //    function sendDataAjaxDetalles() {
    //        $.ajax({
    //            type: "POST",
    //            url: "frmClientes.aspx/mtdListarDetallesP",
    //            data: '{}',
    //            contentType: "application/json; charset=utf-8",
    //            dataType: "json",

    //            success: function (datosDetalle) {
    //                agregarFilasDetalle(datosDetalles.d);
    //            },
    //            failure: function (response) {
    //                alert(response);
    //            },
    //            error: function (response) {
    //                alert(response.d);
    //            }

    //        });









