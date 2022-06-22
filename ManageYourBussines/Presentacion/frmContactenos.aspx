<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmContactenos.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmContactenos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="//code.tidio.co/xed0rnwvhavbuz7gsahpinux2goqrymt.js" async></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <nav class="navbar navbar-expand-sm navbar-dark bg-dark">
  <div class="container-fluid">
  <img src="recursos/images/icono3.png" widt="20" height="20" />
       <a class="navbar-brand" href="#">Muebles San José</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#mynavbar">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="mynavbar">
      <ul class="navbar-nav me-auto">
        <li class="nav-item">
          <a class="nav-link" href="frmHome.aspx">Home</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
<br />
<h1>DATOS DE CONTACTO:</h1>
    <p>Duitama: Cra 40 # 24-63 - barrio Camilo Torres </p>
    <p>Números de contacto: 3133658254 </p>
    <p>Email de contacto: muebles.sanjose@gmail.com</p>
   <h2>PREGUNTAS FRECUENTES:</h2> 
    <p>Por favor lea las preguntas antes de escribirnos:</p>
    <div class="accordion">
        <div class="accordion-item">
            <a href="#" class="accordation-title plain-active " aria-expanded="false">
                <button class="toggle">
                    <i class="icon-angle-down">^</i>
                    </button>
                <span>¿Cuales son los gastos de los envios de la tienda online?</span>
                <div class="accordion-inner" style="display:block;">
                <p>
                    Dependiendo del lugar que usted se encuentre se calcula el envío según lo que cobra la empresa de DOMICILIOS, usualmente el costo no supera los $10.000 Pesos y no es inferior a los $3.000.
                </p>
                </div>
            </a>
        </div>
    </div>

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

</html>
    

</asp:Content>
