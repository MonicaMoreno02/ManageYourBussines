<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmAdmin.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">

        <asp:Button CssClass="" ID="BtnInicio" runat="server" Text="INICIO" Height="96px" OnClick="BtnInicio_Click" Width="235px" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" Font-Names="Century Gothic" Font-Size="40px" />
        <br />


        <h1 class="title" style="padding: 25px 17px 25px 17px; margin: 15px; font-family: 'Calisto MT'; font-size: 54px; font-style: oblique; border-style: inherit; color: #000000; background-repeat: no-repeat; background-attachment: fixed; background-image: none; text-transform: capitalize;" aria-checked="undefined">BIENVENIDO ADMINISTRADOR</h1>
        <br />
        <br />
        <br />

        <ul>
            <li>
                <a class="btn link" href="frmEmpleados.aspx">
                    <div class="btn from-top">
                        Empleados 
                    </div>
                </a>
            </li>
            <li>
                <a class="btn link" href="frmVenta.aspx">
                    <div class="btn from-left">
                        Ventas     
                    </div>
                </a>
            </li>
            <li>
                <a class="btn link" href="frmClientes.aspx">
                    <div class="btn from-right">
                        Clientes     
                    </div>
                </a>
            </li>
            <li>
                <a class="btn link" href="frmAdminProductos.aspx">
                    <div class="btn from-center">
                        Productos     
                    </div>
                </a>
            </li>
            <li>

                <a class="btn link" href="frmbalance.aspx">
                    <div class="btn from-bottom">
                        Balance 
                    </div>
                </a>
            </li>
        </ul>

    </form>

    <%-- Recursos para btn en Admin --%>
    <link href="recursos/css/stylebuttons.css" rel="stylesheet" />
</asp:Content>
