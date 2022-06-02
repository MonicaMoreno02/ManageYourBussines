<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ManageYourBussines.index" %>


<html>

<head>
    <!-- Basic -->
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <!-- Mobile Metas -->
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <!-- Site Metas -->
    <meta name="keywords" content="" />
    <meta name="description" content="" />
    <meta name="author" content="" />



    <!--Insertamos el icono que se visualiza en la esquina de la pestaña en el navegador-->
    <link rel="shortcut icon" href="recursos/images/sillaIcono.png" type="">
    <!--Añadimos el titulo-->
    <title>Muebles San José</title>



    <!-- bootstrap core css -->
    <link rel="stylesheet" type="text/css" href="recursos/css/bootstrap.css" />

    <!--owl slider stylesheet -->
    <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.carousel.min.css" />
    <!-- nice select  -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery-nice-select/1.1.0/css/nice-select.min.css" integrity="sha512-CruCP+TD3yXzlvvijET8wV5WxxEh5H8P4cmz0RFbKK6FlZ2sYl3AEsKlLPHbniXKSrDdFewhbmBK5skbdsASbQ==" crossorigin="anonymous" />
    <!-- font awesome style -->
    <link href="recursos/css/font-awesome.min.css" rel="stylesheet" />

  <!-- Custom styles for this template -->
  <link href="recursos/css/style.css" rel="stylesheet" />
  <!-- responsive style -->
  <link href="recursos/css/responsive.css" rel="stylesheet" />
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
  <form id="form1" runat="server">
    <!-- Custom styles for this template -->
    <link href="recursos/css/style.css" rel="stylesheet" />
    <!-- estilo para que sea responsive -->
    <link href="recursos/css/responsive.css" rel="stylesheet" />

</head>


<body>
    <!--Añadimos el fondo-->
    <div class="hero_area">
        <div class="bg-box">
            <img src="recursos/images/fondo5.jpeg" alt="">
        </div>
        <!-- header section strats -->
        <header class="header_section">
            <div class="container">
                <nav class="navbar navbar-expand-lg custom_nav-container ">
                    <a class="navbar-brand" href="index.aspx">
                        <span>Muebles San José
                        </span>
                    </a>

                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                        <span class=""></span>
                    </button>

                    <div class="collapse navbar-collapse" id="navbarSupportedContent">
                        <ul class="navbar-nav  mx-auto ">
                            <li class="nav-item active">
                                <a class="nav-link" href="index.aspx">Home <span class="sr-only">(current)</span></a>
                            </li>
                           <%-- <li class="nav-item">
                                <a class="nav-link" href="menu.html">Productos</a>
                            </li>--%>
                           <%-- <li class="nav-item">
                                <a class="nav-link" href="about.html">Sobre Nosotros</a>
                            </li>--%>


                             <div class="container mt-">



                                <li class="nav-item">
                                    <a class="nav-link" data-bs-toggle="modal" data-bs-target="#myModal">Iniciar Sesión </a>
                                </li>
                            </div>

                            <!-- The Modal -->
                            <div class="modal" id="myModal">
                                <div class="modal-dialog">
                                    <div class="modal-content">

                                        <!-- Modal Header -->
                                        <div class="modal-header">
                                            <h4 class="modal-title">Iniciar Sesión </h4>
                                            <button type="button" class="btn-close" data-bs-dismiss="modal"></button>
                                        </div>

                                        <!-- Modal body  el inicio de sesion  para cliente y administraador -->
                                        <div class="modal-body">

                                           

                                                <div class="mb-3 mt-3">
                                                    <label for="email" class="form-label">Email:</label>

                                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email usuario" TextMode="Email"></asp:TextBox>


                                                </div>
                                                <div class="mb-3">
                                                    <label for="pwd" class="form-label">Password:</label>


                                                    <asp:TextBox ID="txtClave" runat="server" CssClass="form-control" placeholder="password" TextMode="Password"></asp:TextBox>


                                                    <div class="container mt-3">
                                                    </div>

                                                    <div class=" col mt-3 mb-3">
                                                        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>


                                                    </div>
                                                </div>
                                                <center>
                                                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-success" onClick="btnIngresar_Click" /></center>
                                                <br />
                                                <center>
                                                    <asp:Button ID="btnRecuperar" runat="server" Text="Recuperar Contraseña" CssClass="btn btn-success" onClick="btnRecuperar_Click" />
                                         


                                        </div>

                                        <!-- Modal footer --->
                                        <div class="modal-footer">
                                            <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Cerrar</button>
                                        </div>

                                    </div>
                                </div>
                            </div>
                            <%-- cierre de  modal  --%>

                            <%-- continua con los  item de  navegacion --%>
                            <li class="nav-item">
          <a class="nav-link" href="Presentacion/frmRegistrar.aspx">Registrarse</a>
      </li>

                
                        </ul>
                        <div class="user_option">
                            <a href="" class="user_link">
                                <i class="fa fa-user" aria-hidden="true"></i>
                            </a>
                           <%-- <asp:ImageButton ID="ImageButton1" runat="server" />--%>
                          <%--  <a class="cart_link" href="#">
                                <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 456.029 456.029" style="enable-background: new 0 0 456.029 456.029;" xml:space="preserve">--%>
                                    <g>
                                        <g>
                                            <path d="M345.6,338.862c-29.184,0-53.248,23.552-53.248,53.248c0,29.184,23.552,53.248,53.248,53.248
                   c29.184,0,53.248-23.552,53.248-53.248C398.336,362.926,374.784,338.862,345.6,338.862z" />
                                        </g>
                                    </g>
                                    <g>
                                        <g>
                                            <path d="M439.296,84.91c-1.024,0-2.56-0.512-4.096-0.512H112.64l-5.12-34.304C104.448,27.566,84.992,10.67,61.952,10.67H20.48
                   C9.216,10.67,0,19.886,0,31.15c0,11.264,9.216,20.48,20.48,20.48h41.472c2.56,0,4.608,2.048,5.12,4.608l31.744,216.064
                   c4.096,27.136,27.648,47.616,55.296,47.616h212.992c26.624,0,49.664-18.944,55.296-45.056l33.28-166.4
                   C457.728,97.71,450.56,86.958,439.296,84.91z" />
                                        </g>
                                    </g>
                                    <g>
                                        <g>
                                            <path d="M215.04,389.55c-1.024-28.16-24.576-50.688-52.736-50.688c-29.696,1.536-52.224,26.112-51.2,55.296
                   c1.024,28.16,24.064,50.688,52.224,50.688h1.024C193.536,443.31,216.576,418.734,215.04,389.55z" />
                                        </g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                </svg>
                            </a>
                           <%-- <form class="form-inline">
                                <button class="btn  my-2 my-sm-0 nav_search-btn" type="submit">
                                    <i class="fa fa-search" aria-hidden="true"></i>
                                </button>
                            </form>
                            <a href="" class="order_online">Compra Ahora
                            </a>--%>
                        </div>
                    </div>
                </nav>
            </div>
        </header>
        <!-- end header section -->
        <!-- slider section -->
        <section class="slider_section ">
            <div id="customCarousel1" class="carousel slide" data-ride="carousel">
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <div class="container ">
                            <div class="row">
                                <div class="col-md-7 col-lg-6 ">
                                    <div class="detail-box">
                                        <h1>Calidad en todo momento
                                        </h1>
                                        <p>
                                            En muebles San José te brindamos lo mejor en ebanistería ya que trabajamos con la mayor calidad usando excelentes materiales como pino, flor morado, cedro, MDF y muchos mas. 
                                        </p>
                                        <div class="btn-box">
                                            <a href="" class="btn1">Hacer pedido
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="carousel-item ">
                        <div class="container ">
                            <div class="row">
                                <div class="col-md-7 col-lg-6 ">
                                    <div class="detail-box">
                                        <h1>Accesible y Amable
                                        </h1>
                                        <p>
                                            Puedes hacer tu pedido desde celular, tablet o laptop, ordenar la cantidad que necesites y con las especificaciones que requieras, para ello puedes comunicarte con nuestros asesores en el CHAT EN VIVO.
                                        </p>
                                        <div class="btn-box">
                                            <a href="" class="btn1">Hacer pedido
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="carousel-item">
                        <div class="container ">
                            <div class="row">
                                <div class="col-md-7 col-lg-6 ">
                                    <div class="detail-box">
                                        <h1>Esfuerzo y dedicación
                                        </h1>
                                        <p>
                                            En Muebles San José damos lo mejor de nosotros porque "La mejor publicidad es la que hacen los clientes satisfechos", nuestra prioridad es brindar sonrisas a nuestros compradores.
                                        </p>
                                        <div class="btn-box">
                                            <a href="" class="btn1">Hacer pedido
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="container">
                    <ol class="carousel-indicators">
                        <li data-target="#customCarousel1" data-slide-to="0" class="active"></li>
                        <li data-target="#customCarousel1" data-slide-to="1"></li>
                        <li data-target="#customCarousel1" data-slide-to="2"></li>
                    </ol>
                </div>
            </div>

        </section>
        <!-- end slider section -->
    </div>

    <!-- offer section -->

    <section class="offer_section layout_padding-bottom">
        <div class="offer_container">
            <div class="container ">
                <div class="row">
                    <div class="col-md-6  ">
                        <div class="box ">
                            <div class="img-box">
                                <img src="recursos/images/sillamesedora.png" alt="">
                            </div>
                            <div class="detail-box">
                                <h5>Jueves de Descuentos
                                </h5>
                                <h6>
                                    <span>15%</span> Off
                                </h6>
                                <a href="">Hacer Pedido
                                    <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 456.029 456.029" style="enable-background: new 0 0 456.029 456.029;" xml:space="preserve">
                                        <g>
                                            <g>
                                                <path d="M345.6,338.862c-29.184,0-53.248,23.552-53.248,53.248c0,29.184,23.552,53.248,53.248,53.248
                     c29.184,0,53.248-23.552,53.248-53.248C398.336,362.926,374.784,338.862,345.6,338.862z" />
                                            </g>
                                        </g>
                                        <g>
                                            <g>
                                                <path d="M439.296,84.91c-1.024,0-2.56-0.512-4.096-0.512H112.64l-5.12-34.304C104.448,27.566,84.992,10.67,61.952,10.67H20.48
                     C9.216,10.67,0,19.886,0,31.15c0,11.264,9.216,20.48,20.48,20.48h41.472c2.56,0,4.608,2.048,5.12,4.608l31.744,216.064
                     c4.096,27.136,27.648,47.616,55.296,47.616h212.992c26.624,0,49.664-18.944,55.296-45.056l33.28-166.4
                     C457.728,97.71,450.56,86.958,439.296,84.91z" />
                                            </g>
                                        </g>
                                        <g>
                                            <g>
                                                <path d="M215.04,389.55c-1.024-28.16-24.576-50.688-52.736-50.688c-29.696,1.536-52.224,26.112-51.2,55.296
                     c1.024,28.16,24.064,50.688,52.224,50.688h1.024C193.536,443.31,216.576,418.734,215.04,389.55z" />
                                            </g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                    </svg>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6  ">
                        <div class="box ">
                            <div class="img-box">
                                <img src="recursos/images/biblioteca1.png" alt="">
                            </div>
                            <div class="detail-box">
                                <h5>Super Sabados
                                </h5>
                                <h6>
                                    <span>20%</span> Off
                                </h6>
                                <a href="">Hacer Pedido
                                    <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 456.029 456.029" style="enable-background: new 0 0 456.029 456.029;" xml:space="preserve">
                                        <g>
                                            <g>
                                                <path d="M345.6,338.862c-29.184,0-53.248,23.552-53.248,53.248c0,29.184,23.552,53.248,53.248,53.248
                     c29.184,0,53.248-23.552,53.248-53.248C398.336,362.926,374.784,338.862,345.6,338.862z" />
                                            </g>
                                        </g>
                                        <g>
                                            <g>
                                                <path d="M439.296,84.91c-1.024,0-2.56-0.512-4.096-0.512H112.64l-5.12-34.304C104.448,27.566,84.992,10.67,61.952,10.67H20.48
                     C9.216,10.67,0,19.886,0,31.15c0,11.264,9.216,20.48,20.48,20.48h41.472c2.56,0,4.608,2.048,5.12,4.608l31.744,216.064
                     c4.096,27.136,27.648,47.616,55.296,47.616h212.992c26.624,0,49.664-18.944,55.296-45.056l33.28-166.4
                     C457.728,97.71,450.56,86.958,439.296,84.91z" />
                                            </g>
                                        </g>
                                        <g>
                                            <g>
                                                <path d="M215.04,389.55c-1.024-28.16-24.576-50.688-52.736-50.688c-29.696,1.536-52.224,26.112-51.2,55.296
                     c1.024,28.16,24.064,50.688,52.224,50.688h1.024C193.536,443.31,216.576,418.734,215.04,389.55z" />
                                            </g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                        <g>
                                        </g>
                                    </svg>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- end offer section -->

    <!-- food section -->

  <section class="food_section layout_padding-bottom">
    <div class="container">
      <div class="heading_container heading_center">
       <h2>
          Nuestros Productos
        </h2>
        <div id="BlockItemSubMenu">
	<asp:Repeater id="Repeater2" runat="server">
		<ItemTemplate>
			<div class="ItemSubMenu">
				<asp:Literal ID="Imagen" runat="server" /><img src="<%#Eval("imagen") %>" width="200" height="200" /></td></tr><br>
                <asp:Literal ID="nombre" runat="server" /> <%#Eval("nombre") %><br>
                <asp:Literal ID="precio" runat="server" />$ <%#Eval("precio") %><br>
                <asp:Button ID="btnDetalles" runat="server" Text="Detalles:" CssClass="btn btn-success" Onclick="btnDetalles_Click"/>
			</div>				
		</ItemTemplate>
	</asp:Repeater>
</div> 
 </div>
</div>
</section>      

    <!-- end food section -->

    <!-- about section -->

   <!-- end client section -->

    <!-- PIE DE PAGINA -->
    <footer class="footer_section">
        <div class="container">
            <div class="row">
                <div class="col-md-4 footer-col">
                    <div class="footer_contact">
                        <h4>Contactanos
                        </h4>
                        <div class="contact_link_box">
                            <a href="">
                                <i class="fa fa-map-marker" aria-hidden="true"></i>
                                <span>Cra40#24-63 - barrio Camilo Torres 
                                </span>
                            </a>
                            <a href="">
                                <i class="fa fa-phone" aria-hidden="true"></i>
                                <span>3133658254
         <br />
                                    <i class="fa fa-phone" aria-hidden="true"></i>
                                    <span>3125403349
                                    </span></a>
                            <a href="">
                                <i class="fa fa-envelope" aria-hidden="true"></i>
                                <span>muebles.sanjose@gmail.com
                                </span>
                            </a>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 footer-col">
                    <div class="footer_detail">
                        <a href="" class="footer-logo">Nuestras redes sociales
                        </a>
                        <p>
                            Contamos con diseños exclusivos, llevando calidad e innovación a tu hogar. 
                        </p>
                        <div class="footer_social">



                            <a href="https://web.facebook.com/Muebles-San-Jos%C3%A9-113560607081755" target="_blank" rel="noopener noreferrer">
                                <i class="fa fa-facebook" aria-hidden="true"></i>
                            </a>

                            <a href="https://instagram.com/muebles.san_jose?igshid=YmMyMTA2M2Y=" target="_blank" rel="noopener noreferrer">
                                <i class="fa fa-instagram" aria-hidden="true"></i>
                            </a>

                            <a href="http://wa.me/573133658254/" target="_blank" rel="noopener noreferrer">
                                <i class="fa fa-whatsapp" aria-hidden="true"></i>
                            </a>




                            </a>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 footer-col">
                    <h4>Horario de atención 
                    </h4>
                    <p>
                        Lunes a sábado
                    </p>
                    <p>
                        8:00 Am a 12:00 Pm - 2:00 Pm a 5:00 Pm
                    </p>
                </div>
            </div>

        </div>
        </div>
    </footer>
    <!-- end about section -->

   
    <!-- footer section -->

  <!-- jQery -->
  <script src="recursos/js/jquery-3.4.1.min.js"></script>
  <!-- popper js -->
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous">
  </script>
  <!-- bootstrap js -->
  <script src="recursos/js/bootstrap.js"></script>
  <!-- owl slider -->
  <script src="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js">
  </script>
  <!-- isotope js -->
  <script src="https://unpkg.com/isotope-layout@3.0.4/dist/isotope.pkgd.min.js"></script>
  <!-- nice select -->
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-nice-select/1.1.0/js/jquery.nice-select.min.js"></script>
  <!-- custom js -->
  <script src="recursos/js/custom.js"></script>
  <!-- Google Map -->
  <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCh39n5U-4IoWpsVGUHWdqB6puEkhRLdmI&callback=myMap">
  </script>
  <!-- End Google Map -->
    <script src="Presentacion/Recursos/js/datosDatable.js"></script>
</body>
</form>
</html>

        