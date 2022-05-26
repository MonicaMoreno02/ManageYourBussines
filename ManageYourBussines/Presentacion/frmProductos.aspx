<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
 <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Logo</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="collapsibleNavbar">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
  <br />
  <br />
    <div class="container">   
   <center><h1>Detalles del Producto</h1></center> 
    <div class="row">       
      <div class="col-md">        
          <div class="card">
              <div class="center">
                 <asp:Image ID="Image1" runat="server" Width="300" height="350" />
                  </div>
            </div>       
      </div>

      <div class="col-md">        
          <div class="card">
            <div class="card-body">
              <h4 class="card-title">Producto:</h4>
          <p class="card-text"><asp:Label ID="lblID" runat="server" Text="Label"></asp:Label></p>
          <p class="card-text"><asp:Label ID="lbnombre" runat="server" Text="Label"></asp:Label>
          <p class="card-text"><asp:Label ID="lbDescripcion" runat="server" Text="Label"></asp:Label>
          <p class="card-text"><asp:Label ID="lbMaterial" runat="server" Text="Label"></asp:Label>
          <asp:Button ID="btnCarrito" runat="server" Text="Agregar a Carrito" CssClass="btn btn-warning" />
            </div>                  
          </div>          
      </div>
      
    </div>
  </div>
       

</asp:Content>
