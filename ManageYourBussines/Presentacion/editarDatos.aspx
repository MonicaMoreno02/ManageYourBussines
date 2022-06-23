<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editarDatos.aspx.cs" Inherits="ManageYourBussines.Presentacion.editarDatos" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Datos Personales</title>

    <!-- Font Icon -->
    <link rel="stylesheet" href="ediar/fonts/material-icon/css/material-design-iconic-font.min.css">

    <!-- Main css -->
    <link rel="stylesheet" href="ediar/css/style.css">
</head>

<body class="bg-gradient-primary">
    <div class="main">

        <div class="container">




            <form runat="server">







                <div class="form-group col-sm-6">

                    <asp:Label ForeColor="White" ID="lblEmpleado" runat="server"></asp:Label>
                    <asp:Label ForeColor="White" ID="lblApellidos" runat="server"></asp:Label>
                    <br />
                    <br />
                     <li><a class="dropdown-item" href="frmHome.aspx">Regresar</a></li>
                    <asp:Button ID="btnDatos" runat="server" Text="Datos" onClick="btnDatos_Click" />


                    <center ><label for="exampleInputName1">documento:</label>
                    <asp:TextBox class="form-control" type="text" ID="txtDocumento" runat="server"></asp:TextBox></center>
                </div>
                <center>
                <div class="form-group col-sm-6">
                    <label for="exampleInputName1">NombreCliente</label>
                    <asp:TextBox class="form-control" type="text" ID="txtnombreCliente" runat="server"></asp:TextBox>

                </div>
                    <center>
                <div class="form-group col-sm-8">
                    <label for="exampleInputName1">apellidos</label>
                    <asp:TextBox class="form-control" type="text" ID="txtapellidos" runat="server"></asp:TextBox>
                </div></center>

                <div class="form-group col-sm-6">
                    <label for="exampleInputName1">telefono:</label>
                    <asp:TextBox class="form-control" type="text" ID="txttelefono" runat="server"></asp:TextBox>
                </div>



                <div class="form-group">
                    <label for="exampleInputEmail1">direccion</label>

                    <asp:TextBox type="exampleInputName1" class="form-control" ID="txtDireccion" runat="server"></asp:TextBox>
                </div>

                <label for="email">Email</label>
                <asp:TextBox type="email" class="form-control" ID="txtEmail" placeholder="Contraseña" runat="server"></asp:TextBox>
        

        <label for="pasword">clave</label>
        <asp:TextBox type="password" class="form-control" ID="txtClave" placeholder="Contraseña" runat="server"></asp:TextBox>
   
        <asp:Button ID="btnActualizar" runat="server" Text="ACTUALIZAR" onClick="btnActualizar_Click" />
                </center>
        </form>
            
     </div>
    <div>
    </div>
        </div>


    <script src="ediar/vendor/jquery/jquery.min.js"></script>
    <script src="ediar/js/main.js"></script>


</body>

</html>