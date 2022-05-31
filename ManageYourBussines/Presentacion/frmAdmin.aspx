<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmAdmin.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <asp:Button ID="BtnInicio" runat="server" Text="INICIO" Height="96px" OnClick="BtnInicio_Click" Width="135px" BackColor="#AB8365" BorderColor="Black" BorderStyle="Outset" BorderWidth="2px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <a class="btn link" href="frmEmpleados.aspx">
            <div class="btn from-top">
                Empleados     
            </div>
        </a>

        <a class="btn link" href="frmEmpleados.aspx">
            <div class="btn from-left">
                Ventas     
            </div>
        </a>

        <a class="btn link" href="frmClientes.aspx">
            <div class="btn from-right">
                Clientes     
            </div>
        </a>
        <a class="btn link" href="frmEmpleados.aspx">
            <div class="btn from-center">
                Productos     
            </div>
        </a>
        <a class="btn link" href="frmInventario.aspx">
            <div class="btn from-bottom">
                Inventario     
            </div>
        </a>
    </form>

</asp:Content>
