<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmAdmin.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
         <asp:Button ID="BtnInicio" runat="server" Text="INICIO" Height="47px" OnClick="BtnInicio_Click" Width="98px" BackColor="#AB8365" BorderColor="Black" BorderStyle="Outset" BorderWidth="2px" />
    <br />
    <br />
    <br />
    <br />
    <br />
    
              
        <div class="btn from-top">Empleados</div>
        <div class="btn from-left">Ventas</div>
        <div class="btn from-right">Clientes</div>
        <div class="btn from-center">Productos</div>
        <div class="btn from-bottom">Inventario</div>
    

     


</asp:Content>
