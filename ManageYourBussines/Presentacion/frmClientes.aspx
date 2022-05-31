<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmClientes.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">

        <%--  <div class="btn fondo">--%>
        <div class="container">

            <table class="table table-hover " id="dtCliente">
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
        <%--  </div>--%>

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

                        <div class="container">

                            <table class="table table-hover " id="dtDetalles">
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
                    <%-- <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        <asp:Button ID="btnActualizar" class="btn btn-primary" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                    </div>--%>
                </div>
            </div>
        </div>
    </form>

    <script src="recursos/js/jquery-3.4.1.min.js"></script>
    <script src="recursos/js/JavaClientes.js"></script>

</asp:Content>
