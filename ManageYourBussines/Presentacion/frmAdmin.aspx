<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmAdmin.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<%--        <div class="btn btn">Inicio<br />
            <br />
            <br />
        </div>--%>

   
              
        <div class="btn from-top">
            <asp:ImageButton ID="btn" runat="server" />
            <br />
            Empleados</div>
        <div class="btn from-left">Ventas</div>
        <div class="btn from-right">Clientes</div>
        <div class="btn from-center">Productos</div>
        <div class="btn from-bottom">Inventario</div>
    

     


</asp:Content>
