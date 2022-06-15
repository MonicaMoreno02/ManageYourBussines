﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmAdminProductos.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmAdminProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <%--Creacion de tabla productos--%>


        <div class="container-fluid">
            <h1>Productos</h1>
            <div class="card shadow mb-4">
                <div class="card-body">
                    <div class="table-responsive">
                        <table class="table table-bordered table-dark" id="dtProductos" width="100%" cellspacing="0">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Nombre</th>
                                    <th>Descripción</th>
                                    <th>precio</th>
                                    <th>Cantidad en Stock</th>
                                    <th>Largo</th>
                                    <th>Ancho</th>
                                    <th>Profundidad</th>
                                    <th>Material</th>
                                    <th>Caracteristicas</th>
                                    <th>Imagen</th>
                                    <th>Editar</th>
                                    <th>Eliminar</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />

        <%--        Formulario para agregar productos--%>
        <h1>Registrar productos</h1>
        <br />
        <div class="col">
            <div class="form-group">
                <label for="txtNombre" class="col-form-label">Nombre</label>
                <asp:TextBox ID="txtAsignarNombre" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtDescripcion" class="col-form-label">Descripcion</label>
                <asp:TextBox ID="txtAsignarDescripcion" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPrecio" class="col-form-label">Precio</label>
                <asp:TextBox ID="txtAsignarPrecio" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCantidadStock" class="col-form-label">Cantidad en Stock</label>
                <asp:TextBox ID="txtAsignarCantidadStock" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtLargo" class="col-form-label">Largo</label>
                <asp:TextBox ID="txtAsignarLargo" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtAncho" class="col-form-label">Ancho</label>
                <asp:TextBox ID="txtAsignarAncho" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtProfundidad" class="col-form-label">Profundidad</label>
                <asp:TextBox ID="txtAsignarProfundidad" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtMaterial" class="col-form-label">Material</label>
                <asp:TextBox ID="txtAsignarMaterial" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCaracteristicas" class="col-form-label">Caracteristicas</label>
                <asp:TextBox ID="txtAsignarCaracteristicas" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtImagen" class="col-form-label">Imagen</label>
                <asp:FileUpload ID="fuImagen" runat="server" />
            </div>


            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
        </div>

        <br />
        <br />
        <br />
        <br />


        <%--Modal editar--%>

        <div class="modal fade" id="ModalDatos" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Datos a Editar</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">

                        <asp:TextBox ID="txtIdProductoEditar" class="form-control" runat="server"></asp:TextBox>

                        <div class="form-group">
                            <label for="txtNombreEditar" class="col-form-label">Nombre</label>
                            <asp:TextBox ID="txtNombreEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtDescripcionEditar" class="col-form-label">Descripcion</label>
                            <asp:TextBox ID="txtDescripcionEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtPrecioEditar" class="col-form-label">Precio</label>
                            <asp:TextBox ID="txtPrecioEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtCantidadStockEditar" class="col-form-label">Cantidad en Stock</label>
                            <asp:TextBox ID="txtCantidadStockEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtLargoEditar" class="col-form-label">Largo</label>
                            <asp:TextBox ID="txtLargoEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtAnchoEditar" class="col-form-label">Ancho</label>
                            <asp:TextBox ID="txtAnchoEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtProfundidadEditar" class="col-form-label">Profundidad</label>
                            <asp:TextBox ID="txtProfundidadEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtMaterialEditar" class="col-form-label">Material</label>
                            <asp:TextBox ID="txtMaterialEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtCaracteristicasEditar" class="col-form-label">Caracteristicas</label>
                            <asp:TextBox ID="txtCaracteristicasEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtImagenEditar" class="col-form-label">Imagen</label>
                            <br />
                            <asp:FileUpload ID="FuEditarImagen" runat="server" />
                        </div>
                        <asp:TextBox ID="txtImagenE" runat="server"></asp:TextBox>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        <asp:Button ID="btnActualizar" class="btn btn-primary" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"/>
                    </div>
                </div>
            </div>
        </div>

        <%--Modal Eliminarr--%>

        <div class="modal fade" id="ModalDatosEliminar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabelE">Advertencia</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <asp:TextBox ID="txtIdProducto" runat="server"></asp:TextBox>
                        <asp:Label ID="Label1" runat="server" Text="¿Estas seguro de eliminar este registro?"></asp:Label>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="txtEliminar" runat="server" class="btn btn-danger" Text="Eliminar" OnClick="txtEliminar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>

    <script src="recursos/js/jquery-3.4.1.min.js"></script>
    <script src="recursos/js/tablaJs.js"></script>
</asp:Content>