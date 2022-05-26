<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="frmProductos2.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmProductos2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <div class="container-fluid">
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
    <div class="container">   
   <center><h1>Detalles del Producto</h1></center> 
<br />

    <div id="demo" class="carousel slide" data-bs-ride="carousel">

  <!-- Indicators/dots -->
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#demo" data-bs-slide-to="0" class="active"></button>
    <button type="button" data-bs-target="#demo" data-bs-slide-to="1"></button>
    <button type="button" data-bs-target="#demo" data-bs-slide-to="2"></button>
  </div>

  <!-- The slideshow/carousel -->
  <div class="carousel-inner">
    <div class="carousel-item active">
       <div align="center"> <asp:Image ID="Image1" runat="server" Width="400" height="400" /></div>
    </div>
    <div class="carousel-item">
      <div align="center"> <asp:Image ID="Image2" runat="server" Width="400" height="400" /></div>
    </div>
    <div class="carousel-item">
     <div align="center"> <asp:Image ID="Image3" runat="server" Width="400" height="400" /></div>
    </div>
  </div>
  
  <!-- Left and right controls/icons -->
  <button class="carousel-control-prev" type="button" data-bs-target="#demo" data-bs-slide="prev">
    <span class="carousel-control-prev-icon"></span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#demo" data-bs-slide="next">
    <span class="carousel-control-next-icon"></span>
  </button>
</div>
          
      <div class="col-md">        
          <div class="card">
            <div class="card-body">
              <h4 class="card-title" align="center">Producto:</h4>
          <p class="card-text" align="center"><asp:Label ID="lblID" runat="server" Text="Label"></asp:Label></p>
          <p class="card-text" align="center"><asp:Label ID="lbnombre" runat="server" Text="Label"></asp:Label>
          <p class="card-text" align="center"><asp:Label ID="lbDescripcion" runat="server" Text="Label"></asp:Label>
          <p class="card-text" align="center"><asp:Label ID="lbMaterial" runat="server" Text="Label"></asp:Label>
          <asp:Button ID="btnCarrito" runat="server" Text="Agregar al Carrito" CssClass="btn btn-warning" />
          <asp:Button ID="btnHome" runat="server" Text="Productos:" CssClass="btn btn-primary" onclick="btnHome_Click"/>

            </div>                  
          </div>          
      </div>
      
</asp:Content>
