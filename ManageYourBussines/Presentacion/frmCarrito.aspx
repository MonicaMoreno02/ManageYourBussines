<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmcarrito.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmcarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
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
      </ul>
    </div>
  </div>
</nav>
     <br />
    <br />
    
    

    <%-- gridwied del carrito --%>
  <!-- about section -->
  <section>
           <asp:ScriptManager ID="ScriptManager1" runat="server">
           </asp:ScriptManager>
           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
               <ContentTemplate>
                   <asp:GridView ID="gvCar" runat="server" AutoGenerateColumns="False" class="table table-dark table-striped" OnRowCommand="gvCar_RowCommand" >
                       <Columns>
                           <asp:BoundField DataField="#" HeaderText="#">
                           <ControlStyle Width="10px" />
                           <ItemStyle Width="10px" />
                           </asp:BoundField>
                           <asp:ImageField DataImageUrlField="imagen" HeaderText="IMAGEN">
                               <ControlStyle Height="60px" Width="60px" />
                               <ItemStyle Height="100px" Width="100px" />
                           </asp:ImageField>
                           <asp:BoundField DataField="nombreProducto" HeaderText="NOMBRE" />
                           <asp:BoundField DataField="describcion" HeaderText="DESCRIPCIÓN" />
                           <asp:BoundField DataField="precio" HeaderText="PRECIO" />
                           <asp:BoundField DataField="cantidad" HeaderText="CANTIDAD" />
                           <asp:ButtonField ButtonType="Button" CommandName="aumentar" Text="+"  />
                           <asp:ButtonField ButtonType="Button" CommandName="disminuir" Text="-" />
                           <asp:BoundField DataField="cantidadstock" HeaderText="CANTIDAD STOCK" />
                           <asp:BoundField DataField="total" HeaderText="TOTAL" />
                           <asp:ButtonField ButtonType="Button" CommandName="eliminar" Text="eliminar" />
                       </Columns>
                   </asp:GridView>
               </ContentTemplate>
           </asp:UpdatePanel>
   

   
    <center>
   <%--boton paypal--%>
        <div id="paypal-button-container"></div>
        <script>

            paypal.Buttons({
                style: {
                    color: 'blue',
                    shape: 'pill',
                    label: 'pay'
                },
                // Sets up the transaction when a payment button is clicked
                createOrder: (data, actions) => {
                    var prueba = "<%= this.valor%>";
                    return actions.order.create({
                        purchase_units: [{
                            amount: {
                                value: prueba// Can also reference a variable or function
                            }
                        }]
                    });
                },
                // Finalize the transaction after payer approval
                onApprove: (data, actions) => {
                    return actions.order.capture().then(function (orderData) {
                        console.log('Capture result', orderData, JSON.stringify(orderData, null, 2));
                        const transaction = orderData.purchase_units[0].payments.captures[0];
                        alert(`Transaction ${transaction.status}: ${transaction.id}\n\nSee console for all available details`);
                        window.location.href = "WebForm1.aspx";

                    });

                },


                onCancel: function (data) {
                    alert("Pago cancelado")
                    console.log(data);
                }
            }).render('#paypal-button-container');
        </script>
   </center>
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

</html>

</asp:Content>
