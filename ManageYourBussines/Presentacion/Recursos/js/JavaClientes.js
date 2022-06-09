var tabla, datos
sendDataAjax();
function agregarFilas(datos) {
    console.log(datos);
    tabla = $("#dtCliente").dataTable();
    for (var i = 0; i < datos.length; i++) {

        tabla.fnAddData([
            datos[i].idCliente,
            datos[i].documento,
            datos[i].nombreCliente,
            datos[i].apellidos,
            datos[i].telefono,
            datos[i].direccion,
            datos[i].email,
            datos[i].clave,
            '<button type="button" id="btnDetalles" class="btn btn-primary btn-details" data-toggle="modal" data-target="#ModalDetalles">Ver Detalles</button>',
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

        $(document).on('click', '#btnDetalles', function (e) {

            e.preventDefault();

            var fila = $(this).parent().parent()[0];
            var datosFila = tabla.fnGetData(fila);
            var idCliente = datosFila[0];            
            $("#txtIdCliente").val(idCliente);


        });

        
    }











