<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmClientes.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: lightblue">
        <form runat="server">
            <asp:TextBox ID="idClientee" runat="server"></asp:TextBox>
            <div class="container-fluid">
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
                            <h5 class="modal-title" id="exampleModalLabel">Detalles de ventas del cliente</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="table-responsive">

                                <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
                                <h2>¿Mostrar elementos del cliente seleccionado?</h2>
                                <br />
                                <asp:GridView ID="dgModal" runat="server"></asp:GridView>
                                 <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />

                            </div>
                           
                        </div>


                    </div>
                </div>
            </div>
        </form>
    </div>
    <script src="recursos/js/jquery-3.4.1.min.js"></script>
    <script src="recursos/js/JavaClientes.js"></script>

</asp:Content>
