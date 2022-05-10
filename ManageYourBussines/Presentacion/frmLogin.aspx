﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="ManageYourBussines.Presentacion.WebForm1" %>

<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>SB Admin 2 - Login</title>

    <!-- Custom fonts for this template-->
    <link href="recursosadmin/vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link
        href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <!-- Custom styles for this template-->
    <link href="recursosadmin/css/sb-admin-2.min.css" rel="stylesheet">


      <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</head>

<body class="bg-gradient-primary">





      
  <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#myModal">
  registrar
  </button>


<!-- The Modal -->
<div class="modal" id="myModal">
  <div class="modal-dialog">
    <div class="modal-content">

      <!-- Modal Header -->
      <div class="modal-header">
        <h4 class="modal-title">Modal Heading</h4>
        <button type="button" class="btn-close" data-bs-dismiss="modal"></button>
      </div>

      <!-- Modal body -->
      <div class="modal-body">
     





    <div class="container">

        <!-- Outer Row -->
        <div class="row justify-content-center">

            <div class="col-xl-10 col-lg-12 col-md-9">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="col-lg-6 d-none d-lg-block bg-login-image"></div>
                            <div class="col-lg-6">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-4">Iniciar Sesion !</h1>
                                    </div>
                                    <form class="user" runat="server">
                                        <div class="form-group">



                                            <div class="mb-3 mt-3">
                                                <label for="email" class="form-label">Email:</label>

                                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email usuario" TextMode="Email"></asp:TextBox>


                                            </div>
                                            <div class="mb-3">
                                                <label for="pwd" class="form-label">Password:</label>


                                                <asp:TextBox ID="txtClave" runat="server" CssClass="form-control" placeholder="password" TextMode="Password"></asp:TextBox>


                                                <div class="container mt-3">
                                              
                                                   <div class="dropdown">
                                                        <button type="button" class="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown">
                                                           elija el usuario para ingresar
                                                        </button>
                                                        <ul class="dropdown-menu">
                                                            <li><a class="dropdown-item" href="#">Cliente</a></li>
                                                            <li><a class="dropdown-item" href="#">Administrado</a></li>
                                                      
                                                        </ul>
                                                    </div>
                                                </div>

                                                <div class=" col mt-3 mb-3">
                                                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>






                                                </div>
                                            </div>
                                            <center>
                                                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" /></center>

                                            <%-- <a href="index.html" class="btn btn-primary btn-user btn-block">
                                            INGRESAR
                                        </a>--%>
                                        <hr>
                                      <%--  <a href="index.html" class="btn btn-google btn-user btn-block">
                                            <i class="fab fa-google fa-fw"></i> Login with Google
                                        </a>
                                        <a href="index.html" class="btn btn-facebook btn-user btn-block">
                                            <i class="fab fa-facebook-f fa-fw"></i> Login with Facebook
                                        </a>--%>
                                    </form>
                                    <hr>
                                   <%-- <div class="text-center">
                                        <a class="small" href="forgot-password.html">Forgot Password?</a>
                                    </div>
                                    <div class="text-center">
                                        <a class="small" href="register.html">Create an Account!</a>--%>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>


    <!-- Bootstrap core JavaScript-->
    <script src="recursosadmin/vendor/jquery/jquery.min.js"></script>
    <script src="recursosadmin/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="recursosadmin/vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom scripts for all pages-->
    <script src="recursosadmin/js/sb-admin-2.min.js"></script>

</body>

</html>