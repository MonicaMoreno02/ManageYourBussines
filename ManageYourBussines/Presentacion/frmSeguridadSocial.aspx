<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmSeguridadSocial.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmSeguridadSocial" ClientIDMode="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">

        <div class="container-fluid">
            <!-- Page Heading -->
            <div class="card card-5">
                <div class="card-heading">
                    <h2 class="title">LISTA DE SEGURIDAD SOCIAL</h2>
                </div>
            </div>
            <!--PAOLA: tabla de Seguridad Social -->
            <div class="card shadow mb-4">
                <div class="card-body">
                    <div class="table-responsive">

                        <table class="table table-bordered table-dark" id="dtSeguridad" width="100%" cellspacing="0">
                            <thead>
                                <tr>

                                    <th>id</th>
                                    <th>Porcentaje Pension</th>
                                    <th>Porcentaje Salud</th>
                                    <th>Salario</th>
                                    <th>Año</th>


                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </form>


    <script src="recursos/js/JavaSeguridad.js"></script>
    <script src="recursos/js/jquery-3.4.1.min.js"></script>
</asp:Content>
