<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="frmProductos2.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmProductos2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
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
  <br />
    <div class="container">   
   <center><h1>Detalles del Producto</h1></center> 
   </div>
<br />

  <div align="center">
<div class="container mt-3 ">
  <div class="card" style="width:400px">
      <div align="center"> <asp:Image ID="Image1" runat="server" Width="100%"/></div>
    <div class="card-body">
      <h4 class="card-title" align="center" font-family="cursive">Producto:</h4>
      <p class="card-text" align="center"><asp:Label ID="lblID" runat="server" Text="Label"></asp:Label></p>
          <p class="card-text" align="center"><asp:Label ID="lbnombre" runat="server" Text="nombre:"></asp:Label>
          <p class="card-text" align="center"><asp:Label ID="lbDescripcion" runat="server" Text="Label"></asp:Label>
          <p class="card-text" align="center"><asp:Label ID="lbMaterial" runat="server" Text="Label"></asp:Label></p>
          <asp:Button ID="Button1" runat="server" Text="Agregar al Carrito" CssClass="btn btn-warning" OnClick="Button1_Click" />
          <asp:Button ID="Button2" runat="server" Text="Productos:" CssClass="btn btn-primary" onclick="btnHome_Click"/>

            </div>
        </div>
     </div>
    </div>
  <br> 
  
</asp:Content>
