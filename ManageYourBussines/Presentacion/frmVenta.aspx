<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmVenta.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container text-center">
            <div class="bg-fa-circle-info rounded mt-2">
                <h2>Factura de Compra</h2>
            </div>
          </div>
   <div>
 <br />
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table table-hover bg-light ">
           <Columns>
               <asp:BoundField DataField="#" HeaderText="#" />
               <asp:BoundField DataField="nombreProducto" HeaderText="nombre" />
                <asp:BoundField DataField="codigoVenta" HeaderText="codigoVenta" />
               <asp:BoundField DataField="precio" HeaderText="precio" />
               <asp:BoundField DataField="cantidad" HeaderText="cantidad" />
                <asp:BoundField DataField="total" HeaderText="total" />
           </Columns>
       </asp:GridView>

      <%-- <asp:Button ID="btnPdf" runat="server" Text="Descargar PDF" CssClass="btn btn-danger" onclick="btnPdf_Click"/>--%>
       <asp:ImageButton ID="ImageButton1" runat="server" Height="54px" ImageUrl="~/recursos/images/pdf.png" Width="62px" onclick="btnPdf_Click"/>
       <asp:ImageButton ID="ImageButton2" runat="server" Height="54px" ImageUrl="~/recursos/images/casa.png" Width="62px" OnClick="btnHome_Click" />
    <%--   <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btn btn-success" OnClick="btnHome_Click"/>--%>
   </div>
    <asp:Label ID="Lbcod" runat="server" Text="Label" Visible="false"></asp:Label>
      
    
  
   
</asp:Content>
