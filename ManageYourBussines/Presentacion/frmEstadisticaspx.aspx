<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmEstadisticaspx.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmEstadisticaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
        <div class="container-fluid">

            <div class="card card-5">
                <div class="card-heading">
                    <h2 class="title">Estadisticas</h2>
                    
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="recursos/images/Agregarver.png" Height="40px" OnClick="ImageButton1_Click" Width="47px" />
                        &nbsp;&nbsp;
                    
                    <p>&nbsp;</p>
                    <p>
                </div>
             </div>

        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Width="427px">
            <Series>
                <asp:Series Name="Series1" XValueMember="nombreproducto" YValueMembers="cantidad">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource2" Width="384px">
                    <Series>
                        <asp:Series Name="Series1" XValueMember="nombreProducto" YValueMembers="precio">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dbManageConnectionString3 %>" SelectCommand="SELECT [nombreProducto], [precio] FROM [producto]"></asp:SqlDataSource>
                &nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbManageConnectionString2 %>" SelectCommand="select producto.nombreproducto, detallesVenta.cantidad from producto inner join detallesVenta on producto.idProducto = detallesVenta.idProducto"></asp:SqlDataSource>
                </p>

            </div>
    </form>

</asp:Content>
