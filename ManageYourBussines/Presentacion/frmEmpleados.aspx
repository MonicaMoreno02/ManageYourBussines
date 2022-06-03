<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmEmpleados.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div id="sidebar">
            <div class="toggle-btn">
                <span>&#9776</span>
                <ul>
                    <%--<li>
                    <img src="recursos/images/logo.png" alt="Logotipo" />" 
                </li>--%>
                    <li>Clientes</li>
                    <li>Productos</li>
                    <li>Ventas</li>
                    <li>Balance</li>
                </ul>
            </div>
        </div>
    </form>
</asp:Content>
