<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site3.Master" AutoEventWireup="true" CodeBehind="frmProductosVendedor.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmProductosVendedor" %>

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
                        <table class="table table-bordered table-dark" id="dtProductosVendedor" width="100%" cellspacing="0">
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
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
            </div>
        </div>

    </form>
    <script src="recursos/js/jquery-3.4.1.min.js"></script>
    <script src="recursos/js/jsProductosV.js"></script>
</asp:Content>
