<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEstadisticasG.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmEstadisticasG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <%--    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Estadisticas</title>
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">

        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {

            var data = google.visualization.arrayToDataTable();

            var options = {
                title: 'Estadisticas',
                "backgroundColor": { "fill": "#ededed" },
                is3D: true, "fontSize": 12,
                "pieSliceTextStyle": { "color": "#FFF" },
                "sliceVisibilityThreshold": false,
                "legend": {
                    "position": "right",
                    "textStyle": {
                        "color": "#000000",
                        "fontSize": 14
                    }
                },
                "tooltip": {
                    "textStyle": { "color": "#000000" },
                    "showColorCode": false
                },
                "colors" : ["#1f386b", "#DC3912", "#109618", "#990099"]
            };

            var chart = new google.visualization.PieChart(document.getElementById('piechart'));


            chart.draw(data, options);
        }
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--            <div id="piechart" style="width: 900px; height: 500px;"></div>--%>
            <h2>Estadisticas</h2>
            <p>
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
</body>
</html>
