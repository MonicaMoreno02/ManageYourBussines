<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recuperar.aspx.cs" Inherits="ManageYourBussines.recuperar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1> Recuperar Contraseña</h1>

            <asp:Label Text="Usuario" runat="server" />
            <asp:TextBox runat="server" ID="txtUsuario" placeholder="Ejm: jperez" />
            <asp:Button Text="Enviar mensaje al correo" ID="btnRecuperar" runat="server" OnClick="btnRecuperar_Click" />

        </div>
    </form>
</body>
</html>
