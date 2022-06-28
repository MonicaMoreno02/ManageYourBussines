<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ManageYourBussines.Presentacion.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <!doctype html>
<html lang="en">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
        <title>Cemre Bakery - Restorant Html Template</title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="author" content="Cemre Tellioğlu Tunçay">

        <link href="https://fonts.googleapis.com/css?family=Roboto&display=swap" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap&subset=latin-ext" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Poppins&display=swap" rel="stylesheet"> 
        <!-- Place favicon.ico in the root directory -->
        <link rel="icon" type="image/png" href="favicon-32x32.png" sizes="32x32" />
        <link rel="icon" type="image/png" href="favicon-16x16.png" sizes="16x16" />
        <link rel="stylesheet" href="recursos2/css/bootstrap.min.css">
        <link rel="stylesheet" href="recursos2/css/owl.carousel.min.css">
        <link rel="stylesheet" href="recursos2/css/font-awesome.min.css">
        <link rel="stylesheet" href="recursos2/css/reset.css">
        <link rel="stylesheet" href="recursos2/css/style.css">
        <link rel="stylesheet" href="recursos2/css/animate.css">
        <link rel="stylesheet" href="recursos2/css/responsive.css">
        <script src="js/vendor/modernizr-2.8.3.min.js"></script>

    </head>
    	<header class="top">
                  <div class="fixedArea">
					<div class="row">
						<div class="col-md-12 col-sm-12 col-xs-12 noPadding">
                            <div class="content-wrapper one">
                                <!-- Main Menu Start -->
                                <!-- Navbar-->
                                <header class="header">
                                    <nav class="navbar navbar-default myNavBar">
                                        <div class="container">

                                            <!-- Brand and toggle get grouped for better mobile display -->
                                            <div class="navbar-header">
                                                <div class="row">
                                                    <div class="col-md-9 col-sm-9 col-xs-9">
                                                        <div class="row">
                                                            <div class="col-md-3 col-xs-3 col-sm-3">
                                                                <a style="padding-top:0px;" class="navbar-brand navBrandText text-uppercase font-weight-bold" href="index.html"><img src="recursos/images/iconoSofa.png" alt="restorant" widt="50" height="50" /></a>
                                                                
                                                            </div>
                                                            <div class="col-md-9 col-sm-9 col-xs-9">
                                                               <a class="navbar-brand" href="#">Muebles San José</a>
                                                                
                                                            </div>
                                                        </div>


                                                    </div>
                                                    <div class="col-md-3 col-sm-3 col-xs-3">
                                                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                                                            <span class="sr-only">Toggle navigation</span>
                                                            <span class="icon-bar"></span>
                                                            <span class="icon-bar"></span>
                                                            <span class="icon-bar"></span>
                                                        </button>
                                                    </div>
                                                </div>

                                            </div>
                                                     
                                        <div class="btn-group">
  <button type="button" class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
    Menú
  </button>
  <div class="dropdown-menu dropdown-menu-right">
      <asp:Button ID="btnHome" runat="server" CssClass="dropdown-item-text" Text="Home" OnClick="btnHome_Click" />
      <asp:Button ID="btnProductos" runat="server" CssClass="dropdown-item-text" Text="Productos" OnClick="btnProductos_Click" />
      <asp:Button ID="btnContactenos" runat="server" CssClass="dropdown-item-text" Text="Contactenos" OnClick="btnContactenos_Click" />
    
  </div>
</div>
                                </header>
                                <!-- Main Menu End -->
                            </div>
						</div>
                  </div>
			</div>
		</header>
    <body>
    <section id="section2">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xs-12 ">
                        <div class="maintext text-center">
                            
                            <h2>Bienvenidos a Muebles San José</h2>                  
                            </div>  
                    </div>
                </div>
                <div class="row shapes">
                    <div class="col-md-6 col-sm-6 col-xs-12">
                        <div class="row">
                            <div class="col-md-12 minHeightProp">
                                <img class="imgback" src="recursos2/img/shape/shape1.png">
                            </div>
                            <div class="col-md-12">
                                <div class="text-center">
                                    <span>Nuestra Misión</span>
                                    <p>Ofrecer a cada uno de los clientes una experiencia de productos y servicios de calidad, llenos de innovación, junto a un gran portafolio de diseños, asesorías personalizadas, puntualidad y compromiso en las entregas. Apoyados de un excelente personal, garantizando la satisfacción del cliente</p>                                
                                    </div> 
                            </div> 
                        </div>
                    </div>
                    <div class="col-md-6 col-sm-6 col-xs-12">
                        <div class="row">
                            <div class="col-md-12 minHeightProp">
                                <img class="imgback" src="recursos2/img/shape/shape2.png">
                            </div>
                            <div class="col-md-12">
                                <div class="text-center">
                                    <span>Nuestra Visión</span>
                                    <p>Mantener el liderazgo e innovación en el mercado de muebles, accesorios; en nuestras diferentes líneas de terminaciones. Llevar a los hogares una restauración satisfactoria para nuestros clientes. Mediante productos y servicios de alta calidad, a la vanguardia de la constante innovación.</p>
                                </div> 
                            </div> 
                        </div> 
                    </div>
                   
                    </div>
               
            </div>
         <div class="container">

                <div class="row">
                     <div class="col-xs-12">
                        <div class="section-title text-center">
                            <h3>Conoce más acerca de nuestros productos</h3>
                            
                        </div>
                    </div>
                </div>
                <div class="row">
                <div class="container">
                        <div class="col-md-12 noPadding">
                            <div id="news-slider" class="news-slider owl-theme owl-carousel">
                                <div class="post-slide">
                                    <div class="post-img">
                                        <div class="post-abs"><p>Cama Miniatura</p></div>
                                        <img src="recursos2/img/new/cama.jpg" width="50" height="50">
                                    </div>
                                    <h3 class="post-title"><a href="#">Cama Miniatura</a></h3>
                                    <p class="center">
                                       Plasmamos cada una de tus ideas en madera.
                                    </p>
                                </div>
                 
                                <div class="post-slide">
                                    <div class="post-img">
                                        <div class="post-abs"><p>Repisa Spiderman</p></div>
                                        <img src="recursos2/img/new/repisaSp.jpg" width="50" height="50">

                                    </div>
                                    <h3 class="post-title"><a href="#">Repisa Spiderman</a></h3>
                                    <p class="center">
                                       Déjanos ser parte de tu hogar,muebles,puertas, decoración y mucho más de la mejor calidad
                                    </p>
                                </div>
                                
                                <div class="post-slide">
                                    <div class="post-img">
                                        <div class="post-abs"><p>Matero</p></div>
                                        <img src="recursos2/img/new/matero3.jpg" width="50" height="50">

                                    </div>
                                    <h3 class="post-title"><a href="#">Matero</a></h3>
                                    <p class="center">
                                      Realizado de la mejor manera para el agrado de cada uno de nuestros clientes
                                    </p>
                                </div>
                                
                                <div class="post-slide">
                                    <div class="post-img">
                                        <div class="post-abs"><p>Repisa Mariposa</p></div>
                                        <img src="recursos2/img/new/repisa.jpeg" width="50" height="50">

                                    </div>
                                    <h3 class="post-title"><a href="#">Repisa Mariposa</a></h3>
                                    <p class="center">
                                      Nos encargamos de diseñar tus muebles y decoración a tu gusto.
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        
         
    <div class="container  ">
            <div class="row">
        <div class="col-md-6 ">
          <div class="img-box">
           <p align="center"> <img src="recursos/images/logo.jpg" alt="10" width="200"></p>
          </div>
        </div>
        <div class="col-md-6">
          <div class="detail-box">
            <div class="heading_container">
              <h2>
                Muebles San José
              </h2><br />
                <br />
                <br />
            </div>
            <p>
              Fabricamos los muebles y decoración para tu hogar, oficina, exteriores y otros.
                    Diferentes lineas de acabados:
                   - Linea de muebles rústicos - Linea de moderno
                   -Linea en forja Dale un toque diferente a tus lugares, con nuestras alcobas, comedores, salas, muebles auxiliares, muebles de exterior.
            </p>
           
          </div>
        </div>
      </div>
    </div>
    
 
           
        </section>

        <!-- Section2 End -->
        <!-- Banner Start -->
         <script src="recursos2/js/vendor/jquery-1.12.0.min.js"></script>
        <script src="recursos2/js/jquery-easing/jquery.easing.min.js"></script>
        <script src="recursos2/js/bootstrap.min.js"></script>
        <script src="recursos2/js/parallax.min.js"></script>
        <script src="recursos2/js/ajax-mail.js"></script>
        <script src="recursos2/js/owl.carousel.min.js"></script>
        <script src="recursos2/js/jquery.nicescroll.min.js"></script>
        <script src="recursos2/js/main.js"></script>
        <script async defer
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDyIMWhs-crjT0yhctbRjfJFq75FlEhSzE&callback=initMap">
        </script>
    </body>
</html>
</asp:Content>
