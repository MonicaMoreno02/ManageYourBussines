<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmClientes.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">

        <div class="btn fondo">
            <div class="container">

                <table class="table table-hover " id="dtCliente" >
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
                        </tr>
                    </thead>

                </table>
            </div>
        </div>
    </form>

    <script src="recursos/js/jquery-3.4.1.min.js"></script>
    <script src="recursos/js/JavaClientes.js"></script>

</asp:Content>
