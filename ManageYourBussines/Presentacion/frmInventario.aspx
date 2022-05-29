<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmInventario.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmInventario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
   
<%--       <asp:Label ID="lbingresar" runat="server" Text="ingresar producto"></asp:Label><br /> 
    <asp:DropDownList ID="dpProducto" runat="server" AutoPostBack="True"></asp:DropDownList><br />
     <asp:Label ID="Label1" runat="server" Text="ingrese catidad de productos"></asp:Label><br />
    <asp:TextBox ID="TxtNproductos" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnEntrada" runat="server" Text="aceptar" /><br />--%>
    <br />
    <asp:GridView ID="gvInventario" runat="server" Width="1159px"  class="table-success" >

    </asp:GridView>
    <br />
  <asp:Button ID="btnreport" runat="server" Text="excel" OnClick="btnreport_Click" cssclass="btn btn-success" />

       <asp:Button ID="btnpdf" runat="server" Text="pdf" OnClick="btnpdf_Click" Width="52px" cssclass="btn btn-danger"/>
     
</asp:Content>
