<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editarDatos.aspx.cs" Inherits="ManageYourBussines.Presentacion.editarDatos" %>

<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Empresa/Site1.Master" AutoEventWireup="true" CodeBehind="frmConfiguracionEmpleados.aspx.cs" Inherits="AppWeb_GestionDeReservaHotelera.Presentacion.Empresa.frmConfiguracionEmpleados" %>--%>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Sign Up Form by Colorlib</title>

    <!-- Font Icon -->
    <link rel="stylesheet" href="plantilla 2/fonts/material-icon/css/material-design-iconic-font.min.css">

    <!-- Main css -->
    <link rel="stylesheet" href="plantilla 2/css/style.css">
</head>
    <body>
        <form runat="server">
    <i class="bi bi-alarm"></i>
    <div class="resume-wrapper-inner mx-auto text-start bg-white shadow-lg">
               
                        <%--<img id="pbImagen" class="picture" height="250" src="../Recursos/assets/images/faces/profile.jpg" alt="">--%>
                    </div>
                    <div class="col">
                        <div class="row p-4 justify-content-center justify-content-md-between">
                            <div class="primary-info col-auto">
                                <h1 class="name mt-0 mb-1 text-white text-uppercase text-uppercase">
                                    <asp:Label ForeColor="White" ID="lblEmpleado" runat="server"></asp:Label>
                                    <asp:Label ForeColor="White" ID="lblApellidos" runat="server"></asp:Label>
                                </h1>
                                <asp:Label ID="lblCargo" class="title mb-3" runat="server"></asp:Label>
                                <ul class="list-unstyled">
                                    <li class="mb-2"><i class="mdi mdi-email fs-5 " data-fa-transform="grow-3"></i>
                                        <asp:Label ForeColor="#c0c0c0" ID="lblCorreo" runat="server"></asp:Label></li>
                                    <li><i class="mdi mdi-phone-in-talk fs-5" data-fa-transform="grow-6"></i>
                                        <asp:Label ForeColor="#c0c0c0" ID="lblTelefono" runat="server"></asp:Label></li>
                                </ul>
                            </div>
                            <!--//primary-info-->
                            <div class="secondary-info col-auto mt-2">
                                <div class="resume-social list-unstyled">
                                    &nbsp; <asp:Label  ID="Label2" runat="server">Tipo de Documento</asp:Label>
                                    <div class="mb-3"><span class="fa-container text-center me-2"><i class="fab fa-linkedin-in fa-fw"></i></span><asp:Label ForeColor="#c0c0c0" ID="lblTipoDocumento" runat="server"></asp:Label></div>
                                    &nbsp; <asp:Label  ID="Label1" runat="server">Documento</asp:Label>
                                    <div class="mb-3"><span class="fa-container text-center me-2"><i class="fab fa-github-alt fa-fw"></i></span><asp:Label ForeColor="#c0c0c0" ID="lblDocumento" runat="server"></asp:Label></div>
                                    <%--<li class="mb-3"><a class="text-link" href="#"><span class="fa-container text-center me-2"><i class="fab fa-codepen fa-fw"></i></span>codepen.io/username/</a></li>
                                    <li><a class="text-link" href="#"><span class="fa-container text-center me-2"><i class="fas fa-globe"></i></span>yourwebsite.com</a></li>--%>
                                </div>
                            </div>
                            <!--//secondary-info-->
                        </div>
                        <!--//row-->
                         <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
                    </div>
               
      
       
        <div class="resume-body p-5">
            <section class="resume-section summary-section mb-5 row">
                <div class="grid-margin stretch-card ">
                    <div class="card">
                        <div class="card-body row">


                            <div class="form-group col-sm-6">

                                <label for="exampleInputName1">Nombres:</label>
                                <asp:TextBox class="form-control" type="text" ID="txtNombres" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group col-sm-6">
                                <label for="exampleInputName1">Apellidos</label>
                                <asp:TextBox class="form-control" type="text" ID="txtApellidos" runat="server"></asp:TextBox>

                            </div>
                            <div class="form-group col-sm-4">

                                <label for="exampleSelectGender">Tipo de Documento</label>
                                <asp:DropDownList class="form-control" ForeColor="White" ID="ddlTipoDocumento" runat="server">

                                    <asp:ListItem Value="" required="">Seleccione...</asp:ListItem>
                                    <asp:ListItem Value="Cédula de Ciudadanía">Cédula de Ciudadanía</asp:ListItem>
                                    <asp:ListItem Value="Tarjeta de Identidad">Tarjeta de Identidad</asp:ListItem>
                                    <asp:ListItem Value="Registro Civil de Nacimiento">Registro Civil de Nacimiento</asp:ListItem>
                                    <asp:ListItem Value="Tarjeta de Extranjería">Tarjeta de Extranjería</asp:ListItem>
                                    <asp:ListItem Value="Cédula de Extranjería ">Cédula de Extranjería</asp:ListItem>
                                    <asp:ListItem Value=" NIT">NIT</asp:ListItem>
                                    <asp:ListItem Value="Pasaporte">Pasaporte </asp:ListItem>
                                </asp:DropDownList>
                                
                            </div>
                            <div class="form-group col-sm-8">
                                <label for="exampleInputName1">Numero de Documento</label>
                                <asp:TextBox class="form-control" type="text" ID="txtNumeroDocumento" runat="server"></asp:TextBox>
                            </div>

                            <div class="form-group col-sm-6">
                                <label for="exampleInputName1">Numero de telefonico:</label>
                                <asp:TextBox class="form-control" type="text" ID="txtNumeroTelefonico" runat="server"></asp:TextBox>
                            </div>


                            <div class="form-group col-sm-6">
                                <label>Subir Imagen</label>
                                <asp:FileUpload ID="fCargaImagen" accept=".jpg" runat="server" CssClass="form-control" />
                            </div>

                            <div class="form-group">
                                <label for="exampleInputEmail1">Correo</label>
                                
                                <asp:TextBox type="email" class="form-control" id="txtCorreo" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group col-sm-6">
                                <label for="exampleInputPassword1">Contraseña</label>
                                <asp:TextBox type="password" class="form-control" id="txtClave" placeholder="Contraseña" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group col-sm-6">
                                <label for="exampleInputConfirmPassword1">Confirma contraseña</label>
                                <asp:TextBox type="password" class="form-control" id="confirm_password"  placeholder="Confirma contraseña" runat="server"></asp:TextBox>
                                
                            </div>
                            <div >
                             <asp:Button ID="btnActualizar" type="submit" class="btn btn-primary mr-2" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
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
