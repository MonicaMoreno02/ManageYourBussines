<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="frmProductos2.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmProductos2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="lblID" runat="server"  Text='<%#Eval("idProducto")%>'> </asp:Label>
</asp:Content>
