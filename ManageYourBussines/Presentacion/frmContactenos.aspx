<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmContactenos.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmContactenos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="//code.tidio.co/xed0rnwvhavbuz7gsahpinux2goqrymt.js" async></script>
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
    	 <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <div class="container-fluid">
    <img src="recursos/images/icono3.png" widt="20" height="20"/>
    <a class="navbar-brand" href="#">Muebles San José</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="collapsibleNavbar">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link" href="frmHome.aspx">Home</a>
        </li>
          <li class="nav-item">
          <a class="nav-link" href="About.aspx">Sobre Nosotros</a>
        </li>
          <li class="nav-item">
          <a class="nav-link" href="frmdetalles.aspx">Productos</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
     
 <section id="section2">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xs-12 ">
                        <div class="maintext text-center">
                            
                            <h2>Encuentranos...</h2>                  
                </div>
                        
                <div class="row shapes">
                    <div class="col-md-6 col-sm-6 col-xs-12">
                        <div class="row">
                            <div class="col-md-12 minHeightProp">
                                <img class="imgback" src="recursos2/img/shape/shape1.png">
                            </div>
                            <div class="col-md-12">
                                <div class="text-center">
                                    <span>Datos del contacto</span>
                                     <p>Duitama: Cra 40 # 24-63 - barrio Camilo Torres </p>
                                     <p>Números de contacto: 3133658254 </p>
                                     <p>Email de contacto: muebles.sanjose@gmail.com</p>
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
                                    <span>Preguntas Frecuentes</span>
                                   <div class="accordion accordion-flush" id="accordionFlushExample">
  <div class="accordion-item">
    <h2 class="accordion-header" id="flush-headingOne">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
        ¿Tiene algún costo adicional el envío de los productos?
      </button>
    </h2>
    <div id="flush-collapseOne" class="accordion-collapse collapse" aria-labelledby="flush-headingOne" data-bs-parent="#accordionFlushExample">
      <div class="accordion-body">Si, los envios son a nivel nacional y el valor se calcula dependiendo del lugar que usted se encuentre. <code></code></div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header" id="flush-headingTwo">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwo" aria-expanded="false" aria-controls="flush-collapseTwo">
         ¿Qué métodos de pago se aceptan en la Tienda Online?
      </button>
    </h2>
    <div id="flush-collapseTwo" class="accordion-collapse collapse" aria-labelledby="flush-headingTwo" data-bs-parent="#accordionFlushExample">
      <div class="accordion-body">Puede pagar con tarjeta de crédito, débito y transferencia bancaria. <code></code></div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header" id="flush-headingThree">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseThree" aria-expanded="false" aria-controls="flush-collapseThree">
       ¿Recibo una factura para mi pedido?
      </button>
    </h2>
    <div id="flush-collapseThree" class="accordion-collapse collapse" aria-labelledby="flush-headingThree" data-bs-parent="#accordionFlushExample">
      <div class="accordion-body">Claro que sí, recibirás una factura electrónica que será enviada al correo con el que te registraste.<code></code></div>
    </div>
  </div>
</div>
                                </div> 
                            </div> 
                        </div> 
                    </div>
                   </div>
                   </div>
                    </div>
               
            </div>

       
          <section id="section7" class="row address parallax-window" data-parallax="scroll" data-image-src="../recursos/images/fondo5.jpeg" />
            <div class="col-md-12">
                    <div class="row">

                        <div class="col-md-5 col-md-offset-1 addess-description">
                            <span>Ubicación de Muebles San José</span>
                            <h2>Muebles San José</h2>
                            <p>En Muebles San José encuentras los mejores diseños para tu hogar</p>
                            <ul>
                                <li class="address-section">
                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2">
                                            <i class="fa fa-phone"></i>                                       
                                         </div>
                                         <div class="col-md-10 col-sm-10 col-xs-10 lineHeight">
                                            3133658254<br>3125403349
                                        </div>
                                    </div>
                                    </li>
                                <li class="address-section">
                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2">
                                            <i class="fa fa-envelope"></i>                                       
                                        </div>
                                        <div class="col-md-10 col-sm-10 col-xs-10 lineHeight">
                                            muebles.sanjose@gmail.com<br>Duitama: Cra 40 # 24-63
                                        </div>
                                    </div>
                                </li>
                            </ul>
                        </div>
                        <div class="col-md-6 addess-map">
                         <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3969.313056549008!2d-73.0163006857766!3d5.811388732644974!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8e6a3f297a7ac04b%3A0x16b53940a2420fb4!2sIndustrias%20Solomarmol!5e0!3m2!1ses!2sco!4v1656448481557!5m2!1ses!2sco" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
                        </div>
            </div>
        </div>
        </section>
  
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

    </body>

        <!-- Adress Section End -->
 
        </section>
        <script type='text/javascript' src='https://maps.googleapis.com/maps/api/js?key=AIzaSyCe30oLPh7uH3vWngw96bjZ0HLPq51Byf8'></script>
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
    </body>


</html>
    

</asp:Content>
