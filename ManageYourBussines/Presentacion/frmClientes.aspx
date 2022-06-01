<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmClientes.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-image: radial-gradient(circle at 50% 50%, #865461 0, #7d485b 16.67%, #6e3751 33.33%, #591f44 50%, #430538 66.67%, #310031 83.33%, #24002f 100%)">
    <form runat="server">
        
            <div  class="container-fluid">
                <h1>Lista de Clientes</h1>
                <div class="card shadow mb-4">
                    <div class="card-body">
                        <div class="table-responsive">

                            <table class=" table table-bordered table-dark" id="dtCliente" width="100%" cellsapcing="0">
                                <thead>
                                    <tr>
                                        <th>id</th>
                                        <th>Documento</th>
                                        <th>Nombres</th>
                                        <th>Apellidos</th>
                                        <th>Telefono</th>
                                        <th>Dirección</th>
                                        <th>Email</th>
                                        <th>Clave</th>
                                        <th>Acciones</th>
                                    </tr>
                                </thead>

                            </table>
                        </div>
                    </div>
                </div>
            </div>

            <%--modal ver detalles--%>

            <div class="modal fade" id="ModalDetalles" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Datos a Editar</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="table-responsive">
                                <asp:GridView ID="dgModal" runat="server"></asp:GridView>
                            </div>


                            <%-- <div class="table-responsive">

                            <table class="table table-hover" id="dtDetalles">
                                <thead>
                                    <tr>
                                        <th>idCliente</th>
                                        <th>Nombre Cliente</th>
                                        <th>Fecha de Venta</th>
                                        <th>Codigo de Venta</th>
                                        <th>Total de Venta</th>
                                        <th>Nombre Empleado</th>
                                        <th>Cantidad</th>
                                        <th>Valor Total</th>
                                        <th>Nombre Producto</th>
                                     
                                    </tr>
                                </thead>

                            </table>
                        </div>--%>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>
    </form>
    </div>
    <script src="recursos/js/jquery-3.4.1.min.js"></script>
    <script src="recursos/js/JavaClientes.js"></script>

</asp:Content>
