<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmVenta.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container text-center">
            <div class="bg-fa-circle-info rounded mt-2">
                <h2>Lista de Ventas</h2>
            </div>
          </div>
    <div>
      
      </div>
      <asp:GridView ID="gvFactura" runat="server">
      </asp:GridView>
</asp:Content>
