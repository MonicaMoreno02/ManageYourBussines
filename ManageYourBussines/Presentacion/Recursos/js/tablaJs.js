/*En este archivo js vamos a llenar la tabla productos*/
var tabla, datos, datosEditar, img
sendDataAjax();
function agregarFilas(datos) {
    console.log(datos);
    tabla = $("#dtProductos").dataTable();
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
            '<img src=' + datos[i].imagen + ' width="100" height="100"/>',
            '<button type="button" id="btnEditarProductos" class="btn btn-primary btn-edit" data-toggle="modal" data-target="#ModalDatos">Editar</button>',
            '<button type="button" id="btnEliminar" class="btn btn-danger btn-delete" data-toggle="modal" data-target="#ModalDatosEliminar">Eliminar</button>',
            img = datos[i].imagen
        ]);
    }
}

/*Esta funcion nos trae los datos de la tabla que retorna el metodo mtdListarProducto*/

function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "frmAdminProductos.aspx/mtdListarProducto",
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


    /*Editar Productos*/

    $(document).on('click', '#btnEditarProductos', function (e) {

        e.preventDefault();
        var row = $(this).parent().parent();
        datosEditar = tabla.fnGetData(row);

        $("#txtIdProductoEditar").val(datosEditar[0]);
        $("#txtNombreEditar").val(datosEditar[1]);
        $("#txtDescripcionEditar").val(datosEditar[2]);
        $("#txtPrecioEditar").val(datosEditar[3]);
        $("#txtCantidadStockEditar").val(datosEditar[4]);
        $("#txtLargoEditar").val(datosEditar[5]);
        $("#txtAnchoEditar").val(datosEditar[6]);
        $("#txtProfundidadEditar").val(datosEditar[7]);
        $("#txtMaterialEditar").val(datosEditar[8]);
        $("#txtCaracteristicasEditar").val(datosEditar[9]);
        $("#Image1").val(datosEditar[13]);
       
       
        
    });


    //Eliminar Productos

    $(document).on('click', '#btnEliminar', function (e) {

        e.preventDefault();

        var fila = $(this).parent().parent()[0];
        var datosFila = tabla.fnGetData(fila);
        var idProducto = datosFila[0];
        $("#txtIdProducto").val(idProducto);
        alert(idProducto);
    });
}
