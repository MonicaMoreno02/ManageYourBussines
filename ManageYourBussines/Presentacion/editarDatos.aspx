<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editarDatos.aspx.cs" Inherits="ManageYourBussines.Presentacion.editarDatos" %>



<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>muebles san jose

    </title>

    <!-- Font Icon -->
    <link rel="stylesheet" href="plantilla 2/fonts/material-icon/css/material-design-iconic-font.min.css">

    <!-- Main css -->
    <link rel="stylesheet" href="plantilla 2/css/style.css">
</head>
<body>
    <form runat="server">
        <%-- <i class="bi bi-alarm"></i>
    <div class="resume-wrapper-inner mx-auto text-start bg-white shadow-lg">
               
                        <%--<img id="pbImagen" class="picture" height="250" src="../Recursos/assets/images/faces/profile.jpg" alt="">--%>
                    </div>
                 <%--   <div class="col">
                        <div class="row p-4 justify-content-center justify-content-md-between">
                            <div class="primary-info col-auto">
                                <h1 class="name mt-0 mb-1 text-white text-uppercase text-uppercase">--%>
        <asp:Label ForeColor="White" ID="lblEmpleado" runat="server"></asp:Label>
        <asp:Label ForeColor="White" ID="lblApellidos" runat="server"></asp:Label>
        <br />
        <br />

    <asp:Button ID="btnDatos" runat="server" Text="Datos" OnClick="btnDatos_Click1" />

        <%--     </h1>--%>
        <%-- <asp:Label ID="lblCargo" class="title mb-3" runat="server"></asp:Label>
                                <ul class="list-unstyled">
                                    <li class="mb-2"><i class="mdi mdi-email fs-5 " data-fa-transform="grow-3"></i>
                                        <asp:Label ForeColor="#c0c0c0" ID="lblCorreo" runat="server"></asp:Label></li>
                                    <li><i class="mdi mdi-phone-in-talk fs-5" data-fa-transform="grow-6"></i>
                                        <asp:Label ForeColor="#c0c0c0" ID="lblTelefono" runat="server"></asp:Label></li>
                                </ul>--%>
                            </div>
                            <!--//primary-info-->
       <%-- <div class="secondary-info col-auto mt-2">
            <div class="resume-social list-unstyled">
                &nbsp;
                <asp:Label ID="Label2" runat="server">Tipo de Documento</asp:Label>
                <div class="mb-3"><span class="fa-container text-center me-2"><i class="fab fa-linkedin-in fa-fw"></i></span>
                    <asp:Label ForeColor="#c0c0c0" ID="lblTipoDocumento" runat="server"></asp:Label></div>
                &nbsp;
                <asp:Label ID="Label1" runat="server">Documento</asp:Label>
                <div class="mb-3"><span class="fa-container text-center me-2"><i class="fab fa-github-alt fa-fw"></i></span>
                    <asp:Label ForeColor="#c0c0c0" ID="lblDocumento" runat="server"></asp:Label></div>--%>
                <%--<li class="mb-3"><a class="text-link" href="#"><span class="fa-container text-center me-2"><i class="fab fa-codepen fa-fw"></i></span>codepen.io/username/</a></li>
                                    <li><a class="text-link" href="#"><span class="fa-container text-center me-2"><i class="fas fa-globe"></i></span>yourwebsite.com</a></li>--%>
       
        <!--//secondary-info-->
       
                        <!--//row-->
        <br />
        <div>
<%--        <asp:Button ID="btnDatos" runat="server" Text="Datos"onClick="btnDatos_Click" />--%>
               </div>
      
       
        <div class="resume-body p-5">
            <section class="resume-section summary-section mb-5 row">
                <div class="grid-margin stretch-card ">
                    <div class="card">
                        <div class="card-body row">






                            <div class="form-group col-sm-6">

                                <label for="exampleInputName1">documento:</label>
                                <asp:TextBox class="form-control" type="text" ID="txtDocumento" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group col-sm-6">
                                <label for="exampleInputName1">NombreCliente</label>
                                <asp:TextBox class="form-control" type="text" ID="txtnombreCliente" runat="server"></asp:TextBox>

                            </div>

                            <div class="form-group col-sm-8">
                                <label for="exampleInputName1">apellidos</label>
                                <asp:TextBox class="form-control" type="text" ID="txtapellidos" runat="server"></asp:TextBox>
                            </div>

                            <div class="form-group col-sm-6">
                                <label for="exampleInputName1">telefono:</label>
                                <asp:TextBox class="form-control" type="text" ID="txttelefono" runat="server"></asp:TextBox>
                            </div>



                            <div class="form-group">
                                <label for="exampleInputEmail1">direccion</label>

                                <asp:TextBox type="email" class="form-control" ID="txtDireccion" runat="server"></asp:TextBox>
                            </div>
                         
                                <label for="email">Email</label>
                                <asp:TextBox type="password" class="form-control" ID="txtEmail" placeholder="Contraseña" runat="server"></asp:TextBox>
                            </div>
                        
                                <label for="pasword">clave</label>
                                <asp:TextBox type="password" class="form-control" ID="txtClave" placeholder="Contraseña" runat="server"></asp:TextBox>
                            </div>

                            <div>
                                <%--                             <asp:Button ID="btnActualizar" type="submit" class="btn btn-primary mr-2" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />--%>
                            </div>
                        </div>
                    </div>
                </div>




            </section>
            <!--//summary-section-->
            <%--<div class="row">
                <div class="col-lg-9">
                    <section class="resume-section experience-section mb-5">
                    </section>
                    <!--//experience-section-->
                </div>
                <div class="col-lg-3">
                    <section class="resume-section skills-section mb-5">
                    </section>
                    <!--//education-section-->
                    <section class="resume-section reference-section mb-5">
                    </section>
                    <!--//interests-section-->
                    <section class="resume-section language-section mb-5">
                    </section>
                    <!--//language-section-->
                    <section class="resume-section interests-section mb-5">
                    </section>
                    <!--//interests-section-->

                </div>
            </div>--%>
            <!--//row-->
        </div>
        <!--//resume-body-->

    </form>
    </div>


</body>

</html>
