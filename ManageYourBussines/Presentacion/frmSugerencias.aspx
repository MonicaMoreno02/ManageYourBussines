<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmSugerencias.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmSugerencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<%--    Tabla sugerencias --%>
    <form runat="server">
        <div class="container-fluid">
            <h1>Sugerencias de Clientes</h1>
            <div class="card shadow mb-4">
                <div class="card-body">
                    <div class="table-responsive">
                        <table class="table table-bordered table-dark" id="dtSugerencias" width="100%" cellspacing="0">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Nombre Cliente</th>
                                    <th>Opinion</th>
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
        </form>

    <script src="recursos/js/sugerenciasJs.js"></script>
    <script src="recursos/js/jquery-3.4.1.min.js"></script>
</asp:Content>
