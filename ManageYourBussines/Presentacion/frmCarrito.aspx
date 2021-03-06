<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmcarrito.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmcarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <!DOCTYPE html>
    <html>

<head>
    <asp:Label ID="lbidC" runat="server" Text="Label"></asp:Label>
  <!-- Basic -->
  <meta charset="utf-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <!-- Mobile Metas -->
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
  <!-- Site Metas -->
  <meta name="keywords" content="" />
  <meta name="description" content="" />
  <meta name="author" content="" />
  <link rel="shortcut icon" href="recursos/images/favicon.png" type="">

  <title> Feane </title>

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

</head>

<body>

    <!-- header section strats -->
    <header class="header_section">
      <div class="container">
        <nav class="navbar navbar-expand-lg custom_nav-container ">
          <a class="navbar-brand" href="index.html">
            <span>
              Feane
            </span>
          </a>

          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class=""> </span>
          </button>

          <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav  mx-auto ">
              <li class="nav-item ">
                <a class="nav-link" href="frmHome.aspx">Home </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="menu.html">Menu</a>
              </li>
              <li class="nav-item active">
                <a class="nav-link" href="about.html">About <span class="sr-only">(current)</span> </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="book.html">
                  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                  Book Table</a>
              </li>
            </ul>
            <div class="user_option">
              <a href="" class="user_link">
                <i class="fa fa-user" aria-hidden="true"></i>
              </a>
              <a class="cart_link" href="#">
                <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 456.029 456.029" style="enable-background:new 0 0 456.029 456.029;" xml:space="preserve">
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
              <form class="form-inline">
                <button class="btn  my-2 my-sm-0 nav_search-btn" type="submit">
                  <i class="fa fa-search" aria-hidden="true"></i>
                </button>
              </form>
            
              </a>
            </div>
          </div>
        </nav>
         
      </div>
    </header>
    <!-- end header section -->
  </div>
     

    <%-- gridwied del carrito --%>
  <!-- about section -->
  <section class="about_section layout_padding">
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
                           <asp:ImageField DataImageUrlField="imagen" HeaderText="imagen">
                               <ControlStyle Height="60px" Width="60px" />
                               <ItemStyle Height="100px" Width="100px" />
                           </asp:ImageField>
                           <asp:BoundField DataField="nombre" HeaderText="nombre" />
                           <asp:BoundField DataField="describcion" HeaderText="describcion" />
                           <asp:BoundField DataField="precio" HeaderText="precio" />
                           <asp:BoundField DataField="cantidad" HeaderText="cantidad" />
                           <asp:ButtonField ButtonType="Button" CommandName="aumentar" Text="+"  />
                           <asp:ButtonField ButtonType="Button" CommandName="disminuir" Text="-" />
                           <asp:BoundField DataField="cantidadstock" HeaderText="cantidadstock" />
                           <asp:BoundField DataField="total" HeaderText="total" />
                           <asp:ButtonField ButtonType="Button" CommandName="eliminar" Text="eliminar" />
                       </Columns>
                   </asp:GridView>
               </ContentTemplate>
           </asp:UpdatePanel>
   

      </section>
    <%--boton paypal--%>
  <div id="paypal-button-container"></div>
    <script>
       
        paypal.Buttons({
            style: {
                color: 'blue',
                shape: 'pill',
                label: 'pay' 
            },
            craeteOrder: function (data, actions) {
                return actions.order.create({
                    purchase_units: [{
                        amount: {
                            value: 100
                        }

                    }]

                });
            },
            onApprove: function (data, actions) {
                actions.order.capture().then(function (detalles) {
                    console.log(detalles);
                    window.location.href = "WebForm1.aspx";

                });

            },


            onCancel: function (data) {
                alert("Pago cancelado")
                console.log(data);
            }
        }).render('#paypal-button-container');
    </script>


</asp:Content>
