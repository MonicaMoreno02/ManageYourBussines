<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ManageYourBussines.Presentacion.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbManageConnectionString %>" SelectCommand="SELECT * FROM [tareas]"></asp:SqlDataSource>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idTareas" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="idTareas" HeaderText="idTareas" ReadOnly="True" SortExpression="idTareas" />
            <asp:BoundField DataField="nombreTarea" HeaderText="nombreTarea" SortExpression="nombreTarea" />
            <asp:BoundField DataField="descripcionTarea" HeaderText="descripcionTarea" SortExpression="descripcionTarea" />
        </Columns>
    </asp:GridView>
        </div>
    </form>
</body>
</html>
