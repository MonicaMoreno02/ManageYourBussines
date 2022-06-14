<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginEmpleado.aspx.cs" Inherits="ManageYourBussines.loginEmpleado" %>

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

<body class="bg-gradient-primary">

    <div class="container">

        <!-- Outer Row -->
        <div class="row justify-content-center">

            <div class="col-xl-10 col-lg-12 col-md-9">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="col-lg-6 d-none d-lg-block bg-login-unnamed"></div>
                            <div class="col-lg-6">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-4">Bienvenido al Sistema</h1>
                                    </div>
                                    <form runat="server">




                                        <div class="mb-3 mt-3">
                                            <label for="email" class="form-label">Email:</label>

                                            <asp:TextBox ID="txtEmailEmpledo" runat="server" CssClass="form-control" placeholder="Email Empleado" TextMode="Email"></asp:TextBox>


                                        </div>
                                        <div class="mb-3">
                                            <label for="pwd" class="form-label">Contraseña:</label>


                                            <asp:TextBox ID="txtClaveEmpleado" runat="server" CssClass="form-control" placeholder="password" TextMode="Password"></asp:TextBox>


                                            <div class="container mt-3">
                                            </div>

                                            <div class=" col mt-3 mb-3">
                                                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>






                                            </div>
                                        </div>
                                        <center>
                                            <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar Sesion" OnClick="btnIniciarSesion_Click" />

                                            <br />
                                            <center>
                                                <br />
                                                <asp:Button ID="btnRecuperarCon" runat="server" Text="Recuperacion de Contraseña " OnClick="btnRecuperarCon_Click" />
                                    </form>

                                    <hr>
                                    <%-- <div class="text-center">
                                        <a class="small" href="forgot-password.html">Forgot Password?</a>
                                    </div>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>

    <!-- Bootstrap core JavaScript-->
    <script src="recursos Emple/vendor/jquery/jquery.min.js"></script>
    <script src="recursos Emple/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="recursos Emple/vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom scripts for all pages-->
    <script src="recursos Emple/js/sb-admin-2.min.js"></script>

</body>

</html>
