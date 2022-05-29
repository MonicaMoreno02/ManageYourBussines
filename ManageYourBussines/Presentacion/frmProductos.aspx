<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
 
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

    <div class="row">       
      <div class="col-md">        
          <div class="card">
             
                <div align="center"> <asp:Image ID="Image1" runat="server" Width="250" height="250" /></div>
                
            </div>       
      </div>

      <div class="col-md">        
          <div class="card">
            <div class="card-body">
              <h4 class="card-title" align="center">Producto:</h4>
          <p class="card-text" align="center"><asp:Label ID="lblID" runat="server" Text="Label"></asp:Label></p>
          <p class="card-text" align="center"><asp:Label ID="lbnombre" runat="server" Text="Label"></asp:Label>
          <p class="card-text" align="center"><asp:Label ID="lbDescripcion" runat="server" Text="Label"></asp:Label>
          <p class="card-text" align="center"><asp:Label ID="lbMaterial" runat="server" Text="Label"></asp:Label>
          <asp:Button ID="btnCarrito" runat="server" Text="Agregar al Carrito" CssClass="btn btn-warning" onclick="btnCarrito_Click"/>
          <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btn btn-primary" onclick="btnHome_Click"/>

            </div>                  
          </div>          
      </div>
      
    </div>
  </div>
  
 <br />
    

</asp:Content>
