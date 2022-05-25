<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmInventario.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmInventario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <asp:Label ID="lbingresar" runat="server" Text="igresar producto"></asp:Label>
    <asp:DropDownList ID="dpProducto" runat="server"></asp:DropDownList><br />
     <asp:Label ID="Label1" runat="server" Text="ingrese catidad de productos"></asp:Label>
    <asp:TextBox ID="TxtNproductos" runat="server"></asp:TextBox>
    <asp:Button ID="btnEntrada" runat="server" Text="aceptar" />
    <asp:GridView ID="gvInventario" runat="server">

    </asp:GridView>

</asp:Content>
