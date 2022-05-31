<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmbalance.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmbalance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="container">
    <div class="col-md-6">
    <asp:GridView ID="gvBalance" runat="server" AutoGenerateColumns="False"  class="table-secondary" Width="394px" OnRowCommand="gvBalance_RowCommand" >

      <Columns>
                           <asp:BoundField DataField="#" HeaderText="#">
                           <ControlStyle Width="10px" />
                           <ItemStyle Width="10px" />
                           </asp:BoundField>
                           <asp:BoundField DataField="idVenta" HeaderText="idVenta" />
                           <asp:BoundField DataField="fechaVenta" HeaderText="fechaVenta" />
                           <asp:BoundField DataField="codigoVenta" HeaderText="codigoVenta" />
                           <asp:BoundField DataField="totalVenta" HeaderText="totalVenta" />
                           <asp:ButtonField ButtonType="Button" CommandName="detalles" Text="detalles" />
                       
                       </Columns>
    </asp:GridView>
    <asp:GridView ID="gvDetalles" runat="server"></asp:GridView>

        </div>
          <div class="col-md-6">

    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="excel" />
          </div>
          </div>
</asp:Content>
