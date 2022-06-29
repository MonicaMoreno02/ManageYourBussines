<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEstadisticasG.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmEstadisticasG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Estadisticas</title>
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">

        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {

            var data = google.visualization.arrayToDataTable(<%=obtenerDatos()%>);

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
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="piechart" style="width: 900px; height: 500px;"></div>
            <h2>Estadisticas</h2>
        </div>
    </form>
</body>
</html>
