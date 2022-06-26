﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site3.Master" AutoEventWireup="true" CodeBehind="frmClientesVendedor.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmClientesVendedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">

        <%--Cristian: creo la tabla donde mostramos los datos del cliente --%>
          -    
    <div class="card-body">
        <div class="table-responsive">

            <table class=" table table-bordered table-dark" id="dtClienteVendedor" width="100%" cellsapcing="0">
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

        <%--PAOLA: creo la tabla donde mostramos los datos del cliente FIN --%>


        <%--CRISTIAN: modal ver detalles--%>

        <div class="modal fade" id="ModalDetallesVendedor" tabindex="-1" data-backdrop="static" data-keyboard="false" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
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
                                <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
                                <asp:Label ID="Label1" runat="server" Text="Label"> </asp:Label>
                                <%--                            <asp:TextBox ID="txtIdClienteV" runat="server"></asp:TextBox>--%>
                                <h2>Para mostrar elementos del cliente </h2>
                                <h2>de click en el botón "ACEPTAR" </h2>
                                <br />
                                <asp:GridView ID="dgModal" runat="server"></asp:GridView>

                            </div>

                            <div class="modal-footer">

                                <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary" Text="ACEPTAR" OnClick="btnAceptar_Click1" />
                                <asp:Button ID="btnCerrar" runat="server" CssClass="btn btn-danger" Text="Cerrar" OnClick="btnCerrar_Click1" />

                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>

                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnAceptar" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
        </div>
        <%--CRISTIAN: modal ver detalles FIN --%>
    </form>



    <script src="recursos/js/jsClienteE.js"></script>
    <script src="recursos/js/jquery-3.4.1.min.js"></script>

</asp:Content>
