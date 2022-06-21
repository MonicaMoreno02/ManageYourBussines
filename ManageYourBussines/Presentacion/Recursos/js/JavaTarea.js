var tabla, datos
senDataAjax();
function agregarFilas(datos) {
    console.log(datos);
    tabla = $("#dtDatosPersonal").dataTable();
    for (var i = 0; i < datos.length; i++) {

        tabla.fnAddData([
            datos[i].idTareas,
            datos[i].nombreTarea,
            datos[i].descripcionTarea,
            datos[i].estado,
            datos[i].tiempo,
            '<button type="button" id="btnEditarProductos" class="btn btn-primary btn-edit" data-toggle="modal" data-target="#ModalDatos">Editar</button>',
            '<button type="button" id="btnEliminar" class="btn btn-danger btn-delete" data-toggle="modal" data-target="#ModalDatosEliminar">Eliminar</button>',
        ]);
    }
}
function senDataAjax() {
    $.ajax({
        type: "POST",
        url: "frmTarea.aspx/mtdListarTar",
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

    $(document).on('click', '#btnEditarProductos', function (e) {

        e.preventDefault();
        var row = $(this).parent().parent();
        datosEditar = tabla.fnGetData(row);
      
        $("#txtIdTareaEditar").val(datosEditar[0]);
        $("#txtNombreEditar").val(datosEditar[1]);
        $("#txtDescripcionEditar").val(datosEditar[2]);
        $("#txtEstadoEditar").val(datosEditar[3]);
        $("#txtTiempoEditar").val(datosEditar[4]);
       

    });
    $(document).on('click', '#btnEliminar', function (e) {

        e.preventDefault();

        var fila = $(this).parent().parent()[0];
        var datosFila = tabla.fnGetData(fila);
        var idTareas = datosFila[0];
        $("#txtIdTareaEditar").val(idTareas);
        alert(idTareas);
    });

}