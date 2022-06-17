<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmSeguridadSocial.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmSeguridadSocial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">

         <!--PAOLA: tabla de Seguridad Social -->
        <div class="card shadow mb-4">
            <div class="card-body">
                <div class="table-responsive">
                    <div class="fa-3x">
                        <i class="fa-solid fa-cog fa-spin"></i>

                    </div>
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

    </form>
        <script src="recursos/js/JavaSeguridad.js"></script>

    <script src="recursos/js/jquery-3.4.1.min.js"></script>
</asp:Content>
