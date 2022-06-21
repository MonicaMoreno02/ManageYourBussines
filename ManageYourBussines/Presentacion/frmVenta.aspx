<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmVenta.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmVenta" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">

        <div class="container text-center">
            <div class="bg-fa-circle-info rounded mt-2">
                <h2>Factura de Compra</h2>
            </div>
        </div>
        <div>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-hover bg-light " BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <Columns>
                    <asp:BoundField DataField="#" HeaderText="#" />
                    <asp:BoundField DataField="nombreProducto" HeaderText="nombre" />
                    <asp:BoundField DataField="codigoVenta" HeaderText="codigoVenta" />
                    <asp:BoundField DataField="precio" HeaderText="precio" />
                    <asp:BoundField DataField="cantidad" HeaderText="cantidad" />
                    <asp:BoundField DataField="total" HeaderText="total" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>

            <asp:Button ID="btnPdf" runat="server" Text="Descargar PDF" CssClass="btn btn-danger" OnClick="btnPdf_Click" />
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btn btn-success" OnClick="btnHome_Click" />
            <br />
            <br />
        </div>
        <asp:Label ID="Lbcod" runat="server" Text="Label" Visible="false"></asp:Label>


    </form>
</asp:Content>
