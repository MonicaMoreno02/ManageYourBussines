<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmClientes.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
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
            <div class="modal-dialog modal-lg" role="document">

                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="modal-content">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="modal-header">
                                <h2 class="modal-title" id="exampleModalLabel">Detalles de ventas del cliente</h2>
                             <%--   <button type="button" class="close" data-dismiss="modal" aria-label="Close">--%>
<%--                                    <span aria-hidden="true">&times;</span>--%>
                                </button>
                            </div>

                            <div class="modal-body">

                                <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
                                <h2>Para mostrar elementos del cliente </h2>

                                <h2>de click en el botón "ACEPTAR" </h2>
                                <br />
                                <asp:GridView ID="dgModal" runat="server" BackColor="#E94E03"></asp:GridView>

                            </div>

                            <div class="modal-footer">

                                <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary" Text="ACEPTAR" OnClick="btnAceptar_Click" />
                                <asp:Button ID="btnCerrar" runat="server" CssClass="btn btn-danger"  Text="Cerrar" OnClick="btnCerrar_Click" />

                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>

                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnAceptar" EventName="Click"/>
                    </Triggers>
                </asp:UpdatePanel>
            </div>
        </div>
    </form>

    <script src="recursos/js/jquery-3.4.1.min.js"></script>
    <script src="recursos/js/JavaClientes.js"></script>

</asp:Content>
