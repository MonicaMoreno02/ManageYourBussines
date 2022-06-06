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
 <br />
       <asp:GridView ID="gvfactura" runat="server" AutoGenerateColumns="false" CssClass="table table-hover ">
           <Columns>
               <asp:BoundField DataField="nombre" HeaderText="Nombre del Producto" />
               <asp:BoundField DataField="precio" HeaderText="Precio" />
               <asp:BoundField DataField="cantidad" HeaderText="cantidad" />
               <asp:BoundField DataField="codigoVenta" HeaderText="codigo de Venta" />
           </Columns>
       </asp:GridView>
   </div>
      
    
</asp:Content>
